using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSupermarket.Models
{
    internal class LoginModel
    {
        // Tạo kết nối SQL
        private SqlConnection conn = Connection.GetConnection();

        public DataTable getFunctionsFromAccount(string username, string password)
        {
            // Tạo đối tượng DataTable
            DataTable table = new DataTable();
            
            try
            {
                // Mở kết nối
                conn.Open();
                // Tạo đối tượng SqlCommand
                string sqlQuery = "SELECT Functions.Name " +
                    "FROM Employee, EmployeeRole, Role, RoleFunction, Functions " +
                    "Where Employee.EmployeeID = EmployeeRole.EmployeeID " +
                    "AND EmployeeRole.RoleID = Role.RoleID " +
                    "AND Role.RoleID = RoleFunction.RoleID " +
                    "AND RoleFunction.FunctionID = Functions.FunctionID " +
                    "AND UserName = @userName AND Password = @Password" +
                    " AND Employee.IsDeleted = 1";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@userName", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    // Tạo đối tượng SqlDataAdapter
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        // Đổ dữ liệu vào DataTable
                        adapter.Fill(table);
                    }
                }

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
