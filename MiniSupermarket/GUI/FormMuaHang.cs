using MiniSupermarket.BUS;
using MiniSupermarket.ImageAndFont;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MiniSupermarket.GUI {
    public partial class FormMuaHang : Form {
        ProductBUS productBUS = new ProductBUS();
        DetalBillBus detalBillBus = new DetalBillBus();
        public FormMuaHang() {
            InitializeComponent();
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
        }

        public void LoadTheme() {
            // Thêm màu cho tất cả các nút ở panel top
            foreach (Control btns in this.pnlInformation.Controls) {
                if (btns.GetType() == typeof(Button)) {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                } else if (btns.GetType() == typeof(Label)) {
                    Label lb = (Label)btns;
                    lb.ForeColor = ThemeColor.SecondaryColor;
                    lb.Font = ProjectFont.getNormalFont();
                }
            }
        }

        private void DetailFormMuaHang_Load(object sender, EventArgs e) {
            dgvDetalBill.DataSource = detalBillBus.getAllDetalBill();
            dgvProduct.DataSource = productBUS.getAllProducts();
            dgvProduct.Columns["ProductID"].HeaderText = "Mã sản phẩm";
            dgvProduct.Columns["Name"].HeaderText = "Tên sản phẩm";
            dgvProduct.Columns["TypeID"].HeaderText = "Mã loại";
            dgvProduct.Columns["Quantity"].HeaderText = "Số lượng";
            dgvProduct.Columns["CurrentPrice"].HeaderText = "Đơn giá";
            dgvProduct.Columns["Description"].HeaderText = "Mô tả";
            dgvProduct.Columns["Unit"].HeaderText = "Kiểu";
            dgvProduct.Columns["Image"].HeaderText = "Hình ảnh";
            dgvProduct.Columns["PromotionID"].HeaderText = "Mã khuyến mãi";
            LoadTheme();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void panel2_Paint(object sender, PaintEventArgs e) {

        }

        private void panel5_Paint(object sender, PaintEventArgs e) {

        }
    }
}
