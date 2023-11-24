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
        public DetailPurchaseOrderForm(string PurchaseOrderID)
        {
            InitializeComponent();
            purchaseOrderID = PurchaseOrderID;
        }

        private void DetailPurchaseOrderForm_Load(object sender, EventArgs e)
        {
            lblProductOrder.Text = lblProductOrder.Text +" "+ purchaseOrderID;
        }
    }
}
