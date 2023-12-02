using MiniSupermarket.BUS;
using MiniSupermarket.ImageAndFont;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSupermarket.GUI
{
    public partial class RoleForm : Form
    {
        private RoleBUS roleBUS = new RoleBUS();
        public RoleForm()
        {
            InitializeComponent();
            this.AutoSize = true;
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);

            SetupComboBox(cb_sanpham);
            SetupComboBox(cb_loaisp);
            SetupComboBox(cb_banhang);
            SetupComboBox(cb_nhaphang);
            SetupComboBox(cb_khachhang);
            SetupComboBox(cb_nhanvien);
            SetupComboBox(cb_quyen);
            SetupComboBox(cb_thongke);
            SetupComboBox(cb_nhacungcap);
            SetupComboBox(cb_ctkm);

            ds_qlcv.BackgroundColor = Color.White;
            ds_qlcv.ReadOnly = true;
            ds_qlcv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ds_qlcv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ds_qlcv.SelectionChanged += DataGridView_SelectionChanged;

            tb_id.ReadOnly = true;
        }

        private void SetupComboBox(ComboBox comboBox)
        {
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox.Items.Add("Không phân quyền");
            comboBox.Items.Add("Có phân quyền");

            comboBox.SelectedIndex = 0;
        }

        public void LoadTheme()
        {
            gb_Function.ForeColor = ThemeColor.SecondaryColor;
            gb_Function.Font = ProjectFont.getTitleFont();
            gb_Info.ForeColor = ThemeColor.SecondaryColor;
            gb_Info.Font = ProjectFont.getTitleFont();
            gb_List.ForeColor = ThemeColor.SecondaryColor;
            gb_List.Font = ProjectFont.getTitleFont();
            gb_role.ForeColor = ThemeColor.SecondaryColor;
            gb_role.Font = ProjectFont.getTitleFont();
            lb_title.ForeColor = ThemeColor.SecondaryColor;
            lb_title.Font = ProjectFont.getTitleFont();


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

            foreach (Control control in this.gb_role.Controls)
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
                else if (control.GetType() == typeof(RichTextBox))
                {
                    RichTextBox rb = (RichTextBox)control;
                    rb.Font = ProjectFont.getNormalFont();
                }
            }
        }

        void setNull()
        {
            tb_id.Text = "";
            tb_name.Text = "";
            rtb_explain.Text = "";
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ds_qlcv.SelectedRows.Count > 0)
            {
                tb_id.Text = ds_qlcv.SelectedRows[0].Cells["RoleID"].Value.ToString();
                tb_name.Text = ds_qlcv.SelectedRows[0].Cells["Name"].Value.ToString();
                rtb_explain.Text = ds_qlcv.SelectedRows[0].Cells["Description"].Value.ToString();
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            string id = tb_id.Text.Trim().ToUpper();
            string name = ProjectFont.upperFirstLetter(tb_name.Text);
            string description = ProjectFont.upperFirstLetter(rtb_explain.Text);
            if (id.Length != 0) 
            {
                if (roleBUS.checkIdExist(id))
                {
                    MessageBox.Show(
                        "Mã sản phẩm đã tồn tại trong hệ thống",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning); 
                    tb_id.Focus();
                    return;
                }
            }
            if (id.Length == 0)
            {
                if (roleBUS.addRole(id, name, description))
                {
                    MessageBox.Show("Thêm thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information); 

                }
                else
                {
                    MessageBox.Show("Thêm thất bại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error); 
                    return;
                }
            }
            else 
            {
                if (roleBUS.addRole(id, name, description))
                {
                    MessageBox.Show("Thêm thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information); 

                }
                else
                {
                    MessageBox.Show("Thêm thất bại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error); 
                    tb_id.Focus();
                    return;
                }
            }
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            ds_qlcv.DataSource = roleBUS.getAllRole();
            RoleBUS.Reset(gb_role.Controls, ds_qlcv);
        }

        private void RoleForm_Load(object sender, EventArgs e)
        {
            setNull();

            ds_qlcv.DataSource = roleBUS.getAllRole();

            ds_qlcv.Columns["RoleID"].HeaderText = "Mã chức vụ";
            ds_qlcv.Columns["Name"].HeaderText = "Tên chức vụ";
            ds_qlcv.Columns["Description"].HeaderText = "Mô tả chức vụ";

            ds_qlcv.Columns["RoleID"].Width = 120;
            ds_qlcv.Columns["Name"].Width = 340;
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (ds_qlcv.SelectedRows.Count > 0)
            {
                string roleId = ds_qlcv.SelectedRows[0].Cells["RoleID"].Value.ToString();

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool deleteResult = roleBUS.deleteRole(roleId);

                    if (deleteResult)
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ds_qlcv.DataSource = roleBUS.getAllRole();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một chức vụ để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            if (ds_qlcv.SelectedRows.Count > 0)
            {
                string id = tb_id.Text.Trim().ToUpper();
                string name = ProjectFont.upperFirstLetter(tb_name.Text);
                string description = ProjectFont.upperFirstLetter(rtb_explain.Text);

                bool editResult = roleBUS.editRole(id, name, description);

                if (editResult)
                {
                    MessageBox.Show("Chỉnh sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ds_qlcv.DataSource = roleBUS.getAllRole();
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
<<<<<<< Updated upstream
                MessageBox.Show("Vui lòng chọn một chức vụ để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
=======
                MessageBox.Show("Vui lòng chọn một quyền để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool checkFunction(string text, List<string> functions)
        {
            // Duyệt qua từng chức năng trong danh sách
            foreach (string function in functions)
            {
                // Nếu có chức năng trong danh sách thì hiện checkbox
                if (function == text)
                {
                    return true;
                }
            }
            return false;
        }

        private void ds_qlcv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ds_qlcv.SelectedRows.Count > 0)
            {
                string roleID = ds_qlcv.SelectedRows[0].Cells["RoleID"].Value + string.Empty;
                List<string> functions = roleBUS.selectFunctionFromRoleID(roleID);
                // Nếu roleID đang chọn không rỗng
                if (roleID.Length > 0)
                {
                    foreach (Control control in this.gb_Info.Controls)
                    {
                        if (control.GetType() == typeof(CheckBox))
                        {
                            CheckBox ck = (CheckBox)control;
                            if (checkFunction(ck.Text, functions))
                            {
                                ck.Checked = true;
                            }
                            else { ck.Checked = false; }
                        }
                    }
                }
            }
        }

        private void resetText()
        {
            tb_name.Clear();
            rtb_explain.Clear();
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ds_qlcv.SelectedRows.Count > 0)
            {
                tb_name.Text = ds_qlcv.SelectedRows[0].Cells["Name"].Value.ToString();
                rtb_explain.Text = ds_qlcv.SelectedRows[0].Cells["Description"].Value.ToString();
            }
        }

        private void btnUpdateFunction_Click(object sender, EventArgs e)
        {
            if (ds_qlcv.SelectedRows.Count > 0)
            {
                string roleID = ds_qlcv.SelectedRows[0].Cells["RoleID"].Value + string.Empty;
                string roleName = ds_qlcv.SelectedRows[0].Cells["Name"].Value + string.Empty;
                bool result = true;
                List<string> funcIDsActivate = new List<string>();
                bool isReturnToMenu = true;

                if (roleID.Length == 0)
                {
                    MessageBox.Show("Vui lòng chọn quyền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult dialogResult = MessageBox.Show($"Bạn có muốn cập nhật chức năng cho {roleName}?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // Nếu roleID đang chọn không rỗng
                    if (roleID.Length > 0)
                    {
                        if (roleBUS.deleteFunctionFromRoleID(roleID))
                        {
                            foreach (Control control in this.gb_Info.Controls)
                            {
                                if (control.GetType() == typeof(CheckBox))
                                {
                                    CheckBox ck = (CheckBox)control;
                                    // Nếu check box đang được chọn thì thêm chức năng vào database
                                    if (ck.Checked == true)
                                    {
                                        if (!roleBUS.insertIntoRoleFunction(roleID, ck.Tag.ToString()))
                                        {
                                            result = false;
                                        }
                                        else
                                        {
                                            funcIDsActivate.Add(ck.Tag.ToString());
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            // Nếu xóa thất bại
                            result = false;
                        }
                    }
                    // Nếu result là true thì hiện thông báo cập nhật chức năng thành công
                    if (result)
                    {
                        MessageBox.Show("Cập nhật chức năng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Nếu cập nhật chức năng mà là nhóm quyền của tài khoản đang đăng nhập
                        // thì sẽ cập nhật chức năng trực tiếp trên thanh menu
                        if (roleID == GlobalState.roleId)
                        {
                            // Ẩn hết tất cả các chức năng
                            foreach (KeyValuePair<string, Button> item in GlobalState.functionsButton)
                            {
                                item.Value.Visible = false;
                            }

                            // Chỉ hiển thị các nút chức năng trong danh sách
                            foreach (string item in funcIDsActivate)
                            {
                                if (item == "F0007")
                                {
                                    // Nếu mà có chức năng quyền thì sẽ set isReturnToMenu là false
                                    isReturnToMenu = false;
                                }
                                GlobalState.functionsButton[item].Visible = true;
                            }

                            // isReturnToMenu là true thì sẽ ra trang menu
                            if (isReturnToMenu)
                            {
                                GlobalState.menuForm.closeChildForm();
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật chức năng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
>>>>>>> Stashed changes
            }
        }
    }
}