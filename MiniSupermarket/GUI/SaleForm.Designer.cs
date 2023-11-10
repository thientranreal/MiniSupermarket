namespace MiniSupermarket.GUI
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
            pnlAddBill = new Panel();
            pnlAddBtn = new Panel();
            btnAddBill = new Button();
            grbCustomerInfo = new GroupBox();
            rdFemale = new RadioButton();
            rdMale = new RadioButton();
            txtPhone = new TextBox();
            txtCustomerName = new TextBox();
            lbSex = new Label();
            lbPhone = new Label();
            lbCustomerName = new Label();
            cbChooseCustomer = new ComboBox();
            lbChooseCustomer = new Label();
            gbSearch = new GroupBox();
            cbNotPay = new CheckBox();
            cbPay = new CheckBox();
            txtEmployeeSearch = new TextBox();
            txtCustomerSearch = new TextBox();
            cbEmployee = new ComboBox();
            cbCustomer = new ComboBox();
            dtpToDate = new DateTimePicker();
            dtpFromDate = new DateTimePicker();
            lbToDate = new Label();
            lbFromDate = new Label();
            pnl_bottom = new Panel();
            dgv_bill = new DataGridView();
            pnl_top.SuspendLayout();
            pnlAddBill.SuspendLayout();
            pnlAddBtn.SuspendLayout();
            grbCustomerInfo.SuspendLayout();
            gbSearch.SuspendLayout();
            pnl_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_bill).BeginInit();
            SuspendLayout();
            // 
            // pnl_top
            // 
            pnl_top.Controls.Add(pnlAddBill);
            pnl_top.Controls.Add(gbSearch);
            pnl_top.Dock = DockStyle.Top;
            pnl_top.Location = new Point(0, 0);
            pnl_top.Name = "pnl_top";
            pnl_top.Size = new Size(955, 310);
            pnl_top.TabIndex = 0;
            // 
            // pnlAddBill
            // 
            pnlAddBill.Controls.Add(pnlAddBtn);
            pnlAddBill.Controls.Add(grbCustomerInfo);
            pnlAddBill.Dock = DockStyle.Fill;
            pnlAddBill.Location = new Point(0, 0);
            pnlAddBill.Name = "pnlAddBill";
            pnlAddBill.Size = new Size(399, 310);
            pnlAddBill.TabIndex = 2;
            // 
            // pnlAddBtn
            // 
            pnlAddBtn.Controls.Add(btnAddBill);
            pnlAddBtn.Dock = DockStyle.Fill;
            pnlAddBtn.Location = new Point(0, 241);
            pnlAddBtn.Name = "pnlAddBtn";
            pnlAddBtn.Size = new Size(399, 69);
            pnlAddBtn.TabIndex = 2;
            // 
            // btnAddBill
            // 
            btnAddBill.Dock = DockStyle.Fill;
            btnAddBill.FlatAppearance.BorderSize = 0;
            btnAddBill.FlatStyle = FlatStyle.Flat;
            btnAddBill.Location = new Point(0, 0);
            btnAddBill.Name = "btnAddBill";
            btnAddBill.Size = new Size(399, 69);
            btnAddBill.TabIndex = 0;
            btnAddBill.Text = "Thêm hóa đơn";
            btnAddBill.UseVisualStyleBackColor = true;
            btnAddBill.Click += btnAddBill_Click;
            // 
            // grbCustomerInfo
            // 
            grbCustomerInfo.Controls.Add(rdFemale);
            grbCustomerInfo.Controls.Add(rdMale);
            grbCustomerInfo.Controls.Add(txtPhone);
            grbCustomerInfo.Controls.Add(txtCustomerName);
            grbCustomerInfo.Controls.Add(lbSex);
            grbCustomerInfo.Controls.Add(lbPhone);
            grbCustomerInfo.Controls.Add(lbCustomerName);
            grbCustomerInfo.Controls.Add(cbChooseCustomer);
            grbCustomerInfo.Controls.Add(lbChooseCustomer);
            grbCustomerInfo.Dock = DockStyle.Top;
            grbCustomerInfo.Location = new Point(0, 0);
            grbCustomerInfo.Name = "grbCustomerInfo";
            grbCustomerInfo.Size = new Size(399, 241);
            grbCustomerInfo.TabIndex = 1;
            grbCustomerInfo.TabStop = false;
            grbCustomerInfo.Text = "Thông tin khách hàng";
            // 
            // rdFemale
            // 
            rdFemale.AutoSize = true;
            rdFemale.Location = new Point(219, 186);
            rdFemale.Name = "rdFemale";
            rdFemale.Size = new Size(50, 24);
            rdFemale.TabIndex = 7;
            rdFemale.TabStop = true;
            rdFemale.Text = "Nữ";
            rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            rdMale.AutoSize = true;
            rdMale.Location = new Point(111, 186);
            rdMale.Name = "rdMale";
            rdMale.Size = new Size(62, 24);
            rdMale.TabIndex = 7;
            rdMale.TabStop = true;
            rdMale.Text = "Nam";
            rdMale.UseVisualStyleBackColor = true;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(111, 135);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(240, 27);
            txtPhone.TabIndex = 6;
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(111, 85);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(240, 27);
            txtCustomerName.TabIndex = 5;
            // 
            // lbSex
            // 
            lbSex.AutoSize = true;
            lbSex.Location = new Point(12, 188);
            lbSex.Name = "lbSex";
            lbSex.Size = new Size(65, 20);
            lbSex.TabIndex = 4;
            lbSex.Text = "Giới tính";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new Point(12, 138);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(49, 20);
            lbPhone.TabIndex = 3;
            lbPhone.Text = "Số ĐT";
            // 
            // lbCustomerName
            // 
            lbCustomerName.AutoSize = true;
            lbCustomerName.Location = new Point(12, 88);
            lbCustomerName.Name = "lbCustomerName";
            lbCustomerName.Size = new Size(54, 20);
            lbCustomerName.TabIndex = 2;
            lbCustomerName.Text = "Họ tên";
            // 
            // cbChooseCustomer
            // 
            cbChooseCustomer.FormattingEnabled = true;
            cbChooseCustomer.Location = new Point(111, 34);
            cbChooseCustomer.Name = "cbChooseCustomer";
            cbChooseCustomer.Size = new Size(240, 28);
            cbChooseCustomer.TabIndex = 1;
            // 
            // lbChooseCustomer
            // 
            lbChooseCustomer.AutoSize = true;
            lbChooseCustomer.Location = new Point(12, 38);
            lbChooseCustomer.Name = "lbChooseCustomer";
            lbChooseCustomer.Size = new Size(67, 20);
            lbChooseCustomer.TabIndex = 0;
            lbChooseCustomer.Text = "Chọn KH";
            // 
            // gbSearch
            // 
            gbSearch.Controls.Add(cbNotPay);
            gbSearch.Controls.Add(cbPay);
            gbSearch.Controls.Add(txtEmployeeSearch);
            gbSearch.Controls.Add(txtCustomerSearch);
            gbSearch.Controls.Add(cbEmployee);
            gbSearch.Controls.Add(cbCustomer);
            gbSearch.Controls.Add(dtpToDate);
            gbSearch.Controls.Add(dtpFromDate);
            gbSearch.Controls.Add(lbToDate);
            gbSearch.Controls.Add(lbFromDate);
            gbSearch.Dock = DockStyle.Right;
            gbSearch.Location = new Point(399, 0);
            gbSearch.Name = "gbSearch";
            gbSearch.Size = new Size(556, 310);
            gbSearch.TabIndex = 1;
            gbSearch.TabStop = false;
            gbSearch.Text = "Tìm kiếm";
            // 
            // cbNotPay
            // 
            cbNotPay.AutoSize = true;
            cbNotPay.Location = new Point(162, 208);
            cbNotPay.Name = "cbNotPay";
            cbNotPay.Size = new Size(140, 24);
            cbNotPay.TabIndex = 8;
            cbNotPay.Text = "Chưa thanh toán";
            cbNotPay.UseVisualStyleBackColor = true;
            // 
            // cbPay
            // 
            cbPay.AutoSize = true;
            cbPay.Location = new Point(6, 208);
            cbPay.Name = "cbPay";
            cbPay.Size = new Size(125, 24);
            cbPay.TabIndex = 7;
            cbPay.Text = "Đã thanh toán";
            cbPay.UseVisualStyleBackColor = true;
            // 
            // txtEmployeeSearch
            // 
            txtEmployeeSearch.Location = new Point(162, 163);
            txtEmployeeSearch.Name = "txtEmployeeSearch";
            txtEmployeeSearch.Size = new Size(250, 27);
            txtEmployeeSearch.TabIndex = 6;
            // 
            // txtCustomerSearch
            // 
            txtCustomerSearch.Location = new Point(162, 116);
            txtCustomerSearch.Name = "txtCustomerSearch";
            txtCustomerSearch.Size = new Size(250, 27);
            txtCustomerSearch.TabIndex = 5;
            // 
            // cbEmployee
            // 
            cbEmployee.FormattingEnabled = true;
            cbEmployee.Location = new Point(6, 162);
            cbEmployee.Name = "cbEmployee";
            cbEmployee.Size = new Size(125, 28);
            cbEmployee.TabIndex = 4;
            // 
            // cbCustomer
            // 
            cbCustomer.FormattingEnabled = true;
            cbCustomer.Location = new Point(6, 115);
            cbCustomer.Name = "cbCustomer";
            cbCustomer.Size = new Size(125, 28);
            cbCustomer.TabIndex = 3;
            // 
            // dtpToDate
            // 
            dtpToDate.Location = new Point(162, 75);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(250, 27);
            dtpToDate.TabIndex = 2;
            // 
            // dtpFromDate
            // 
            dtpFromDate.Location = new Point(162, 32);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(250, 27);
            dtpFromDate.TabIndex = 1;
            // 
            // lbToDate
            // 
            lbToDate.AutoSize = true;
            lbToDate.Location = new Point(6, 78);
            lbToDate.Name = "lbToDate";
            lbToDate.Size = new Size(72, 20);
            lbToDate.TabIndex = 0;
            lbToDate.Text = "Đến ngày";
            // 
            // lbFromDate
            // 
            lbFromDate.AutoSize = true;
            lbFromDate.Location = new Point(6, 35);
            lbFromDate.Name = "lbFromDate";
            lbFromDate.Size = new Size(62, 20);
            lbFromDate.TabIndex = 0;
            lbFromDate.Text = "Từ ngày";
            // 
            // pnl_bottom
            // 
            pnl_bottom.Controls.Add(dgv_bill);
            pnl_bottom.Dock = DockStyle.Fill;
            pnl_bottom.Location = new Point(0, 310);
            pnl_bottom.Name = "pnl_bottom";
            pnl_bottom.Size = new Size(955, 220);
            pnl_bottom.TabIndex = 1;
            // 
            // dgv_bill
            // 
            dgv_bill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_bill.Dock = DockStyle.Fill;
            dgv_bill.Location = new Point(0, 0);
            dgv_bill.MultiSelect = false;
            dgv_bill.Name = "dgv_bill";
            dgv_bill.RowHeadersWidth = 51;
            dgv_bill.RowTemplate.Height = 29;
            dgv_bill.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_bill.Size = new Size(955, 220);
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
            pnlAddBill.ResumeLayout(false);
            pnlAddBtn.ResumeLayout(false);
            grbCustomerInfo.ResumeLayout(false);
            grbCustomerInfo.PerformLayout();
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
        private TextBox txtEmployeeSearch;
        private TextBox txtCustomerSearch;
        private CheckBox cbNotPay;
        private CheckBox cbPay;
        private Panel pnlAddBill;
        private GroupBox grbCustomerInfo;
        private Panel pnlAddBtn;
        private ComboBox cbChooseCustomer;
        private Label lbChooseCustomer;
        private Label lbSex;
        private Label lbPhone;
        private Label lbCustomerName;
        private TextBox txtPhone;
        private TextBox txtCustomerName;
        private RadioButton rdFemale;
        private RadioButton rdMale;
    }
}