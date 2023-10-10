using MiniSupermarket.Controllers;
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

namespace MiniSupermarket.Views
{
    public partial class ProductTypeManage : Form
    {
        // khai bao controller
        private ProductTypeController ptController = new ProductTypeController();
        public ProductTypeManage()
        {
            InitializeComponent();
            this.AutoSize = true;
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // Đặt font cho các textbox và label
            lb_QLLSP.Font = ProjectFont.getTitleFont();
            txt_idType.Font = ProjectFont.getNormalFont();
            txt_nameType.Font = ProjectFont.getNormalFont();
            txt_search.Font = ProjectFont.getNormalFont();
            lb_idType.Font = ProjectFont.getNormalFont();
            lb_typeName.Font = ProjectFont.getNormalFont();
            cb_search.Font = ProjectFont.getNormalFont();
            //
            cb_search.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_search.Items.Add("Mã loại");
            cb_search.Items.Add("Tên loại");
            cb_search.SelectedIndex = 0;
            // Cho hiển thị hết chiều dài của bảng
            dgv_qllsp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Tải dữ liệu lên data grid view
            dgv_qllsp.DataSource = ptController.getAllProducts();

            // Chỉ cho đọc data grid view
            dgv_qllsp.ReadOnly = true;

            // Đổi tên cột
            dgv_qllsp.Columns["TypeID"].HeaderText = "Mã loại";
            dgv_qllsp.Columns["Name"].HeaderText = "Tên loại";

            // Đổi màu mặc định của data grid view
            dgv_qllsp.BackgroundColor = Color.White;


        }

        private void dgv_qllsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // make sure user select at least 1 row 
            {
                DataGridViewRow row = dgv_qllsp.Rows[e.RowIndex];
                txt_idType.Text = row.Cells["TypeID"].Value.ToString();
                txt_nameType.Text = row.Cells["Name"].Value.ToString();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string id = txt_idType.Text.Trim();
            string name = txt_nameType.Text.Trim();
            // Nếu mà mã loại rỗng
            if (id.Length == 0)
            {//Nếu tên loại rỗng thì hiện thông báo warning
                if (name.Length == 0)
                {
                    MessageBox.Show(
                        "Không được bỏ trống tên loại sản phẩm",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning // cho cảnh báo
                    );
                }
                else
                {// Nếu tên loại đã tồn tại trong hệ thống thì hiện lỗi
                    if (ptController.checkNameExist(name))
                    {
                        MessageBox.Show(
                        "Tên loại đã tồn tại trong hệ thống",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning // cho cảnh báo
                    );
                    }
                }
            }
        }
    }
}
