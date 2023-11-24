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
using MiniSupermarket.RegularExpression;
using MiniSupermarket.CustomControl;
using System.Diagnostics.Metrics;

namespace MiniSupermarket.GUI
{
    public partial class NCCForm : Form
    {
        private SupplierBUS supplierBUS = new SupplierBUS();
        DataTable dtSupplier = new DataTable();
        DataTable dtSupplierDetail = new DataTable();
        DataTable dtProduct = new DataTable();


        public NCCForm()
        {
            InitializeComponent();


            txtID.ReadOnly1 = true;
            txtTen.ReadOnly1 = true;
            txtDiaChi.ReadOnly1 = true;
            txtSDT.ReadOnly1 = true;
            txtEmail.ReadOnly1 = true;
            dateTimePickerNgayNhap.Enabled = false;



        }
        private void ketnoicsdl()
        {
            dtSupplier = supplierBUS.getAllFromSupplier();
            dataGridViewNCC.DataSource = dtSupplier;
        }


        private void NCCForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            ketnoicsdl();

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
            dataGridViewLoaiSanPham.DataSource = null;
            dtSupplier = supplierBUS.getAllFromSupplier();
            dataGridViewNCC.DataSource = dtSupplier;
            txtTimKiem.Text = "";
            comboBox1.Text = "";
            foreach (Control c in panelThongTinNhaCungCap.Controls)
            {
                if (c.GetType() == typeof(CustomTextBox))
                {
                    c.Text = "";
                }
            }
            dateTimePickerNgayNhap.Value = DateTime.Now;

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string selected = comboBox1.Text;
            switch (selected)
            {
                case "ID":
                    dtSupplier = supplierBUS.getSupplierWithIDFromSupplier(txtTimKiem.Text);
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

        private void panelThongTinNhaCungCap_Resize(object sender, EventArgs e)
        {

        }

        private void NCCForm_Resize(object sender, EventArgs e)
        {

        }

        private void NCCForm_SizeChanged(object sender, EventArgs e)
        {

        }
        private string id;
        private void btnThem_Click(object sender, EventArgs e)
        {
            dtProduct = supplierBUS.AllProduct();
            dataGridViewLoaiSanPham.DataSource = dtProduct;

            txtTen.ReadOnly1 = false;
            txtDiaChi.ReadOnly1 = false;
            txtSDT.ReadOnly1 = false;
            txtEmail.ReadOnly1 = false;
            dateTimePickerNgayNhap.Enabled = true;

            btnConfirm.Enabled = true;
            btnThem.Enabled = false;
            btnHuy.Enabled = true;

            foreach (Control c in panelThongTinNhaCungCap.Controls)
            {
                if (c.GetType() == typeof(CustomTextBox))
                {
                    c.Text = "";
                }
            }

            count = dataGridViewNCC.Rows.Count + 1;
            id = "S" + count.ToString("D4");
            txtID.Text = id;

        }

        private void dataGridViewNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewNCC.SelectedRows)
            {
                dtSupplierDetail = supplierBUS.getAllFromSupplierDetail(row.Cells[0].Value.ToString());
                dataGridViewLoaiSanPham.DataSource = dtSupplierDetail;
                DataGridViewRow rows = dataGridViewLoaiSanPham.Rows[0];
                txtID.Text = row.Cells[0].Value.ToString();
                txtTen.Text = row.Cells[1].Value.ToString();
                txtDiaChi.Text = row.Cells[2].Value.ToString();
                txtSDT.Text = row.Cells[3].Value.ToString();
                txtEmail.Text = row.Cells[4].Value.ToString();
                dateTimePickerNgayNhap.Text = rows.Cells[1].Value.ToString();
            }
        }

        private void dataGridViewNCC_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewNCC.ClearSelection();
        }

        private void dataGridViewLoaiSanPham_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewLoaiSanPham.ClearSelection();
        }

        private void dataGridViewLoaiSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            supplierBUS.delSupplier(txtID.Text);
            foreach (Control c in panelThongTinNhaCungCap.Controls)
            {
                if (c.GetType() == typeof(CustomTextBox))
                {
                    c.Text = "";
                }
            }
            dateTimePickerNgayNhap.Value = DateTime.Now;
            dataGridViewLoaiSanPham.DataSource = null;
            ketnoicsdl();
        }

        private void txtID_EnabledChanged(object sender, EventArgs e)
        {

        }


        private string name;
        private string address;
        private string phoneNumber;
        private string email;
        private string productId;
        private string date;
        private int count;

        private void btnConfirm_Click(object sender, EventArgs e)
        {


            name = txtTen.Text;

            address = txtDiaChi.Text;



            if (ProjectRegex.IsPhoneNumber(txtSDT.Text) == true)
            {
                phoneNumber = txtSDT.Text;
            }
            else
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
            }

            if (ProjectRegex.IsEmail(txtEmail.Text) == true)
            {
                email = txtEmail.Text;
            }
            else
            {
                MessageBox.Show("Email không hợp lệ ");
            }
            foreach (DataGridViewRow row in dataGridViewLoaiSanPham.SelectedRows)
            {
                productId = row.Cells[0].Value.ToString();
            }
            date = dateTimePickerNgayNhap.Value.ToString();

            int count1 = 4;
            foreach (Control c in panelThongTinNhaCungCap.Controls)
            {
                if (c.GetType() == typeof(CustomTextBox))
                {
                    if (c.Text.Equals(""))
                    {
                        count1 = count1 - 1;
                    }
                }
            }

            if (count1 == 4)
            {

                if (supplierBUS.addSupplier(id, name, address, phoneNumber, email, productId, date) == true)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnThem.Enabled = true;
                    btnConfirm.Enabled = false;
                    btnHuy.Enabled = false;
                    ketnoicsdl();
                }
            }
            else
            {
                MessageBox.Show("Không được bỏ trống thông tin ", "Thông báo", MessageBoxButtons.OK);
            }



        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có muốn hủy?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foreach (Control c in panelThongTinNhaCungCap.Controls)
                {
                    if (c.GetType() == typeof(CustomTextBox))
                    {
                        c.Text = "";
                    }
                }
                dataGridViewLoaiSanPham.DataSource = null;
                btnConfirm.Enabled = false;
                btnHuy.Enabled = false;
                btnThem.Enabled = true;
            }

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }
    }
}
