namespace Clinic_System.Forms
{
    partial class MedicineForm
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
            lblName = new Label();
            lblQty = new Label();
            lblPrice = new Label();
            lblExpiry = new Label();
            lblSearch = new Label();
            txtName = new TextBox();
            txtQty = new TextBox();
            txtPrice = new TextBox();
            txtExpiry = new TextBox();
            txtSearch = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvMedicines = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMedicines).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(285, 33);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(273, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Medicine Inventory";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(15, 145);
            lblName.Name = "lblName";
            lblName.Size = new Size(160, 28);
            lblName.TabIndex = 1;
            lblName.Text = "Medicine Name:";
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQty.Location = new Point(351, 145);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(95, 28);
            lblQty.TabIndex = 2;
            lblQty.Text = "Quantity:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(15, 235);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(61, 28);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Price:";
            // 
            // lblExpiry
            // 
            lblExpiry.AutoSize = true;
            lblExpiry.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExpiry.Location = new Point(326, 253);
            lblExpiry.Name = "lblExpiry";
            lblExpiry.Size = new Size(120, 28);
            lblExpiry.TabIndex = 4;
            lblExpiry.Text = "Expiry Date:";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(173, 367);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(77, 28);
            lblSearch.TabIndex = 5;
            lblSearch.Text = "Search:";
            // 
            // txtName
            // 
            txtName.Location = new Point(100, 176);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 6;
            // 
            // txtQty
            // 
            txtQty.Location = new Point(384, 190);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(150, 31);
            txtQty.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(52, 277);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(150, 31);
            txtPrice.TabIndex = 8;
            // 
            // txtExpiry
            // 
            txtExpiry.Location = new Point(384, 296);
            txtExpiry.Name = "txtExpiry";
            txtExpiry.Size = new Size(150, 31);
            txtExpiry.TabIndex = 9;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(220, 413);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(150, 31);
            txtSearch.TabIndex = 10;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(588, 371);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(588, 411);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(588, 451);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(588, 491);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dgvMedicines
            // 
            dgvMedicines.AllowUserToAddRows = false;
            dgvMedicines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicines.Dock = DockStyle.Bottom;
            dgvMedicines.Location = new Point(0, 543);
            dgvMedicines.MultiSelect = false;
            dgvMedicines.Name = "dgvMedicines";
            dgvMedicines.ReadOnly = true;
            dgvMedicines.RowHeadersWidth = 62;
            dgvMedicines.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMedicines.Size = new Size(996, 225);
            dgvMedicines.TabIndex = 15;
            dgvMedicines.CellClick += dgvMedicines_CellClick;
            // 
            // MedicineForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 768);
            Controls.Add(dgvMedicines);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtSearch);
            Controls.Add(txtExpiry);
            Controls.Add(txtPrice);
            Controls.Add(txtQty);
            Controls.Add(txtName);
            Controls.Add(lblSearch);
            Controls.Add(lblExpiry);
            Controls.Add(lblPrice);
            Controls.Add(lblQty);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MedicineForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Medicine Inventory";
            ((System.ComponentModel.ISupportInitialize)dgvMedicines).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblName;
        private Label lblQty;
        private Label lblPrice;
        private Label lblExpiry;
        private Label lblSearch;
        private TextBox txtName;
        private TextBox txtQty;
        private TextBox txtPrice;
        private TextBox txtExpiry;
        private TextBox txtSearch;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvMedicines;
    }
}