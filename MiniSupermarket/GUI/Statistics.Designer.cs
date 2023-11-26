namespace MiniSupermarket.GUI
{
    partial class Statistics
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.grb_ThongTin = new System.Windows.Forms.GroupBox();
            this.grb_ChiTiet = new System.Windows.Forms.GroupBox();
            this.lb_TongDoanhThu = new System.Windows.Forms.Label();
            this.lb_DoanhThu = new System.Windows.Forms.Label();
            this.lb_ThongKeTheo = new System.Windows.Forms.Label();
            this.dtp_DenNgay = new System.Windows.Forms.DateTimePicker();
            this.lb_DenNgay = new System.Windows.Forms.Label();
            this.cbx_TimKiem = new System.Windows.Forms.ComboBox();
            this.dtp_TuNgay = new System.Windows.Forms.DateTimePicker();
            this.lb_TuNgay = new System.Windows.Forms.Label();
            this.btn_ThongKe = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dshd_sp = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.grb_ThongTin.SuspendLayout();
            this.grb_ChiTiet.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dshd_sp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grb_ThongTin);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 227);
            this.panel1.TabIndex = 0;
            // 
            // grb_ThongTin
            // 
            this.grb_ThongTin.Controls.Add(this.grb_ChiTiet);
            this.grb_ThongTin.Controls.Add(this.lb_ThongKeTheo);
            this.grb_ThongTin.Controls.Add(this.dtp_DenNgay);
            this.grb_ThongTin.Controls.Add(this.lb_DenNgay);
            this.grb_ThongTin.Controls.Add(this.cbx_TimKiem);
            this.grb_ThongTin.Controls.Add(this.dtp_TuNgay);
            this.grb_ThongTin.Controls.Add(this.lb_TuNgay);
            this.grb_ThongTin.Controls.Add(this.btn_ThongKe);
            this.grb_ThongTin.Location = new System.Drawing.Point(0, 3);
            this.grb_ThongTin.Name = "grb_ThongTin";
            this.grb_ThongTin.Size = new System.Drawing.Size(1165, 221);
            this.grb_ThongTin.TabIndex = 0;
            this.grb_ThongTin.TabStop = false;
            this.grb_ThongTin.Text = "Thông tin";
            this.grb_ThongTin.Enter += new System.EventHandler(this.grb_ThongTin_Enter);
            // 
            // grb_ChiTiet
            // 
            this.grb_ChiTiet.Controls.Add(this.lb_TongDoanhThu);
            this.grb_ChiTiet.Controls.Add(this.lb_DoanhThu);
            this.grb_ChiTiet.Location = new System.Drawing.Point(527, 20);
            this.grb_ChiTiet.Name = "grb_ChiTiet";
            this.grb_ChiTiet.Size = new System.Drawing.Size(632, 195);
            this.grb_ChiTiet.TabIndex = 9;
            this.grb_ChiTiet.TabStop = false;
            this.grb_ChiTiet.Text = "Chi tiết";
            // 
            // lb_TongDoanhThu
            // 
            this.lb_TongDoanhThu.AutoSize = true;
            this.lb_TongDoanhThu.Location = new System.Drawing.Point(153, 142);
            this.lb_TongDoanhThu.Name = "lb_TongDoanhThu";
            this.lb_TongDoanhThu.Size = new System.Drawing.Size(117, 20);
            this.lb_TongDoanhThu.TabIndex = 6;
            this.lb_TongDoanhThu.Text = "Tổng doanh thu:";
            // 
            // lb_DoanhThu
            // 
            this.lb_DoanhThu.AutoSize = true;
            this.lb_DoanhThu.Location = new System.Drawing.Point(333, 142);
            this.lb_DoanhThu.Name = "lb_DoanhThu";
            this.lb_DoanhThu.Size = new System.Drawing.Size(17, 20);
            this.lb_DoanhThu.TabIndex = 7;
            this.lb_DoanhThu.Text = "0";
            this.lb_DoanhThu.Click += new System.EventHandler(this.lb_DoanhThu_Click);
            // 
            // lb_ThongKeTheo
            // 
            this.lb_ThongKeTheo.AutoSize = true;
            this.lb_ThongKeTheo.Location = new System.Drawing.Point(21, 35);
            this.lb_ThongKeTheo.Name = "lb_ThongKeTheo";
            this.lb_ThongKeTheo.Size = new System.Drawing.Size(104, 20);
            this.lb_ThongKeTheo.TabIndex = 8;
            this.lb_ThongKeTheo.Text = "Thống kê theo";
            // 
            // dtp_DenNgay
            // 
            this.dtp_DenNgay.Location = new System.Drawing.Point(190, 116);
            this.dtp_DenNgay.Name = "dtp_DenNgay";
            this.dtp_DenNgay.Size = new System.Drawing.Size(311, 27);
            this.dtp_DenNgay.TabIndex = 1;
            // 
            // lb_DenNgay
            // 
            this.lb_DenNgay.AutoSize = true;
            this.lb_DenNgay.Location = new System.Drawing.Point(21, 116);
            this.lb_DenNgay.Name = "lb_DenNgay";
            this.lb_DenNgay.Size = new System.Drawing.Size(72, 20);
            this.lb_DenNgay.TabIndex = 3;
            this.lb_DenNgay.Text = "Đến ngày";
            this.lb_DenNgay.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbx_TimKiem
            // 
            this.cbx_TimKiem.FormattingEnabled = true;
            this.cbx_TimKiem.Location = new System.Drawing.Point(190, 32);
            this.cbx_TimKiem.Name = "cbx_TimKiem";
            this.cbx_TimKiem.Size = new System.Drawing.Size(311, 28);
            this.cbx_TimKiem.TabIndex = 4;
            // 
            // dtp_TuNgay
            // 
            this.dtp_TuNgay.Location = new System.Drawing.Point(190, 77);
            this.dtp_TuNgay.Name = "dtp_TuNgay";
            this.dtp_TuNgay.Size = new System.Drawing.Size(311, 27);
            this.dtp_TuNgay.TabIndex = 0;
            // 
            // lb_TuNgay
            // 
            this.lb_TuNgay.AutoSize = true;
            this.lb_TuNgay.Location = new System.Drawing.Point(21, 77);
            this.lb_TuNgay.Name = "lb_TuNgay";
            this.lb_TuNgay.Size = new System.Drawing.Size(62, 20);
            this.lb_TuNgay.TabIndex = 2;
            this.lb_TuNgay.Text = "Từ ngày";
            this.lb_TuNgay.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.Location = new System.Drawing.Point(21, 162);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(480, 52);
            this.btn_ThongKe.TabIndex = 5;
            this.btn_ThongKe.Text = "Thống kê";
            this.btn_ThongKe.UseVisualStyleBackColor = true;
            this.btn_ThongKe.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dshd_sp);
            this.panel2.Location = new System.Drawing.Point(1, 232);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1181, 448);
            this.panel2.TabIndex = 1;
            // 
            // dshd_sp
            // 
            this.dshd_sp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dshd_sp.Location = new System.Drawing.Point(3, 3);
            this.dshd_sp.Name = "dshd_sp";
            this.dshd_sp.RowHeadersWidth = 51;
            this.dshd_sp.RowTemplate.Height = 29;
            this.dshd_sp.Size = new System.Drawing.Size(1175, 442);
            this.dshd_sp.TabIndex = 0;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 682);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.panel1.ResumeLayout(false);
            this.grb_ThongTin.ResumeLayout(false);
            this.grb_ThongTin.PerformLayout();
            this.grb_ChiTiet.ResumeLayout(false);
            this.grb_ChiTiet.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dshd_sp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lb_TuNgay;
        private DateTimePicker dtp_DenNgay;
        private DateTimePicker dtp_TuNgay;
        private Label lb_DenNgay;
        private Button btn_ThongKe;
        private ComboBox cbx_TimKiem;
        private Label lb_DoanhThu;
        private Label lb_TongDoanhThu;
        private GroupBox grb_ThongTin;
        private DataGridView dshd_sp;
        private GroupBox grb_ChiTiet;
        private Label lb_ThongKeTheo;
    }
}