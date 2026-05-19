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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
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
            lblTitle.BackColor = Color.FromArgb(27, 79, 114);
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(996, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Medicine Inventory";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.FromArgb(27, 79, 114);
            lblName.Location = new Point(25, 130);
            lblName.Name = "lblName";
            lblName.Size = new Size(166, 28);
            lblName.TabIndex = 1;
            lblName.Text = "Medicine Name:";
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQty.ForeColor = Color.FromArgb(27, 79, 114);
            lblQty.Location = new Point(25, 227);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(100, 28);
            lblQty.TabIndex = 2;
            lblQty.Text = "Quantity:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.FromArgb(27, 79, 114);
            lblPrice.Location = new Point(25, 329);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(64, 28);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Price:";
            // 
            // lblExpiry
            // 
            lblExpiry.AutoSize = true;
            lblExpiry.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExpiry.ForeColor = Color.FromArgb(27, 79, 114);
            lblExpiry.Location = new Point(25, 427);
            lblExpiry.Name = "lblExpiry";
            lblExpiry.Size = new Size(128, 28);
            lblExpiry.TabIndex = 4;
            lblExpiry.Text = "Expiry Date:";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = Color.FromArgb(27, 79, 114);
            lblSearch.Location = new Point(284, 81);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(80, 28);
            lblSearch.TabIndex = 5;
            lblSearch.Text = "Search:";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(100, 176);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 34);
            txtName.TabIndex = 6;
            // 
            // txtQty
            // 
            txtQty.BorderStyle = BorderStyle.FixedSingle;
            txtQty.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQty.Location = new Point(100, 280);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(150, 34);
            txtQty.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(100, 375);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(150, 34);
            txtPrice.TabIndex = 8;
            // 
            // txtExpiry
            // 
            txtExpiry.BorderStyle = BorderStyle.FixedSingle;
            txtExpiry.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtExpiry.Location = new Point(100, 481);
            txtExpiry.Name = "txtExpiry";
            txtExpiry.Size = new Size(150, 34);
            txtExpiry.TabIndex = 9;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(384, 81);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(181, 34);
            txtSearch.TabIndex = 10;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(39, 174, 96);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(718, 222);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(138, 52);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(41, 128, 185);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(718, 280);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(138, 52);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(718, 338);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(138, 49);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(127, 140, 141);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(718, 394);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(138, 47);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dgvMedicines
            // 
            dgvMedicines.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(214, 234, 248);
            dgvMedicines.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvMedicines.BackgroundColor = Color.White;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(27, 79, 114);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvMedicines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvMedicines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicines.Dock = DockStyle.Bottom;
            dgvMedicines.EnableHeadersVisualStyles = false;
            dgvMedicines.Location = new Point(0, 543);
            dgvMedicines.MultiSelect = false;
            dgvMedicines.Name = "dgvMedicines";
            dgvMedicines.ReadOnly = true;
            dgvMedicines.RowHeadersVisible = false;
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
            BackColor = Color.FromArgb(235, 245, 251);
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