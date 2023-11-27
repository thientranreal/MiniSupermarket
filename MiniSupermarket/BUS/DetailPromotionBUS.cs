using MiniSupermarket.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSupermarket.BUS
{
    internal class DetailPromotionBUS
    {
        private DataTable products, productPromotions;

        public DataTable getProducts()
        {
            string storedProcedure = "SelectProductToPromotion";
            products = Connection.Execute(storedProcedure,null);
            return products;
        }

        public DataTable getProductPromotions(string ID)
        {
            string storedProcedure = "SelectProductToPromotionApply";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@PromotionID",ID)
            };
            productPromotions = Connection.Execute(storedProcedure, parameters);
            return productPromotions;
        }
    }
}
