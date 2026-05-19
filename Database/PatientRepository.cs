using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using Clinic_System.Models;
using System.Text;

namespace Clinic_System.Database
{
        /// <summary>
        /// Handles all database operations for Patients table.
        /// Used by PatientForm — form has zero SQL.
        /// </summary>
        public class PatientRepository
        {
            /// <summary>
            /// Returns all patients, filtered by optional search term.
            /// </summary>
            public static List<Patient> GetAllPatients(string search = "")
            {
                List<Patient> patients = new List<Patient>();

                try
                {
                    using (SqliteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string sql = "SELECT * FROM Patients WHERE Name LIKE @search";

                        using (SqliteCommand cmd = new SqliteCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                            using (SqliteDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    patients.Add(new Patient
                                    {
                                        Id = Convert.ToInt32(reader["Id"]),
                                        Name = reader["Name"].ToString(),
                                        Age = Convert.ToInt32(reader["Age"]),
                                        Contact = reader["Contact"].ToString(),
                                        Disease = reader["Disease"].ToString()
                                    });
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading patients: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return patients;
            }

            /// <summary>
            /// Returns all patients for dropdown in BillingForm.
            /// </summary>
            public static List<Patient> GetAllPatientsForDropdown()
            {
                return GetAllPatients();
            }

            /// <summary>
            /// Inserts a new patient record into the database.
            /// Returns true if successful.
            /// </summary>
            public static bool AddPatient(Patient patient)
            {
                try
                {
                    using (SqliteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string sql = @"INSERT INTO Patients (Name, Age, Contact, Disease) 
                                   VALUES (@name, @age, @contact, @disease)";

                        using (SqliteCommand cmd = new SqliteCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@name", patient.Name);
                            cmd.Parameters.AddWithValue("@age", patient.Age);
                            cmd.Parameters.AddWithValue("@contact", patient.Contact);
                            cmd.Parameters.AddWithValue("@disease", patient.Disease);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding patient: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            /// <summary>
            /// Updates an existing patient record identified by patient.Id.
            /// </summary>
            public static bool UpdatePatient(Patient patient)
            {
                try
                {
                    using (SqliteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string sql = @"UPDATE Patients 
                                   SET Name=@name, Age=@age, 
                                       Contact=@contact, Disease=@disease 
                                   WHERE Id=@id";

                        using (SqliteCommand cmd = new SqliteCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@name", patient.Name);
                            cmd.Parameters.AddWithValue("@age", patient.Age);
                            cmd.Parameters.AddWithValue("@contact", patient.Contact);
                            cmd.Parameters.AddWithValue("@disease", patient.Disease);
                            cmd.Parameters.AddWithValue("@id", patient.Id);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating patient: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            /// <summary>
            /// Deletes a patient only if they have no billing history.
            /// Shows friendly warning if deletion not allowed.
            /// </summary>
            public static bool DeletePatient(int patientId)
            {
                try
                {
                    using (SqliteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();

                        // Check if patient has any bills — cannot delete if yes
                        string checkSql = "SELECT COUNT(*) FROM Bills WHERE PatientId=@id";
                        using (SqliteCommand cmd = new SqliteCommand(checkSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", patientId);
                            int count = Convert.ToInt32(cmd.ExecuteScalar());

                            if (count > 0)
                            {
                                MessageBox.Show(
                                    $"Cannot delete this patient!\nThis patient has {count} bill(s) on record.",
                                    "Cannot Delete",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return false;
                            }
                        }

                        // Safe to delete
                        string deleteSql = "DELETE FROM Patients WHERE Id=@id";
                        using (SqliteCommand cmd = new SqliteCommand(deleteSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", patientId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting patient: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
 }

