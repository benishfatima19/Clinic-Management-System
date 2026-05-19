using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using Clinic_System.Models;

namespace Clinic_System.Database
{
        /// <summary>
        /// Handles all database operations for Medicines table.
        /// Used by MedicineForm — form has zero SQL.
        /// </summary>
        public class MedicineRepository
        {
            /// <summary>
            /// Returns all medicines, filtered by optional search term.
            /// </summary>
            public static List<Medicine> GetAllMedicines(string search = "")
            {
                List<Medicine> medicines = new List<Medicine>();

                try
                {
                    using (SqliteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string sql = "SELECT * FROM Medicines WHERE Name LIKE @search";

                        using (SqliteCommand cmd = new SqliteCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                            using (SqliteDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    medicines.Add(new Medicine
                                    {
                                        Id = Convert.ToInt32(reader["Id"]),
                                        Name = reader["Name"].ToString(),
                                        Quantity = Convert.ToInt32(reader["Quantity"]),
                                        Price = Convert.ToDecimal(reader["Price"]),
                                        ExpiryDate = reader["ExpiryDate"].ToString()
                                    });
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading medicines: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return medicines;
            }

            /// <summary>
            /// Returns only medicines that have stock greater than zero.
            /// Used by BillingForm dropdown.
            /// </summary>
            public static List<Medicine> GetMedicinesInStock()
            {
                List<Medicine> medicines = new List<Medicine>();

                try
                {
                    using (SqliteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string sql = "SELECT * FROM Medicines WHERE Quantity > 0";

                        using (SqliteCommand cmd = new SqliteCommand(sql, conn))
                        using (SqliteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                medicines.Add(new Medicine
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Name = reader["Name"].ToString(),
                                    Quantity = Convert.ToInt32(reader["Quantity"]),
                                    Price = Convert.ToDecimal(reader["Price"]),
                                    ExpiryDate = reader["ExpiryDate"].ToString()
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading medicines: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return medicines;
            }

            /// <summary>
            /// Inserts a new medicine record into the database.
            /// Returns true if successful.
            /// </summary>
            public static bool AddMedicine(Medicine medicine)
            {
                try
                {
                    using (SqliteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string sql = @"INSERT INTO Medicines (Name, Quantity, Price, ExpiryDate) 
                                   VALUES (@name, @qty, @price, @expiry)";

                        using (SqliteCommand cmd = new SqliteCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@name", medicine.Name);
                            cmd.Parameters.AddWithValue("@qty", medicine.Quantity);
                            cmd.Parameters.AddWithValue("@price", medicine.Price);
                            cmd.Parameters.AddWithValue("@expiry", medicine.ExpiryDate);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding medicine: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            /// <summary>
            /// Updates an existing medicine record identified by medicine.Id.
            /// </summary>
            public static bool UpdateMedicine(Medicine medicine)
            {
                try
                {
                    using (SqliteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string sql = @"UPDATE Medicines 
                                   SET Name=@name, Quantity=@qty, 
                                       Price=@price, ExpiryDate=@expiry 
                                   WHERE Id=@id";

                        using (SqliteCommand cmd = new SqliteCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@name", medicine.Name);
                            cmd.Parameters.AddWithValue("@qty", medicine.Quantity);
                            cmd.Parameters.AddWithValue("@price", medicine.Price);
                            cmd.Parameters.AddWithValue("@expiry", medicine.ExpiryDate);
                            cmd.Parameters.AddWithValue("@id", medicine.Id);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating medicine: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            /// <summary>
            /// Deletes a medicine only if it has no billing history.
            /// Shows warning if medicine has been used in bills.
            /// </summary>
            public static bool DeleteMedicine(int medicineId)
            {
                try
                {
                    using (SqliteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();

                        // Check if medicine has been used in any bill
                        string checkSql = "SELECT COUNT(*) FROM BillItems WHERE MedicineId=@id";
                        using (SqliteCommand cmd = new SqliteCommand(checkSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", medicineId);
                            int count = Convert.ToInt32(cmd.ExecuteScalar());

                            if (count > 0)
                            {
                                MessageBox.Show(
                                    "Cannot delete! This medicine has billing history.",
                                    "Cannot Delete",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return false;
                            }
                        }

                        // Safe to delete
                        string deleteSql = "DELETE FROM Medicines WHERE Id=@id";
                        using (SqliteCommand cmd = new SqliteCommand(deleteSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", medicineId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting medicine: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            /// <summary>
            /// Returns current stock quantity for a specific medicine.
            /// Used by BillingForm to check before adding to bill.
            /// </summary>
            public static int GetMedicineStock(int medicineId)
            {
                try
                {
                    using (SqliteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string sql = "SELECT Quantity FROM Medicines WHERE Id=@id";

                        using (SqliteCommand cmd = new SqliteCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", medicineId);
                            return Convert.ToInt32(cmd.ExecuteScalar());
                        }
                    }
                }
                catch { return 0; }
            }
        }
 }

