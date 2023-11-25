using MiniSupermarket.BUS;
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
        // khai bao controller
        private ProductBUS ptBus = new ProductBUS();
        AutoCompleteStringCollection allowedTypes = new AutoCompleteStringCollection();

        public ProductManage()
        {
            InitializeComponent();
            this.AutoSize = true;
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // Đặt font cho các textbox và label
            txt_TimKiem.Font = ProjectFont.getNormalFont();
            txt_MaSp.Font = ProjectFont.getNormalFont();
            cbx_MaLoai.Font = ProjectFont.getNormalFont();
            txt_TenSp.Font = ProjectFont.getNormalFont();
            txt_SoLuong.Font = ProjectFont.getNormalFont();
            txt_DonGia.Font = ProjectFont.getNormalFont();
            txt_MoTa.Font = ProjectFont.getNormalFont();
            txt_Kieu.Font = ProjectFont.getNormalFont();
            txt_SoLuong.ReadOnly = true;



            cbx_TimKiem.Font = ProjectFont.getNormalFont();
            lb_MaSp.Font = ProjectFont.getNormalFont();
            lb_MaLoaiSp.Font = ProjectFont.getNormalFont();
            lb_TenSp.Font = ProjectFont.getNormalFont();
            lb_Soluong.Font = ProjectFont.getNormalFont();
            lb_DonGia.Font = ProjectFont.getNormalFont();
            lb_MoTa.Font = ProjectFont.getNormalFont();
            lb_Kieu.Font = ProjectFont.getNormalFont();



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
            cbx_MaLoai.Font = ProjectFont.getNormalFont();



            lb_DonGia.Font = ProjectFont.getNormalFont();
            lb_Kieu.Font = ProjectFont.getNormalFont();
            lb_MoTa.Font = ProjectFont.getNormalFont();
            lb_Soluong.Font = ProjectFont.getNormalFont();
            lb_TenSp.Font = ProjectFont.getNormalFont();




        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dssp_DSSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductManage_Load(object sender, EventArgs e)
        {
            // Tải dữ liệu lên data grid view
            dssp_DSSP.DataSource = ptBus.getAllProducts();
            // Đổi tên cột
            dssp_DSSP.Columns["ProductID"].HeaderText = "Mã sản phẩm";
            dssp_DSSP.Columns["Name"].HeaderText = "Tên sản phẩm";
            dssp_DSSP.Columns["TypeID"].HeaderText = "Mã loại";
            dssp_DSSP.Columns["Quantity"].HeaderText = "Số lượng";
            dssp_DSSP.Columns["CurrentPrice"].HeaderText = "Đơn giá";
            dssp_DSSP.Columns["Description"].HeaderText = "Mô tả";
            dssp_DSSP.Columns["Unit"].HeaderText = "Kiểu";

            dssp_DSSP.Columns["PromotionID"].HeaderText = "Mã khuyến mãi";


            // Load danh sách loại sản phẩm vào ComboBox
            ProductTypeBUS typeBus = new ProductTypeBUS(); // Tạo đối tượng BUS cho loại sản phẩm
            string[] danhSachLoaiSPNames = typeBus.getProductTypesWithIdAndName(); // Lấy danh sách tên loại sản phẩm
            foreach (var loaiSP in danhSachLoaiSPNames)
            {
                
                cbx_MaLoai.Items.Add(loaiSP); // Thêm từng loại sản phẩm vào ComboBox
            }
            cbx_MaLoai.DropDownStyle = ComboBoxStyle.DropDownList;
            LoadTheme();
        }

        private void dssp_DSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // make sure user select at least 1 row 
            {
                DataGridViewRow row = dssp_DSSP.Rows[e.RowIndex];
                // Lấy TypeID và name từ DataGridView
                string typeID = row.Cells["TypeID"].Value.ToString();
                ProductTypeBUS typeBus = new ProductTypeBUS();

                // Gọi phương thức trong ProductTypeBUS để lấy TypeName từ TypeID
                string typeName = typeBus.GetNameFromId(typeID); // Hàm này sẽ trả về name dựa trên TypeID

                // Hiển thị TypeID và name trong ComboBox
                string displayText = $"[{typeID}] {typeName}";
                cbx_MaLoai.Text = displayText;


                txt_MaSp.Text = row.Cells["ProductID"].Value.ToString();
                txt_TenSp.Text = row.Cells["Name"].Value.ToString();
                cbx_MaLoai.Text = row.Cells["TypeID"].Value.ToString();
                txt_SoLuong.Text = row.Cells["Quantity"].Value.ToString();
                txt_DonGia.Text = row.Cells["CurrentPrice"].Value.ToString();
                txt_MoTa.Text = row.Cells["Description"].Value.ToString();
                txt_Kieu.Text = row.Cells["Unit"].Value.ToString();



            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            // Viết hoa id và chữ cái đầu 
            string id = txt_MaSp.Text.Trim().ToUpper();
            string name = ProjectFont.upperFirstLetter(txt_TenSp.Text);
            string maloai = ProjectFont.upperFirstLetter(cbx_MaLoai.Text);
            string soluong = "0";
            string dongia = ProjectFont.upperFirstLetter(txt_DonGia.Text);
            string mota = ProjectFont.upperFirstLetter(txt_MoTa.Text);
            string kieu = ProjectFont.upperFirstLetter(txt_Kieu.Text);

          
            if (id.Length != 0) // Nếu người dùng nhập mã loại
            {
                // Nếu mã loại đã tồn tại trong hệ thống thì hiện lỗi
                if (ptBus.checkIdExist(id))
                {
                    MessageBox.Show(
                        "Mã sản phẩm đã tồn tại trong hệ thống",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning); // cho cảnh báo
                    txt_MaSp.Focus();
                    return;
                }
            }
            // Nếu mà mã loại rỗng thì sẽ tự tạo mã id
            if (id.Length == 0)
            {
                if (ptBus.addProduct(name, maloai, soluong, dongia, mota, kieu))
                {
                    MessageBox.Show("Thêm thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information); // Thêm thành công

                }
                else
                {
                    MessageBox.Show("Thêm thất bại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error); // Thêm thất bại
                    return;
                }
            }
            else // Nếu mà nhập đầy đủ thông tin thì thêm đầy đủ
            {
                if (ptBus.addProduct(name, maloai, soluong, dongia, mota, kieu, id))
                {
                    MessageBox.Show("Thêm thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information); // Thêm thành công

                }
                else
                {
                    MessageBox.Show("Thêm thất bại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error); // Thêm thất bại
                    txt_MaSp.Focus();
                    return;
                }
            }
            dssp_DSSP.DataSource = ptBus.getAllProducts();
        }

        private void txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập các ký tự số và ký tự điều khiển (như Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;  // Chặn ký tự không mong muốn
            }
        }

        private void txt_DonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập các ký tự số và ký tự điều khiển (như Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;  // Chặn ký tự không mong muốn
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            
            // Lấy id của hàng đang chọn
            string id = dssp_DSSP.CurrentRow.Cells[0].Value.ToString();
            if (ptBus.deleteProduct(id))
            {
                MessageBox.Show("Xóa thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information); // Xóa thành công
          
            }
            else
            {
                MessageBox.Show("Xóa thất bại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error); // Xóa thất bại
                return;
            }

            // Tải lại danh sách
            dssp_DSSP.DataSource = ptBus.getAllProducts();
        }
    }
}
