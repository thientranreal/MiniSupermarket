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
    public partial class PurchaseOderForm : Form
    {
        private PurchaseOderBUS bus = new PurchaseOderBUS();
        public PurchaseOderForm()
        {
            InitializeComponent();
        }

        void LoadTheme()
        {
            lblTitle.ForeColor = ThemeColor.SecondaryColor;
            lblTitle.Font = ProjectFont.getTitleFont();
            lblSupplier.ForeColor = ThemeColor.SecondaryColor;
            lblSupplier.Font = ProjectFont.getNormalFont();
            lblPurchaseOderID.ForeColor = ThemeColor.SecondaryColor;
            lblPurchaseOderID.Font = ProjectFont.getNormalFont();
            btnAddPurchaseOder.BackColor = ThemeColor.PrimaryColor;
            btnAddPurchaseOder.ForeColor = Color.White;
            btnAddPurchaseOder.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            btnDeletePurchaseOder.BackColor = ThemeColor.PrimaryColor;
            btnDeletePurchaseOder.ForeColor = Color.White;
            btnDeletePurchaseOder.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            btnPay.BackColor = ThemeColor.PrimaryColor;
            btnPay.ForeColor = Color.White;
            btnPay.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

        }

        private void PurchaseOderForm_Load(object sender, EventArgs e)
        {
            LoadTheme();
            HienThiPhieuNhap();
        }

        private void HienThiPhieuNhap()
        {
            dgvPurchaseOders.Rows.Clear();
            dgvPurchaseOders.DataSource = bus.getAllPurchaseOder();
        }

        private void dgvPurchaseOders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dgvPurchaseOders.Rows[rowIndex];
            string promotionID = row.Cells["OrderID"].Value.ToString();
            DetailPurchaseOrderForm form = new DetailPurchaseOrderForm(promotionID);
            form.ShowDialog();
        }
    }
}
