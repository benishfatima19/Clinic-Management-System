using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using BCrypt.Net;


namespace Clinic_System.Database
{
    /// <summary>
    /// Handles all database operations related to Users table.
    /// Used by LoginForm for authentication.
    /// </summary>
    public class UserRepository
    {
        /// <summary>
        /// Validates login credentials against database.
        /// Uses BCrypt to compare entered password with stored hash.
        /// Returns true if valid, false otherwise.
        /// </summary>
        public static bool ValidateLogin(string username, string password)
        {
            try
            {
                using (SqliteConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // Get stored hashed password for this username
                    string sql = "SELECT Password FROM Users WHERE Username=@u";

                    using (SqliteCommand cmd = new SqliteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@u", username);
                        string hashedPassword = cmd.ExecuteScalar()?.ToString();

                        if (hashedPassword == null) return false;

                        // BCrypt.Verify — one way comparison, never decrypts
                        return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
