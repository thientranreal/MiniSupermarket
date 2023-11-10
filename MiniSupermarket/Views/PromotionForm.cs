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

namespace MiniSupermarket.Views
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
            dgvPromotions.DataSource = promotionBUS.getAllPromotions();
            BindingPromotions();
            LoadTheme();
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
        }
        public void BindingPromotions()
        {
            BindingSource binding = new BindingSource();
            binding.DataSource = promotionBUS.getAllPromotions();
            dgvPromotions.DataSource = binding;
            txtPromotionID.DataBindings.Add("Text", binding, "ID");
            txtPromotionName.DataBindings.Add("Text", binding, "Name");
            dtpkStartDate.DataBindings.Add("Value", binding, "StartDate");
            dtpkEndDate.DataBindings.Add("Value", binding, "EndDate");
            txtDiscount.DataBindings.Add("Text", binding, "Discount");
        }
    }
}
