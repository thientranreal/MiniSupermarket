using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSupermarket
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        int intImage = 0;

        private void tmrChangedImage_Tick_1(object sender, EventArgs e)
        {
            pbxImage.Image = ImageListShow.Images[intImage];
            if (intImage == ImageListShow.Images.Count - 1)
            {
                intImage = 0;
            }
            else
            {
                intImage++;
            }
        }
    }
}
