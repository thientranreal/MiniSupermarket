using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSupermarket.GUI
{
    public partial class NewMenu : Form
    {
        NCCForm formNCC;
        public NewMenu()
        {
            InitializeComponent();
            mdiProp();
        }
        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }

        private void menuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sanphamTimer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void NewMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            menuTimer.Start();
            if (expandSanPham == true && expandMenu == true)
            {
                sanphamTimer.Start();
            }
            if (expandNCC == true && expandMenu == true)
            {
                nccTimer.Start();
            }
            if (expandNhanVien == true && expandMenu == true)
            {
                nhanvienTimer.Start();
            }
        }
        bool expandMenu = true;
        private void menuTimer_Tick(object sender, EventArgs e)
        {
            if (expandMenu)
            {
                menuPanel.Width -= 10;
                if (menuPanel.Width <= 60)
                {

                    menuTimer.Stop();
                    expandMenu = false;
                }


            }
            else
            {
                menuPanel.Width += 10;
                if (menuPanel.Width >= 300)
                {
                    menuTimer.Stop();
                    expandMenu = true;
                }
            }
        }
        bool expandSanPham = false;
        private void sanphamTimer_Tick(object sender, EventArgs e)
        {
            if (expandSanPham == false)
            {
                panelSanPham.Height += 10;
                if (panelSanPham.Height >= 150)
                {
                    sanphamTimer.Stop();
                    expandSanPham = true;
                }
            }
            else
            {
                panelSanPham.Height -= 10;
                if (panelSanPham.Height <= 50)
                {
                    sanphamTimer.Stop();
                    expandSanPham = false;
                }
            }
        }
        bool expandNCC = false;
        private void nccTimer_Tick(object sender, EventArgs e)
        {
            if (expandNCC == false)
            {
                panelNCC.Height += 10;
                if (panelNCC.Height >= 150)
                {
                    nccTimer.Stop();
                    expandNCC = true;
                }
            }
            else
            {
                panelNCC.Height -= 10;
                if (panelNCC.Height <= 50)
                {
                    nccTimer.Stop();
                    expandNCC = false;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            nccTimer.Start();
        }
        bool expandNhanVien = false;
        private void nhanvienTimer_Tick(object sender, EventArgs e)
        {
            if (expandNhanVien == false)
            {
                panelNhanVien.Height += 10;
                if (panelNhanVien.Height >= 150)
                {
                    expandNhanVien = true;
                    nhanvienTimer.Stop();
                }
            }
            else
            {
                panelNhanVien.Height -= 10;
                if (panelNhanVien.Height <= 50)
                {
                    expandNhanVien = false;
                    nhanvienTimer.Stop();
                }
            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            nhanvienTimer.Start();
        }

        private void btnThongTinNCC_Click(object sender, EventArgs e)
        {
            if (formNCC == null)
            {
                formNCC = new NCCForm();
                formNCC.FormClosed += FormNCC_FormClosed;
                formNCC.MdiParent = this;
                formNCC.Dock = DockStyle.Fill;
                formNCC.Show();
            }
            else
            {
                formNCC.Activate();
            }
        }

        private void FormNCC_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formNCC = null;
        }
    }
}
