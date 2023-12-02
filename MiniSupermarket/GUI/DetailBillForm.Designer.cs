namespace MiniSupermarket.GUI {
    partial class DetailBillForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            txtFind = new TextBox();
            cboFind = new ComboBox();
            lblTitleProduct = new Label();
            panel3 = new Panel();
            dgvProduct = new DataGridView();
            panel1 = new Panel();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label1 = new Label();
            panel4 = new Panel();
            dgvDetalBill = new DataGridView();
            pnlInformation = new Panel();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalBill).BeginInit();
            pnlInformation.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(lblTitleProduct);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(488, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(838, 80);
            panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Location = new Point(506, 18);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(208, 54);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Loại sản phẩm";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Mã khách hàng", "Tên khách hàng", "Số điện thoại", "" });
            comboBox1.Location = new Point(19, 20);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(171, 23);
            comboBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtFind);
            groupBox1.Controls.Add(cboFind);
            groupBox1.Location = new Point(78, 18);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(399, 54);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm theo";
            // 
            // txtFind
            // 
            txtFind.Location = new Point(215, 20);
            txtFind.Margin = new Padding(3, 2, 3, 2);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(171, 23);
            txtFind.TabIndex = 1;
            // 
            // cboFind
            // 
            cboFind.FormattingEnabled = true;
            cboFind.Items.AddRange(new object[] { "Mã khách hàng", "Tên khách hàng", "Số điện thoại", "" });
            cboFind.Location = new Point(19, 20);
            cboFind.Margin = new Padding(3, 2, 3, 2);
            cboFind.Name = "cboFind";
            cboFind.Size = new Size(171, 23);
            cboFind.TabIndex = 0;
            // 
            // lblTitleProduct
            // 
            lblTitleProduct.AutoSize = true;
            lblTitleProduct.Location = new Point(432, 1);
            lblTitleProduct.Name = "lblTitleProduct";
            lblTitleProduct.Size = new Size(119, 15);
            lblTitleProduct.TabIndex = 3;
            lblTitleProduct.Text = "Danh Sách Sản Phẩm";
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvProduct);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(488, 80);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(838, 348);
            panel3.TabIndex = 2;
            // 
            // dgvProduct
            // 
            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Dock = DockStyle.Fill;
            dgvProduct.Location = new Point(0, 0);
            dgvProduct.Margin = new Padding(3, 2, 3, 2);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.RowTemplate.Height = 29;
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduct.Size = new Size(838, 348);
            dgvProduct.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(488, 80);
            panel1.TabIndex = 1;
            // 
            // btnXoa
            // 
            btnXoa.AutoSize = true;
            btnXoa.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnXoa.Location = new Point(368, 38);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(92, 25);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa sản phẩm";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.AutoSize = true;
            btnSua.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSua.Location = new Point(180, 38);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(123, 25);
            btnSua.TabIndex = 1;
            btnSua.Text = "Cập nhập sản phẩm";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.AutoSize = true;
            btnThem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnThem.Location = new Point(12, 38);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(102, 25);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm sản phẩm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(203, 9);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Giỏ Hàng";
            // 
            // panel4
            // 
            panel4.Controls.Add(dgvDetalBill);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 80);
            panel4.Name = "panel4";
            panel4.Size = new Size(488, 348);
            panel4.TabIndex = 2;
            // 
            // dgvDetalBill
            // 
            dgvDetalBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalBill.Dock = DockStyle.Fill;
            dgvDetalBill.Location = new Point(0, 0);
            dgvDetalBill.Name = "dgvDetalBill";
            dgvDetalBill.RowTemplate.Height = 25;
            dgvDetalBill.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalBill.Size = new Size(488, 348);
            dgvDetalBill.TabIndex = 0;
            // 
            // pnlInformation
            // 
            pnlInformation.Controls.Add(panel4);
            pnlInformation.Controls.Add(panel1);
            pnlInformation.Dock = DockStyle.Left;
            pnlInformation.Location = new Point(0, 0);
            pnlInformation.Margin = new Padding(3, 2, 3, 2);
            pnlInformation.Name = "pnlInformation";
            pnlInformation.Size = new Size(488, 428);
            pnlInformation.TabIndex = 0;
            // 
            // DetailBillForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1326, 428);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pnlInformation);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DetailBillForm";
            Text = "PromotionForm";
            Load += DetailFormMuaHang_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetalBill).EndInit();
            pnlInformation.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private DataGridView dgvProduct;
        private GroupBox groupBox1;
        private TextBox txtFind;
        private ComboBox cboFind;
        private Label lblTitleProduct;
        private GroupBox groupBox2;
        private ComboBox comboBox1;
        private Panel pnlInformation;
        private Panel panel4;
        private DataGridView dgvDetalBill;
        private Panel panel1;
        private Label label1;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
    }
}