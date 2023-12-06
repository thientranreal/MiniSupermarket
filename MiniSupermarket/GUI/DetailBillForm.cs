using MiniSupermarket.BUS;
using MiniSupermarket.ImageAndFont;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MiniSupermarket.GUI {
    public partial class DetailBillForm : Form {
        string idBill;
        ProductBUS productBUS = new ProductBUS();
        DetalBillBus detalBillBus = new DetalBillBus();

        public DetailBillForm(string idBill, bool isDeleted) {
            this.idBill = idBill;

            InitializeComponent();
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            if (isDeleted) {
                this.btnThanhToan.Enabled = false;
            }
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
            load_dtgv();
            //LoadTheme();
        }

        private void load_dtgv() {

            // Lấy dữ liệu chi tiết hóa đơn từ Bus
            dgvDetalBill.DataSource = detalBillBus.getDetalBill(this.idBill);

            // Điều chỉnh tiêu đề cột
            dgvDetalBill.Columns["Name"].HeaderText = "Tên Sản Phẩm";
            dgvDetalBill.Columns["TotalQuantity"].HeaderText = "Số lượng";
            dgvDetalBill.Columns["TotalSalePrice"].HeaderText = "Tổng Đơn giá";
            dgvDetalBill.Columns["PromotionID"].HeaderText = "Mã giảm giá";

            // Ẩn các cột không cần thiết
            dgvDetalBill.Columns["BillID"].Visible = false;
            dgvDetalBill.Columns["ProductID"].Visible = false;


            dgvProduct.DataSource = productBUS.getAllProduct();
            dgvProduct.Columns["ProductID"].HeaderText = "Mã sản phẩm";
            dgvProduct.Columns["Name"].HeaderText = "Tên sản phẩm";
            dgvProduct.Columns["TypeID"].HeaderText = "Mã loại";
            dgvProduct.Columns["Quantity"].HeaderText = "Số lượng";
            dgvProduct.Columns["CurrentPrice"].HeaderText = "Đơn giá";
            dgvProduct.Columns["Description"].HeaderText = "Mô tả";
            dgvProduct.Columns["Unit"].HeaderText = "Kiểu";
            dgvProduct.Columns["PromotionID"].HeaderText = "Mã khuyến mãi";
        }

        private void btnThem_Click(object sender, EventArgs e) {
            // Kiểm tra xem có hàng nào được chọn trong dgvProduct hay không
            if (dgvProduct.SelectedRows.Count > 0 && dgvProduct.Rows.Count > 1) {
                DataGridViewRow selectedRow = dgvProduct.SelectedRows[0];
                string productID = selectedRow.Cells["ProductID"].Value.ToString();
                if (!detalBillBus.checkIdExist(this.idBill, productID)) {
                    if (int.TryParse(txtQuantity.Text, out int quantity)) {
                        detalBillBus.AddDetailBill(this.idBill, productID, quantity);
                        load_dtgv();
                    } else {
                        MessageBox.Show("Số lượng phải là số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } else {
                    MessageBox.Show("Sản phẩm đã tồn tại trong giỏ hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else {
                // Hiển thị thông báo nếu không có hàng nào được chọn
                MessageBox.Show("Chưa chọn sản phẩm để thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e) {
            // Kiểm tra xem có hàng nào được chọn trong dgvDetalBill hay không
            if (dgvDetalBill.SelectedRows.Count > 0 && dgvDetalBill.Rows.Count > 1) {
                DataGridViewRow selectedRow = dgvProduct.SelectedRows[0];
                string productID = selectedRow.Cells["ProductID"].Value.ToString();
                if (int.TryParse(txtQuantity.Text, out int quantity)) {
                    detalBillBus.UpdateDetailBill(this.idBill, productID, quantity);
                    load_dtgv();
                } else {
                    MessageBox.Show("Số lượng phải là số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else {
                MessageBox.Show("Vui lòng chọn một sản phẩm để cập nhật.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e) {
            // Kiểm tra xem có hàng nào được chọn trong dgvDetalBill hay không
            if (dgvDetalBill.SelectedRows.Count > 0 && dgvDetalBill.Rows.Count > 1) {
                DataGridViewRow selectedRow = dgvDetalBill.SelectedRows[0];
                string productID = selectedRow.Cells["ProductID"].Value.ToString();

                detalBillBus.DeleteDetailBill(this.idBill, productID);
                load_dtgv();
                //MessageBox.Show("Xóa thành công.");
            } else {
                // Hiển thị thông báo nếu không có hàng nào được chọn
                MessageBox.Show("Chưa chọn sản phẩm để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
