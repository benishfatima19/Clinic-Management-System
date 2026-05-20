namespace Clinic_System.Forms
{
    partial class ReportsForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblTitle = new Label();
            tabControl1 = new TabControl();
            tabBilling = new TabPage();
            dgvBills = new DataGridView();
            lblTotalRevenue = new Label();
            btnRefreshBills = new Button();
            txtBillSearch = new TextBox();
            lblBillSearch = new Label();
            tabInventory = new TabPage();
            btnRefreshInventory = new Button();
            dgvInventory = new DataGridView();
            lblLowStock = new Label();
            tabControl1.SuspendLayout();
            tabBilling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBills).BeginInit();
            tabInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
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
            lblTitle.Size = new Size(878, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Reports";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabBilling);
            tabControl1.Controls.Add(tabInventory);
            tabControl1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 141);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(879, 452);
            tabControl1.TabIndex = 1;
            // 
            // tabBilling
            // 
            tabBilling.Controls.Add(dgvBills);
            tabBilling.Controls.Add(lblTotalRevenue);
            tabBilling.Controls.Add(btnRefreshBills);
            tabBilling.Controls.Add(txtBillSearch);
            tabBilling.Controls.Add(lblBillSearch);
            tabBilling.ForeColor = Color.FromArgb(27, 79, 114);
            tabBilling.Location = new Point(4, 37);
            tabBilling.Name = "tabBilling";
            tabBilling.Padding = new Padding(3);
            tabBilling.Size = new Size(871, 411);
            tabBilling.TabIndex = 0;
            tabBilling.Text = "Billing Report";
            tabBilling.UseVisualStyleBackColor = true;
            // 
            // dgvBills
            // 
            dgvBills.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(214, 234, 248);
            dgvBills.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvBills.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(27, 79, 114);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBills.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBills.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBills.EnableHeadersVisualStyles = false;
            dgvBills.Location = new Point(0, 186);
            dgvBills.Name = "dgvBills";
            dgvBills.ReadOnly = true;
            dgvBills.RowHeadersVisible = false;
            dgvBills.RowHeadersWidth = 62;
            dgvBills.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBills.Size = new Size(862, 222);
            dgvBills.TabIndex = 4;
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.AutoSize = true;
            lblTotalRevenue.Location = new Point(306, 145);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(231, 28);
            lblTotalRevenue.TabIndex = 3;
            lblTotalRevenue.Text = "Total Revenue: Rs. 0.00";
            lblTotalRevenue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRefreshBills
            // 
            btnRefreshBills.BackColor = Color.FromArgb(243, 156, 18);
            btnRefreshBills.Cursor = Cursors.Hand;
            btnRefreshBills.FlatStyle = FlatStyle.Flat;
            btnRefreshBills.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefreshBills.ForeColor = Color.White;
            btnRefreshBills.Location = new Point(683, 17);
            btnRefreshBills.Name = "btnRefreshBills";
            btnRefreshBills.Size = new Size(117, 43);
            btnRefreshBills.TabIndex = 2;
            btnRefreshBills.Text = "Refresh";
            btnRefreshBills.UseVisualStyleBackColor = false;
            btnRefreshBills.Click += btnRefreshBills_Click;
            // 
            // txtBillSearch
            // 
            txtBillSearch.BorderStyle = BorderStyle.FixedSingle;
            txtBillSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBillSearch.Location = new Point(281, 41);
            txtBillSearch.Name = "txtBillSearch";
            txtBillSearch.Size = new Size(259, 34);
            txtBillSearch.TabIndex = 1;
            txtBillSearch.TextChanged += txtBillSearch_TextChanged;
            // 
            // lblBillSearch
            // 
            lblBillSearch.AutoSize = true;
            lblBillSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBillSearch.ForeColor = Color.FromArgb(27, 79, 114);
            lblBillSearch.Location = new Point(92, 20);
            lblBillSearch.Name = "lblBillSearch";
            lblBillSearch.Size = new Size(183, 28);
            lblBillSearch.TabIndex = 0;
            lblBillSearch.Text = "Search by Patient:";
            // 
            // tabInventory
            // 
            tabInventory.Controls.Add(btnRefreshInventory);
            tabInventory.Controls.Add(dgvInventory);
            tabInventory.Controls.Add(lblLowStock);
            tabInventory.ForeColor = Color.FromArgb(27, 79, 114);
            tabInventory.Location = new Point(4, 37);
            tabInventory.Name = "tabInventory";
            tabInventory.Padding = new Padding(3);
            tabInventory.Size = new Size(871, 411);
            tabInventory.TabIndex = 1;
            tabInventory.Text = "Inventory Report";
            tabInventory.UseVisualStyleBackColor = true;
            // 
            // btnRefreshInventory
            // 
            btnRefreshInventory.BackColor = Color.FromArgb(243, 156, 18);
            btnRefreshInventory.Cursor = Cursors.Hand;
            btnRefreshInventory.FlatStyle = FlatStyle.Flat;
            btnRefreshInventory.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefreshInventory.ForeColor = Color.White;
            btnRefreshInventory.Location = new Point(683, 17);
            btnRefreshInventory.Name = "btnRefreshInventory";
            btnRefreshInventory.Size = new Size(117, 43);
            btnRefreshInventory.TabIndex = 2;
            btnRefreshInventory.Text = "Refresh";
            btnRefreshInventory.UseVisualStyleBackColor = false;
            btnRefreshInventory.Click += btnRefreshInventory_Click;
            // 
            // dgvInventory
            // 
            dgvInventory.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(214, 234, 248);
            dgvInventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvInventory.BackgroundColor = Color.White;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(27, 79, 114);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.EnableHeadersVisualStyles = false;
            dgvInventory.Location = new Point(3, 163);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.RowHeadersWidth = 62;
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.Size = new Size(862, 241);
            dgvInventory.TabIndex = 1;
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowStock.ForeColor = Color.FromArgb(27, 79, 114);
            lblLowStock.Location = new Point(247, 83);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(309, 28);
            lblLowStock.TabIndex = 0;
            lblLowStock.Text = "⚠️ Low Stock Items (Qty < 10):";
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 245, 251);
            ClientSize = new Size(878, 594);
            Controls.Add(tabControl1);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ReportsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reports";
            tabControl1.ResumeLayout(false);
            tabBilling.ResumeLayout(false);
            tabBilling.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBills).EndInit();
            tabInventory.ResumeLayout(false);
            tabInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private TabControl tabControl1;
        private TabPage tabBilling;
        private TabPage tabInventory;
        private TextBox txtBillSearch;
        private Label lblBillSearch;
        private DataGridView dgvBills;
        private Label lblTotalRevenue;
        private Button btnRefreshBills;
        private Button btnRefreshInventory;
        private DataGridView dgvInventory;
        private Label lblLowStock;
    }
}