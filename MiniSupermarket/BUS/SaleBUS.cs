using MiniSupermarket.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MiniSupermarket.BUS
{
    internal class SaleBUS
    {
        // Chứa dữ liệu lấy lên từ database
        private static DataTable bills;
        // Chứa mã khác hàng và tên KH
        private static List<string> customers = new List<string>();

        public SaleBUS()
        {
            updateData();
        }

        public DataTable getAllBills()
        {
            // Lấy những bill chưa xóa
            updateBills();
            DataRow[] selectedRows = bills.Select("isDeleted = 1");
            DataTable newTable = selectedRows.CopyToDataTable();

            if (newTable.Columns.Contains("isDeleted"))
            {
                newTable.Columns.Remove("isDeleted");
            }

            return newTable;
        }

        public List<string> getCustomers()
        {
            return customers;
        }
        // Cập nhật danh sách bill
        public void updateBills()
        {
            // Lấy hết tất cả bill kể cả những bill đã xóa
            string procedureName = "SelectAllBills";

            bills = Connection.Execute(procedureName, null);

            // Nếu bills có dữ liệu
            if (bills != null)
            {
                // Clone DataTable
                DataTable dtCloned = bills.Clone();

                // Thay đổi kiểu dữ liệu của cột
                dtCloned.Columns["Status"].DataType = typeof(bool);

                // Import dữ liệu từ DataTable cũ
                foreach (DataRow row in bills.Rows)
                {
                    dtCloned.ImportRow(row);
                }

                bills = dtCloned;
            }
        }
        // Cập nhật danh sách khách hàng
        public void updateCustomers()
        {
            string id, name;
            List<string> result = new List<string>();
            List<Customer> customers = CustomerBus.customerList;
            if (customers != null)
            {
                foreach (Customer cus in customers)
                {
                    id = cus.CustomerID;
                    name = cus.Name;
                    result.Add($"[{id}] {name}");
                }
            }

            SaleBUS.customers = result;
        }
         // Cập nhật tất cả dữ liệu cần thiết
        public void updateData()
        {
            updateBills();
            updateCustomers();
        }

        // Kiểm tra mã bill đã tồn tại trong bill chưa
        private bool checkBillExist(string billId)
        {
            foreach (DataRow row in bills.Rows)
            {
                if (row["BillID"].ToString() == billId) { return true; }
            }
            return false;
        }

        // Tạo mã mới cho bill
        private string generateBillID()
        {
            string id = "";
            int currentBillId = 1;
            while (true)
            {
                id = "B" + currentBillId.ToString("D4");
                if (!checkBillExist(id)) { break; }
                ++currentBillId;
            }
            return id;
        }

        // Thêm bill mới vào csdl
        public bool InsertIntoBill(string EmployeeId, string CustomerId, string date)
        {
            DataTable temp = bills;
            string storedProcudure = "InsertIntoBill";
            string billId = generateBillID();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@BillID", billId),
                new SqlParameter("@Date", date),
                new SqlParameter("@EmployeeID", EmployeeId),
                new SqlParameter("@CustomerID", CustomerId),
            };
            return Connection.ExecuteNonQuery(storedProcudure, parameters);
        }

        // Thêm khách hàng mới vào csld
        public bool InsertCustomerSale(string customerId, string name, string phone, string sex)
        {
            string procedure = "InsertCustomerSale";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@CustomerID", customerId),
                new SqlParameter("@Name", name),
                new SqlParameter("@PhoneNumber", phone),
                new SqlParameter("@Sex", sex)
            };
            // Nếu thêm khách hàng thành công thì cập nhật danh sách khách hàng
            if (Connection.ExecuteNonQuery(procedure, parameters))
            {
                customers.Add($"[{customerId}] {name}");
                return true;
            }
            return false;
        }

        // Xóa hóa đơn chưa thanh toán
        public bool DeleteBill(string billId)
        {
            string procedure = "DeleteBill";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@BillID", billId)
            };
            return Connection.ExecuteNonQuery(procedure, parameters);
        }
    }
}
