using MiniSupermarket.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSupermarket.BUS
{
    internal class PromotionBUS
    {
        private DataTable promotions;

        public PromotionBUS() {
            promotions = getAllPromotions();
        }

        public DataTable getAllPromotions()
        {
            string storedProcedureName = "SelectAllPromotions";
            return Connection.Execute(storedProcedureName, null);
        }
    }
}
