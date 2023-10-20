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
    public partial class SaleForm : Form
    {
        public SaleForm()
        {
            InitializeComponent();
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);

            // Thêm lựa chọn combo box
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
        }

        public void LoadTheme()
        {
            // Thêm màu cho tất cả các nút ở panel top
            foreach (Control btns in this.pnl_top.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }

            // Thêm màu cho group box tìm kiếm
            foreach (Control control in this.gbSearch.Controls)
            {
                // Nếu control là label thì thêm màu và chỉnh font
                if (control.GetType() == typeof(Label))
                {
                    Label lb = (Label)control;
                    lb.ForeColor = ThemeColor.SecondaryColor;
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
                    cb.ForeColor = ThemeColor.SecondaryColor;
                }
                // Nếu control là check box thì chỉnh font
                else if (control.GetType() == typeof(CheckBox))
                {
                    CheckBox chk = (CheckBox)control;
                    chk.Font = ProjectFont.getNormalFont();
                    chk.ForeColor = ThemeColor.SecondaryColor;
                }
            }
        }
    }
}
