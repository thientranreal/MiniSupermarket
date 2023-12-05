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
                MessageBox.Show("Vui lòng chọn một chức vụ để chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}