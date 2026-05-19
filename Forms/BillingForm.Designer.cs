namespace Clinic_System.Forms
{
    partial class BillingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            lblTitle = new Label();
            lblPatient = new Label();
            lblMedicine = new Label();
            lblQty = new Label();
            lblTotal = new Label();
            lblTotalValue = new Label();
            cmbPatient = new ComboBox();
            cmbMedicine = new ComboBox();
            txtQty = new TextBox();
            btnAddItem = new Button();
            btnRemoveItem = new Button();
            btnGenerateBill = new Button();
            btnClear = new Button();
            dgvBillItems = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvBillItems).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.FromArgb(27, 79, 114);
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(907, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Generate Bill";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPatient
            // 
            lblPatient.AutoSize = true;
            lblPatient.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPatient.ForeColor = Color.FromArgb(27, 79, 114);
            lblPatient.Location = new Point(22, 108);
            lblPatient.Name = "lblPatient";
            lblPatient.Size = new Size(148, 28);
            lblPatient.TabIndex = 1;
            lblPatient.Text = "Select Patient:";
            // 
            // lblMedicine
            // 
            lblMedicine.AutoSize = true;
            lblMedicine.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMedicine.ForeColor = Color.FromArgb(27, 79, 114);
            lblMedicine.Location = new Point(22, 167);
            lblMedicine.Name = "lblMedicine";
            lblMedicine.Size = new Size(167, 28);
            lblMedicine.TabIndex = 2;
            lblMedicine.Text = "Select Medicine:";
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQty.ForeColor = Color.FromArgb(27, 79, 114);
            lblQty.Location = new Point(22, 219);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(100, 28);
            lblQty.TabIndex = 3;
            lblQty.Text = "Quantity:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.FromArgb(27, 79, 114);
            lblTotal.Location = new Point(22, 278);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(146, 28);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total Amount:";
            // 
            // lblTotalValue
            // 
            lblTotalValue.AutoSize = true;
            lblTotalValue.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalValue.ForeColor = Color.FromArgb(39, 174, 96);
            lblTotalValue.Location = new Point(213, 273);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(119, 38);
            lblTotalValue.TabIndex = 5;
            lblTotalValue.Text = "Rs. 0.00";
            // 
            // cmbPatient
            // 
            cmbPatient.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPatient.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPatient.FormattingEnabled = true;
            cmbPatient.Location = new Point(213, 108);
            cmbPatient.Name = "cmbPatient";
            cmbPatient.Size = new Size(206, 36);
            cmbPatient.TabIndex = 6;
            // 
            // cmbMedicine
            // 
            cmbMedicine.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMedicine.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbMedicine.FormattingEnabled = true;
            cmbMedicine.Location = new Point(213, 159);
            cmbMedicine.Name = "cmbMedicine";
            cmbMedicine.Size = new Size(206, 36);
            cmbMedicine.TabIndex = 7;
            // 
            // txtQty
            // 
            txtQty.BorderStyle = BorderStyle.FixedSingle;
            txtQty.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQty.Location = new Point(213, 213);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(206, 34);
            txtQty.TabIndex = 8;
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = Color.FromArgb(39, 174, 96);
            btnAddItem.Cursor = Cursors.Hand;
            btnAddItem.FlatStyle = FlatStyle.Flat;
            btnAddItem.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddItem.ForeColor = Color.White;
            btnAddItem.Location = new Point(615, 128);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(175, 47);
            btnAddItem.TabIndex = 9;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = false;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.BackColor = Color.FromArgb(231, 76, 60);
            btnRemoveItem.Cursor = Cursors.Hand;
            btnRemoveItem.FlatStyle = FlatStyle.Flat;
            btnRemoveItem.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveItem.ForeColor = Color.White;
            btnRemoveItem.Location = new Point(615, 181);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(175, 51);
            btnRemoveItem.TabIndex = 10;
            btnRemoveItem.Text = "Remove Item";
            btnRemoveItem.UseVisualStyleBackColor = false;
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // btnGenerateBill
            // 
            btnGenerateBill.BackColor = Color.FromArgb(142, 68, 173);
            btnGenerateBill.Cursor = Cursors.Hand;
            btnGenerateBill.FlatStyle = FlatStyle.Flat;
            btnGenerateBill.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateBill.ForeColor = Color.White;
            btnGenerateBill.Location = new Point(615, 238);
            btnGenerateBill.Name = "btnGenerateBill";
            btnGenerateBill.Size = new Size(175, 54);
            btnGenerateBill.TabIndex = 11;
            btnGenerateBill.Text = "Generate Bill";
            btnGenerateBill.UseVisualStyleBackColor = false;
            btnGenerateBill.Click += btnGenerateBill_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(127, 140, 141);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(615, 298);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(175, 45);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dgvBillItems
            // 
            dgvBillItems.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(214, 234, 248);
            dgvBillItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvBillItems.BackgroundColor = Color.White;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(27, 79, 114);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvBillItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvBillItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBillItems.EnableHeadersVisualStyles = false;
            dgvBillItems.Location = new Point(-1, 366);
            dgvBillItems.MultiSelect = false;
            dgvBillItems.Name = "dgvBillItems";
            dgvBillItems.ReadOnly = true;
            dgvBillItems.RowHeadersVisible = false;
            dgvBillItems.RowHeadersWidth = 62;
            dgvBillItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBillItems.Size = new Size(909, 225);
            dgvBillItems.TabIndex = 13;
            // 
            // BillingForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 245, 251);
            ClientSize = new Size(907, 594);
            Controls.Add(dgvBillItems);
            Controls.Add(btnClear);
            Controls.Add(btnGenerateBill);
            Controls.Add(btnRemoveItem);
            Controls.Add(btnAddItem);
            Controls.Add(txtQty);
            Controls.Add(cmbMedicine);
            Controls.Add(cmbPatient);
            Controls.Add(lblTotalValue);
            Controls.Add(lblTotal);
            Controls.Add(lblQty);
            Controls.Add(lblMedicine);
            Controls.Add(lblPatient);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "BillingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing";
            ((System.ComponentModel.ISupportInitialize)dgvBillItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblPatient;
        private Label lblMedicine;
        private Label lblQty;
        private Label lblTotal;
        private Label lblTotalValue;
        private ComboBox cmbPatient;
        private ComboBox cmbMedicine;
        private TextBox txtQty;
        private Button btnAddItem;
        private Button btnRemoveItem;
        private Button btnGenerateBill;
        private Button btnClear;
        private DataGridView dgvBillItems;
    }
}