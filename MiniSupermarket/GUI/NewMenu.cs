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
        public NewMenu()
        {
            InitializeComponent();
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
        }
        bool expandMenu = true;
        private void menuTimer_Tick(object sender, EventArgs e)
        {
            if (expandMenu)
            {
                menuPanel.Width -= 10;
                if (menuPanel.Width <= 40)
                {

                    menuTimer.Stop();
                    expandMenu = false;
                }


            }
            else
            {
                menuPanel.Width += 10;
                if (menuPanel.Width >= 200)
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
    }
}
