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
    public partial class UserAccount : Form
    {
        private string userName;
        public UserAccount(string userName)
        {
            InitializeComponent();
            this.userName = userName;
        }

        // Hàm tải màu cho label và nút
        public void LoadTheme()
        {
            // Thêm màu cho tất cả các nút và label ở panel top
            foreach (Control control in this.pnlLeft.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    Button btn = (Button)control;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
                else if (control.GetType() == typeof(Label))
                {
                    Label lb = (Label)control;
                    lb.ForeColor = ThemeColor.SecondaryColor;
                    lb.Font = ProjectFont.getNormalFont();
                }
            }

            // Thêm màu cho tất cả các nút và label ở panel top
            foreach (Control control in this.pnlRight.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    Button btn = (Button)control;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
                else if (control.GetType() == typeof(Label))
                {
                    Label lb = (Label)control;
                    lb.ForeColor = ThemeColor.SecondaryColor;
                    lb.Font = ProjectFont.getNormalFont();
                }
            }
        }

        private void UserAccount_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
