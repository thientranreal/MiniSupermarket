﻿using MiniSupermarket.ImageAndFont;
using MiniSupermarket.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSupermarket
{
    public partial class MenuForm : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private List<string> funcs;
        private string userName;
        private Form loginForm;

        // Lưu dictionary cho các forms
        Dictionary<string, Form> forms;


        //Constructor
        public MenuForm(Form loginForm, string username, List<string> funcs)
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.funcs = funcs;
            this.userName = username;
            this.loginForm = loginForm;

            // Khởi tạo giá trị cho dictionary
            forms = new Dictionary<string, Form>();
            forms.Add("Quản lý loại sản phẩm", new ProductTypeManage());
            forms.Add("Quản lý bán hàng", new SaleForm());

            // Ẩn nút chức năng
            foreach (var control in panelMenu.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    Button button = (Button)control;
                    if (button.Text == "Đăng xuất" || button.Text == "Tài khoản")
                    {
                        continue;
                    }
                    button.Visible = false;
                }
            }

            // Chỉ hiển thị những chức năng có trong danh sách chức năng của người dùng
            foreach (string func in funcs)
            {
                switch (func)
                {
                    case "Quản lý sản phẩm":
                        btnProducts.Visible = true;
                        break;
                    case "Quản lý loại sản phẩm":
                        btnProductType.Visible = true;
                        break;
                    case "Quản lý khách hàng":
                        btnCustomers.Visible = true;
                        break;
                    case "Quản lý nhập hàng":
                        btnImport.Visible = true;
                        break;
                    case "Quản lý bán hàng":
                        btnSale.Visible = true;
                        break;
                    case "Quản lý nhân viên":
                        btnEmployees.Visible = true;
                        break;
                    case "Quản lý quyền":
                        btnRoles.Visible = true;
                        break;
                    case "Quản lý chương trình khuyến mãi":
                        btnPromotions.Visible = true;
                        break;
                    case "Quản lý nhà cung cấp":
                        btnSuppliers.Visible = true;
                        break;
                    case "Thống kê":
                        btnStatistic.Visible = true;
                        break;
                }
            }
        }
        // Function dùng để kéo form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        // Hiển thị nút được click
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        // Mở form con từ form menu
        private void OpenChildForm(Form childForm, object btnSender, string title)
        {
            if (activeForm != null)
                activeForm.Hide();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = title;
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Hide();
            Reset();
        }

        private void panelTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void bntMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnProductType_Click(object sender, EventArgs e)
        {
            ProductTypeManage temp = (ProductTypeManage)forms["Quản lý loại sản phẩm"];
            OpenChildForm(temp, sender, "Quản lý loại sản phẩm");
            temp.LoadTheme();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            //OpenChildForm(forms["Quản lý loại sản phẩm"], sender, "Quản lý loại sản phẩm");
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            SaleForm temp = (SaleForm)forms["Quản lý bán hàng"];
            OpenChildForm(temp, sender, "Quản lý bán hàng");
            temp.LoadTheme();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Close();
        }
    }
}