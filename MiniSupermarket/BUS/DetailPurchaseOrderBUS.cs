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
    internal class DetailPurchaseOrderBUS
    {
        private DataTable products, productOrders;

        public DataTable getProducts(string OrderID)
        {
            string storedProcedure = "SelectProductsToPurchaseOrder";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderID",OrderID),
            };
            products = Connection.Execute(storedProcedure,parameters);
            return products;
        }

        public DataTable getProductOrders(string OrderID)
        {
            string storedProcedure = "SelectProductsToDetailOrder";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderID",OrderID),
            };
            productOrders = Connection.Execute(storedProcedure, parameters);
            //MessageBox.Show(pro);
            return productOrders;
        }

        public Boolean AddProductToDetailOrder(string OrderID, string ProductID, string OrderPrice, string Quantity)
        {
            string storedProcedure = "AddProductToDetailOrder";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Order",OrderID),
                new SqlParameter("@ProductID",ProductID),
                new SqlParameter("@OrderPrice",OrderPrice),
                new SqlParameter("@Quantity",Quantity)
            };
            return Connection.ExecuteNonQuery(storedProcedure,parameters);
        }
    }
}
