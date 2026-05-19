using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using Clinic_System.Models;
using System.Text;

namespace Clinic_System.Database
   { 
        /// <summary>
        /// Handles all database operations for Bills and BillItems tables.
        /// Used by BillingForm and ReportsForm — forms have zero SQL.
        /// </summary>
        public class BillRepository
        {
            /// <summary>
            /// Saves a complete bill with all its items to database.
            /// Also reduces medicine stock for each item in the bill.
            /// Returns the new Bill ID if successful, -1 if failed.
            /// </summary>
            public static int GenerateBill(int patientId, decimal total, List<BillItem> items)
            {
                try
                {
                    using (SqliteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();

                        // Step 1 — Insert the bill record
                        string insertBillSql = @"INSERT INTO Bills (PatientId, Date, Total) 
                                             VALUES (@patientId, @date, @total)";

                        using (SqliteCommand cmd = new SqliteCommand(insertBillSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@patientId", patientId);
                            cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@total", total);
                            cmd.ExecuteNonQuery();
                        }

                        // Step 2 — Get the bill ID that was just created
                        int billId = 0;
                        string getIdSql = "SELECT last_insert_rowid()";
                        using (SqliteCommand cmd = new SqliteCommand(getIdSql, conn))
                        {
                            billId = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        // Step 3 — Save each bill item and reduce stock
                        foreach (BillItem item in items)
                        {
                            // Save bill item
                            string itemSql = @"INSERT INTO BillItems 
                                           (BillId, MedicineId, Quantity, Price) 
                                           VALUES (@billId, @medicineId, @qty, @price)";

                            using (SqliteCommand cmd = new SqliteCommand(itemSql, conn))
                            {
                                cmd.Parameters.AddWithValue("@billId", billId);
                                cmd.Parameters.AddWithValue("@medicineId", item.MedicineId);
                                cmd.Parameters.AddWithValue("@qty", item.Quantity);
                                cmd.Parameters.AddWithValue("@price", item.Price);
                                cmd.ExecuteNonQuery();
                            }

                            // Reduce medicine stock automatically
                            string stockSql = @"UPDATE Medicines 
                                            SET Quantity = Quantity - @qty 
                                            WHERE Id = @id";

                            using (SqliteCommand cmd = new SqliteCommand(stockSql, conn))
                            {
                                cmd.Parameters.AddWithValue("@qty", item.Quantity);
                                cmd.Parameters.AddWithValue("@id", item.MedicineId);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        return billId;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error generating bill: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
            }

            /// <summary>
            /// Returns all bills with patient names.
            /// Filtered by optional search term.
            /// Uses JOIN to get patient name from Patients table.
            /// </summary>
            public static List<Bill> GetAllBills(string search = "")
            {
                List<Bill> bills = new List<Bill>();

                try
                {
                    using (SqliteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string sql = @"SELECT b.Id, p.Name AS PatientName, b.Date, b.Total 
                                   FROM Bills b 
                                   JOIN Patients p ON b.PatientId = p.Id
                                   WHERE p.Name LIKE @search
                                   ORDER BY b.Date DESC";

                        using (SqliteCommand cmd = new SqliteCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                            using (SqliteDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    bills.Add(new Bill
                                    {
                                        Id = Convert.ToInt32(reader["Id"]),
                                        PatientName = reader["PatientName"].ToString(),
                                        Date = reader["Date"].ToString(),
                                        Total = Convert.ToDecimal(reader["Total"])
                                    });
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading bills: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return bills;
            }

            /// <summary>
            /// Returns total revenue from all bills.
            /// Used by DashboardForm and ReportsForm.
            /// </summary>
            public static decimal GetTotalRevenue()
            {
                try
                {
                    using (SqliteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string sql = "SELECT IFNULL(SUM(Total), 0) FROM Bills";

                        using (SqliteCommand cmd = new SqliteCommand(sql, conn))
                            return Convert.ToDecimal(cmd.ExecuteScalar());
                    }
                }
                catch { return 0; }
            }

            /// <summary>
            /// Returns total number of bills generated today.
            /// Used by DashboardForm statistics.
            /// </summary>
            public static int GetTodayBillsCount()
            {
                try
                {
                    using (SqliteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string sql = "SELECT COUNT(*) FROM Bills WHERE Date=@date";

                        using (SqliteCommand cmd = new SqliteCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                            return Convert.ToInt32(cmd.ExecuteScalar());
                        }
                    }
                }
                catch { return 0; }
            }
        }

        /// <summary>
        /// Represents one medicine item inside a bill.
        /// Used to pass bill items between BillingForm and BillRepository.
        /// </summary>
        public class BillItem
        {
            public int MedicineId { get; set; }
            public string MedicineName { get; set; }
            public int Quantity { get; set; }
            public decimal Price { get; set; }
            public decimal Subtotal => Quantity * Price;
        }
  }

