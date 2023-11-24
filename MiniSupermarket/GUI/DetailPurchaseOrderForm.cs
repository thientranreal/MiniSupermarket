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
                lblProduct.Font = ProjectFont.getTitleFont();
                lblProductOrder.Font = ProjectFont.getTitleFont();
            }
        }

        public void ShowProducts()
        {
            dgvProducts.DataSource = bus.getProducts();
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
    }
}
