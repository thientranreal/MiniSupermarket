using MiniSupermarket.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSupermarket.BUS
{
    internal class DetailPurchaseOrderBUS
    {
        private DataTable products, productOrders;

        public DataTable getProducts()
        {
            string storedProcedure = "SelectProductsToPurchaseOrder";
            products = Connection.Execute(storedProcedure, null);
            return products;
        }
    }
}
