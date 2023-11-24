namespace MiniSupermarket.GUI
{
    partial class ProductManage
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
            this.grb_TimKiem = new System.Windows.Forms.GroupBox();
            this.cbx_TimKiem = new System.Windows.Forms.ComboBox();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grb_TextField = new System.Windows.Forms.GroupBox();
            this.cbx_MaLoai = new System.Windows.Forms.ComboBox();
            this.btn_NhapExcel = new System.Windows.Forms.Button();
            this.txt_MaSp = new System.Windows.Forms.TextBox();
            this.btn_XuatExcel = new System.Windows.Forms.Button();
            this.lb_MaSp = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.lb_TenSp = new System.Windows.Forms.Label();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.lb_MaLoaiSp = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.lb_Soluong = new System.Windows.Forms.Label();
            this.txt_HinhAnh = new System.Windows.Forms.TextBox();
            this.lb_DonGia = new System.Windows.Forms.Label();
            this.txt_Kieu = new System.Windows.Forms.TextBox();
            this.lb_MoTa = new System.Windows.Forms.Label();
            this.txt_MoTa = new System.Windows.Forms.TextBox();
            this.lb_Kieu = new System.Windows.Forms.Label();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.lb_HinhAnh = new System.Windows.Forms.Label();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.txt_TenSp = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dssp_DSSP = new System.Windows.Forms.DataGridView();
            this.grb_TimKiem.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grb_TextField.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dssp_DSSP)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_TimKiem
            // 
            this.grb_TimKiem.Controls.Add(this.cbx_TimKiem);
            this.grb_TimKiem.Controls.Add(this.txt_TimKiem);
            this.grb_TimKiem.Location = new System.Drawing.Point(3, 3);
            this.grb_TimKiem.Name = "grb_TimKiem";
            this.grb_TimKiem.Size = new System.Drawing.Size(949, 72);
            this.grb_TimKiem.TabIndex = 0;
            this.grb_TimKiem.TabStop = false;
            this.grb_TimKiem.Text = "Tìm kiếm";
            // 
            // cbx_TimKiem
            // 
            this.cbx_TimKiem.FormattingEnabled = true;
            this.cbx_TimKiem.Location = new System.Drawing.Point(207, 25);
            this.cbx_TimKiem.Name = "cbx_TimKiem";
            this.cbx_TimKiem.Size = new System.Drawing.Size(202, 28);
            this.cbx_TimKiem.TabIndex = 1;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(415, 25);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(324, 27);
            this.txt_TimKiem.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grb_TimKiem);
            this.panel1.Controls.Add(this.grb_TextField);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 373);
            this.panel1.TabIndex = 1;
            // 
            // grb_TextField
            // 
            this.grb_TextField.Controls.Add(this.cbx_MaLoai);
            this.grb_TextField.Controls.Add(this.btn_NhapExcel);
            this.grb_TextField.Controls.Add(this.txt_MaSp);
            this.grb_TextField.Controls.Add(this.btn_XuatExcel);
            this.grb_TextField.Controls.Add(this.lb_MaSp);
            this.grb_TextField.Controls.Add(this.btn_Xoa);
            this.grb_TextField.Controls.Add(this.lb_TenSp);
            this.grb_TextField.Controls.Add(this.btn_Sua);
            this.grb_TextField.Controls.Add(this.lb_MaLoaiSp);
            this.grb_TextField.Controls.Add(this.btn_Them);
            this.grb_TextField.Controls.Add(this.lb_Soluong);
            this.grb_TextField.Controls.Add(this.txt_HinhAnh);
            this.grb_TextField.Controls.Add(this.lb_DonGia);
            this.grb_TextField.Controls.Add(this.txt_Kieu);
            this.grb_TextField.Controls.Add(this.lb_MoTa);
            this.grb_TextField.Controls.Add(this.txt_MoTa);
            this.grb_TextField.Controls.Add(this.lb_Kieu);
            this.grb_TextField.Controls.Add(this.txt_DonGia);
            this.grb_TextField.Controls.Add(this.lb_HinhAnh);
            this.grb_TextField.Controls.Add(this.txt_SoLuong);
            this.grb_TextField.Controls.Add(this.txt_TenSp);
            this.grb_TextField.Location = new System.Drawing.Point(3, 81);
            this.grb_TextField.Name = "grb_TextField";
            this.grb_TextField.Size = new System.Drawing.Size(946, 289);
            this.grb_TextField.TabIndex = 22;
            this.grb_TextField.TabStop = false;
            this.grb_TextField.Text = "Thông tin";
            // 
            // cbx_MaLoai
            // 
            this.cbx_MaLoai.FormattingEnabled = true;
            this.cbx_MaLoai.Location = new System.Drawing.Point(185, 86);
            this.cbx_MaLoai.Name = "cbx_MaLoai";
            this.cbx_MaLoai.Size = new System.Drawing.Size(172, 28);
            this.cbx_MaLoai.TabIndex = 24;
            // 
            // btn_NhapExcel
            // 
            this.btn_NhapExcel.Location = new System.Drawing.Point(824, 229);
            this.btn_NhapExcel.Name = "btn_NhapExcel";
            this.btn_NhapExcel.Size = new System.Drawing.Size(94, 43);
            this.btn_NhapExcel.TabIndex = 21;
            this.btn_NhapExcel.Text = "Nhập ";
            this.btn_NhapExcel.UseVisualStyleBackColor = true;
            // 
            // txt_MaSp
            // 
            this.txt_MaSp.Location = new System.Drawing.Point(185, 44);
            this.txt_MaSp.Name = "txt_MaSp";
            this.txt_MaSp.Size = new System.Drawing.Size(172, 27);
            this.txt_MaSp.TabIndex = 9;
            // 
            // btn_XuatExcel
            // 
            this.btn_XuatExcel.Location = new System.Drawing.Point(711, 229);
            this.btn_XuatExcel.Name = "btn_XuatExcel";
            this.btn_XuatExcel.Size = new System.Drawing.Size(94, 43);
            this.btn_XuatExcel.TabIndex = 20;
            this.btn_XuatExcel.Text = "Xuất ";
            this.btn_XuatExcel.UseVisualStyleBackColor = true;
            // 
            // lb_MaSp
            // 
            this.lb_MaSp.AutoSize = true;
            this.lb_MaSp.Location = new System.Drawing.Point(31, 47);
            this.lb_MaSp.Name = "lb_MaSp";
            this.lb_MaSp.Size = new System.Drawing.Size(98, 20);
            this.lb_MaSp.TabIndex = 1;
            this.lb_MaSp.Text = "Mã sản phẩm";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(824, 152);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(94, 43);
            this.btn_Xoa.TabIndex = 19;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // lb_TenSp
            // 
            this.lb_TenSp.AutoSize = true;
            this.lb_TenSp.Location = new System.Drawing.Point(397, 50);
            this.lb_TenSp.Name = "lb_TenSp";
            this.lb_TenSp.Size = new System.Drawing.Size(100, 20);
            this.lb_TenSp.TabIndex = 2;
            this.lb_TenSp.Text = "Tên sản phẩm";
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(824, 92);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(94, 43);
            this.btn_Sua.TabIndex = 18;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // lb_MaLoaiSp
            // 
            this.lb_MaLoaiSp.AutoSize = true;
            this.lb_MaLoaiSp.Location = new System.Drawing.Point(31, 89);
            this.lb_MaLoaiSp.Name = "lb_MaLoaiSp";
            this.lb_MaLoaiSp.Size = new System.Drawing.Size(59, 20);
            this.lb_MaLoaiSp.TabIndex = 3;
            this.lb_MaLoaiSp.Text = "Mã loại";
            this.lb_MaLoaiSp.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(824, 31);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(94, 43);
            this.btn_Them.TabIndex = 17;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // lb_Soluong
            // 
            this.lb_Soluong.AutoSize = true;
            this.lb_Soluong.Location = new System.Drawing.Point(397, 92);
            this.lb_Soluong.Name = "lb_Soluong";
            this.lb_Soluong.Size = new System.Drawing.Size(69, 20);
            this.lb_Soluong.TabIndex = 4;
            this.lb_Soluong.Text = "Số lượng";
            // 
            // txt_HinhAnh
            // 
            this.txt_HinhAnh.Location = new System.Drawing.Point(535, 171);
            this.txt_HinhAnh.Name = "txt_HinhAnh";
            this.txt_HinhAnh.Size = new System.Drawing.Size(147, 27);
            this.txt_HinhAnh.TabIndex = 16;
            // 
            // lb_DonGia
            // 
            this.lb_DonGia.AutoSize = true;
            this.lb_DonGia.Location = new System.Drawing.Point(31, 129);
            this.lb_DonGia.Name = "lb_DonGia";
            this.lb_DonGia.Size = new System.Drawing.Size(62, 20);
            this.lb_DonGia.TabIndex = 5;
            this.lb_DonGia.Text = "Đơn giá";
            // 
            // txt_Kieu
            // 
            this.txt_Kieu.Location = new System.Drawing.Point(185, 168);
            this.txt_Kieu.Name = "txt_Kieu";
            this.txt_Kieu.Size = new System.Drawing.Size(172, 27);
            this.txt_Kieu.TabIndex = 15;
            // 
            // lb_MoTa
            // 
            this.lb_MoTa.AutoSize = true;
            this.lb_MoTa.Location = new System.Drawing.Point(397, 132);
            this.lb_MoTa.Name = "lb_MoTa";
            this.lb_MoTa.Size = new System.Drawing.Size(48, 20);
            this.lb_MoTa.TabIndex = 6;
            this.lb_MoTa.Text = "Mô tả";
            // 
            // txt_MoTa
            // 
            this.txt_MoTa.Location = new System.Drawing.Point(535, 129);
            this.txt_MoTa.Name = "txt_MoTa";
            this.txt_MoTa.Size = new System.Drawing.Size(240, 27);
            this.txt_MoTa.TabIndex = 14;
            // 
            // lb_Kieu
            // 
            this.lb_Kieu.AutoSize = true;
            this.lb_Kieu.Location = new System.Drawing.Point(31, 171);
            this.lb_Kieu.Name = "lb_Kieu";
            this.lb_Kieu.Size = new System.Drawing.Size(38, 20);
            this.lb_Kieu.TabIndex = 7;
            this.lb_Kieu.Text = "Kiểu";
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Location = new System.Drawing.Point(185, 126);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(172, 27);
            this.txt_DonGia.TabIndex = 13;
            // 
            // lb_HinhAnh
            // 
            this.lb_HinhAnh.AutoSize = true;
            this.lb_HinhAnh.Location = new System.Drawing.Point(397, 174);
            this.lb_HinhAnh.Name = "lb_HinhAnh";
            this.lb_HinhAnh.Size = new System.Drawing.Size(68, 20);
            this.lb_HinhAnh.TabIndex = 8;
            this.lb_HinhAnh.Text = "Hình ảnh";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(535, 89);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(111, 27);
            this.txt_SoLuong.TabIndex = 12;
            // 
            // txt_TenSp
            // 
            this.txt_TenSp.Location = new System.Drawing.Point(535, 47);
            this.txt_TenSp.Name = "txt_TenSp";
            this.txt_TenSp.Size = new System.Drawing.Size(161, 27);
            this.txt_TenSp.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dssp_DSSP);
            this.panel2.Location = new System.Drawing.Point(2, 380);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(952, 347);
            this.panel2.TabIndex = 2;
            // 
            // dssp_DSSP
            // 
            this.dssp_DSSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dssp_DSSP.Location = new System.Drawing.Point(3, 3);
            this.dssp_DSSP.Name = "dssp_DSSP";
            this.dssp_DSSP.RowHeadersWidth = 51;
            this.dssp_DSSP.RowTemplate.Height = 29;
            this.dssp_DSSP.Size = new System.Drawing.Size(946, 379);
            this.dssp_DSSP.TabIndex = 0;
            this.dssp_DSSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dssp_DSSP_CellClick);
            this.dssp_DSSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dssp_DSSP_CellContentClick);
            // 
            // ProductManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 728);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ProductManage";
            this.Text = "ProductManage";
            this.Load += new System.EventHandler(this.ProductManage_Load);
            this.grb_TimKiem.ResumeLayout(false);
            this.grb_TimKiem.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.grb_TextField.ResumeLayout(false);
            this.grb_TextField.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dssp_DSSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grb_TimKiem;
        private ComboBox cbx_TimKiem;
        private TextBox txt_TimKiem;
        private Panel panel1;
        private Label lb_MaLoaiSp;
        private Label lb_TenSp;
        private Label lb_MaSp;
        private Label lb_HinhAnh;
        private Label lb_Kieu;
        private Label lb_MoTa;
        private Label lb_DonGia;
        private Label lb_Soluong;
        private Button btn_NhapExcel;
        private Button btn_XuatExcel;
        private Button btn_Xoa;
        private Button btn_Sua;
        private Button btn_Them;
        private TextBox txt_HinhAnh;
        private TextBox txt_Kieu;
        private TextBox txt_MoTa;
        private TextBox txt_DonGia;
        private TextBox txt_SoLuong;
        private TextBox txt_TenSp;
        private TextBox txt_MaSp;
        private Panel panel2;
        private DataGridView dssp_DSSP;
        private GroupBox grb_TextField;
        private ComboBox cbx_MaLoai;
    }
}