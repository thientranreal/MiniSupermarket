namespace MiniSupermarket.Views
{
    partial class SaleForm
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
            pnl_top = new Panel();
            gbSearch = new GroupBox();
            cbNotPay = new CheckBox();
            cbPay = new CheckBox();
            txtEmployee = new TextBox();
            txtCustomer = new TextBox();
            cbEmployee = new ComboBox();
            cbCustomer = new ComboBox();
            dtpToDate = new DateTimePicker();
            dtpFromDate = new DateTimePicker();
            lbToDate = new Label();
            lbFromDate = new Label();
            btnAddBill = new Button();
            pnl_bottom = new Panel();
            dgv_bill = new DataGridView();
            pnl_top.SuspendLayout();
            gbSearch.SuspendLayout();
            pnl_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_bill).BeginInit();
            SuspendLayout();
            // 
            // pnl_top
            // 
            pnl_top.Controls.Add(gbSearch);
            pnl_top.Controls.Add(btnAddBill);
            pnl_top.Dock = DockStyle.Top;
            pnl_top.Location = new Point(0, 0);
            pnl_top.Name = "pnl_top";
            pnl_top.Size = new Size(955, 280);
            pnl_top.TabIndex = 0;
            // 
            // gbSearch
            // 
            gbSearch.Controls.Add(cbNotPay);
            gbSearch.Controls.Add(cbPay);
            gbSearch.Controls.Add(txtEmployee);
            gbSearch.Controls.Add(txtCustomer);
            gbSearch.Controls.Add(cbEmployee);
            gbSearch.Controls.Add(cbCustomer);
            gbSearch.Controls.Add(dtpToDate);
            gbSearch.Controls.Add(dtpFromDate);
            gbSearch.Controls.Add(lbToDate);
            gbSearch.Controls.Add(lbFromDate);
            gbSearch.Dock = DockStyle.Right;
            gbSearch.Location = new Point(399, 0);
            gbSearch.Name = "gbSearch";
            gbSearch.Size = new Size(556, 280);
            gbSearch.TabIndex = 1;
            gbSearch.TabStop = false;
            gbSearch.Text = "Tìm kiếm";
            // 
            // cbNotPay
            // 
            cbNotPay.AutoSize = true;
            cbNotPay.Location = new Point(162, 199);
            cbNotPay.Name = "cbNotPay";
            cbNotPay.Size = new Size(140, 24);
            cbNotPay.TabIndex = 8;
            cbNotPay.Text = "Chưa thanh toán";
            cbNotPay.UseVisualStyleBackColor = true;
            // 
            // cbPay
            // 
            cbPay.AutoSize = true;
            cbPay.Location = new Point(6, 199);
            cbPay.Name = "cbPay";
            cbPay.Size = new Size(125, 24);
            cbPay.TabIndex = 7;
            cbPay.Text = "Đã thanh toán";
            cbPay.UseVisualStyleBackColor = true;
            // 
            // txtEmployee
            // 
            txtEmployee.Location = new Point(162, 154);
            txtEmployee.Name = "txtEmployee";
            txtEmployee.Size = new Size(250, 27);
            txtEmployee.TabIndex = 6;
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(162, 107);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(250, 27);
            txtCustomer.TabIndex = 5;
            // 
            // cbEmployee
            // 
            cbEmployee.FormattingEnabled = true;
            cbEmployee.Location = new Point(6, 153);
            cbEmployee.Name = "cbEmployee";
            cbEmployee.Size = new Size(125, 28);
            cbEmployee.TabIndex = 4;
            // 
            // cbCustomer
            // 
            cbCustomer.FormattingEnabled = true;
            cbCustomer.Location = new Point(6, 106);
            cbCustomer.Name = "cbCustomer";
            cbCustomer.Size = new Size(125, 28);
            cbCustomer.TabIndex = 3;
            // 
            // dtpToDate
            // 
            dtpToDate.Location = new Point(162, 66);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(250, 27);
            dtpToDate.TabIndex = 2;
            // 
            // dtpFromDate
            // 
            dtpFromDate.Location = new Point(162, 23);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(250, 27);
            dtpFromDate.TabIndex = 1;
            // 
            // lbToDate
            // 
            lbToDate.AutoSize = true;
            lbToDate.Location = new Point(6, 69);
            lbToDate.Name = "lbToDate";
            lbToDate.Size = new Size(72, 20);
            lbToDate.TabIndex = 0;
            lbToDate.Text = "Đến ngày";
            // 
            // lbFromDate
            // 
            lbFromDate.AutoSize = true;
            lbFromDate.Location = new Point(6, 26);
            lbFromDate.Name = "lbFromDate";
            lbFromDate.Size = new Size(62, 20);
            lbFromDate.TabIndex = 0;
            lbFromDate.Text = "Từ ngày";
            // 
            // btnAddBill
            // 
            btnAddBill.FlatAppearance.BorderSize = 0;
            btnAddBill.FlatStyle = FlatStyle.Flat;
            btnAddBill.Location = new Point(12, 12);
            btnAddBill.Name = "btnAddBill";
            btnAddBill.Size = new Size(94, 29);
            btnAddBill.TabIndex = 0;
            btnAddBill.Text = "Thêm";
            btnAddBill.UseVisualStyleBackColor = true;
            // 
            // pnl_bottom
            // 
            pnl_bottom.Controls.Add(dgv_bill);
            pnl_bottom.Dock = DockStyle.Fill;
            pnl_bottom.Location = new Point(0, 280);
            pnl_bottom.Name = "pnl_bottom";
            pnl_bottom.Size = new Size(955, 250);
            pnl_bottom.TabIndex = 1;
            // 
            // dgv_bill
            // 
            dgv_bill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_bill.Dock = DockStyle.Fill;
            dgv_bill.Location = new Point(0, 0);
            dgv_bill.Name = "dgv_bill";
            dgv_bill.RowHeadersWidth = 51;
            dgv_bill.RowTemplate.Height = 29;
            dgv_bill.Size = new Size(955, 250);
            dgv_bill.TabIndex = 0;
            // 
            // SaleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 530);
            Controls.Add(pnl_bottom);
            Controls.Add(pnl_top);
            Name = "SaleForm";
            Text = "SaleForm";
            Load += SaleForm_Load;
            pnl_top.ResumeLayout(false);
            gbSearch.ResumeLayout(false);
            gbSearch.PerformLayout();
            pnl_bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_bill).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_top;
        private Panel pnl_bottom;
        private DataGridView dgv_bill;
        private Button btnAddBill;
        private GroupBox gbSearch;
        private Label lbFromDate;
        private Label lbToDate;
        private DateTimePicker dtpToDate;
        private DateTimePicker dtpFromDate;
        private ComboBox cbEmployee;
        private ComboBox cbCustomer;
        private TextBox txtEmployee;
        private TextBox txtCustomer;
        private CheckBox cbNotPay;
        private CheckBox cbPay;
    }
}