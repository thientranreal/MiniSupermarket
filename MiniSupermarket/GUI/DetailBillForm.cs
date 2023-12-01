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
        string idBill = "";
        ProductBUS productBUS = new ProductBUS();
        DetalBillBus detalBillBus = new DetalBillBus();
        public DetailBillForm(string idBill) {
            this.idBill = idBill;
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
            // Thêm cột vào DataGridView
            dgvDetalBill.Columns.Add("ProductID", "Mã Sản Phẩm");
            dgvDetalBill.Columns.Add("ProductName", "Tên Sản Phẩm");
            dgvDetalBill.Columns.Add("ProductCurrentPrice", "Đơn giá");
            dgvDetalBill.Columns.Add("ProductUnit", "Kiểu");
            dgvDetalBill.Columns.Add("Quantity", "Số lượng");
            dgvDetalBill.Columns.Add("OrderID", "Mã Đơn Hàng");

            // Ẩn cột "ProductID" và "OrderID"
            dgvDetalBill.Columns["ProductID"].Visible = false;
            dgvDetalBill.Columns["OrderID"].Visible = false;
            load_dtgv();
        }

        private void load_dtgv() {
            List<DetailBill> detailBills = detalBillBus.getAllDetalBills();
            dgvDetalBill.Rows.Clear();
            foreach (var detailBill in detailBills) {
                // Thêm một dòng mới vào DataGridView
                if (detailBill.BillID == this.idBill) {
                    int rowIndex = dgvDetalBill.Rows.Add();

                    // Đặt giá trị cho các ô tương ứng
                    dgvDetalBill.Rows[rowIndex].Cells["ProductID"].Value = detailBill.ProductID;
                    dgvDetalBill.Rows[rowIndex].Cells["ProductName"].Value = detailBill.ProductName;
                    dgvDetalBill.Rows[rowIndex].Cells["ProductCurrentPrice"].Value = detailBill.ProductCurrentPrice;
                    dgvDetalBill.Rows[rowIndex].Cells["ProductUnit"].Value = detailBill.ProductUnit;
                    dgvDetalBill.Rows[rowIndex].Cells["Quantity"].Value = detailBill.Quantity;
                    dgvDetalBill.Rows[rowIndex].Cells["OrderID"].Value = detailBill.OrderID;
                }
            }

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
        }

        private void btnThem_Click(object sender, EventArgs e) {
            // Kiểm tra xem có hàng nào được chọn trong dgvProduct hay không
            if (dgvProduct.SelectedRows.Count > 0 && dgvDetalBill.Rows.Count > 1) {
                // Lấy ra dữ liệu của hàng được chọn
                DataGridViewRow selectedRow = dgvProduct.SelectedRows[0];
                string productID = selectedRow.Cells["ProductID"].Value.ToString();
                string name = selectedRow.Cells["Name"].Value.ToString();
                float currentPrice = float.Parse(selectedRow.Cells["CurrentPrice"].Value.ToString());
                string unit = selectedRow.Cells["Unit"].Value.ToString();

                // Gọi phương thức AddDetailBill từ DetailBillBus
                detalBillBus.AddDetailBill(new DetailBill(this.idBill, productID, "PO0001", name, currentPrice, unit, currentPrice * 3, 3));

                // Sau khi thêm thành công, cập nhật lại DataGridView và List
                load_dtgv();
            } else {
                // Hiển thị thông báo nếu không có hàng nào được chọn
                MessageBox.Show("Chưa chọn sản phẩm để thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e) {
            if (dgvProduct.SelectedRows.Count > 0 && dgvDetalBill.Rows.Count > 1) {
                // Lấy thông tin từ hàng đã chọn trong dgvProduct
                string productID = dgvDetalBill.SelectedRows[0].Cells["ProductID"].Value.ToString();
                string name = dgvDetalBill.SelectedRows[0].Cells["ProductName"].Value.ToString();
                string orderID = dgvDetalBill.SelectedRows[0].Cells["OrderID"].Value.ToString();
                float currentPrice = float.Parse(dgvDetalBill.SelectedRows[0].Cells["ProductCurrentPrice"].Value.ToString());
                string unit = dgvDetalBill.SelectedRows[0].Cells["ProductUnit"].Value.ToString();
                // ...

                // Tạo đối tượng DetailBill
                DetailBill detailBill = new DetailBill(this.idBill, productID, orderID, name, currentPrice, unit, currentPrice * 3, 3);

                // Gọi phương thức update của detalBillBus
                bool result = detalBillBus.UpdateDetailBill(detailBill);

                if (result) {
                    // Nếu cập nhật thành công, cập nhật lại DataGridView
                    load_dtgv();
                    MessageBox.Show("Cập nhật thành công.");
                } else {
                    // Xử lý khi cập nhật thất bại
                    MessageBox.Show("Cập nhật không thành công.");
                }
            } else {
                MessageBox.Show("Vui lòng chọn một sản phẩm để cập nhật.");
            }
        }




        private void btnXoa_Click(object sender, EventArgs e) {
            // Kiểm tra xem có hàng nào được chọn không
            if (dgvDetalBill.SelectedRows.Count > 0 && dgvDetalBill.Rows.Count > 1) {
                // Lấy ra dữ liệu của hàng được chọn
                DataGridViewRow selectedRow = dgvDetalBill.SelectedRows[0];
                string productID = selectedRow.Cells["ProductID"].Value.ToString();
                string orderID = dgvDetalBill.SelectedRows[0].Cells["OrderID"].Value.ToString();

                // Kiểm tra xem dữ liệu có hợp lệ không (ở đây mình giả sử productName không null hoặc empty)
                if (!string.IsNullOrEmpty(productID) && !string.IsNullOrEmpty(orderID)) {
                    // Gọi phương thức DeleteDetailBill từ DetailBillBus
                    detalBillBus.DeleteDetailBill(this.idBill, productID, orderID);

                    // Sau khi xóa thành công, cập nhật lại DataGridView và List
                    MessageBox.Show("Xóa thành công.");
                    load_dtgv();
                }
            } else {
                // Hiển thị thông báo nếu không có hàng nào được chọn
                MessageBox.Show("Chưa chọn sản phẩm để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
