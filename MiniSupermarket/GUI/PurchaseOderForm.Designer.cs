namespace MiniSupermarket.GUI
{
    partial class PurchaseOderForm
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
            panel1 = new Panel();
            groupBox4 = new GroupBox();
            dtpkFilterDate = new DateTimePicker();
            groupBox3 = new GroupBox();
            txtSearch = new TextBox();
            cbxTypeSearch = new ComboBox();
            grbxAddPurchaseOder = new GroupBox();
            btnReset = new Button();
            btnPrintOrder = new Button();
            btnUpdate = new Button();
            btnDeletePurchaseOder = new Button();
            btnAddPurchaseOder = new Button();
            txtOrderID = new TextBox();
            cbxSupplier = new ComboBox();
            lblPurchaseOderID = new Label();
            lblSupplier = new Label();
            label2 = new Label();
            lblTitle = new Label();
            panel2 = new Panel();
            dgvPurchaseOders = new DataGridView();
            panel1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            grbxAddPurchaseOder.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPurchaseOders).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(grbxAddPurchaseOder);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1034, 221);
            panel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dtpkFilterDate);
            groupBox4.Location = new Point(686, 133);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(345, 75);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tìm kiếm theo ngày";
            // 
            // dtpkFilterDate
            // 
            dtpkFilterDate.Location = new Point(39, 27);
            dtpkFilterDate.Name = "dtpkFilterDate";
            dtpkFilterDate.Size = new Size(250, 27);
            dtpkFilterDate.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtSearch);
            groupBox3.Controls.Add(cbxTypeSearch);
            groupBox3.Location = new Point(686, 53);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(345, 73);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm kiếm theo";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(158, 27);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(169, 27);
            txtSearch.TabIndex = 1;
            // 
            // cbxTypeSearch
            // 
            cbxTypeSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTypeSearch.FormattingEnabled = true;
            cbxTypeSearch.Items.AddRange(new object[] { "Mã phiếu", "Nhà cung cấp" });
            cbxTypeSearch.Location = new Point(6, 27);
            cbxTypeSearch.Name = "cbxTypeSearch";
            cbxTypeSearch.Size = new Size(123, 28);
            cbxTypeSearch.TabIndex = 0;
            // 
            // grbxAddPurchaseOder
            // 
            grbxAddPurchaseOder.Controls.Add(btnReset);
            grbxAddPurchaseOder.Controls.Add(btnPrintOrder);
            grbxAddPurchaseOder.Controls.Add(btnUpdate);
            grbxAddPurchaseOder.Controls.Add(btnDeletePurchaseOder);
            grbxAddPurchaseOder.Controls.Add(btnAddPurchaseOder);
            grbxAddPurchaseOder.Controls.Add(txtOrderID);
            grbxAddPurchaseOder.Controls.Add(cbxSupplier);
            grbxAddPurchaseOder.Controls.Add(lblPurchaseOderID);
            grbxAddPurchaseOder.Controls.Add(lblSupplier);
            grbxAddPurchaseOder.Location = new Point(21, 53);
            grbxAddPurchaseOder.Name = "grbxAddPurchaseOder";
            grbxAddPurchaseOder.Size = new Size(614, 139);
            grbxAddPurchaseOder.TabIndex = 2;
            grbxAddPurchaseOder.TabStop = false;
            grbxAddPurchaseOder.Text = "Thêm phiếu nhập";
            // 
            // btnReset
            // 
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Location = new Point(360, 95);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 6;
            btnReset.Text = "Tải lại";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnPrintOrder
            // 
            btnPrintOrder.FlatAppearance.BorderSize = 0;
            btnPrintOrder.FlatStyle = FlatStyle.Flat;
            btnPrintOrder.Location = new Point(478, 95);
            btnPrintOrder.Name = "btnPrintOrder";
            btnPrintOrder.Size = new Size(127, 29);
            btnPrintOrder.TabIndex = 5;
            btnPrintOrder.Text = "In phiếu nhập";
            btnPrintOrder.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(124, 95);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDeletePurchaseOder
            // 
            btnDeletePurchaseOder.FlatAppearance.BorderSize = 0;
            btnDeletePurchaseOder.FlatStyle = FlatStyle.Flat;
            btnDeletePurchaseOder.Location = new Point(242, 95);
            btnDeletePurchaseOder.Name = "btnDeletePurchaseOder";
            btnDeletePurchaseOder.Size = new Size(94, 29);
            btnDeletePurchaseOder.TabIndex = 2;
            btnDeletePurchaseOder.Text = "Xoá";
            btnDeletePurchaseOder.UseVisualStyleBackColor = true;
            btnDeletePurchaseOder.Click += btnDeletePurchaseOder_Click;
            // 
            // btnAddPurchaseOder
            // 
            btnAddPurchaseOder.FlatAppearance.BorderSize = 0;
            btnAddPurchaseOder.FlatStyle = FlatStyle.Flat;
            btnAddPurchaseOder.Location = new Point(6, 95);
            btnAddPurchaseOder.Name = "btnAddPurchaseOder";
            btnAddPurchaseOder.Size = new Size(94, 29);
            btnAddPurchaseOder.TabIndex = 2;
            btnAddPurchaseOder.Text = "Thêm";
            btnAddPurchaseOder.UseVisualStyleBackColor = true;
            btnAddPurchaseOder.Click += btnAddPurchaseOder_Click;
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(156, 27);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(125, 27);
            txtOrderID.TabIndex = 3;
            // 
            // cbxSupplier
            // 
            cbxSupplier.FormattingEnabled = true;
            cbxSupplier.Location = new Point(457, 27);
            cbxSupplier.Name = "cbxSupplier";
            cbxSupplier.Size = new Size(151, 28);
            cbxSupplier.TabIndex = 1;
            // 
            // lblPurchaseOderID
            // 
            lblPurchaseOderID.AutoSize = true;
            lblPurchaseOderID.Enabled = false;
            lblPurchaseOderID.Location = new Point(6, 30);
            lblPurchaseOderID.Name = "lblPurchaseOderID";
            lblPurchaseOderID.Size = new Size(111, 20);
            lblPurchaseOderID.TabIndex = 0;
            lblPurchaseOderID.Text = "Mã phiếu nhập:";
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Location = new Point(310, 30);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(103, 20);
            lblSupplier.TabIndex = 0;
            lblSupplier.Text = "Nhà cung cấp:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 53);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(416, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(158, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ PHIẾU NHẬP";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvPurchaseOders);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 221);
            panel2.Name = "panel2";
            panel2.Size = new Size(1034, 283);
            panel2.TabIndex = 1;
            // 
            // dgvPurchaseOders
            // 
            dgvPurchaseOders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPurchaseOders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPurchaseOders.Dock = DockStyle.Fill;
            dgvPurchaseOders.Location = new Point(0, 0);
            dgvPurchaseOders.Name = "dgvPurchaseOders";
            dgvPurchaseOders.RowHeadersWidth = 51;
            dgvPurchaseOders.RowTemplate.Height = 29;
            dgvPurchaseOders.Size = new Size(1034, 283);
            dgvPurchaseOders.TabIndex = 0;
            dgvPurchaseOders.CellDoubleClick += dgvPurchaseOders_CellDoubleClick;
            dgvPurchaseOders.CellMouseClick += dgvPurchaseOders_CellMouseClick;
            // 
            // PurchaseOderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 504);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "PurchaseOderForm";
            Text = "PurchaseOderForm";
            Load += PurchaseOderForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            grbxAddPurchaseOder.ResumeLayout(false);
            grbxAddPurchaseOder.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPurchaseOders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Panel panel2;
        private DataGridView dgvPurchaseOders;
        private GroupBox groupBox3;
        private TextBox txtOrderID;
        private Button btnDeletePurchaseOder;
        private Label lblPurchaseOderID;
        private GroupBox grbxAddPurchaseOder;
        private Button btnAddPurchaseOder;
        private ComboBox cbxSupplier;
        private Label lblSupplier;
        private Label label2;
        private GroupBox groupBox4;
        private TextBox txtSearch;
        private ComboBox cbxTypeSearch;
        private DateTimePicker dtpkFilterDate;
        private Button btnPrintOrder;
        private Button btnUpdate;
        private Button btnReset;
    }
}