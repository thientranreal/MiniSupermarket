using MiniSupermarket.BUS;
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

namespace MiniSupermarket.GUI
{
    public partial class DetailPurchaseOrderForm : Form
    {
        private string purchaseOrderID;
        private DetailPurchaseOrderBUS bus = new DetailPurchaseOrderBUS();
        public DetailPurchaseOrderForm(string PurchaseOrderID)
        {
            InitializeComponent();
            purchaseOrderID = PurchaseOrderID;
        }

        private void DetailPurchaseOrderForm_Load(object sender, EventArgs e)
        {
            lblProductOrder.Text = lblProductOrder.Text + " " + purchaseOrderID;
            ShowProducts();
            LoadTheme();
            nudQuantity.Value = 0;
            txtProductID.ReadOnly = true;
            txtProductName.ReadOnly = true;
            dgvProductOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        void LoadTheme()
        {
            foreach (Control controls in this.pnlInformation.Controls)
            {
                if (controls.GetType() == typeof(Label))
                {
                    Label lb = (Label)controls;
                    lb.ForeColor = ThemeColor.SecondaryColor;
                    lb.Font = ProjectFont.getNormalFont();
                }

                else if (controls.GetType() == typeof(Button))
                {
                    Button btn = (Button)controls;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
                lblProduct.Font = ProjectFont.getTitleFont();
                lblProductOrder.Font = ProjectFont.getTitleFont();
            }
        }

        public void ShowProducts()
        {
            dgvProducts.DataSource = bus.getProducts(purchaseOrderID);
            dgvProductOrders.DataSource = bus.getProductOrders(purchaseOrderID);
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProducts_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dgvProducts.SelectedRows[0];
            txtProductID.Text = row.Cells[0].Value.ToString();
            txtProductName.Text = row.Cells[1].Value.ToString();
            txtOrderPrice.Text = "";
            nudQuantity.Value = 0;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtProductID.Text = "";
            txtProductName.Text = "";
            txtOrderPrice.Text = "";
            nudQuantity.Value = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string orderID = purchaseOrderID;
            string productID = txtProductID.Text;
            string orderPrice = txtOrderPrice.Text;
            string quantity = nudQuantity.Value.ToString();
            
        }
    }
}
