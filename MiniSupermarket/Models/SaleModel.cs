using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSupermarket.Models
{
    internal class SaleModel
    {
        // Tạo kết nối SQL
        private SqlConnection conn = Connection.GetConnection();

        public DataTable getAllBills()
        {
            // Tạo đối tượng DataTable
            DataTable table = new DataTable();
            try
            {
                // Mở kết nối
                conn.Open();
                // Tạo đối tượng SqlCommand
                string sqlQuery = "SELECT Bill.BillID, Bill.Date, Bill.EmployeeID, " +
                    "Employee.Name AS EmployeeName, Bill.CustomerID, " +
                    "Customer.Name AS CustomerName, Promotion.Name AS PromotionName, " +
                    "Bill.TotalPrice, Bill.Status FROM Bill INNER JOIN " +
                    "Employee ON Bill.EmployeeID = Employee.EmployeeID " +
                    "INNER JOIN Customer ON Bill.CustomerID = Customer.CustomerID " +
                    "LEFT JOIN Promotion ON Promotion.PromotionID = Bill.PromotionID " +
                    "WHERE Bill.isDeleted = 1;";
                SqlCommand command = new SqlCommand(sqlQuery, conn);

                // Tạo đối tượng SqlDataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // Đổ dữ liệu vào DataTable
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Đảm bảo đóng kết nối
                conn.Close();
            }
            return table;
        }
    }
}
