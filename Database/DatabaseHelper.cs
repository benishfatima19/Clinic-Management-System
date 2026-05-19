using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using BCrypt.Net;

namespace Clinic_System.Database
{
    public class DatabaseHelper
    {
        private static string dbPath = "clinic.db";
        private static string connectionString = $"Data Source={dbPath}";

        // ─────────────────────────────────────────
        // 1. CREATE DATABASE AND ALL TABLES
        // ─────────────────────────────────────────
        /// <summary>
        /// Initializes SQLite database and creates all tables if they don't exist.
        /// Inserts default admin user with BCrypt hashed password.
        /// Called once at application startup from Program.cs
        /// </summary>
   
        public static void InitializeDatabase()
        {
            try
            {
                using (SqliteConnection conn = new SqliteConnection(connectionString))
                {
                    conn.Open();

                    string[] tables = {

                        // Users Table
                        @"CREATE TABLE IF NOT EXISTS Users (
                            Id       INTEGER PRIMARY KEY AUTOINCREMENT,
                            Username TEXT NOT NULL UNIQUE,
                            Password TEXT NOT NULL
                        );",

                        // Medicines Table
                        @"CREATE TABLE IF NOT EXISTS Medicines (
                            Id         INTEGER PRIMARY KEY AUTOINCREMENT,
                            Name       TEXT NOT NULL,
                            Quantity   INTEGER NOT NULL DEFAULT 0,
                            Price      REAL NOT NULL DEFAULT 0,
                            ExpiryDate TEXT
                        );",

                        // Patients Table
                        @"CREATE TABLE IF NOT EXISTS Patients (
                            Id      INTEGER PRIMARY KEY AUTOINCREMENT,
                            Name    TEXT NOT NULL,
                            Age     INTEGER,
                            Contact TEXT,
                            Disease TEXT
                        );",

                        // Bills Table
                        @"CREATE TABLE IF NOT EXISTS Bills (
                            Id        INTEGER PRIMARY KEY AUTOINCREMENT,
                            PatientId INTEGER NOT NULL,
                            Date      TEXT NOT NULL,
                            Total     REAL NOT NULL DEFAULT 0,
                            FOREIGN KEY (PatientId) REFERENCES Patients(Id)
                        );",

                        // BillItems Table
                        @"CREATE TABLE IF NOT EXISTS BillItems (
                            Id         INTEGER PRIMARY KEY AUTOINCREMENT,
                            BillId     INTEGER NOT NULL,
                            MedicineId INTEGER NOT NULL,
                            Quantity   INTEGER NOT NULL,
                            Price      REAL NOT NULL,
                            FOREIGN KEY (BillId)     REFERENCES Bills(Id),
                            FOREIGN KEY (MedicineId) REFERENCES Medicines(Id)
                        );"
                    };

                    foreach (string sql in tables)
                    {
                        using (SqliteCommand cmd = new SqliteCommand(sql, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                    // Insert default admin with BCrypt hashed password
                    string checkAdmin = "SELECT COUNT(*) FROM Users WHERE Username='admin'";
                    using (SqliteCommand cmd = new SqliteCommand(checkAdmin, conn))
                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count == 0)
                        {
                            // BCrypt hashes the password — never stored as plain text
                            string hashedPassword = BCrypt.Net.BCrypt.HashPassword("1234");
                            string insertAdmin = "INSERT INTO Users (Username, Password) VALUES ('admin', @pwd)";
                            using (SqliteCommand insertCmd = new SqliteCommand(insertAdmin, conn))
                            {
                                insertCmd.Parameters.AddWithValue("@pwd", hashedPassword);
                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─────────────────────────────────────────
        // 2. GET CONNECTION (used by other methods)
        // ─────────────────────────────────────────
        /// <summary>
        /// Returns a new SQLite connection.
        /// Used by all forms to connect to the database.
        /// </summary>
        
        public static SqliteConnection GetConnection()
        {
            return new SqliteConnection(connectionString);
        }
    }
}
