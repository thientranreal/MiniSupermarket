using MiniSupermarket.BUS;
using MiniSupermarket.ImageAndFont;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MiniSupermarket.BUS
{
    public partial class EmployeeForm : Form
    {
        private EmployeeBUS employeeBUS = new EmployeeBUS();
        public EmployeeForm()
        {
            InitializeComponent();
            this.AutoSize = true;
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);

            cb_sex.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_sex.Items.Add("Chọn giới tính");
            cb_sex.Items.Add("Nam");
            cb_sex.Items.Add("Nữ");
            cb_sex.SelectedIndex = 0;

            cb_find.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_find.Items.Add("Tìm kiếm");
            cb_find.Items.Add("Mã nhân viên");
            cb_find.Items.Add("Tên nhân viên");

            ds_qlnv.BackgroundColor = Color.White;
            ds_qlnv.ReadOnly = true;
            ds_qlnv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ds_qlnv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ds_qlnv.SelectionChanged += DataGridView_SelectionChanged;

            tb_id.ReadOnly = true;
        }

        public void LoadTheme()
        {
            // Thêm màu và chỉnh font cho các group box
            gb_Function.ForeColor = ThemeColor.SecondaryColor;
            gb_Function.Font = ProjectFont.getTitleFont();
            gb_Info.ForeColor = ThemeColor.SecondaryColor;
            gb_Info.Font = ProjectFont.getTitleFont();
            gb_List.ForeColor = ThemeColor.SecondaryColor;
            gb_List.Font = ProjectFont.getTitleFont();
            lb_title.ForeColor = ThemeColor.SecondaryColor;
            lb_title.Font = ProjectFont.getTitleFont();

            // Thêm màu và chỉnh font cho các button
            foreach (Control btns in this.gb_Function.Controls)
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

            foreach (Control control in this.gb_Info.Controls)
            {
                if (control.GetType() == typeof(Label))
                {
                    Label lb = (Label)control;
                    lb.Font = ProjectFont.getNormalFont();
                }
                else if (control.GetType() == typeof(TextBox))
                {
                    TextBox tb = (TextBox)control;
                    tb.Font = ProjectFont.getNormalFont();
                }
                else if (control.GetType() == typeof(ComboBox))
                {
                    ComboBox cb = (ComboBox)control;
                    cb.Font = ProjectFont.getNormalFont();
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // Viết hoa id và chữ cái đầu 
            string id = tb_id.Text.Trim().ToUpper();
            string name = ProjectFont.upperFirstLetter(tb_name.Text);
            string address = ProjectFont.upperFirstLetter(tb_address.Text);
            string pnumber = ProjectFont.upperFirstLetter(tb_pNumber.Text);
            string email = ProjectFont.upperFirstLetter(tb_email.Text);
            //DateTime birthdate = ProjectFont.upperFirstLetter(dtp_birth.Text);
            string password = ProjectFont.upperFirstLetter(tb_pass.Text);
            string sex = ProjectFont.upperFirstLetter(cb_sex.Text);
            string username = ProjectFont.upperFirstLetter(tb_id.Text);
            if (id.Length != 0) // Nếu người dùng nhập mã loại
            {
                // Nếu mã loại đã tồn tại trong hệ thống thì hiện lỗi
                if (employeeBUS.checkIdExist(id))
                {
                    MessageBox.Show(
                        "Mã sản phẩm đã tồn tại trong hệ thống",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning); // cho cảnh báo
                    tb_id.Focus();
                    return;
                }
            }
            // Nếu mà mã loại rỗng thì sẽ tự tạo mã id
            if (id.Length == 0)
            {
                if (employeeBUS.addEmployee(id, username, name, address, pnumber, email, dtp_birth.Value, password, sex))
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
                if (employeeBUS.addEmployee(id, username, name, address, pnumber, email, dtp_birth.Value, password, sex))
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
                    tb_id.Focus();
                    return;
                }
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            ds_qlnv.DataSource = employeeBUS.getAllEmployee();
            EmployeeBUS.Reset(gb_Info.Controls, ds_qlnv, gb_Function.Controls);
        }

        void setNull()
        {
            tb_name.Text = "";
            tb_pass.Text = "";
            tb_email.Text = "";
            tb_address.Text = "";
            tb_pNumber.Text = "";
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            setNull();

            ds_qlnv.DataSource = employeeBUS.getAllEmployee();

            ds_qlnv.Columns["EmployeeID"].HeaderText = "Mã nhân viên";
            ds_qlnv.Columns["Name"].HeaderText = "Tên nhân viên";
            ds_qlnv.Columns["BirthDate"].HeaderText = "Ngày sinh";
            if (ds_qlnv.Columns["BirthDate"] != null)
            {
                ds_qlnv.Columns["BirthDate"].HeaderText = "Ngày sinh";
            }
            ds_qlnv.Columns["Address"].HeaderText = "Địa chỉ";
            ds_qlnv.Columns["PhoneNumber"].HeaderText = "Số điện thoại";
            ds_qlnv.Columns["Email"].HeaderText = "Email";
            ds_qlnv.Columns["Sex"].HeaderText = "Giới tính";
            ds_qlnv.Columns["Password"].HeaderText = "Mật khẩu";

            ds_qlnv.Columns["EmployeeID"].Width = 115;
            ds_qlnv.Columns["Password"].Width = 90;
            ds_qlnv.Columns["Sex"].Width = 100;
            ds_qlnv.Columns["BirthDate"].Width = 180;
            ds_qlnv.Columns["PhoneNumber"].Width = 200;
            ds_qlnv.Columns["Email"].Width = 200;

            LoadTheme();
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ds_qlnv.SelectedRows.Count > 0)
            {
                // Assuming you have textboxes named txtEmployeeID, txtName, etc.
                tb_id.Text = ds_qlnv.SelectedRows[0].Cells["EmployeeID"].Value.ToString();
                tb_name.Text = ds_qlnv.SelectedRows[0].Cells["Name"].Value.ToString();
                tb_address.Text = ds_qlnv.SelectedRows[0].Cells["Address"].Value.ToString();
                tb_pNumber.Text = ds_qlnv.SelectedRows[0].Cells["PhoneNumber"].Value.ToString();
                tb_email.Text = ds_qlnv.SelectedRows[0].Cells["Email"].Value.ToString();
                cb_sex.Text = ds_qlnv.SelectedRows[0].Cells["Sex"].Value.ToString();
                tb_pass.Text = ds_qlnv.SelectedRows[0].Cells["Password"].Value.ToString();

                DateTime BirthDate = (DateTime)ds_qlnv.SelectedRows[0].Cells["BirthDate"].Value;
                dtp_birth.Text = BirthDate.ToShortDateString();

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (ds_qlnv.SelectedRows.Count > 0)
            {
                // Get the employee ID from the selected row
                string employeeId = ds_qlnv.SelectedRows[0].Cells["EmployeeID"].Value.ToString();

                // Prompt the user for confirmation before deleting
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Attempt to delete the employee
                    bool deleteResult = employeeBUS.deleteEmployee(employeeId);

                    // Check if the deletion was successful
                    if (deleteResult)
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh the DataGridView after deletion
                        ds_qlnv.DataSource = employeeBUS.getAllEmployee();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (ds_qlnv.SelectedRows.Count > 0)
            {
                // Lấy dữ liệu từ các ô trên DataGridView
                string id = tb_id.Text.Trim().ToUpper();
                string name = ProjectFont.upperFirstLetter(tb_name.Text);
                string address = ProjectFont.upperFirstLetter(tb_address.Text);
                string pnumber = ProjectFont.upperFirstLetter(tb_pNumber.Text);
                string email = ProjectFont.upperFirstLetter(tb_email.Text);
                string sex = ProjectFont.upperFirstLetter(cb_sex.Text);
                string password = ProjectFont.upperFirstLetter(tb_pass.Text);
                string username = ProjectFont.upperFirstLetter(tb_id.Text);

                // Gọi phương thức chỉnh sửa từ EmployeeBUS
                bool editResult = employeeBUS.editEmployee(id, name, address, pnumber, email, sex, dtp_birth.Value, password, username);

                // Kiểm tra kết quả chỉnh sửa
                if (editResult)
                {
                    MessageBox.Show("Chỉnh sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cập nhật lại DataGridView sau khi chỉnh sửa
                    ds_qlnv.DataSource = employeeBUS.getAllEmployee();
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            string searchTerm = tb_find.Text.Trim();

            // Kiểm tra xem ComboBox chọn là ID hay Tên
            string searchType = cb_find.SelectedItem.ToString();

            // Gọi phương thức tìm kiếm từ EmployeeBUS
            DataTable searchResult = null;

            if (searchType == "Mã nhân viên")
            {
                // Gọi phương thức tìm kiếm theo ID
                searchResult = employeeBUS.SearchEmployeeByID(searchTerm);
            }
            else if (searchType == "Tên nhân viên")
            {
                // Gọi phương thức tìm kiếm theo Tên
                searchResult = employeeBUS.SearchEmployeeByName(searchTerm);
            }

            // Hiển thị kết quả trong DataGridView hoặc bảng dữ liệu của bạn
            ds_qlnv.DataSource = searchResult;
        }
    }
}
