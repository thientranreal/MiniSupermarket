using MiniSupermarket.BUS;
using MiniSupermarket.ImageAndFont;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSupermarket.GUI
{
    public partial class PurchaseOderForm : Form
    {
        private PurchaseOrderBUS bus = new PurchaseOrderBUS();
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

            btnUpdate.BackColor = ThemeColor.PrimaryColor;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

            btnPrintOrder.BackColor = ThemeColor.PrimaryColor;
            btnPrintOrder.ForeColor = Color.White;
            btnPrintOrder.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

            btnReset.BackColor = ThemeColor.PrimaryColor;
            btnReset.ForeColor = Color.White;
            btnReset.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

            cbxTypeSearch.SelectedIndex = 0;
            dgvPurchaseOders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            txtOrderID.ReadOnly = true;

        }

        private void PurchaseOderForm_Load(object sender, EventArgs e)
        {
            LoadTheme();
            HienThiPhieuNhap();
            BindingSource binding = new BindingSource();
            binding.DataSource = bus.getPurchaseOrders();
            dgvPurchaseOders.DataSource = binding;
            txtOrderID.DataBindings.Add("Text", binding, "OrderID");
            cbxSupplier.DataBindings.Add("Text", binding, "Name1");
            ShowComboboxSupplier();
        }

        private void HienThiPhieuNhap()
        {
            dgvPurchaseOders.Rows.Clear();
            dgvPurchaseOders.DataSource = bus.getPurchaseOrders();
        }

        public void ShowComboboxSupplier()
        {
            DataTable dt = bus.getSuppliers();
            cbxSupplier.DataSource = dt;
            cbxSupplier.DisplayMember = "Name";
            cbxSupplier.ValueMember = "SupplierID";
        }

        public void setNull()
        {
            txtOrderID.Text = "";
            txtSearch.Text = "";
            cbxSupplier.SelectedIndex = 0;
            cbxTypeSearch.SelectedIndex = 0;
        }

        private void dgvPurchaseOders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dgvPurchaseOders.Rows[rowIndex];
            string promotionID = row.Cells[0].Value.ToString();
            string status = row.Cells[5].Value.ToString();
            DetailPurchaseOrderForm form = new DetailPurchaseOrderForm(promotionID, status);
            form.ShowDialog();
        }

        private void btnAddPurchaseOder_Click(object sender, EventArgs e)
        {
            string OrderID = txtOrderID.Text;
            string SupplierID = cbxSupplier.SelectedValue.ToString();
            if (OrderID.Length != 0)
            {
                MessageBox.Show("Vui lòng không chọn phiếu nhập! Chọn nút tải lại",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
            DialogResult choice = MessageBox.Show($"Bạn có muốn nhập hàng từ nhà cung cấp {cbxSupplier.Text} không?", "Tạo phiếu nhập", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)
            {
                if (bus.InsertPurchaseOrder(SupplierID))
                {
                    MessageBox.Show("Tạo phiếu nhập thành công", "Tạo thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setNull();
                    return;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string OrderID = txtOrderID.Text;
            string SupplierID = cbxSupplier.SelectedValue.ToString();
            if (OrderID.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập muốn sửa",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
            if (bus.UpdatePurchaseOrder(OrderID, SupplierID))
            {
                MessageBox.Show("Sửa phiếu nhập thành công", "Sửa thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                setNull();
                return;
            }
        }

        private void btnDeletePurchaseOder_Click(object sender, EventArgs e)
        {
            string OrderID = txtOrderID.Text;
            if (OrderID.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập muốn xoá",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
            DialogResult choice = MessageBox.Show($"Bạn có muốn xoá phiếu nhập {OrderID} không?", "Xoá phiếu nhập", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)
            {
                if (bus.DeletePurchaseOrder(OrderID))
                {
                    MessageBox.Show("Xoá phiếu nhập thành công", "Xoá thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setNull();
                    return;
                }
            }
            
        }
    }
}
