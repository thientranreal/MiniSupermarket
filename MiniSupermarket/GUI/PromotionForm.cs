using MiniSupermarket.BUS;
using MiniSupermarket.ImageAndFont;
using MiniSupermarket.RegularExpression;
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
    public partial class PromotionForm : Form
    {
        PromotionBUS promotionBUS = new PromotionBUS();
        public PromotionForm()
        {
            InitializeComponent();
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
        }

        public void LoadTheme()
        {
            // Thêm màu cho tất cả các nút ở panel top
            foreach (Control btns in this.pnlInformation.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
                else if (btns.GetType() == typeof(Label))
                {
                    Label lb = (Label)btns;
                    lb.ForeColor = ThemeColor.SecondaryColor;
                    lb.Font = ProjectFont.getNormalFont();
                }
            }

            // Thêm màu cho group box tìm kiếm
            foreach (Control control in this.grbPriceFilter.Controls)
            {
                // Nếu control là label thì thêm màu và chỉnh font
                if (control.GetType() == typeof(Label))
                {
                    Label lb = (Label)control;
                    lb.ForeColor = ThemeColor.SecondaryColor;
                    lb.Font = ProjectFont.getNormalFont();
                }

            }
            foreach (Control control in this.grbDateFilter.Controls)
            {
                // Nếu control là label thì thêm màu và chỉnh font
                if (control.GetType() == typeof(Label))
                {
                    Label lb = (Label)control;
                    lb.ForeColor = ThemeColor.SecondaryColor;
                    lb.Font = ProjectFont.getNormalFont();
                }
            }
            lblTitle.Font = ProjectFont.getTitleFont();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void PromotionForm_Load(object sender, EventArgs e)
        {
            dgvPromotions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPromotions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPromotions.ReadOnly = true;
            //dgvPromotions.Columns["PromotionID"].HeaderText = "Mã CTKM";
            //dgvPromotions.Columns["Name"].HeaderText = "Tên CTKM";
            //dgvPromotions.Columns["StartDate"].HeaderText = "Ngày bắt đầu";
            //dgvPromotions.Columns["EndDate"].HeaderText = "Ngày kết thúc";
            //dgvPromotions.Columns["Giảm"].HeaderText = "Giảm (%)";
            //dgvPromotions.Columns["Status"].HeaderText = "Trạng thái";
            LoadTheme();
            SetNull();
            cbxTypeOfSearch.Text = "Mã CTKM";
        }

        public void ShowPromotion()
        {
            dgvPromotions.DataSource = null;
            dgvPromotions.DataSource = promotionBUS.getAllPromotions();
        }

        void SetNull()
        {
            ShowPromotion();
            BindingPromotions();
            txtPromotionID.Clear();
            txtPromotionName.Clear();
            txtDiscount.Clear();
            dtpkStartDate.Value = DateTime.Now;
            dtpkEndDate.Value = DateTime.Now;
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
        }
        public void BindingPromotions()
        {
            txtPromotionID.DataBindings.Clear();
            txtPromotionName.DataBindings.Clear();
            dtpkStartDate.DataBindings.Clear();
            dtpkEndDate.DataBindings.Clear();
            txtDiscount.DataBindings.Clear();
            BindingSource binding = new BindingSource();
            binding.DataSource = promotionBUS.getAllPromotions();
            dgvPromotions.DataSource = binding;

            txtPromotionID.DataBindings.Add("Text", binding, "ID");
            txtPromotionName.DataBindings.Add("Text", binding, "Name");
            dtpkStartDate.DataBindings.Add("Value", binding, "StartDate");
            dtpkEndDate.DataBindings.Add("Value", binding, "EndDate");
            txtDiscount.DataBindings.Add("Text", binding, "Discount");
        }

        private void dgvPromotions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dgvPromotions.Rows[rowIndex];
            string promotionID = row.Cells["ID"].Value.ToString();
            DetailPronmotionForm form = new DetailPronmotionForm(promotionID);
            form.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Name = txtPromotionName.Text.Trim();
            string StartDate = String.Format("{0:dd/MM/yyyy}", dtpkStartDate.Value);
            string EndDate = String.Format("{0:dd/MM/yyyy}", dtpkEndDate.Value);
            string Discount = txtDiscount.Text.Trim();
            if (txtPromotionID.Text.Length != 0)
            {
                MessageBox.Show("Vui lòng để trống mã chương trình khuyến mãi! Chọn tải lại để xoá",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
            if (Name.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên chương trình khuyến mãi",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                txtPromotionName.Focus();
                return;
            }
            if (Discount.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập phần trăm giảm của chương trình khuyến mãi",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                txtDiscount.Focus();
                return;
            }
            if (!ProjectRegex.checkDayAfterDay(StartDate, EndDate))
            {
                MessageBox.Show("Ngày kết thúc phải sau ngày bắt đầu",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToInt32(Discount) > 100 || Convert.ToInt32(Discount) < 1)
            {
                MessageBox.Show("Phần trăm giảm không hợp lệ! Hợp lệ trong khoảng 1 đến 100",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                txtDiscount.Focus();
                return;
            }
            if (promotionBUS.insertPromotion(Name, StartDate, EndDate, Discount))
            {
                MessageBox.Show("Thêm chương trình khuyến mãi thành công", "Thêm thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetNull();
                return;
            }
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) || !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SetNull();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string ID = txtPromotionID.Text;
            string Name = txtPromotionName.Text.Trim();
            string StartDate = String.Format("{0:dd/MM/yyyy}", dtpkStartDate.Value);
            string EndDate = String.Format("{0:dd/MM/yyyy}", dtpkEndDate.Value);
            string Discount = txtDiscount.Text.Trim();
            if (ID.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn chương trình khuyến mãi",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
            if (Name.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên chương trình khuyến mãi",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                txtPromotionName.Focus();
                return;
            }
            if (Discount.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập phần trăm giảm của chương trình khuyến mãi",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                txtDiscount.Focus();
                return;
            }
            if (!ProjectRegex.checkDayAfterDay(StartDate, EndDate))
            {
                MessageBox.Show("Ngày kết thúc phải sau ngày bắt đầu",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToInt32(Discount) > 100 || Convert.ToInt32(Discount) < 1)
            {
                MessageBox.Show("Phần trăm giảm không hợp lệ! Hợp lệ trong khoảng 1 đến 100",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                txtDiscount.Focus();
                return;
            }
            if (promotionBUS.updatePromotion(ID, Name, StartDate, EndDate, Discount))
            {
                MessageBox.Show("Sửa thông tin chương trình khuyến mãi thành công", "Xoá thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetNull();
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string ID = txtPromotionID.Text;
            if (ID.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn chương trình khuyến mãi",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
            DialogResult choice = MessageBox.Show($"Bạn có muốn chắc muốn xoá chương trình khuyến mãi {ID} không?", "Xoá chương trình khuyến mãi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)
            {
                if (promotionBUS.deletePromotion(ID))
                {
                    MessageBox.Show("Xoá chương trình khuyến mãi thành công", "Xoá thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    promotionBUS.clearAllProductsFromPromotion(ID);
                    SetNull();
                    return;
                }
            }

        }

        private void btnStartWork_Click(object sender, EventArgs e)
        {
            string ID = txtPromotionID.Text;
            if (ID.Length == 0 || dgvPromotions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn chương trình khuyến mãi",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
            DataGridViewRow row = dgvPromotions.SelectedRows[0];
            string status = row.Cells["Status"].Value.ToString();
            string startDate = String.Format("{0:dd/MM/yyyy}", row.Cells["StartDate"].Value);
            string endDate = String.Format("{0:dd/MM/yyyy}", row.Cells["EndDate"].Value);
            if (status.Equals("Đang hoạt động"))
            {
                MessageBox.Show("Chương trình khuyến mãi này đang hoạt động",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
            if (!ProjectRegex.checkDayBelongDay(startDate, endDate))
            {
                MessageBox.Show("Chương trình khuyến mãi này không trong thời gian được hoạt động",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
            if (promotionBUS.startWorkPromotion(ID))
            {
                MessageBox.Show("Chương trình khuyến mãi bắt đầu hoạt động", "Hoạt động chương trình khuyến mãi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowPromotion();
                SetNull();
                return;
            }
        }

        private void btnStopWork_Click(object sender, EventArgs e)
        {
            string ID = txtPromotionID.Text;
            if (ID.Length == 0 || dgvPromotions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn chương trình khuyến mãi",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
            DataGridViewRow row = dgvPromotions.SelectedRows[0];
            string status = row.Cells["Status"].Value.ToString();
            if (status.Equals("Không hoạt động"))
            {
                MessageBox.Show("Chương trình khuyến mãi này không hoạt động",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
            DialogResult choice = MessageBox.Show($"Bạn có chắc muốn ngưng áp dụng chương trình khuyến mãi {ID} không", "Ngưng hoạt động chương trình khuyến mãi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)
            {
                if (promotionBUS.stopWorkPromotion(ID))
                {
                    MessageBox.Show("Chương trình khuyến mãi ngưng hoạt động thành công", "Ngưng hoạt động chương trình khuyến mãi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowPromotion();
                    SetNull();
                    return;
                }
            }
        }


        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            if (search.Length == 0)
            {
                dgvPromotions.DataSource = promotionBUS.getAllPromotions();
            }
            else
            {
                if (cbxTypeOfSearch.SelectedIndex == 0)
                {
                    dgvPromotions.DataSource = promotionBUS.SearchPromotionsByID(search);
                }
                if (cbxTypeOfSearch.SelectedIndex == 1)
                {
                    dgvPromotions.DataSource = promotionBUS.SearchPromotionsByName(search);
                }
            }
        }
    }
}
