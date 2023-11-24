using MiniSupermarket.BUS;
using MiniSupermarket.ImageAndFont;
using MiniSupermarket.RegularExpression;
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

namespace MiniSupermarket.GUI
{
    public partial class SaleForm : Form
    {
        private SaleBUS saleBus = new SaleBUS();
        private string sex;
        public SaleForm()
        {
            InitializeComponent();
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            // chuyển định dạng cho date time picker
            dtpFromDate.Format = DateTimePickerFormat.Custom;
            dtpFromDate.CustomFormat = "yyyy-MM-dd";
            dtpToDate.Format = DateTimePickerFormat.Custom;
            dtpToDate.CustomFormat = "yyyy-MM-dd";

            txtToTotal.Text = "Giá đến";
            txtToTotal.ForeColor = Color.Gray;
            txtFromTotal.Text = "Giá từ";
            txtFromTotal.ForeColor = Color.Gray;

            LoadTheme();
            // Cho hiển thị hết chiều dài của bảng
            dgv_bill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Đổi màu mặc định của data grid view
            dgv_bill.BackgroundColor = Color.White;
            // Chỉ cho đọc data grid view
            dgv_bill.ReadOnly = true;

            dgv_bill.DataSource = saleBus.getAllBills();

            // Sửa tên cột trong data grid view
            dgv_bill.Columns["BillID"].HeaderText = "Mã hóa đơn";
            dgv_bill.Columns["Date"].HeaderText = "Ngày lập";
            dgv_bill.Columns["EmployeeID"].HeaderText = "Mã NV";
            dgv_bill.Columns["EmployeeName"].HeaderText = "Tên NV";
            dgv_bill.Columns["CustomerID"].HeaderText = "Mã KH";
            dgv_bill.Columns["CustomerName"].HeaderText = "Tên KH";
            dgv_bill.Columns["EstimatedPrice"].HeaderText = "Tạm tính";
            dgv_bill.Columns["ReducePrice"].HeaderText = "Giá giảm";
            dgv_bill.Columns["TotalPrice"].HeaderText = "Tổng tiền";
            dgv_bill.Columns["Status"].HeaderText = "Thanh toán";

            // Vô hiệu hóa các trường nhập của text box khách hàng mới
            txtCustomerName.Enabled = false;
            txtPhone.Enabled = false;
            rdFemale.Enabled = false;
            rdMale.Enabled = false;
        }

        public void LoadTheme()
        {
            // Thêm màu cho tiêu đề group box
            grbCustomerInfo.ForeColor = ThemeColor.SecondaryColor;
            grbCustomerInfo.Font = ProjectFont.getTitleFont();
            gbSearch.ForeColor = ThemeColor.SecondaryColor;
            gbSearch.Font = ProjectFont.getTitleFont();

            // Thêm màu cho tất cả các nút thêm hóa đơn
            foreach (Control control in this.pnlAddBtn.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    Button btn = (Button)control;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                    btn.Font = ProjectFont.getNormalFont();
                }
            }

            btnReset.BackColor = ThemeColor.PrimaryColor;
            btnReset.ForeColor = Color.White;
            btnReset.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            btnReset.Font = ProjectFont.getNormalFont();

            // Thêm màu cho group box tìm kiếm
            foreach (Control control in this.gbSearch.Controls)
            {
                // Nếu control là label thì thêm màu và chỉnh font
                if (control.GetType() == typeof(Label))
                {
                    Label lb = (Label)control;
                    lb.Font = ProjectFont.getNormalFont();
                }
                // Nếu control là text box thì chỉnh font
                else if (control.GetType() == typeof(TextBox))
                {
                    TextBox tb = (TextBox)control;
                    tb.Font = ProjectFont.getNormalFont();
                }
                // Nếu control là combobox thì chỉnh font
                else if (control.GetType() == typeof(ComboBox))
                {
                    ComboBox cb = (ComboBox)control;
                    cb.Font = ProjectFont.getNormalFont();
                }
                // Nếu control là check box thì chỉnh font
                else if (control.GetType() == typeof(CheckBox))
                {
                    CheckBox chk = (CheckBox)control;
                    chk.Font = ProjectFont.getNormalFont();
                }
                // Nếu control là button thì chỉnh font
                else if (control.GetType() == typeof(Button))
                {
                    Button btn = (Button)control;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                    btn.Font = ProjectFont.getNormalFont();
                }
            }

            // Thêm màu cho group box thông tin khách hàng
            foreach (Control control in this.grbCustomerInfo.Controls)
            {
                // Nếu control là label thì thêm màu và chỉnh font
                if (control.GetType() == typeof(Label))
                {
                    Label lb = (Label)control;
                    lb.Font = ProjectFont.getNormalFont();
                }
                // Nếu control là text box thì chỉnh font
                else if (control.GetType() == typeof(TextBox))
                {
                    TextBox tb = (TextBox)control;
                    tb.Font = ProjectFont.getNormalFont();
                }
                // Nếu control là combobox thì chỉnh font
                else if (control.GetType() == typeof(ComboBox))
                {
                    ComboBox cb = (ComboBox)control;
                    cb.Font = ProjectFont.getNormalFont();
                }
                // Nếu control là radio button thì chỉnh font
                else if (control.GetType() == typeof(RadioButton))
                {
                    RadioButton radio = (RadioButton)control;
                    radio.Font = ProjectFont.getNormalFont();
                }
                // Nếu control là check box thì chỉnh font
                else if (control.GetType() == typeof(CheckBox))
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Font = ProjectFont.getNormalFont();
                }
            }

            // Chỉnh size chữ cho date time picker
            dtpFromDate.Font = new Font("Microsoft Sans Serif", 8.5F);
            dtpToDate.Font = new Font("Microsoft Sans Serif", 8.5F);
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            // Nếu chọn khách hàng mới thì phải nhập đầy đủ thông tin khách hàng
            if (ckNewCustomer.Checked)
            {
                // Yêu cầu nhập tên khách hàng
                if (txtCustomerName.Text.Trim().Length == 0)
                {
                    // Hiện thông báo
                    MessageBox.Show("Vui lòng nhập tên khách hàng",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    txtCustomerName.Focus();
                    return;
                }
                // Yêu cầu nhập số điện thoại
                if (txtPhone.Text.Trim().Length == 0)
                {
                    // Hiện thông báo
                    MessageBox.Show("Vui lòng nhập số điện thoại",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    txtPhone.Focus();
                    return;
                }
                // Yêu cầu chọn giới tính
                if (!rdMale.Checked && !rdFemale.Checked)
                {
                    // Hiện thông báo
                    MessageBox.Show("Vui lòng chọn giới tính",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    return;
                }
                // Kiểm tra số điện thoại có hợp lệ
                if (!ProjectRegex.IsPhoneNumber(txtPhone.Text))
                {
                    // Hiện thông báo
                    MessageBox.Show("Số điện thoại không hợp lệ",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    return;
                }

                // Tạo một mã khách hàng mới
                string customerId = RandomString(5);
                string customerName = txtCustomerName.Text.Trim();
                if (saleBus.InsertCustomerSale(customerId, customerName, txtPhone.Text, sex))
                {
                    // Thêm khách hàng mới tạo vào combo box chọn khách hàng
                    cbChooseCustomer.Items.Add($"[{customerId}] {customerName}");

                    if (saleBus.InsertIntoBill(GlobalState.employeeId, customerId, currentDate))
                    {
                        // Hiện thông báo thành công
                        MessageBox.Show("Tạo hóa đơn thành công",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                        // Cập nhật lại data grid view
                        resetBillGridView();
                        return;
                    }
                    else
                    {
                        // Hiện thông báo thất bại
                        MessageBox.Show("Tạo hóa đơn thất bại",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else
            {
                // Nếu đã chọn khách hàng
                string input = txtSearchCustomer.Text.Trim();
                string customerId = null;
                Match match = Regex.Match(input, @"\[(.*?)\]");
                if (match.Success)
                {
                    customerId = match.Groups[1].Value;
                }

                if (saleBus.InsertIntoBill(GlobalState.employeeId, customerId, currentDate))
                {
                    // Hiện thông báo thành công
                    MessageBox.Show("Tạo hóa đơn thành công",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    // Cập nhật lại data grid view
                    resetBillGridView();
                    return;
                }
                else
                {
                    // Hiện thông báo thất bại
                    MessageBox.Show("Tạo hóa đơn thất bại",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    return;
                }
            }
        }

        // Tạo tạm mã khách hàng mới
        private static Random random = new Random();
        private static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) || !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void updateDataForSaleForm()
        {
            cbChooseCustomer.Items.Clear();
            // Thêm danh sách khách hàng cho combo box
            cbChooseCustomer.Items.AddRange(saleBus.getCustomers().ToArray());
            dgv_bill.DataSource = saleBus.getAllBills();
        }

        // Khi text change của combo box thì lựa chọn sẽ hiển thị tương ứng
        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            string typedText = txtSearchCustomer.Text.ToLower();
            List<string> filteredItems = saleBus.getCustomers().Where(item => item.ToLower().Contains(typedText)).ToList();

            cbChooseCustomer.Items.Clear();
            cbChooseCustomer.Items.AddRange(filteredItems.ToArray());
        }

        private void ckNewCustomer_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox newCustomer = (CheckBox)sender;
            if (newCustomer.Checked)
            {
                txtCustomerName.Enabled = true;
                txtPhone.Enabled = true;
                rdFemale.Enabled = true;
                rdMale.Enabled = true;
            }
            else
            {
                txtCustomerName.Enabled = false;
                txtPhone.Enabled = false;
                rdFemale.Enabled = false;
                rdMale.Enabled = false;

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearchCustomer.Clear();
            txtCustomerName.Clear();
            txtPhone.Clear();
        }

        private void rdMale_CheckedChanged(object sender, EventArgs e)
        {
            sex = "Nam";
        }

        private void rdFemale_CheckedChanged(object sender, EventArgs e)
        {
            sex = "Nữ";
        }

        // Sự kiện tìm kiếm hóa đơn
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = dtpFromDate.Value;
            DateTime dateTo = dtpToDate.Value;

            if (dateFrom > dateTo)
            {
                // Hiện thông báo cảnh báo từ ngày phải nhỏ hơn đến ngày
                MessageBox.Show("Từ ngày phải nhỏ hơn đến ngày",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                return;
            }

            string customer = txtCustomerSearch.Text.Trim();
            string employee = txtEmployeeSearch.Text.Trim();
            bool isCheckOut = cbPay.Checked ? true : false;

            DataTable bills = saleBus.getAllBills();
            DataTable resultSearch = bills.Clone();

            // Lấy những hóa đơn từ ngày
            foreach (DataRow dr in bills.Rows)
            {
                DateTime itemDate;
                if (DateTime.TryParse(dr["Date"].ToString(), out itemDate) &&
                    itemDate >= dateFrom && itemDate <= dateTo &&
                    (dr["CustomerID"].ToString().Contains(customer) || dr["CustomerName"].ToString().Contains(customer) &&
                    (dr["EmployeeID"].ToString().Contains(employee) || dr["EmployeeName"].ToString().Contains(employee))) &&
                    dr["Status"].Equals(isCheckOut))
                {
                    resultSearch.ImportRow(dr);
                }
            }

            dgv_bill.DataSource = resultSearch;
        }

        // Sự kiện chọn combo box
        private void cbChooseCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchCustomer.Text = cbChooseCustomer.Text;
        }

        private void dgv_bill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            object status = dgv_bill.SelectedRows[0].Cells["Status"].Value;
            if (status.ToString() == "")
            {
                btnDelBill.Enabled = false;
                return;
            }
            bool isCheckOut = (bool)status;
            // Nếu đã thanh toán hóa đơn thì disable nút xóa và ngược lại
            if (isCheckOut)
            {
                btnDelBill.Enabled = false;
            }
            else
            {
                btnDelBill.Enabled = true;
            }
        }

        private void btnDelBill_Click(object sender, EventArgs e)
        {
            string billId = dgv_bill.SelectedRows[0].Cells["BillID"].Value.ToString();
            if (saleBus.DeleteBill(billId))
            {
                // Hiện thông báo thành công
                MessageBox.Show("Xóa hóa đơn thành công",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                resetBillGridView();

                return;
            }
            else
            {
                // Hiện thông báo thất bại
                MessageBox.Show("Xóa hóa đơn thất bại",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                return;
            }
        }

        private void dtpFromDate_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void dtpToDate_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        public void resetBillGridView()
        {
            // Cập nhật lại data grid view
            saleBus.updateBills();
            dgv_bill.DataSource = saleBus.getAllBills();
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập các ký tự chữ cái và ký tự điều khiển (như Backspace)
            if (!char.IsWhiteSpace(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;  // Chặn ký tự không mong muốn
            }
        }

        private void txtFromTotal_Leave(object sender, EventArgs e)
        {
            if (txtFromTotal.Text == "")
            {
                txtFromTotal.Text = "Giá từ";
                txtFromTotal.ForeColor = Color.Gray;
            }
        }

        private void txtFromTotal_Enter(object sender, EventArgs e)
        {
            if (txtFromTotal.Text == "Giá từ")
            {
                txtFromTotal.Text = "";
                txtFromTotal.ForeColor = Color.Black;
            }
        }

        private void txtToTotal_Leave(object sender, EventArgs e)
        {
            if (txtToTotal.Text == "")
            {
                txtToTotal.Text = "Giá đến";
                txtToTotal.ForeColor = Color.Gray;
            }
        }

        private void txtToTotal_Enter(object sender, EventArgs e)
        {
            if (txtToTotal.Text == "Giá đến")
            {
                txtToTotal.Text = "";
                txtToTotal.ForeColor = Color.Black;
            }
        }

        private void txtFromTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập các ký tự số và ký tự điều khiển (như Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;  // Chặn ký tự không mong muốn
            }
        }

        private void txtToTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập các ký tự số và ký tự điều khiển (như Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;  // Chặn ký tự không mong muốn
            }
        }
    }
}
