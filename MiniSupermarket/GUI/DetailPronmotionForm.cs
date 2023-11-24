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
    public partial class DetailPronmotionForm : Form
    {
        private DetailPromotionBUS bus = new DetailPromotionBUS();
        private string promotionID;
        public DetailPronmotionForm(string PromotionID)
        {
            InitializeComponent();
            promotionID = PromotionID;
        }

        private void DetailPronmotionForm_Load(object sender, EventArgs e)
        {
            lblTitlePromotion.Text = lblTitlePromotion.Text + " " + promotionID;
            lblTitlePromotion.Font = ProjectFont.getTitleFont();
            lblTitleProduct.Font = ProjectFont.getTitleFont();
            dgvProductPromotions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ShowListProduct();
        }

        public void ShowListProduct()
        {
            dgvProductPromotions.DataSource = bus.getProductPromotions(promotionID);
            dgvProducts.DataSource = bus.getProducts(promotionID);

        }

        private void dgvProductPromotions_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dgvProductPromotions.SelectedRows[0];
            string id = row.Cells["ProductID"].Value.ToString();
            if (bus.DeleteProductFromDetailPromotion(id))
            {
                MessageBox.Show("Xoá sản phẩm khỏi danh sách khuyến mãi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowListProduct();
            }
        }

        private void dgvProducts_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dgvProducts.SelectedRows[0];
            string id = row.Cells["ProductID"].Value.ToString();
            string ingPromotionID = bus.getPromotionIDFromProductID(id);
            string currentPromtotionID = promotionID;
            if (!ingPromotionID.Equals(""))
            {
                DialogResult choice = MessageBox.Show($"Sản phẩm này đang được khuyến mãi ở chương trình khuyến mãi {ingPromotionID}, bạn có muốn thay đổi sang chương trình này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (choice == DialogResult.Yes)
                {
                    if (bus.AddProductFromDetailPromotion(id, currentPromtotionID))
                    {
                        MessageBox.Show("Thêm sản phẩm vào danh sách khuyến mãi thành công danh sách khuyến mãi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowListProduct();
                    }
                }
            }
            else
            {
                if (bus.AddProductFromDetailPromotion(id, currentPromtotionID))
                {
                    MessageBox.Show("Thêm sản phẩm vào danh sách khuyến mãi thành công danh sách khuyến mãi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowListProduct();
                }
            }
        }
    }
}
