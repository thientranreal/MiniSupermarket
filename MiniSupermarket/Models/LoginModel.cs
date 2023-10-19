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

        public int countAccount(string username, string password)
        {
            int count = -1;
            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Employee " +
                    "WHERE UserName = @UserName " +
                    "AND Password = @Password AND isDeleted = 1", conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    count = (int)cmd.ExecuteScalar();
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
            return count;
        }

        public List<string> getFunctionFromAccount(string username)
        {
            // Tạo đối tượng DataTable
            DataTable table = new DataTable();
            List<string> funcs = new List<string>();
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
                    "AND UserName = @userName AND IsDeleted = 1";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@userName", username);
                    // Tạo đối tượng SqlDataAdapter
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    // Đổ dữ liệu vào DataTable
                    adapter.Fill(table);

                    // Lấy các tên chức năng
                    foreach (DataRow row in table.Rows)
                    {
                        string temp = row[0].ToString();
                        funcs.Add(temp);
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
            return funcs;
        }
    }
}
