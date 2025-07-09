using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace Takatracker_login
{
    public class DatabaseHelper
    {
        private string connectionString;

        public DatabaseHelper()
        {
            // SQL Server connection string
            connectionString = @"Server=.\SQLEXPRESS;Database=TakatrackerDB;Integrated Security=true;";
            
            // Initialize database when creating the helper
            try
            {
                InitializeDatabase();
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to initialize database: {ex.Message}");
            }
        }

        // Make this public if you want to call it manually, or keep private for internal use only
        public void InitializeDatabase()
        {
            try
            {
                CreateDatabaseIfNotExists();
                CreateTablesIfNotExist();
                CreateDefaultAdmin();
            }
            catch (Exception ex)
            {
                throw new Exception($"Database initialization failed: {ex.Message}");
            }
        }

        private void CreateDatabaseIfNotExists()
        {
            try
            {
                string masterConnectionString = @"Server=.\SQLEXPRESS;Database=master;Integrated Security=true;";
                
                using (var connection = new SqlConnection(masterConnectionString))
                {
                    connection.Open();
                    
                    string checkDbQuery = "SELECT COUNT(*) FROM sys.databases WHERE name = 'TakatrackerDB'";
                    using (var command = new SqlCommand(checkDbQuery, connection))
                    {
                        int dbCount = (int)command.ExecuteScalar();
                        
                        if (dbCount == 0)
                        {
                            string createDbQuery = "CREATE DATABASE TakatrackerDB";
                            using (var createCommand = new SqlCommand(createDbQuery, connection))
                            {
                                createCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error creating database: {ex.Message}");
            }
        }

        private void CreateTablesIfNotExist()
{
    try
    {
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            
            // Existing Users table creation code...
            string createUsersTableQuery = @"
                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Users' AND xtype='U')
                CREATE TABLE Users (
                    Id INT IDENTITY(1,1) PRIMARY KEY,
                    Username NVARCHAR(50) NOT NULL UNIQUE,
                    Email NVARCHAR(100) NOT NULL UNIQUE,
                    PasswordHash NVARCHAR(255) NOT NULL,
                    Salt NVARCHAR(255) NOT NULL,
                    CreatedAt DATETIME2 DEFAULT GETDATE(),
                    LastLogin DATETIME2 NULL,
                    IsActive BIT DEFAULT 1
                )";
            
            // Add Income table
            string createIncomeTableQuery = @"
                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Income' AND xtype='U')
                CREATE TABLE Income (
                    Id INT IDENTITY(1,1) PRIMARY KEY,
                    UserId INT NOT NULL,
                    Amount DECIMAL(18,2) NOT NULL,
                    Category NVARCHAR(100) NOT NULL,
                    IncomeDate DATE NOT NULL,
                    CreatedAt DATETIME2 DEFAULT GETDATE(),
                    FOREIGN KEY (UserId) REFERENCES Users(Id)
                )";
            
            using (var command = new SqlCommand(createUsersTableQuery, connection))
            {
                command.ExecuteNonQuery();
            }
            
            using (var command = new SqlCommand(createIncomeTableQuery, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }
    catch (Exception ex)
    {
        throw new Exception($"Error creating tables: {ex.Message}");
    }
}

        private void CreateDefaultAdmin()
        {
            try
            {
                if (!UserExists("admin"))
                {
                    CreateUser("admin", "admin@takatracker.com", "admin123");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error creating default admin: {ex.Message}");
            }
        }

        public bool TestConnection()
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool CreateUser(string username, string email, string password)
        {
            try
            {
                string salt = GenerateSalt();
                string hashedPassword = HashPassword(password, salt);

                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    
                    string query = @"INSERT INTO Users (Username, Email, PasswordHash, Salt) 
                                   VALUES (@username, @email, @passwordHash, @salt)";
                    
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@passwordHash", hashedPassword);
                        command.Parameters.AddWithValue("@salt", salt);
                        
                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error creating user: {ex.Message}");
            }
        }

        public bool ValidateUser(string usernameOrEmail, string password)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    
                    string query = @"SELECT PasswordHash, Salt FROM Users 
                                   WHERE (Username = @usernameOrEmail OR Email = @usernameOrEmail) 
                                   AND IsActive = 1";
                    
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@usernameOrEmail", usernameOrEmail);
                        
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedHash = reader["PasswordHash"].ToString();
                                string salt = reader["Salt"].ToString();
                                string hashedInputPassword = HashPassword(password, salt);
                                
                                bool isValid = storedHash == hashedInputPassword;
                                
                                if (isValid)
                                {
                                    reader.Close();
                                    UpdateLastLogin(usernameOrEmail);
                                }
                                
                                return isValid;
                            }
                        }
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error validating user: {ex.Message}");
            }
        }

        public bool UserExists(string usernameOrEmail)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE Username = @username OR Email = @email";
                    
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", usernameOrEmail);
                        command.Parameters.AddWithValue("@email", usernameOrEmail);
                        
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error checking if user exists: {ex.Message}");
            }
        }

        public DataTable GetAllUsers()
        {
            DataTable dataTable = new DataTable();
            
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"SELECT 
                                        Id,
                                        Username,
                                        Email,
                                        CreatedAt,
                                        LastLogin,
                                        IsActive
                                     FROM Users 
                                     ORDER BY CreatedAt DESC";
                    
                    using (var adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving users: {ex.Message}");
            }
            
            return dataTable;
        }

        public int GetUserCount()
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE IsActive = 1";
                    
                    using (var command = new SqlCommand(query, connection))
                    {
                        return (int)command.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error counting users: {ex.Message}");
            }
        }
public int GetUserId(string usernameOrEmail)
{
    try
    {
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            
            string query = @"SELECT Id FROM Users 
                           WHERE (Username = @usernameOrEmail OR Email = @usernameOrEmail) 
                           AND IsActive = 1";
            
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@usernameOrEmail", usernameOrEmail);
                
                object result = command.ExecuteScalar();
                return result != null ? (int)result : -1;
            }
        }
    }
    catch (Exception ex)
    {
        throw new Exception($"Error getting user ID: {ex.Message}");
    }
}
        private void UpdateLastLogin(string usernameOrEmail)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"UPDATE Users SET LastLogin = GETDATE() 
                                   WHERE Username = @usernameOrEmail OR Email = @usernameOrEmail";
                    
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@usernameOrEmail", usernameOrEmail);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error updating last login: {ex.Message}");
            }
        }

        private string GenerateSalt()
        {
            byte[] saltBytes = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }

        private string HashPassword(string password, string salt)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] saltedPassword = Encoding.UTF8.GetBytes(password + salt);
                byte[] hash = sha256.ComputeHash(saltedPassword);
                return Convert.ToBase64String(hash);
            }
        }
        public bool SaveIncome(int userId, decimal amount, string category, DateTime incomeDate)
{
    try
    {
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            
            string query = @"INSERT INTO Income (UserId, Amount, Category, IncomeDate) 
                           VALUES (@userId, @amount, @category, @incomeDate)";
            
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@userId", userId);
                command.Parameters.AddWithValue("@amount", amount);
                command.Parameters.AddWithValue("@category", category);
                command.Parameters.AddWithValue("@incomeDate", incomeDate.Date);
                
                int result = command.ExecuteNonQuery();
                return result > 0;
            }
        }
    }
    catch (Exception ex)
    {
        throw new Exception($"Error saving income: {ex.Message}");
    }
}

    }
}
