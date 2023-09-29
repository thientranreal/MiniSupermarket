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
    public partial class ProductTypeForm : Form
    {
        public ProductTypeForm()
        {
            InitializeComponent();
            cb_search_type.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_search_type.Items.Add("Mã loại");
            cb_search_type.Items.Add("Tên loại");
        }
    }
}
