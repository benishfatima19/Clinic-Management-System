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
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(380, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(109, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Generate Bill";
            // 
            // lblPatient
            // 
            lblPatient.AutoSize = true;
            lblPatient.Location = new Point(31, 111);
            lblPatient.Name = "lblPatient";
            lblPatient.Size = new Size(120, 25);
            lblPatient.TabIndex = 1;
            lblPatient.Text = "Select Patient:";
            // 
            // lblMedicine
            // 
            lblMedicine.AutoSize = true;
            lblMedicine.Location = new Point(31, 159);
            lblMedicine.Name = "lblMedicine";
            lblMedicine.Size = new Size(138, 25);
            lblMedicine.TabIndex = 2;
            lblMedicine.Text = "Select Medicine:";
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Location = new Point(31, 219);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(84, 25);
            lblQty.TabIndex = 3;
            lblQty.Text = "Quantity:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(31, 278);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(123, 25);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total Amount:";
            // 
            // lblTotalValue
            // 
            lblTotalValue.AutoSize = true;
            lblTotalValue.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalValue.Location = new Point(187, 278);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(119, 38);
            lblTotalValue.TabIndex = 5;
            lblTotalValue.Text = "Rs. 0.00";
            // 
            // cmbPatient
            // 
            cmbPatient.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPatient.FormattingEnabled = true;
            cmbPatient.Location = new Point(187, 108);
            cmbPatient.Name = "cmbPatient";
            cmbPatient.Size = new Size(182, 33);
            cmbPatient.TabIndex = 6;
            // 
            // cmbMedicine
            // 
            cmbMedicine.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMedicine.FormattingEnabled = true;
            cmbMedicine.Location = new Point(187, 159);
            cmbMedicine.Name = "cmbMedicine";
            cmbMedicine.Size = new Size(182, 33);
            cmbMedicine.TabIndex = 7;
            // 
            // txtQty
            // 
            txtQty.Location = new Point(187, 213);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(150, 31);
            txtQty.TabIndex = 8;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(615, 148);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(140, 34);
            btnAddItem.TabIndex = 9;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.Location = new Point(615, 198);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(140, 34);
            btnRemoveItem.TabIndex = 10;
            btnRemoveItem.Text = "Remove Item";
            btnRemoveItem.UseVisualStyleBackColor = true;
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // btnGenerateBill
            // 
            btnGenerateBill.Location = new Point(615, 238);
            btnGenerateBill.Name = "btnGenerateBill";
            btnGenerateBill.Size = new Size(140, 34);
            btnGenerateBill.TabIndex = 11;
            btnGenerateBill.Text = "Generate Bill";
            btnGenerateBill.UseVisualStyleBackColor = true;
            btnGenerateBill.Click += btnGenerateBill_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(615, 278);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(140, 34);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dgvBillItems
            // 
            dgvBillItems.AllowUserToAddRows = false;
            dgvBillItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBillItems.Location = new Point(-1, 366);
            dgvBillItems.MultiSelect = false;
            dgvBillItems.Name = "dgvBillItems";
            dgvBillItems.ReadOnly = true;
            dgvBillItems.RowHeadersWidth = 62;
            dgvBillItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBillItems.Size = new Size(909, 225);
            dgvBillItems.TabIndex = 13;
            // 
            // BillingForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
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