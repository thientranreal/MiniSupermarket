namespace MiniSupermarket.GUI
{
    partial class RoleForm
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
            tb_id = new TextBox();
            lb_id = new Label();
            bt_add = new Button();
            gb_Info = new GroupBox();
            lb_nhaphang = new Label();
            cb_nhaphang = new ComboBox();
            lb_khuyenmai = new Label();
            lb_quyen = new Label();
            lb_banhang = new Label();
            cb_ctkm = new ComboBox();
            cb_quyen = new ComboBox();
            cb_banhang = new ComboBox();
            lb_nhacungcap = new Label();
            lb_nhanvien = new Label();
            loaisanpham = new Label();
            cb_nhacungcap = new ComboBox();
            cb_nhanvien = new ComboBox();
            cb_loaisp = new ComboBox();
            lb_thongke = new Label();
            cb_thongke = new ComboBox();
            lb_khachhang = new Label();
            cb_khachhang = new ComboBox();
            lb_sanpham = new Label();
            cb_sanpham = new ComboBox();
            lb_title = new Label();
            bt_edit = new Button();
            bt_delete = new Button();
            bt_reset = new Button();
            gb_List = new GroupBox();
            ds_qlcv = new DataGridView();
            gb_Function = new GroupBox();
            gb_role = new GroupBox();
            rtb_explain = new RichTextBox();
            lb_explain = new Label();
            lb_name = new Label();
            tb_name = new TextBox();
            gb_Info.SuspendLayout();
            gb_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ds_qlcv).BeginInit();
            gb_Function.SuspendLayout();
            gb_role.SuspendLayout();
            SuspendLayout();
            // 
            // tb_id
            // 
            tb_id.Location = new Point(144, 45);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(248, 31);
            tb_id.TabIndex = 0;
            // 
            // lb_id
            // 
            lb_id.AutoSize = true;
            lb_id.Location = new Point(7, 45);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(92, 25);
            lb_id.TabIndex = 1;
            lb_id.Text = "Mã vai trò";
            // 
            // bt_add
            // 
            bt_add.Location = new Point(31, 45);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(112, 40);
            bt_add.TabIndex = 2;
            bt_add.Text = "Thêm";
            bt_add.UseVisualStyleBackColor = true;
            bt_add.Click += bt_add_Click;
            // 
            // gb_Info
            // 
            gb_Info.Controls.Add(lb_nhaphang);
            gb_Info.Controls.Add(cb_nhaphang);
            gb_Info.Controls.Add(lb_khuyenmai);
            gb_Info.Controls.Add(lb_quyen);
            gb_Info.Controls.Add(lb_banhang);
            gb_Info.Controls.Add(cb_ctkm);
            gb_Info.Controls.Add(cb_quyen);
            gb_Info.Controls.Add(cb_banhang);
            gb_Info.Controls.Add(lb_nhacungcap);
            gb_Info.Controls.Add(lb_nhanvien);
            gb_Info.Controls.Add(loaisanpham);
            gb_Info.Controls.Add(cb_nhacungcap);
            gb_Info.Controls.Add(cb_nhanvien);
            gb_Info.Controls.Add(cb_loaisp);
            gb_Info.Controls.Add(lb_thongke);
            gb_Info.Controls.Add(cb_thongke);
            gb_Info.Controls.Add(lb_khachhang);
            gb_Info.Controls.Add(cb_khachhang);
            gb_Info.Controls.Add(lb_sanpham);
            gb_Info.Controls.Add(cb_sanpham);
            gb_Info.Location = new Point(12, 258);
            gb_Info.Name = "gb_Info";
            gb_Info.Size = new Size(1301, 260);
            gb_Info.TabIndex = 3;
            gb_Info.TabStop = false;
            gb_Info.Text = "Phân quyền";
            // 
            // lb_nhaphang
            // 
            lb_nhaphang.AutoSize = true;
            lb_nhaphang.Location = new Point(6, 214);
            lb_nhaphang.Name = "lb_nhaphang";
            lb_nhaphang.Size = new Size(100, 25);
            lb_nhaphang.TabIndex = 2;
            lb_nhaphang.Text = "Nhập hàng";
            // 
            // cb_nhaphang
            // 
            cb_nhaphang.FormattingEnabled = true;
            cb_nhaphang.Location = new Point(192, 214);
            cb_nhaphang.Name = "cb_nhaphang";
            cb_nhaphang.Size = new Size(242, 33);
            cb_nhaphang.TabIndex = 0;
            // 
            // lb_khuyenmai
            // 
            lb_khuyenmai.AutoSize = true;
            lb_khuyenmai.Location = new Point(464, 214);
            lb_khuyenmai.Name = "lb_khuyenmai";
            lb_khuyenmai.Size = new Size(104, 25);
            lb_khuyenmai.TabIndex = 2;
            lb_khuyenmai.Text = "Khuyến mãi";
            // 
            // lb_quyen
            // 
            lb_quyen.AutoSize = true;
            lb_quyen.Location = new Point(464, 157);
            lb_quyen.Name = "lb_quyen";
            lb_quyen.Size = new Size(64, 25);
            lb_quyen.TabIndex = 2;
            lb_quyen.Text = "Quyền";
            // 
            // lb_banhang
            // 
            lb_banhang.AutoSize = true;
            lb_banhang.Location = new Point(6, 155);
            lb_banhang.Name = "lb_banhang";
            lb_banhang.Size = new Size(86, 25);
            lb_banhang.TabIndex = 2;
            lb_banhang.Text = "Bán hàng";
            // 
            // cb_ctkm
            // 
            cb_ctkm.FormattingEnabled = true;
            cb_ctkm.Location = new Point(605, 214);
            cb_ctkm.Name = "cb_ctkm";
            cb_ctkm.Size = new Size(242, 33);
            cb_ctkm.TabIndex = 0;
            // 
            // cb_quyen
            // 
            cb_quyen.FormattingEnabled = true;
            cb_quyen.Location = new Point(605, 157);
            cb_quyen.Name = "cb_quyen";
            cb_quyen.Size = new Size(242, 33);
            cb_quyen.TabIndex = 0;
            // 
            // cb_banhang
            // 
            cb_banhang.FormattingEnabled = true;
            cb_banhang.Location = new Point(192, 157);
            cb_banhang.Name = "cb_banhang";
            cb_banhang.Size = new Size(242, 33);
            cb_banhang.TabIndex = 0;
            // 
            // lb_nhacungcap
            // 
            lb_nhacungcap.AutoSize = true;
            lb_nhacungcap.Location = new Point(866, 100);
            lb_nhacungcap.Name = "lb_nhacungcap";
            lb_nhacungcap.Size = new Size(121, 25);
            lb_nhacungcap.TabIndex = 2;
            lb_nhacungcap.Text = "Nhà cung cấp";
            // 
            // lb_nhanvien
            // 
            lb_nhanvien.AutoSize = true;
            lb_nhanvien.Location = new Point(464, 100);
            lb_nhanvien.Name = "lb_nhanvien";
            lb_nhanvien.Size = new Size(91, 25);
            lb_nhanvien.TabIndex = 2;
            lb_nhanvien.Text = "Nhân viên";
            // 
            // loaisanpham
            // 
            loaisanpham.AutoSize = true;
            loaisanpham.Location = new Point(6, 100);
            loaisanpham.Name = "loaisanpham";
            loaisanpham.Size = new Size(127, 25);
            loaisanpham.TabIndex = 2;
            loaisanpham.Text = "Loại sản phẩm";
            // 
            // cb_nhacungcap
            // 
            cb_nhacungcap.FormattingEnabled = true;
            cb_nhacungcap.Location = new Point(1034, 100);
            cb_nhacungcap.Name = "cb_nhacungcap";
            cb_nhacungcap.Size = new Size(242, 33);
            cb_nhacungcap.TabIndex = 0;
            // 
            // cb_nhanvien
            // 
            cb_nhanvien.FormattingEnabled = true;
            cb_nhanvien.Location = new Point(605, 100);
            cb_nhanvien.Name = "cb_nhanvien";
            cb_nhanvien.Size = new Size(242, 33);
            cb_nhanvien.TabIndex = 0;
            // 
            // cb_loaisp
            // 
            cb_loaisp.FormattingEnabled = true;
            cb_loaisp.Location = new Point(192, 100);
            cb_loaisp.Name = "cb_loaisp";
            cb_loaisp.Size = new Size(242, 33);
            cb_loaisp.TabIndex = 0;
            // 
            // lb_thongke
            // 
            lb_thongke.AutoSize = true;
            lb_thongke.Location = new Point(866, 43);
            lb_thongke.Name = "lb_thongke";
            lb_thongke.Size = new Size(86, 25);
            lb_thongke.TabIndex = 2;
            lb_thongke.Text = "Thống kê";
            // 
            // cb_thongke
            // 
            cb_thongke.FormattingEnabled = true;
            cb_thongke.Location = new Point(1034, 43);
            cb_thongke.Name = "cb_thongke";
            cb_thongke.Size = new Size(242, 33);
            cb_thongke.TabIndex = 0;
            // 
            // lb_khachhang
            // 
            lb_khachhang.AutoSize = true;
            lb_khachhang.Location = new Point(464, 43);
            lb_khachhang.Name = "lb_khachhang";
            lb_khachhang.Size = new Size(104, 25);
            lb_khachhang.TabIndex = 2;
            lb_khachhang.Text = "Khách hàng";
            // 
            // cb_khachhang
            // 
            cb_khachhang.FormattingEnabled = true;
            cb_khachhang.Location = new Point(605, 43);
            cb_khachhang.Name = "cb_khachhang";
            cb_khachhang.Size = new Size(242, 33);
            cb_khachhang.TabIndex = 0;
            // 
            // lb_sanpham
            // 
            lb_sanpham.AutoSize = true;
            lb_sanpham.Location = new Point(6, 43);
            lb_sanpham.Name = "lb_sanpham";
            lb_sanpham.Size = new Size(92, 25);
            lb_sanpham.TabIndex = 2;
            lb_sanpham.Text = "Sản phẩm";
            // 
            // cb_sanpham
            // 
            cb_sanpham.FormattingEnabled = true;
            cb_sanpham.Location = new Point(192, 43);
            cb_sanpham.Name = "cb_sanpham";
            cb_sanpham.Size = new Size(242, 33);
            cb_sanpham.TabIndex = 0;
            // 
            // lb_title
            // 
            lb_title.AutoSize = true;
            lb_title.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lb_title.Location = new Point(499, 9);
            lb_title.Name = "lb_title";
            lb_title.Size = new Size(344, 48);
            lb_title.TabIndex = 6;
            lb_title.Text = "QUẢN LÝ CHỨC VỤ";
            // 
            // bt_edit
            // 
            bt_edit.Location = new Point(31, 128);
            bt_edit.Name = "bt_edit";
            bt_edit.Size = new Size(112, 40);
            bt_edit.TabIndex = 7;
            bt_edit.Text = "Sửa";
            bt_edit.UseVisualStyleBackColor = true;
            bt_edit.Click += bt_edit_Click;
            // 
            // bt_delete
            // 
            bt_delete.Location = new Point(31, 211);
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new Size(112, 40);
            bt_delete.TabIndex = 8;
            bt_delete.Text = "Xoá";
            bt_delete.UseVisualStyleBackColor = true;
            bt_delete.Click += bt_delete_Click;
            // 
            // bt_reset
            // 
            bt_reset.Location = new Point(31, 294);
            bt_reset.Name = "bt_reset";
            bt_reset.Size = new Size(112, 40);
            bt_reset.TabIndex = 9;
            bt_reset.Text = "Reset";
            bt_reset.UseVisualStyleBackColor = true;
            bt_reset.Click += bt_reset_Click;
            // 
            // gb_List
            // 
            gb_List.Controls.Add(ds_qlcv);
            gb_List.Location = new Point(12, 524);
            gb_List.Name = "gb_List";
            gb_List.Size = new Size(1514, 382);
            gb_List.TabIndex = 10;
            gb_List.TabStop = false;
            gb_List.Text = "Dach sách chức vụ";
            // 
            // ds_qlcv
            // 
            ds_qlcv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ds_qlcv.Location = new Point(6, 30);
            ds_qlcv.Name = "ds_qlcv";
            ds_qlcv.RowHeadersWidth = 62;
            ds_qlcv.RowTemplate.Height = 33;
            ds_qlcv.Size = new Size(1502, 346);
            ds_qlcv.TabIndex = 0;
            // 
            // gb_Function
            // 
            gb_Function.Controls.Add(bt_add);
            gb_Function.Controls.Add(bt_reset);
            gb_Function.Controls.Add(bt_edit);
            gb_Function.Controls.Add(bt_delete);
            gb_Function.Location = new Point(1338, 84);
            gb_Function.Name = "gb_Function";
            gb_Function.Size = new Size(188, 434);
            gb_Function.TabIndex = 11;
            gb_Function.TabStop = false;
            gb_Function.Text = "Chức năng";
            // 
            // gb_role
            // 
            gb_role.Controls.Add(rtb_explain);
            gb_role.Controls.Add(lb_explain);
            gb_role.Controls.Add(lb_name);
            gb_role.Controls.Add(tb_name);
            gb_role.Controls.Add(lb_id);
            gb_role.Controls.Add(tb_id);
            gb_role.Location = new Point(18, 84);
            gb_role.Name = "gb_role";
            gb_role.Size = new Size(1295, 168);
            gb_role.TabIndex = 12;
            gb_role.TabStop = false;
            gb_role.Text = "Chức vụ";
            // 
            // rtb_explain
            // 
            rtb_explain.Location = new Point(631, 45);
            rtb_explain.Name = "rtb_explain";
            rtb_explain.Size = new Size(639, 106);
            rtb_explain.TabIndex = 3;
            rtb_explain.Text = "";
            // 
            // lb_explain
            // 
            lb_explain.AutoSize = true;
            lb_explain.Location = new Point(458, 45);
            lb_explain.Name = "lb_explain";
            lb_explain.Size = new Size(125, 25);
            lb_explain.TabIndex = 2;
            lb_explain.Text = "Mô tả chức vụ";
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Location = new Point(6, 105);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(93, 25);
            lb_name.TabIndex = 1;
            lb_name.Text = "Tên vai trò";
            // 
            // tb_name
            // 
            tb_name.Location = new Point(143, 105);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(248, 31);
            tb_name.TabIndex = 0;
            // 
            // RoleForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1554, 918);
            Controls.Add(gb_role);
            Controls.Add(gb_Function);
            Controls.Add(gb_List);
            Controls.Add(lb_title);
            Controls.Add(gb_Info);
            Name = "RoleForm";
            Text = "RoleForm";
            Load += RoleForm_Load;
            gb_Info.ResumeLayout(false);
            gb_Info.PerformLayout();
            gb_List.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ds_qlcv).EndInit();
            gb_Function.ResumeLayout(false);
            gb_role.ResumeLayout(false);
            gb_role.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_id;
        private Label lb_id;
        private Button bt_add;
        private GroupBox gb_Info;
        private ComboBox cb_sanpham;
        private Label lb_title;
        private Button bt_edit;
        private Button bt_delete;
        private Button bt_reset;
        private Label lb_sanpham;
        private Label lb_banhang;
        private ComboBox cb_banhang;
        private Label loaisanpham;
        private ComboBox cb_loaisp;
        private Label lb_nhaphang;
        private ComboBox cb_nhaphang;
        private Label lb_khuyenmai;
        private Label lb_quyen;
        private ComboBox cb_ctkm;
        private ComboBox cb_quyen;
        private Label lb_nhacungcap;
        private Label lb_nhanvien;
        private ComboBox cb_nhacungcap;
        private ComboBox cb_nhanvien;
        private Label lb_thongke;
        private ComboBox cb_thongke;
        private Label lb_khachhang;
        private ComboBox cb_khachhang;
        private GroupBox gb_List;
        private DataGridView ds_qlcv;
        private GroupBox gb_Function;
        private GroupBox gb_role;
        private RichTextBox rtb_explain;
        private Label lb_explain;
        private Label lb_name;
        private TextBox tb_name;
    }
}