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
        }
    }
}
