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
    public partial class CustomerForm : Form {
        CustomerBus customerBus = new CustomerBus();
        public CustomerForm() {
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
            lblTitle.Font = ProjectFont.getTitleFont();
        }

        private void CustomerForm_Load(object sender, EventArgs e) {
            dgvCustomer.DataSource = customerBus.getAllCustomers();
            BindingPromotions();
            LoadTheme();
        }

        public void BindingPromotions() {
            BindingSource binding = new BindingSource();
            binding.DataSource = customerBus.getAllCustomers();
            dgvCustomer.DataSource = binding;
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            txtCustomerID.Text = null;
            txtCustomerName.Text = null;
            txtPhoneNumber.Text = null;
            txtGioiTinh.Text = null;
            txtPoint.Text = null;
            errorProvider1.Clear();
            radNam.Checked = false;
            radNu.Checked = false;
        }

        private bool check_empty() {
            errorProvider1.Clear();
            bool result;
            if (txtCustomerID.Text == "") {
                MessageBox.Show("Mã khách hàng đang rỗng");
                errorProvider1.SetError(txtCustomerID, "Mã khánh hàng không được để trống");
            }
            if (txtCustomerName.Text == "") {
                MessageBox.Show("Bạn chưa nhập tên khách hàng");
                errorProvider1.SetError(txtCustomerName, "Tên khách hàng không được để trống");
            }
            if (txtPhoneNumber.Text == "") {
                MessageBox.Show("Bạn chưa nhập số điện thoại");
                errorProvider1.SetError(txtPhoneNumber, "Số điện thoại không được để trống");
            } else if (!IsValidVietnamesePhoneNumber(txtPhoneNumber.Text)) {
                MessageBox.Show("Số điện thoại không hợp lệ");
                errorProvider1.SetError(txtPhoneNumber, "SDT có dạng 037-6714-453");
            }
            if (txtGioiTinh.Text == "") {
                MessageBox.Show("Giới tính không được để trống");
                errorProvider1.SetError(txtGioiTinh, "Giới tính là nam hoặc nữ");
            }
            return true;
        }

        static bool IsValidVietnamesePhoneNumber(string phoneNumber) {
            // Mẫu regex cho số điện thoại ở Việt Nam
            string pattern = @"^(0[0-9]{9}|84[0-9]{9})$";

            // Kiểm tra sự khớp của số điện thoại với mẫu regex
            Match match = Regex.Match(phoneNumber, pattern);

            // Trả về kết quả kiểm tra
            return match.Success;
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            string id = txtCustomerID.Text.Trim().ToUpper();
            string name = ProjectFont.upperFirstLetter(txtCustomerName.Text);
            string phoneNumber = ProjectFont.upperFirstLetter(txtPhoneNumber.Text);
            string sex = ProjectFont.upperFirstLetter(txtGioiTinh.Text);
            string point = ProjectFont.upperFirstLetter(txtPoint.Text);

            if (check_empty()) {
                if (txtCustomerID.Text.Length != 0) {
                    // Nếu mã loại đã tồn tại trong hệ thống thì hiện lỗi
                    if (!customerBus.checkIdExist(id)) {
                        MessageBox.Show(
                            "Mã sản phẩm không tồn tại trong hệ thống",
                            "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning); // cho cảnh báo
                        txtCustomerID.Focus();
                        return;
                    } else if (!customerBus.checkIdExist(id)) {
                        MessageBox.Show(
                            "Mã sản phẩm không tồn tại trong hệ thống",
                            "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning); // cho cảnh báo
                        txtCustomerID.Focus();
                        return;
                    } else if (customerBus.updateProduct(id, name, phoneNumber, sex, point, "1")) {
                        BindingPromotions();
                        MessageBox.Show("Sửa thành công!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information); // Thêm thành công

                    } else {
                        MessageBox.Show("Sửa thất bại!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error); // Thêm thất bại
                        return;
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (txtCustomerID.Text == "") {
                MessageBox.Show("Mã khách hàng đang rỗng");
                errorProvider1.SetError(txtCustomerID, "Mã khánh hàng không được để trống");
            } else {
                string id = txtCustomerID.Text.Trim().ToUpper();
                if (txtCustomerID.Text.Length != 0) {
                    // Nếu mã loại đã tồn tại trong hệ thống thì hiện lỗi
                    if (!customerBus.checkIdExist(id)) {
                        MessageBox.Show(
                            "Mã sản phẩm không tồn tại trong hệ thống",
                            "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning); // cho cảnh báo
                        txtCustomerID.Focus();
                        return;
                    } else if (customerBus.deleteProduct(id)) {
                        BindingPromotions();
                        MessageBox.Show("Xóa thành công!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information); // Thêm thành công

                    } else {
                        MessageBox.Show("Xóa thất bại!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error); // Thêm thất bại
                        return;
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (check_empty()) {
                string id = txtCustomerID.Text.Trim().ToUpper();
                string name = ProjectFont.upperFirstLetter(txtCustomerName.Text);
                string phoneNumber = ProjectFont.upperFirstLetter(txtPhoneNumber.Text);
                string sex = ProjectFont.upperFirstLetter(txtGioiTinh.Text);
                string point = ProjectFont.upperFirstLetter(txtPoint.Text);


                if (txtCustomerID.Text.Length != 0) {
                    // Nếu mã loại đã tồn tại trong hệ thống thì hiện lỗi
                    if (customerBus.checkIdExist(id)) {
                        MessageBox.Show(
                            "Mã sản phẩm đã tồn tại trong hệ thống",
                            "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning); // cho cảnh báo
                        txtCustomerID.Focus();
                        return;
                    }
                }
                // Nếu mà mã loại rỗng thì sẽ tự tạo mã id
                if (id.Length == 0) {
                    if (customerBus.addProduct(id, name, phoneNumber, sex, point, "1")) {
                        BindingPromotions();
                        MessageBox.Show("Thêm thành công!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information); // Thêm thành công

                    } else {
                        MessageBox.Show("Thêm thất bại!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error); // Thêm thất bại
                        return;
                    }
                } else // Nếu mà nhập đầy đủ thông tin thì thêm đầy đủ
                  {
                    if (customerBus.addProduct(id, name, phoneNumber, sex, point, "1")) {
                        MessageBox.Show("Thêm thành công!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information); // Thêm thành công

                    } else {
                        MessageBox.Show("Thêm thất bại!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error); // Thêm thất bại
                        txtCustomerID.Focus();
                        return;
                    }
                }
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e) {
            string selectedValue = cboFind.SelectedItem != null ? cboFind.SelectedItem.ToString() : string.Empty;

            string input = txtFind.Text;
            string sex = "";
            if (radNam.Checked) {
                sex = "Nam";
            } else if (radNam.Checked) {
                sex = "Nữ";
            }
            dgvCustomer.DataSource = customerBus.FindCustomer(selectedValue, input, sex);
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e) {
            DataGridViewRow selectedRow = dgvCustomer.Rows[e.RowIndex];
            // Lấy giá trị từ các ô của hàng được chọn
            txtCustomerID.Text = selectedRow.Cells["CustomerID"].Value.ToString();
            txtCustomerName.Text = selectedRow.Cells["Name"].Value.ToString();
            txtPhoneNumber.Text = selectedRow.Cells["PhoneNumber"].Value.ToString();
            txtGioiTinh.Text = selectedRow.Cells["Sex"].Value.ToString();
            txtPoint.Text = selectedRow.Cells["Point"].Value.ToString();
        }
    }
}
