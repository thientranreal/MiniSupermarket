using MiniSupermarket.Views;
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
    public partial class MenuForm : Form
    {
        Form currentForm;

        String TreeViewVisible = "";

        TreeView treeView;
        TabControl tabControl;

        // Tạo các TabPage
        TabPage tabProStorageManage = new TabPage("Quản lý sản phẩm và kho hàng");
        TabPage tabCustomerSellManage = new TabPage("Quản lý khách hàng và bán hàng");
        TabPage tabEmployeeRoleManage = new TabPage("Quản lý nhân viên và quyền");
        TabPage tabStatistic = new TabPage("Thống kê");
        //

        public MenuForm()
        {
            InitializeComponent();
            treeView = new TreeView();
            treeView.Dock = DockStyle.Fill;
            // Form ở giữa màn hình, không cho resize, và để autosize, chứa form con
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            //
            
            InitializeTabControl();
        }
        // Tao cac tab control
        private void InitializeTabControl()
        {
            // Tạo TabControl
            tabControl = new TabControl();
            tabControl.Dock = DockStyle.Fill;

            // Thêm các TabPage vào TabControl
            tabControl.TabPages.Add(tabProStorageManage);
            tabControl.TabPages.Add(tabCustomerSellManage);
            tabControl.TabPages.Add(tabEmployeeRoleManage);
            tabControl.TabPages.Add(tabStatistic);
            //

            // Thêm TabControl vào panel top
            pnl_top.Controls.Add(tabControl);

            // Thêm sự kiện click cho tab control
            tabControl.Click += TabPageClickHandler;


        }

        private void TreeViewHandler(object sender, TreeViewEventArgs e)
        {
            // Nếu form hiện tại tồn tại thì đóng form đó lại để tạo form mới
            if (currentForm != null)
            {
                currentForm.Close();
            }
            switch (e.Node.Text)
            {
                case "Quản lý loại sản phẩm":
                    currentForm = new ProductTypeManage();
                    showCurrentForm();
                    break;
            }
        }

        private void TabPageClickHandler(object sender, EventArgs e)
        {
            treeView.Nodes.Clear();
            TabPage selectedTab = tabControl.SelectedTab;
            // Thêm các node tương ứng với từng TabPage
            switch (selectedTab.Text)
            {
                case "Quản lý sản phẩm và kho hàng":
                    if (TreeViewVisible != "Quản lý sản phẩm và kho hàng")
                    {
                        // Tạo TreeView cho tabProStorageManage
                        treeView.Nodes.Add("Quản lý sản phẩm");
                        treeView.Nodes.Add("Quản lý loại sản phẩm");
                        treeView.Nodes.Add("Quản lý kho hàng");
                        treeView.Nodes.Add("Quản lý nhà cung cấp");
                        tabProStorageManage.Controls.Add(treeView);
                        TreeViewVisible = "Quản lý sản phẩm và kho hàng";
                    }
                    else // Nếu mà chọn lại tab này thì sẽ xóa treeview
                    {
                        tabProStorageManage.Controls.Remove(treeView);
                        TreeViewVisible = "";
                    }
                    break;

                case "Quản lý khách hàng và bán hàng":
                    if (TreeViewVisible != "Quản lý khách hàng và bán hàng")
                    {
                        // Tạo TreeView cho tabCustomerSellManage
                        treeView.Nodes.Add("Quản lý khách hàng");
                        treeView.Nodes.Add("Quản lý bán hàng");
                        treeView.Nodes.Add("Quản lý chương trình khuyến mãi");
                        tabCustomerSellManage.Controls.Add(treeView);
                        TreeViewVisible = "Quản lý khách hàng và bán hàng";
                    }
                    else
                    {
                        tabCustomerSellManage.Controls.Remove(treeView);
                        TreeViewVisible = "";
                    }
                    break;

                case "Quản lý nhân viên và quyền":
                    if (TreeViewVisible != "Quản lý nhân viên và quyền")
                    {
                        // Tạo TreeView cho tabEmployeeRoleManage
                        treeView.Nodes.Add("Quản lý nhân viên");
                        treeView.Nodes.Add("Quản lý nhóm quyền");
                        tabEmployeeRoleManage.Controls.Add(treeView);
                        TreeViewVisible = "Quản lý nhân viên và quyền";
                    }
                    else
                    {
                        tabEmployeeRoleManage.Controls.Remove(treeView);
                        TreeViewVisible = "";
                    }
                    break;

                case "Thống kê":
                    if (TreeViewVisible != "Thống kê")
                    {
                        // Tạo TreeView cho tabCustomerSellManage
                        treeView.Nodes.Add("Thống kê sản phẩm bán chạy");
                        treeView.Nodes.Add("Thống kê doanh thu, lợi nhuận");
                        tabStatistic.Controls.Add(treeView);
                        TreeViewVisible = "Thống kê";
                    }
                    else
                    {
                        tabStatistic.Controls.Remove(treeView);
                        TreeViewVisible = "";
                    }
                    break;
            }
            // Sự kiện click cho quản lý loại sản phẩm
            treeView.AfterSelect += TreeViewHandler;
        }

        private void showCurrentForm()
        {
            currentForm.MdiParent = this;
            pnl_feature.Controls.Add(currentForm);
            currentForm.Dock = DockStyle.Fill;
            currentForm.FormBorderStyle = FormBorderStyle.None;
            currentForm.Show();
        }
    }
}
