using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSupermarket.ImageAndFont
{
    internal static class ProjectFont
    {
        private static Font titleFont = new Font("microsoft sans serif", 16);
        private static Font normalFont = new Font("microsoft sans serif", 12);

        public static Font getTitleFont()
        {
            return titleFont;
        }

        public static Font getNormalFont()
        {
            return normalFont;
        }
    }
}
