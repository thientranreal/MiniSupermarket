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
    internal class PurchaseOrderBUS
    {
        private DataTable purchaseOrders;

        public DataTable getPurchaseOrders(string employeeID)
        {
            string storedProcedure = "SelectAllPurchaseOrder";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@EmployeeID",employeeID)
            };
            purchaseOrders = Connection.Execute(storedProcedure, parameters);
            return purchaseOrders;
        }

        public DataTable getSuppliers()
        {
            string sql = "SELECT SupplierID, Name From Supplier Where isDeleted = 1";
            DataTable dt = Connection.Execute(sql);
            return dt;
        }

        public Boolean checkExistedID(string id)
        {
            foreach (DataRow row in purchaseOrders.Rows)
            {
                if (id.Equals(row["OrderID"].ToString()))
                {
                    return true;
                }
            }
            return false;
        }

        public string createNewOrderID()
        {
            string id = "";
            int currentID = 1;
            while (true)
            {
                id = "PO" + currentID.ToString("D4");
                if (!checkExistedID(id))
                {
                    break;
                }
                ++currentID;
            }
            return id;
        }

        public Boolean InsertPurchaseOrder( string SupplierID)
        {
            string storedProcedure = "InsertPurchaseOrder";
            string ID = createNewOrderID();
            string EmployeeID = GlobalState.employeeId;
            DateTime currentDate = DateTime.Now;
            string date = String.Format("{0:dd/MM/yyyy}", currentDate);
            MessageBox.Show(ID +"   "+EmployeeID+"   "+date);
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderID",ID),
                new SqlParameter("@EmployeeID",EmployeeID),
                new SqlParameter("@SupplierID",SupplierID),
                new SqlParameter("@importDate",currentDate),
                new SqlParameter("@TotalPrice",'0')
            };
            return Connection.ExecuteNonQuery(storedProcedure,parameters);
        }

        public Boolean UpdatePurchaseOrder(string OrderID, string SupplierID)
        {
            string storedProcedure = "UpdatePurchaseOrder";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderID",OrderID),
                new SqlParameter("@SupplierID",SupplierID)
            };
            return Connection.ExecuteNonQuery(storedProcedure, parameters);
        }

        public Boolean DeletePurchaseOrder( string OrderID )
        {
            string storedProcedure = "DeletePurchaseOrder";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderID",OrderID)
            };
            return Connection.ExecuteNonQuery(storedProcedure, parameters);
        }
    }
}
