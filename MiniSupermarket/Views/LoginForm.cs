using MiniSupermarket.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSupermarket
{
    public partial class formLogin : Form
    {
        private LoginController controller = new LoginController();

        public formLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        int intImage = 0;

        private void tmrChangedImage_Tick_1(object sender, EventArgs e)
        {
            pbxImage.Image = ImageListShow.Images[intImage];
            if (intImage == ImageListShow.Images.Count - 1)
            {
                intImage = 0;
            }
            else
            {
                intImage++;
            }
        }

        // Hàm login cho form
        private void login(string username, string password)
        {
            switch (controller.countAccount(username, password))
            {
                case -1:
                    MessageBox.Show("Lỗi hệ thống",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error); // Lỗi hệ thống
                    break;
                case 0:
                    MessageBox.Show("Tài khoản không có trong hệ thống",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning); // Tài khoản không có trong hệ thống
                    break;
                default:
                    MenuForm menu = new MenuForm(username, controller.getFunctionFromAccount(username));
                    this.Hide();
                    menu.Show();
                    break;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login(txtUsername.Text, txtPassword.Text);
        }

        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Gọi hàm đăng nhập
                login(txtUsername.Text, txtPassword.Text);
            }
        }
    }
}
