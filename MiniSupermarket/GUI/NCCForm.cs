using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using MiniSupermarket.BUS;

namespace MiniSupermarket.GUI
{
    public partial class NCCForm : Form
    {
        private SupplierBUS supplierBUS = new SupplierBUS();
        DataTable dtSupplier = new DataTable();
        DataTable dtSupplierDetail = new DataTable();
        public NCCForm()
        {
            InitializeComponent();


        }



        private void NCCForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            dtSupplier = supplierBUS.getAllFromSupplier();
            dataGridViewNCC.DataSource = dtSupplier;
            dtSupplierDetail = supplierBUS.getAllFromSupplierDetail();
            dataGridViewLoaiSanPham.DataSource = dtSupplierDetail;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTitleThongTinNCC_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            dtSupplier = supplierBUS.getAllFromSupplier();
            dataGridViewNCC.DataSource = dtSupplier;
            txtTimKiem.Texts = "";
            comboBox1.Text = "";

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string selected = comboBox1.Text;
            switch (selected)
            {
                case "ID":
                    dtSupplier = supplierBUS.getSupplierWithIDFromSupplier(txtTimKiem.Texts);
                    dataGridViewNCC.DataSource = dtSupplier;
                    btnLoad.Focus();

                    break;
            }

        }

        private void NCCForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                btnLoad.PerformClick();
            }
        }
    }
}
