using MiniSupermarket.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSupermarket.BUS
{
    internal class PurchaseOrderBUS
    {
        private DataTable purchaseOrders;

        public DataTable getPurchaseOrders()
        {
            string storedProcedure = "SelectAllPurchaseOrder";
            purchaseOrders = Connection.Execute(storedProcedure, null);
            return purchaseOrders;
        }

        public DataTable getSuppliers()
        {
            string sql = "SELECT SupplierID, Name From Supplier Where isDeleted = 1";
            DataTable dt = Connection.Execute(sql);
            return dt;
        }
    }
}
