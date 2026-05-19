using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using Clinic_System.Database;
using Clinic_System.Models;

namespace Clinic_System.Forms
{
    public partial class BillingForm : Form
    {
        // This list holds items added to the bill
        private List<BillItem> billItems = new List<BillItem>();
        private decimal totalAmount = 0;
        public BillingForm()
        {
            InitializeComponent();
            LoadPatients();
            LoadMedicines();
            SetupGrid();
        }

        // ─────────────────────────────────────────
        // HELPER CLASS FOR BILL ITEMS
        // ─────────────────────────────────────────
        private class BillItem
        {
            public int MedicineId { get; set; }
            public string MedicineName { get; set; }
            public int Quantity { get; set; }
            public decimal Price { get; set; }
            public decimal Subtotal => Quantity * Price;
        }

        // ─────────────────────────────────────────
        // SETUP DATAGRIDVIEW COLUMNS
        // ─────────────────────────────────────────
        private void SetupGrid()
        {
            dgvBillItems.Columns.Clear();
            dgvBillItems.Columns.Add("MedicineName", "Medicine");
            dgvBillItems.Columns.Add("Quantity", "Quantity");
            dgvBillItems.Columns.Add("Price", "Unit Price");
            dgvBillItems.Columns.Add("Subtotal", "Subtotal");
        }

        // ─────────────────────────────────────────
        // LOAD PATIENTS INTO COMBOBOX
        // ─────────────────────────────────────────
        private void LoadPatients()
        {
            try
            {
                cmbPatient.Items.Clear();
                cmbPatient.Items.Add("-- Select Patient --");
                cmbPatient.SelectedIndex = 0;

                using (SqliteConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT Id, Name FROM Patients ORDER BY Name";

                    using (SqliteCommand cmd = new SqliteCommand(sql, conn))
                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbPatient.Items.Add(new ComboItem(
                                Convert.ToInt32(reader["Id"]),
                                reader["Name"].ToString()
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading patients: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─────────────────────────────────────────
        // LOAD MEDICINES INTO COMBOBOX
        // ─────────────────────────────────────────
        private void LoadMedicines()
        {
            try
            {
                cmbMedicine.Items.Clear();
                cmbMedicine.Items.Add("-- Select Medicine --");
                cmbMedicine.SelectedIndex = 0;

                using (SqliteConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    // Only load medicines that are in stock
                    string sql = "SELECT Id, Name, Price FROM Medicines WHERE Quantity > 0";

                    using (SqliteCommand cmd = new SqliteCommand(sql, conn))
                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbMedicine.Items.Add(new ComboItem(
                                Convert.ToInt32(reader["Id"]),
                                reader["Name"].ToString(),
                                Convert.ToDecimal(reader["Price"])
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading medicines: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // ─────────────────────────────────────────
        // ADD ITEM TO BILL
        // ─────────────────────────────────────────
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            // Validations
            if (cmbPatient.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a patient!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbMedicine.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a medicine!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtQty.Text.Trim()))
            {
                MessageBox.Show("Please enter quantity!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtQty.Text.Trim(), out int qty) || qty <= 0)
            {
                MessageBox.Show("Please enter a valid quantity!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ComboItem selectedMedicine = (ComboItem)cmbMedicine.SelectedItem;

            // Stock automatically reduces after bill is generated
            // Prevents overselling medicine that is out of stock

            // Check available stock before adding to bill
            int availableStock = GetMedicineStock(selectedMedicine.Id);
            if (qty > availableStock)
            {
                MessageBox.Show($"Not enough stock! Available: {availableStock}", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if medicine already added
            foreach (BillItem existing in billItems)
            {
                if (existing.MedicineId == selectedMedicine.Id)
                {
                    MessageBox.Show("This medicine is already added! Remove it first to change quantity.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Add to list
            BillItem item = new BillItem
            {
                MedicineId = selectedMedicine.Id,
                MedicineName = selectedMedicine.Name,
                Quantity = qty,
                Price = selectedMedicine.Price
            };

            billItems.Add(item);
            RefreshGrid();

            txtQty.Clear();
            cmbMedicine.SelectedIndex = 0;
        }
        // ─────────────────────────────────────────
        // REMOVE ITEM FROM BILL
        // ─────────────────────────────────────────
        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvBillItems.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to remove!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = dgvBillItems.SelectedRows[0].Index;
            billItems.RemoveAt(index);
            RefreshGrid();
        }
        // ─────────────────────────────────────────
        // GENERATE AND SAVE BILL
        // ─────────────────────────────────────────
        private void btnGenerateBill_Click(object sender, EventArgs e)
        {
            if (cmbPatient.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a patient!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (billItems.Count == 0)
            {
                MessageBox.Show("Please add at least one medicine to the bill!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Generate bill for Rs. {totalAmount:F2}?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int billId = 0;
                    ComboItem selectedPatient = (ComboItem)cmbPatient.SelectedItem;

                    using (SqliteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();

                        // Save bill - two separate statements
                        string insertBillSql = @"INSERT INTO Bills (PatientId, Date, Total) 
                          VALUES (@patientId, @date, @total)";

                        using (SqliteCommand cmd = new SqliteCommand(insertBillSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@patientId", selectedPatient.Id);
                            cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@total", totalAmount);
                            cmd.ExecuteNonQuery();
                        }

                        // Get the bill ID that was just created

                        string getIdSql = "SELECT last_insert_rowid()";
                        using (SqliteCommand cmd = new SqliteCommand(getIdSql, conn))
                        {
                            billId = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        // Save each bill item and reduce stock
                        foreach (BillItem item in billItems)
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

                            // Reduce medicine stock
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
                    }

                    MessageBox.Show(
                        $"Bill generated successfully!\nBill ID: {billId}\nTotal: Rs. {totalAmount:F2}",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearAll();
                    LoadMedicines(); // Reload to reflect updated stock
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error generating bill: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // ─────────────────────────────────────────
        // CLEAR BUTTON
        // ─────────────────────────────────────────
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        // ─────────────────────────────────────────
        // HELPER METHODS
        // ─────────────────────────────────────────
        private void RefreshGrid()
        {
            dgvBillItems.Rows.Clear();
            totalAmount = 0;

            foreach (BillItem item in billItems)
            {
                dgvBillItems.Rows.Add(
                    item.MedicineName,
                    item.Quantity,
                    $"Rs. {item.Price:F2}",
                    $"Rs. {item.Subtotal:F2}"
                );
                totalAmount += item.Subtotal;
            }

            lblTotalValue.Text = $"Rs. {totalAmount:F2}";
        }

        private int GetMedicineStock(int medicineId)
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

        private void ClearAll()
        {
            billItems.Clear();
            dgvBillItems.Rows.Clear();
            totalAmount = 0;
            lblTotalValue.Text = "Rs. 0.00";
            cmbPatient.SelectedIndex = 0;
            cmbMedicine.SelectedIndex = 0;
            txtQty.Clear();
        }

      
    }

    // ─────────────────────────────────────────
    // HELPER CLASS FOR COMBOBOX ITEMS
    // ─────────────────────────────────────────
    public class ComboItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public ComboItem(int id, string name, decimal price = 0)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name; // This is what shows in the dropdown
        }
    }
}
