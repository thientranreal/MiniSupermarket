using MiniSupermarket.BUS;
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
    public partial class Supplier : Form
    {
        SupplierBUS supplierBUS = new SupplierBUS();
        DataTable dataSupplier = new DataTable();
        DataTable dataLoaiSanPham = new DataTable();
        public Supplier()
        {
            InitializeComponent();
            textBoxID.ReadOnly = true;
            textBoxTen.ReadOnly = true;
            textBoxSDT.ReadOnly = true;
            textBoxEmail.ReadOnly = true;
            textBoxDiaChi.ReadOnly = true;
            dateTimePickerNgayNhap.Enabled = false;
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            dataSupplier = supplierBUS.getAllFromSupplier();
            dtgvSupplier.DataSource = dataSupplier;
        }

        private void dtgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dtgvSupplier.SelectedRows)
            {
                dataLoaiSanPham = supplierBUS.getAllFromSupplierDetail(row.Cells[0].Value.ToString());
                dtgvLoaiSanPham.DataSource = dataLoaiSanPham;

                textBoxID.Text = row.Cells[0].Value.ToString();
                textBoxTen.Text = row.Cells[1].Value.ToString();
                textBoxDiaChi.Text = row.Cells[2].Value.ToString();
                textBoxSDT.Text = row.Cells[3].Value.ToString();
                textBoxEmail.Text = row.Cells[4].Value.ToString();

            }
        }

        private void dtgvSupplier_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dtgvSupplier.ClearSelection();
        }

        private void dtgvLoaiSanPham_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dtgvLoaiSanPham.ClearSelection();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int count = dtgvSupplier.Rows.Count;
            count = count + 1;
            textBoxID.Text = "S" + count.ToString("D4");

            textBoxTen.ReadOnly = false;
            textBoxSDT.ReadOnly = false;
            textBoxEmail.ReadOnly = false;
            textBoxDiaChi.ReadOnly = false;
            dateTimePickerNgayNhap.Enabled = true;

            btnHuy.Enabled = true;
            btnXacNhan.Enabled = true;
            btnThem.Enabled = false;

            dataLoaiSanPham = supplierBUS.AllProduct();
            dtgvLoaiSanPham.DataSource = dataLoaiSanPham;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (Control c in groupBoxThongTinNCC.Controls)
            {
                if (c.GetType() == typeof(TextBox) && c.Text.Equals(""))
                {
                    count = count + 1;
                    //MessageBox.Show(c.Name);
                }
            }
            if (count == 0)
            {
                supplierBUS.addSupplier(
                    textBoxID.Text,
                    textBoxTen.Text,
                    textBoxDiaChi.Text,
                    textBoxSDT.Text,
                    textBoxEmail.Text
                    );
                foreach (DataGridViewRow row in dtgvLoaiSanPham.SelectedRows)
                {
                    supplierBUS.AddDetailSupplier(textBoxID.Text, row.Cells[0].Value.ToString(), dateTimePickerNgayNhap.Value.ToString());
                }

                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK);
                btnHuy.Enabled = false;
                btnXacNhan.Enabled = false;
                btnThem.Enabled = true;

                dataSupplier = supplierBUS.getAllFromSupplier();
                dtgvSupplier.DataSource = dataSupplier;
            }
            else
            {
                MessageBox.Show("Không được bỏ trống thông tin");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            textBoxID.ReadOnly = true;
            textBoxTen.ReadOnly = true;
            textBoxSDT.ReadOnly = true;
            textBoxEmail.ReadOnly = true;
            textBoxDiaChi.ReadOnly = true;
            dateTimePickerNgayNhap.Enabled = false;

            btnHuy.Enabled = false;
            btnXacNhan.Enabled = false;
            btnThem.Enabled = true;

            foreach (Control c in groupBoxThongTinNCC.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    c.Text = "";
                }
            }

            dataSupplier = supplierBUS.getAllFromSupplier();
            dtgvSupplier.DataSource = dataSupplier;

            dataLoaiSanPham = null;
            dtgvLoaiSanPham.DataSource = dataLoaiSanPham;
        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            
                if (dtgvSupplier.SelectedRows.Count==0)
                {
                    MessageBox.Show("Chọn nhà cung cấp trước khi thêm loại sản phẩm","Thông báo",MessageBoxButtons.OK);
                }
                else
                {
                    btnXacNhanLoai.Enabled = true;
                    btnHuyThemLoai.Enabled = true;
                    btnThemLoai.Enabled = false;

                    dateTimePickerNgayNhap.Enabled = true;

                    dataLoaiSanPham = supplierBUS.AllProduct();
                    dtgvLoaiSanPham.DataSource = dataLoaiSanPham;
                }
            

        }

        private void btnXacNhanLoai_Click(object sender, EventArgs e)
        {
           
                if (dtgvLoaiSanPham.SelectedRows.Count==0)
                {
                    MessageBox.Show("Bạn chưa chọn loại sản phẩm cần thêm");
                }
                else
                {
                    foreach(DataGridViewRow rows in dtgvLoaiSanPham.SelectedRows)
                    {
                    supplierBUS.AddDetailSupplier(textBoxID.Text, rows.Cells[0].Value.ToString(), dateTimePickerNgayNhap.Value.ToString());
                    }
                }
            
        }
    }
}
