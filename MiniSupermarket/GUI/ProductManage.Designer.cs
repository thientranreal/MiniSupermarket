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
            grb_TimKiem = new GroupBox();
            cbx_TimKiem = new ComboBox();
            txt_TimKiem = new TextBox();
            panel1 = new Panel();
            grb_TextField = new GroupBox();
            cbx_MaLoai = new ComboBox();
            btn_NhapExcel = new Button();
            txt_MaSp = new TextBox();
            btn_XuatExcel = new Button();
            lb_MaSp = new Label();
            btn_Xoa = new Button();
            lb_TenSp = new Label();
            btn_Sua = new Button();
            lb_MaLoaiSp = new Label();
            btn_Them = new Button();
            lb_Soluong = new Label();
            lb_DonGia = new Label();
            txt_Kieu = new TextBox();
            lb_MoTa = new Label();
            txt_MoTa = new TextBox();
            lb_Kieu = new Label();
            txt_DonGia = new TextBox();
            txt_SoLuong = new TextBox();
            txt_TenSp = new TextBox();
            panel2 = new Panel();
            dssp_DSSP = new DataGridView();
            grb_TimKiem.SuspendLayout();
            panel1.SuspendLayout();
            grb_TextField.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dssp_DSSP).BeginInit();
            SuspendLayout();
            // 
            // grb_TimKiem
            // 
            grb_TimKiem.Controls.Add(cbx_TimKiem);
            grb_TimKiem.Controls.Add(txt_TimKiem);
            grb_TimKiem.Location = new Point(3, 3);
            grb_TimKiem.Name = "grb_TimKiem";
            grb_TimKiem.Size = new Size(949, 72);
            grb_TimKiem.TabIndex = 0;
            grb_TimKiem.TabStop = false;
            grb_TimKiem.Text = "Tìm kiếm";
            // 
            // cbx_TimKiem
            // 
            cbx_TimKiem.FormattingEnabled = true;
            cbx_TimKiem.Location = new Point(207, 25);
            cbx_TimKiem.Name = "cbx_TimKiem";
            cbx_TimKiem.Size = new Size(202, 28);
            cbx_TimKiem.TabIndex = 1;
            // 
            // txt_TimKiem
            // 
            txt_TimKiem.Location = new Point(415, 25);
            txt_TimKiem.Name = "txt_TimKiem";
            txt_TimKiem.Size = new Size(324, 27);
            txt_TimKiem.TabIndex = 0;
            txt_TimKiem.TextChanged+=txt_TimKiem_TextChanged;
            txt_TimKiem.KeyDown += txt_TimKiem_KeyDown;
            // 
            // panel1
            // 
            panel1.Controls.Add(grb_TimKiem);
            panel1.Controls.Add(grb_TextField);
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(955, 373);
            panel1.TabIndex = 1;
            // 
            // grb_TextField
            // 
            grb_TextField.Controls.Add(cbx_MaLoai);
            grb_TextField.Controls.Add(btn_NhapExcel);
            grb_TextField.Controls.Add(txt_MaSp);
            grb_TextField.Controls.Add(btn_XuatExcel);
            grb_TextField.Controls.Add(lb_MaSp);
            grb_TextField.Controls.Add(btn_Xoa);
            grb_TextField.Controls.Add(lb_TenSp);
            grb_TextField.Controls.Add(btn_Sua);
            grb_TextField.Controls.Add(lb_MaLoaiSp);
            grb_TextField.Controls.Add(btn_Them);
            grb_TextField.Controls.Add(lb_Soluong);
            grb_TextField.Controls.Add(lb_DonGia);
            grb_TextField.Controls.Add(txt_Kieu);
            grb_TextField.Controls.Add(lb_MoTa);
            grb_TextField.Controls.Add(txt_MoTa);
            grb_TextField.Controls.Add(lb_Kieu);
            grb_TextField.Controls.Add(txt_DonGia);
            grb_TextField.Controls.Add(txt_SoLuong);
            grb_TextField.Controls.Add(txt_TenSp);
            grb_TextField.Location = new Point(3, 81);
            grb_TextField.Name = "grb_TextField";
            grb_TextField.Size = new Size(946, 289);
            grb_TextField.TabIndex = 22;
            grb_TextField.TabStop = false;
            grb_TextField.Text = "Thông tin";
            // 
            // cbx_MaLoai
            // 
            cbx_MaLoai.FormattingEnabled = true;
            cbx_MaLoai.Location = new Point(185, 86);
            cbx_MaLoai.Name = "cbx_MaLoai";
            cbx_MaLoai.Size = new Size(172, 28);
            cbx_MaLoai.TabIndex = 24;
            // 
            // btn_NhapExcel
            // 
            btn_NhapExcel.Location = new Point(824, 229);
            btn_NhapExcel.Name = "btn_NhapExcel";
            btn_NhapExcel.Size = new Size(94, 43);
            btn_NhapExcel.TabIndex = 21;
            btn_NhapExcel.Text = "Nhập ";
            btn_NhapExcel.UseVisualStyleBackColor = true;
            // 
            // txt_MaSp
            // 
            txt_MaSp.Location = new Point(185, 44);
            txt_MaSp.Name = "txt_MaSp";
            txt_MaSp.Size = new Size(172, 27);
            txt_MaSp.TabIndex = 9;
            // 
            // btn_XuatExcel
            // 
            btn_XuatExcel.Location = new Point(711, 229);
            btn_XuatExcel.Name = "btn_XuatExcel";
            btn_XuatExcel.Size = new Size(94, 43);
            btn_XuatExcel.TabIndex = 20;
            btn_XuatExcel.Text = "Xuất ";
            btn_XuatExcel.UseVisualStyleBackColor = true;
            // 
            // lb_MaSp
            // 
            lb_MaSp.AutoSize = true;
            lb_MaSp.Location = new Point(31, 47);
            lb_MaSp.Name = "lb_MaSp";
            lb_MaSp.Size = new Size(98, 20);
            lb_MaSp.TabIndex = 1;
            lb_MaSp.Text = "Mã sản phẩm";
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(824, 152);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(94, 43);
            btn_Xoa.TabIndex = 19;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // lb_TenSp
            // 
            lb_TenSp.AutoSize = true;
            lb_TenSp.Location = new Point(397, 50);
            lb_TenSp.Name = "lb_TenSp";
            lb_TenSp.Size = new Size(100, 20);
            lb_TenSp.TabIndex = 2;
            lb_TenSp.Text = "Tên sản phẩm";
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(824, 92);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(94, 43);
            btn_Sua.TabIndex = 18;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // lb_MaLoaiSp
            // 
            lb_MaLoaiSp.AutoSize = true;
            lb_MaLoaiSp.Location = new Point(31, 89);
            lb_MaLoaiSp.Name = "lb_MaLoaiSp";
            lb_MaLoaiSp.Size = new Size(59, 20);
            lb_MaLoaiSp.TabIndex = 3;
            lb_MaLoaiSp.Text = "Mã loại";
            lb_MaLoaiSp.Click += label3_Click;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(824, 31);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(94, 43);
            btn_Them.TabIndex = 17;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // lb_Soluong
            // 
            lb_Soluong.AutoSize = true;
            lb_Soluong.Location = new Point(397, 92);
            lb_Soluong.Name = "lb_Soluong";
            lb_Soluong.Size = new Size(69, 20);
            lb_Soluong.TabIndex = 4;
            lb_Soluong.Text = "Số lượng";
            // 
            // lb_DonGia
            // 
            lb_DonGia.AutoSize = true;
            lb_DonGia.Location = new Point(31, 129);
            lb_DonGia.Name = "lb_DonGia";
            lb_DonGia.Size = new Size(62, 20);
            lb_DonGia.TabIndex = 5;
            lb_DonGia.Text = "Đơn giá";
            // 
            // txt_Kieu
            // 
            txt_Kieu.Location = new Point(185, 168);
            txt_Kieu.Name = "txt_Kieu";
            txt_Kieu.Size = new Size(172, 27);
            txt_Kieu.TabIndex = 15;
            // 
            // lb_MoTa
            // 
            lb_MoTa.AutoSize = true;
            lb_MoTa.Location = new Point(397, 132);
            lb_MoTa.Name = "lb_MoTa";
            lb_MoTa.Size = new Size(48, 20);
            lb_MoTa.TabIndex = 6;
            lb_MoTa.Text = "Mô tả";
            // 
            // txt_MoTa
            // 
            txt_MoTa.Location = new Point(535, 129);
            txt_MoTa.Name = "txt_MoTa";
            txt_MoTa.Size = new Size(240, 27);
            txt_MoTa.TabIndex = 14;
            // 
            // lb_Kieu
            // 
            lb_Kieu.AutoSize = true;
            lb_Kieu.Location = new Point(31, 171);
            lb_Kieu.Name = "lb_Kieu";
            lb_Kieu.Size = new Size(38, 20);
            lb_Kieu.TabIndex = 7;
            lb_Kieu.Text = "Kiểu";
            // 
            // txt_DonGia
            // 
            txt_DonGia.Location = new Point(185, 126);
            txt_DonGia.Name = "txt_DonGia";
            txt_DonGia.Size = new Size(172, 27);
            txt_DonGia.TabIndex = 13;
            txt_DonGia.KeyPress += txt_DonGia_KeyPress;
            // 
            // txt_SoLuong
            // 
            txt_SoLuong.Location = new Point(535, 89);
            txt_SoLuong.Name = "txt_SoLuong";
            txt_SoLuong.Size = new Size(111, 27);
            txt_SoLuong.TabIndex = 12;
            txt_SoLuong.KeyPress += txt_SoLuong_KeyPress;
            // 
            // txt_TenSp
            // 
            txt_TenSp.Location = new Point(535, 47);
            txt_TenSp.Name = "txt_TenSp";
            txt_TenSp.Size = new Size(161, 27);
            txt_TenSp.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(dssp_DSSP);
            panel2.Location = new Point(2, 380);
            panel2.Name = "panel2";
            panel2.Size = new Size(952, 347);
            panel2.TabIndex = 2;
            // 
            // dssp_DSSP
            // 
            dssp_DSSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dssp_DSSP.Location = new Point(3, 3);
            dssp_DSSP.Name = "dssp_DSSP";
            dssp_DSSP.RowHeadersWidth = 51;
            dssp_DSSP.RowTemplate.Height = 29;
            dssp_DSSP.Size = new Size(946, 379);
            dssp_DSSP.TabIndex = 0;
            dssp_DSSP.CellClick += dssp_DSSP_CellClick;
            dssp_DSSP.CellContentClick += dssp_DSSP_CellContentClick;
            // 
            // ProductManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 728);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ProductManage";
            Text = "ProductManage";
            Load += ProductManage_Load;
            grb_TimKiem.ResumeLayout(false);
            grb_TimKiem.PerformLayout();
            panel1.ResumeLayout(false);
            grb_TextField.ResumeLayout(false);
            grb_TextField.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dssp_DSSP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grb_TimKiem;
        private ComboBox cbx_TimKiem;
        private TextBox txt_TimKiem;
        private Panel panel1;
        private Label lb_MaLoaiSp;
        private Label lb_TenSp;
        private Label lb_MaSp;
        private Label lb_Kieu;
        private Label lb_MoTa;
        private Label lb_DonGia;
        private Label lb_Soluong;
        private Button btn_NhapExcel;
        private Button btn_XuatExcel;
        private Button btn_Xoa;
        private Button btn_Sua;
        private Button btn_Them;
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