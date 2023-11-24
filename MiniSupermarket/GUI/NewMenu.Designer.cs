namespace MiniSupermarket.GUI
{
    partial class NewMenu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMenu));
            controlPanel = new Panel();
            control = new CustomControl.CustomPanel();
            btnResize = new PictureBox();
            btnExit = new PictureBox();
            pictureBox2 = new PictureBox();
            btnDangXuat = new Button();
            btnMenu = new PictureBox();
            menuPanel = new FlowLayoutPanel();
            btnThongKe = new Button();
            btnBanHang = new Button();
            btnCTKM = new Button();
            panelNhanVien = new Panel();
            btnQuyen = new Button();
            btnThongTinNhanVien = new Button();
            btnNhanVien = new Button();
            panelSanPham = new Panel();
            btnThongTinSanPham = new Button();
            btnLoaiSanPham = new Button();
            btnSanPham = new Button();
            panelNCC = new Panel();
            btnNhaCungCap = new Button();
            btnNhapHang = new Button();
            btnThongTinNCC = new Button();
            menuTimer = new System.Windows.Forms.Timer(components);
            sanphamTimer = new System.Windows.Forms.Timer(components);
            nccTimer = new System.Windows.Forms.Timer(components);
            nhanvienTimer = new System.Windows.Forms.Timer(components);
            controlPanel.SuspendLayout();
            control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnResize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            menuPanel.SuspendLayout();
            panelNhanVien.SuspendLayout();
            panelSanPham.SuspendLayout();
            panelNCC.SuspendLayout();
            SuspendLayout();
            // 
            // controlPanel
            // 
            controlPanel.BackColor = Color.FromArgb(71, 92, 108);
            controlPanel.Controls.Add(control);
            controlPanel.Controls.Add(btnDangXuat);
            controlPanel.Controls.Add(btnMenu);
            controlPanel.Dock = DockStyle.Top;
            controlPanel.ForeColor = Color.CadetBlue;
            controlPanel.Location = new Point(0, 0);
            controlPanel.Name = "controlPanel";
            controlPanel.Size = new Size(1280, 44);
            controlPanel.TabIndex = 0;
            // 
            // control
            // 
            control.BackColor = Color.FromArgb(71, 92, 108);
            control.BackgroundColor = Color.FromArgb(71, 92, 108);
            control.BorderColor = Color.PaleVioletRed;
            control.BorderRadius = 8;
            control.BorderSize = 0;
            control.Controls.Add(btnResize);
            control.Controls.Add(btnExit);
            control.Controls.Add(pictureBox2);
            control.Dock = DockStyle.Right;
            control.ForeColor = Color.White;
            control.Location = new Point(1154, 0);
            control.Name = "control";
            control.Size = new Size(126, 44);
            control.TabIndex = 3;
            control.TextColor = Color.White;
            // 
            // btnResize
            // 
            btnResize.Dock = DockStyle.Fill;
            btnResize.Image = Properties.Resources.maximize;
            btnResize.Location = new Point(42, 0);
            btnResize.Margin = new Padding(0);
            btnResize.Name = "btnResize";
            btnResize.Size = new Size(42, 44);
            btnResize.SizeMode = PictureBoxSizeMode.CenterImage;
            btnResize.TabIndex = 3;
            btnResize.TabStop = false;
            btnResize.Click += pictureBox1_Click;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Right;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(84, 0);
            btnExit.Margin = new Padding(0);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(5);
            btnExit.Size = new Size(42, 44);
            btnExit.SizeMode = PictureBoxSizeMode.AutoSize;
            btnExit.TabIndex = 2;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = Properties.Resources.minus_button;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDangXuat.FlatAppearance.BorderSize = 5;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangXuat.Image = (Image)resources.GetObject("btnDangXuat.Image");
            btnDangXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.Location = new Point(1030, 4);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(118, 38);
            btnDangXuat.TabIndex = 3;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.TextAlign = ContentAlignment.MiddleRight;
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnMenu
            // 
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.Location = new Point(0, 2);
            btnMenu.Margin = new Padding(0);
            btnMenu.Name = "btnMenu";
            btnMenu.Padding = new Padding(10);
            btnMenu.Size = new Size(60, 42);
            btnMenu.SizeMode = PictureBoxSizeMode.CenterImage;
            btnMenu.TabIndex = 2;
            btnMenu.TabStop = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // menuPanel
            // 
            menuPanel.BackColor = Color.FromArgb(71, 92, 108);
            menuPanel.Controls.Add(btnThongKe);
            menuPanel.Controls.Add(btnBanHang);
            menuPanel.Controls.Add(btnCTKM);
            menuPanel.Controls.Add(panelNhanVien);
            menuPanel.Controls.Add(panelSanPham);
            menuPanel.Controls.Add(panelNCC);
            menuPanel.Dock = DockStyle.Left;
            menuPanel.FlowDirection = FlowDirection.TopDown;
            menuPanel.Location = new Point(0, 44);
            menuPanel.Margin = new Padding(0);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(300, 676);
            menuPanel.TabIndex = 1;
            menuPanel.WrapContents = false;
            // 
            // btnThongKe
            // 
            btnThongKe.FlatAppearance.BorderSize = 0;
            btnThongKe.FlatStyle = FlatStyle.Flat;
            menuPanel.SetFlowBreak(btnThongKe, true);
            btnThongKe.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnThongKe.Image = (Image)resources.GetObject("btnThongKe.Image");
            btnThongKe.ImageAlign = ContentAlignment.MiddleLeft;
            btnThongKe.Location = new Point(0, 0);
            btnThongKe.Margin = new Padding(0);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Padding = new Padding(10);
            btnThongKe.Size = new Size(300, 50);
            btnThongKe.TabIndex = 0;
            btnThongKe.Text = "Dashboard";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += button1_Click;
            // 
            // btnBanHang
            // 
            btnBanHang.FlatAppearance.BorderSize = 0;
            btnBanHang.FlatStyle = FlatStyle.Flat;
            btnBanHang.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBanHang.Image = (Image)resources.GetObject("btnBanHang.Image");
            btnBanHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnBanHang.Location = new Point(0, 50);
            btnBanHang.Margin = new Padding(0);
            btnBanHang.Name = "btnBanHang";
            btnBanHang.Padding = new Padding(10);
            btnBanHang.Size = new Size(300, 50);
            btnBanHang.TabIndex = 10;
            btnBanHang.Text = "Bán hàng";
            btnBanHang.UseVisualStyleBackColor = true;
            // 
            // btnCTKM
            // 
            btnCTKM.FlatAppearance.BorderSize = 0;
            btnCTKM.FlatStyle = FlatStyle.Flat;
            btnCTKM.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCTKM.Image = (Image)resources.GetObject("btnCTKM.Image");
            btnCTKM.ImageAlign = ContentAlignment.MiddleLeft;
            btnCTKM.Location = new Point(0, 100);
            btnCTKM.Margin = new Padding(0);
            btnCTKM.Name = "btnCTKM";
            btnCTKM.Padding = new Padding(10);
            btnCTKM.Size = new Size(300, 50);
            btnCTKM.TabIndex = 9;
            btnCTKM.Text = "Khuyến mãi";
            btnCTKM.UseVisualStyleBackColor = true;
            // 
            // panelNhanVien
            // 
            panelNhanVien.Controls.Add(btnQuyen);
            panelNhanVien.Controls.Add(btnThongTinNhanVien);
            panelNhanVien.Controls.Add(btnNhanVien);
            panelNhanVien.Location = new Point(0, 150);
            panelNhanVien.Margin = new Padding(0);
            panelNhanVien.Name = "panelNhanVien";
            panelNhanVien.Size = new Size(300, 50);
            panelNhanVien.TabIndex = 8;
            // 
            // btnQuyen
            // 
            btnQuyen.BackColor = Color.FromArgb(138, 133, 131);
            btnQuyen.FlatAppearance.BorderSize = 0;
            btnQuyen.FlatStyle = FlatStyle.Flat;
            btnQuyen.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnQuyen.Image = (Image)resources.GetObject("btnQuyen.Image");
            btnQuyen.ImageAlign = ContentAlignment.MiddleLeft;
            btnQuyen.Location = new Point(0, 100);
            btnQuyen.Margin = new Padding(0);
            btnQuyen.Name = "btnQuyen";
            btnQuyen.Size = new Size(300, 50);
            btnQuyen.TabIndex = 9;
            btnQuyen.Text = "    Quyền hạn";
            btnQuyen.UseVisualStyleBackColor = false;
            // 
            // btnThongTinNhanVien
            // 
            btnThongTinNhanVien.BackColor = Color.FromArgb(138, 133, 131);
            btnThongTinNhanVien.FlatAppearance.BorderSize = 0;
            btnThongTinNhanVien.FlatStyle = FlatStyle.Flat;
            btnThongTinNhanVien.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnThongTinNhanVien.Image = (Image)resources.GetObject("btnThongTinNhanVien.Image");
            btnThongTinNhanVien.ImageAlign = ContentAlignment.MiddleLeft;
            btnThongTinNhanVien.Location = new Point(0, 50);
            btnThongTinNhanVien.Margin = new Padding(0);
            btnThongTinNhanVien.Name = "btnThongTinNhanVien";
            btnThongTinNhanVien.Size = new Size(300, 50);
            btnThongTinNhanVien.TabIndex = 8;
            btnThongTinNhanVien.Text = "    Thông tin ";
            btnThongTinNhanVien.UseVisualStyleBackColor = false;
            // 
            // btnNhanVien
            // 
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNhanVien.Image = (Image)resources.GetObject("btnNhanVien.Image");
            btnNhanVien.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.Location = new Point(0, 0);
            btnNhanVien.Margin = new Padding(0);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Padding = new Padding(10);
            btnNhanVien.Size = new Size(300, 50);
            btnNhanVien.TabIndex = 7;
            btnNhanVien.Text = "Nhân viên";
            btnNhanVien.UseVisualStyleBackColor = true;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // panelSanPham
            // 
            panelSanPham.Controls.Add(btnThongTinSanPham);
            panelSanPham.Controls.Add(btnLoaiSanPham);
            panelSanPham.Controls.Add(btnSanPham);
            panelSanPham.Location = new Point(0, 200);
            panelSanPham.Margin = new Padding(0);
            panelSanPham.Name = "panelSanPham";
            panelSanPham.Size = new Size(300, 50);
            panelSanPham.TabIndex = 4;
            // 
            // btnThongTinSanPham
            // 
            btnThongTinSanPham.BackColor = Color.FromArgb(138, 133, 131);
            btnThongTinSanPham.FlatAppearance.BorderSize = 0;
            btnThongTinSanPham.FlatStyle = FlatStyle.Flat;
            btnThongTinSanPham.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnThongTinSanPham.Image = (Image)resources.GetObject("btnThongTinSanPham.Image");
            btnThongTinSanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btnThongTinSanPham.Location = new Point(0, 50);
            btnThongTinSanPham.Margin = new Padding(0);
            btnThongTinSanPham.Name = "btnThongTinSanPham";
            btnThongTinSanPham.Size = new Size(300, 50);
            btnThongTinSanPham.TabIndex = 2;
            btnThongTinSanPham.Text = "Thông tin";
            btnThongTinSanPham.UseVisualStyleBackColor = false;
            // 
            // btnLoaiSanPham
            // 
            btnLoaiSanPham.BackColor = Color.FromArgb(138, 133, 131);
            btnLoaiSanPham.FlatAppearance.BorderSize = 0;
            btnLoaiSanPham.FlatStyle = FlatStyle.Flat;
            btnLoaiSanPham.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLoaiSanPham.Image = (Image)resources.GetObject("btnLoaiSanPham.Image");
            btnLoaiSanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btnLoaiSanPham.Location = new Point(0, 100);
            btnLoaiSanPham.Margin = new Padding(0);
            btnLoaiSanPham.Name = "btnLoaiSanPham";
            btnLoaiSanPham.Size = new Size(300, 50);
            btnLoaiSanPham.TabIndex = 3;
            btnLoaiSanPham.Text = "  Loại hàng";
            btnLoaiSanPham.UseVisualStyleBackColor = false;
            btnLoaiSanPham.Click += btnLoaiSanPham_Click;
            // 
            // btnSanPham
            // 
            btnSanPham.FlatAppearance.BorderSize = 0;
            btnSanPham.FlatStyle = FlatStyle.Flat;
            btnSanPham.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSanPham.Image = (Image)resources.GetObject("btnSanPham.Image");
            btnSanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btnSanPham.Location = new Point(0, 0);
            btnSanPham.Margin = new Padding(0);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Padding = new Padding(10);
            btnSanPham.Size = new Size(300, 50);
            btnSanPham.TabIndex = 1;
            btnSanPham.Text = "Sản phẩm";
            btnSanPham.UseVisualStyleBackColor = true;
            btnSanPham.Click += button2_Click;
            // 
            // panelNCC
            // 
            panelNCC.Controls.Add(btnNhaCungCap);
            panelNCC.Controls.Add(btnNhapHang);
            panelNCC.Controls.Add(btnThongTinNCC);
            panelNCC.Location = new Point(0, 250);
            panelNCC.Margin = new Padding(0);
            panelNCC.Name = "panelNCC";
            panelNCC.Size = new Size(300, 50);
            panelNCC.TabIndex = 6;
            // 
            // btnNhaCungCap
            // 
            btnNhaCungCap.FlatAppearance.BorderSize = 0;
            btnNhaCungCap.FlatStyle = FlatStyle.Flat;
            btnNhaCungCap.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNhaCungCap.Image = (Image)resources.GetObject("btnNhaCungCap.Image");
            btnNhaCungCap.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhaCungCap.Location = new Point(0, 0);
            btnNhaCungCap.Margin = new Padding(0);
            btnNhaCungCap.Name = "btnNhaCungCap";
            btnNhaCungCap.Padding = new Padding(10);
            btnNhaCungCap.Size = new Size(300, 50);
            btnNhaCungCap.TabIndex = 4;
            btnNhaCungCap.Text = "Nhà cung cấp";
            btnNhaCungCap.UseVisualStyleBackColor = true;
            btnNhaCungCap.Click += button1_Click_1;
            // 
            // btnNhapHang
            // 
            btnNhapHang.BackColor = Color.FromArgb(138, 133, 131);
            btnNhapHang.FlatAppearance.BorderSize = 0;
            btnNhapHang.FlatStyle = FlatStyle.Flat;
            btnNhapHang.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNhapHang.Image = (Image)resources.GetObject("btnNhapHang.Image");
            btnNhapHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhapHang.Location = new Point(0, 100);
            btnNhapHang.Margin = new Padding(0);
            btnNhapHang.Name = "btnNhapHang";
            btnNhapHang.Size = new Size(300, 50);
            btnNhapHang.TabIndex = 6;
            btnNhapHang.Text = "    Nhập hàng";
            btnNhapHang.UseVisualStyleBackColor = false;
            // 
            // btnThongTinNCC
            // 
            btnThongTinNCC.BackColor = Color.FromArgb(138, 133, 131);
            btnThongTinNCC.FlatAppearance.BorderSize = 0;
            btnThongTinNCC.FlatStyle = FlatStyle.Flat;
            btnThongTinNCC.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnThongTinNCC.Image = (Image)resources.GetObject("btnThongTinNCC.Image");
            btnThongTinNCC.ImageAlign = ContentAlignment.MiddleLeft;
            btnThongTinNCC.Location = new Point(0, 50);
            btnThongTinNCC.Margin = new Padding(0);
            btnThongTinNCC.Name = "btnThongTinNCC";
            btnThongTinNCC.Size = new Size(300, 50);
            btnThongTinNCC.TabIndex = 5;
            btnThongTinNCC.Text = "    Thông tin";
            btnThongTinNCC.UseVisualStyleBackColor = false;
            btnThongTinNCC.Click += btnThongTinNCC_Click;
            // 
            // menuTimer
            // 
            menuTimer.Interval = 5;
            menuTimer.Tick += menuTimer_Tick;
            // 
            // sanphamTimer
            // 
            sanphamTimer.Interval = 10;
            sanphamTimer.Tick += sanphamTimer_Tick;
            // 
            // nccTimer
            // 
            nccTimer.Interval = 10;
            nccTimer.Tick += nccTimer_Tick;
            // 
            // nhanvienTimer
            // 
            nhanvienTimer.Interval = 10;
            nhanvienTimer.Tick += nhanvienTimer_Tick;
            // 
            // NewMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(menuPanel);
            Controls.Add(controlPanel);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "NewMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewMenu";
            Load += NewMenu_Load;
            controlPanel.ResumeLayout(false);
            control.ResumeLayout(false);
            control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnResize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMenu).EndInit();
            menuPanel.ResumeLayout(false);
            panelNhanVien.ResumeLayout(false);
            panelSanPham.ResumeLayout(false);
            panelNCC.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel controlPanel;
        private FlowLayoutPanel menuPanel;
        private PictureBox btnExit;
        private PictureBox btnMenu;
        private Button btnThongKe;
        private Button btnSanPham;
        private Button btnThongTinSanPham;
        private Button btnLoaiSanPham;
        private Panel panelSanPham;
        private Button btnThongTinNCC;
        private Panel panelNCC;
        private Button btnNhapHang;
        private Button btnNhaCungCap;
        private System.Windows.Forms.Timer menuTimer;
        private System.Windows.Forms.Timer sanphamTimer;
        private System.Windows.Forms.Timer nccTimer;
        private Button btnNhanVien;
        private Panel panelNhanVien;
        private Button btnThongTinNhanVien;
        private Button btnQuyen;
        private System.Windows.Forms.Timer nhanvienTimer;
        private Button btnCTKM;
        private Button btnDangXuat;
        private Button btnBanHang;
        private PictureBox btnResize;
        private PictureBox pictureBox2;
        private CustomControl.CustomPanel control;
    }
}