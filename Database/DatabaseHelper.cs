using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.Sqlite;

namespace Clinic_System.Database
{
    public class DatabaseHelper
    {
        private static string dbPath = "clinic.db";
        private static string connectionString = $"Data Source={dbPath}";

        // ─────────────────────────────────────────
        // 1. CREATE DATABASE AND ALL TABLES
        // ─────────────────────────────────────────
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

                    // Insert default admin if not exists
                    string adminSql = @"INSERT OR IGNORE INTO Users 
                                        (Username, Password) 
                                        VALUES ('admin', '1234');";
                    using (SqliteCommand cmd = new SqliteCommand(adminSql, conn))
                    {
                        cmd.ExecuteNonQuery();
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
        public static SqliteConnection GetConnection()
        {
            return new SqliteConnection(connectionString);
        }
    }
}
