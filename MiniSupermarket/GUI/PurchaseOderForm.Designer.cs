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
            dateTimePicker1 = new DateTimePicker();
            groupBox3 = new GroupBox();
            textBox2 = new TextBox();
            comboBox2 = new ComboBox();
            btnPay = new Button();
            grbxDeletePurchaseOder = new GroupBox();
            textBox1 = new TextBox();
            btnDeletePurchaseOder = new Button();
            lblPurchaseOderID = new Label();
            grbxAddPurchaseOder = new GroupBox();
            btnAddPurchaseOder = new Button();
            cbxSupplier = new ComboBox();
            lblSupplier = new Label();
            label2 = new Label();
            lblTitle = new Label();
            panel2 = new Panel();
            dgvPurchaseOders = new DataGridView();
            panel1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            grbxDeletePurchaseOder.SuspendLayout();
            grbxAddPurchaseOder.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPurchaseOders).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(btnPay);
            panel1.Controls.Add(grbxDeletePurchaseOder);
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
            groupBox4.Controls.Add(dateTimePicker1);
            groupBox4.Location = new Point(686, 133);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(345, 75);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tìm kiếm theo ngày";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(39, 27);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(comboBox2);
            groupBox3.Location = new Point(686, 53);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(345, 73);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm kiếm theo";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(158, 27);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(169, 27);
            textBox2.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(6, 27);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(123, 28);
            comboBox2.TabIndex = 0;
            // 
            // btnPay
            // 
            btnPay.FlatAppearance.BorderSize = 0;
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Location = new Point(461, 173);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(94, 35);
            btnPay.TabIndex = 4;
            btnPay.Text = "Thanh toán";
            btnPay.UseVisualStyleBackColor = true;
            // 
            // grbxDeletePurchaseOder
            // 
            grbxDeletePurchaseOder.Controls.Add(textBox1);
            grbxDeletePurchaseOder.Controls.Add(btnDeletePurchaseOder);
            grbxDeletePurchaseOder.Controls.Add(lblPurchaseOderID);
            grbxDeletePurchaseOder.Location = new Point(357, 53);
            grbxDeletePurchaseOder.Name = "grbxDeletePurchaseOder";
            grbxDeletePurchaseOder.Size = new Size(305, 115);
            grbxDeletePurchaseOder.TabIndex = 3;
            grbxDeletePurchaseOder.TabStop = false;
            grbxDeletePurchaseOder.Text = "Xoá phiếu nhập";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(165, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // btnDeletePurchaseOder
            // 
            btnDeletePurchaseOder.FlatAppearance.BorderSize = 0;
            btnDeletePurchaseOder.FlatStyle = FlatStyle.Flat;
            btnDeletePurchaseOder.Location = new Point(104, 68);
            btnDeletePurchaseOder.Name = "btnDeletePurchaseOder";
            btnDeletePurchaseOder.Size = new Size(94, 29);
            btnDeletePurchaseOder.TabIndex = 2;
            btnDeletePurchaseOder.Text = "Xoá";
            btnDeletePurchaseOder.UseVisualStyleBackColor = true;
            // 
            // lblPurchaseOderID
            // 
            lblPurchaseOderID.AutoSize = true;
            lblPurchaseOderID.Location = new Point(16, 37);
            lblPurchaseOderID.Name = "lblPurchaseOderID";
            lblPurchaseOderID.Size = new Size(108, 20);
            lblPurchaseOderID.TabIndex = 0;
            lblPurchaseOderID.Text = "Mã phiếu nhập";
            // 
            // grbxAddPurchaseOder
            // 
            grbxAddPurchaseOder.Controls.Add(btnAddPurchaseOder);
            grbxAddPurchaseOder.Controls.Add(cbxSupplier);
            grbxAddPurchaseOder.Controls.Add(lblSupplier);
            grbxAddPurchaseOder.Location = new Point(21, 53);
            grbxAddPurchaseOder.Name = "grbxAddPurchaseOder";
            grbxAddPurchaseOder.Size = new Size(305, 139);
            grbxAddPurchaseOder.TabIndex = 2;
            grbxAddPurchaseOder.TabStop = false;
            grbxAddPurchaseOder.Text = "Thêm phiếu nhập";
            // 
            // btnAddPurchaseOder
            // 
            btnAddPurchaseOder.FlatAppearance.BorderSize = 0;
            btnAddPurchaseOder.FlatStyle = FlatStyle.Flat;
            btnAddPurchaseOder.Location = new Point(101, 95);
            btnAddPurchaseOder.Name = "btnAddPurchaseOder";
            btnAddPurchaseOder.Size = new Size(94, 29);
            btnAddPurchaseOder.TabIndex = 2;
            btnAddPurchaseOder.Text = "Thêm";
            btnAddPurchaseOder.UseVisualStyleBackColor = true;
            // 
            // cbxSupplier
            // 
            cbxSupplier.FormattingEnabled = true;
            cbxSupplier.Location = new Point(149, 47);
            cbxSupplier.Name = "cbxSupplier";
            cbxSupplier.Size = new Size(151, 28);
            cbxSupplier.TabIndex = 1;
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Location = new Point(17, 53);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(100, 20);
            lblSupplier.TabIndex = 0;
            lblSupplier.Text = "Nhà cung cáp";
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
            dgvPurchaseOders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPurchaseOders.Dock = DockStyle.Fill;
            dgvPurchaseOders.Location = new Point(0, 0);
            dgvPurchaseOders.Name = "dgvPurchaseOders";
            dgvPurchaseOders.RowHeadersWidth = 51;
            dgvPurchaseOders.RowTemplate.Height = 29;
            dgvPurchaseOders.Size = new Size(1034, 283);
            dgvPurchaseOders.TabIndex = 0;
            dgvPurchaseOders.CellDoubleClick += dgvPurchaseOders_CellDoubleClick;
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
            grbxDeletePurchaseOder.ResumeLayout(false);
            grbxDeletePurchaseOder.PerformLayout();
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
        private Button btnPay;
        private GroupBox grbxDeletePurchaseOder;
        private TextBox textBox1;
        private Button btnDeletePurchaseOder;
        private Label lblPurchaseOderID;
        private GroupBox grbxAddPurchaseOder;
        private Button btnAddPurchaseOder;
        private ComboBox cbxSupplier;
        private Label lblSupplier;
        private Label label2;
        private GroupBox groupBox4;
        private TextBox textBox2;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker1;
    }
}