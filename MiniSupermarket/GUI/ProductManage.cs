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

    public partial class ProductManage : Form
    {
        AutoCompleteStringCollection allowedTypes = new AutoCompleteStringCollection();

        public ProductManage()
        {
            InitializeComponent();
            this.AutoSize = true;
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // Đặt font cho các textbox và label
            txt_TimKiem.Font = ProjectFont.getNormalFont();
            txt_MaSp.Font = ProjectFont.getNormalFont();    
            txt_MaLoaiSp.Font = ProjectFont.getNormalFont();    
            txt_TenSp.Font = ProjectFont.getNormalFont();
            txt_SoLuong.Font = ProjectFont.getNormalFont();
            txt_DonGia.Font = ProjectFont.getNormalFont();
            txt_MoTa.Font = ProjectFont.getNormalFont();
            txt_Kieu.Font = ProjectFont.getNormalFont();
            txt_HinhAnh.Font = ProjectFont.getNormalFont();
            cbx_TimKiem.Font=ProjectFont.getNormalFont();
            lb_MaSp.Font=ProjectFont.getNormalFont();
            lb_MaLoaiSp.Font = ProjectFont.getNormalFont();
            lb_TenSp.Font = ProjectFont.getNormalFont();
            lb_Soluong.Font = ProjectFont.getNormalFont();
            lb_DonGia.Font = ProjectFont.getNormalFont();
            lb_MoTa.Font = ProjectFont.getNormalFont();
            lb_Kieu.Font = ProjectFont.getNormalFont();
            lb_HinhAnh.Font = ProjectFont.getNormalFont();
            //
            cbx_TimKiem.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_TimKiem.Items.Add("Mã sản phẩm");
            cbx_TimKiem.Items.Add("Tên sản phẩm");
            cbx_TimKiem.Items.Add("Mã loại sản phẩm");
            cbx_TimKiem.SelectedIndex = 0;
            // Cho hiển thị hết chiều dài của bảng
            dssp_DSSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Đổi màu mặc định của data grid view
            dssp_DSSP.BackgroundColor = Color.White;
            // Chỉ cho đọc data grid view
            dssp_DSSP.ReadOnly = true;
            // Cho text search sẽ hiển thị suggestion box
            txt_TimKiem.AutoCompleteCustomSource = allowedTypes;
            txt_TimKiem.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_TimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        public void LoadTheme()
        {
            // Thêm màu và chỉnh font cho các tiêu đề group box
            grb_TimKiem.ForeColor = ThemeColor.SecondaryColor;
            grb_TimKiem.Font = ProjectFont.getTitleFont();
            grb_TextField.ForeColor = ThemeColor.SecondaryColor;
            grb_TextField.Font = ProjectFont.getTitleFont();

            // Thêm màu và chỉnh font cho các nút
            foreach (Control btns in this.grb_TextField.Controls)
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
            // Thêm màu và chỉnh font cho các label
            lb_MaSp.Font = ProjectFont.getNormalFont();

            lb_MaLoaiSp.Font = ProjectFont.getNormalFont();

            cbx_TimKiem.Font = ProjectFont.getNormalFont();

            lb_DonGia.Font = ProjectFont.getNormalFont();
            lb_Kieu.Font = ProjectFont.getNormalFont();
            lb_MoTa.Font = ProjectFont.getNormalFont();
            lb_Soluong.Font = ProjectFont.getNormalFont();
            lb_TenSp.Font = ProjectFont.getNormalFont();    
            lb_HinhAnh.Font = ProjectFont.getNormalFont();
            
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dssp_DSSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductManage_Load(object sender, EventArgs e)
        {

        }

        private void dssp_DSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // make sure user select at least 1 row 
            {
                DataGridViewRow row = dssp_DSSP.Rows[e.RowIndex];
                txt_MaSp.Text = row.Cells["Mã sản phẩm"].Value.ToString();
                txt_TenSp.Text = row.Cells["Tên sản phẩm"].Value.ToString();
                txt_MaLoaiSp.Text = row.Cells["Mã loại"].Value.ToString();
                txt_SoLuong.Text = row.Cells["Số lượng"].Value.ToString();
                txt_DonGia.Text = row.Cells["Đơn giá"].Value.ToString();
                txt_MoTa.Text = row.Cells["Mô tả"].Value.ToString();
                txt_Kieu.Text = row.Cells["Kiểu"].Value.ToString();
                txt_HinhAnh.Text = row.Cells["Hình ảnh"].Value.ToString();
            }
        }
    }
}
