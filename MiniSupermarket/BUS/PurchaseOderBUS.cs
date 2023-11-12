using MiniSupermarket.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSupermarket.BUS
{
    internal class PurchaseOderBUS
    {
        public DataTable getAllPurchaseOder()
        {
            string sql = "SELECT OrderID, EmployeeID, SupplierID, ImportDate, TotalPrice, Status FROM PurchaseOrder WHERE isDeleted = 1";
            return Connection.Execute(sql);
        }
    }
}
