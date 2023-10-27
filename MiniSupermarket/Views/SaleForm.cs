using MiniSupermarket.Controllers;
using MiniSupermarket.ImageAndFont;
using MiniSupermarket.Models;
using MiniSupermarket.RegularExpression;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSupermarket.Views
{
    public partial class SaleForm : Form
    {
        private SaleController saleController = new SaleController();
        public SaleForm()
        {
            InitializeComponent();
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);

            // Thêm lựa chọn combo box tìm kiếm
            cbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCustomer.Items.Add("Mã KH");
            cbCustomer.Items.Add("Tên KH");
            cbEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEmployee.Items.Add("Mã NV");
            cbEmployee.Items.Add("Tên NV");
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            LoadTheme();

            dgv_bill.DataSource = saleController.getAllBills();
            // Cho hiển thị hết chiều dài của bảng
            dgv_bill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Đổi màu mặc định của data grid view
            dgv_bill.BackgroundColor = Color.White;
            // Chỉ cho đọc data grid view
            dgv_bill.ReadOnly = true;
            // Sửa tên cột trong data grid view
            dgv_bill.Columns["BillID"].HeaderText = "Mã hóa đơn";
            dgv_bill.Columns["Date"].HeaderText = "Ngày lập";
            dgv_bill.Columns["EmployeeID"].HeaderText = "Mã NV";
            dgv_bill.Columns["EmployeeName"].HeaderText = "Tên NV";
            dgv_bill.Columns["CustomerID"].HeaderText = "Mã KH";
            dgv_bill.Columns["CustomerName"].HeaderText = "Tên KH";
            dgv_bill.Columns["PromotionName"].HeaderText = "CTKM";
            dgv_bill.Columns["TotalPrice"].HeaderText = "Tổng tiền";
            dgv_bill.Columns["Status"].HeaderText = "Trạng thái";
        }

        public void LoadTheme()
        {
            // Thêm màu cho tiêu đề group box
            grbCustomerInfo.ForeColor = ThemeColor.SecondaryColor;
            grbCustomerInfo.Font = ProjectFont.getTitleFont();
            gbSearch.ForeColor = ThemeColor.SecondaryColor;
            gbSearch.Font = ProjectFont.getTitleFont();

            // Thêm màu cho tất cả các nút thêm hóa đơn
            btnAddBill.BackColor = ThemeColor.PrimaryColor;
            btnAddBill.ForeColor = Color.White;
            btnAddBill.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            btnAddBill.Font = ProjectFont.getNormalFont();

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
            }

            // Chỉnh size chữ cho date time picker
            dtpFromDate.Font = new Font("Microsoft Sans Serif", 8.5F);
            dtpToDate.Font = new Font("Microsoft Sans Serif", 8.5F);
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            // Nếu chưa chọn khách hàng thì phải nhập đầy đủ thông tin khách hàng
            if (cbChooseCustomer.Text.Trim().Length == 0)
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
            }
            else
            {
                // Nếu đã chọn khách hàng
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) || !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
