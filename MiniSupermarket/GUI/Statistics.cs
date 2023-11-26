using MiniSupermarket.ImageAndFont;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSupermarket.GUI
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
            this.AutoSize = true;
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // Đặt font cho các textbox và label
            cbx_TimKiem.Font = ProjectFont.getNormalFont();
            lb_DenNgay.Font = ProjectFont.getNormalFont();
            lb_TuNgay.Font = ProjectFont.getNormalFont();
            dtp_DenNgay.Font = ProjectFont.getNormalFont();
            dtp_TuNgay.Font = ProjectFont.getNormalFont();
            lb_TongDoanhThu.Font = ProjectFont.getNormalFont();
            lb_TongDoanhThu.Font = ProjectFont.getNormalFont();
            lb_DoanhThu.Font = ProjectFont.getNormalFont();
            lb_ThongKeTheo.Font = ProjectFont.getNormalFont();

            cbx_TimKiem.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_TimKiem.Items.Add("Hóa đơn");
            cbx_TimKiem.Items.Add("Sản phẩm");
            cbx_TimKiem.Items.Add("Nhân viên");
            cbx_TimKiem.SelectedIndex = 0;
            // Cho hiển thị hết chiều dài của bảng
            dshd_sp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Đổi màu mặc định của data grid view
            dshd_sp.BackgroundColor = Color.White;
            // Chỉ cho đọc data grid view
            dshd_sp.ReadOnly = true;
            
        }
        public void LoadTheme()
        {
            // Thêm màu và chỉnh font cho các tiêu đề group box
            grb_ThongTin.ForeColor = ThemeColor.SecondaryColor;
            grb_ThongTin.Font = ProjectFont.getTitleFont();
            grb_ChiTiet.ForeColor = ThemeColor.SecondaryColor;
            grb_ChiTiet.Font = ProjectFont.getTitleFont();

            // Thêm màu và chỉnh font cho các nút
            foreach (Control btns in this.grb_ThongTin.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                    btn.Font = ProjectFont.getNormalFont();
                }
            }
            //Thêm màu và chỉnh font cho các label
            cbx_TimKiem.Font = ProjectFont.getNormalFont();
            lb_DenNgay.Font = ProjectFont.getNormalFont();
            lb_TuNgay.Font = ProjectFont.getNormalFont();
            dtp_DenNgay.Font = ProjectFont.getNormalFont();
            dtp_TuNgay.Font = ProjectFont.getNormalFont();
            lb_TongDoanhThu.Font = ProjectFont.getNormalFont();
            lb_TongDoanhThu.Font = ProjectFont.getNormalFont();
            lb_DoanhThu.Font = ProjectFont.getNormalFont();
            lb_ThongKeTheo.Font = ProjectFont.getNormalFont();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            


            LoadTheme();
        }

        private void lb_DoanhThu_Click(object sender, EventArgs e)
        {

        }

        private void grb_ThongTin_Enter(object sender, EventArgs e)
        {

        }
    }
}
