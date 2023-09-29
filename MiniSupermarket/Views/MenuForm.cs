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
    public partial class MenuForm : Form
    {
        private ProductTypeForm typeForm = new ProductTypeForm();
        private Form activeForm;
        public MenuForm()
        {
            InitializeComponent();
            pnl_root.Padding = new System.Windows.Forms.Padding(5);
        }

        private void btn_product_type_Click(object sender, EventArgs e)
        {
            typeForm.MdiParent = this;
            typeForm.Show();
            pnl_form.Controls.Add(typeForm);
            typeForm.Dock = DockStyle.Fill;
            typeForm.AutoSize = true;
            activeForm = typeForm;
        }
    }
}
