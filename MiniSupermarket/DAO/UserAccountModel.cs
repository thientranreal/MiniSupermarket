using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MiniSupermarket.DAO
{
    internal class UserAccountModel
    {
        // Tạo kết nối SQL
        private SqlConnection conn = Connection.GetConnection();
        public DataTable getInforFromAccount(string username)
        {
            // Tạo đối tượng DataTable
            DataTable table = new DataTable();

            try
            {
                // Mở kết nối
                conn.Open();
                // Tạo đối tượng SqlCommand
                string sqlQuery = "SELECT EmployeeID, Name, Address, PhoneNumber, Email " +
                    "FROM Employee Where UserName = @userName " +
                    "AND Employee.IsDeleted = 1";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@userName", username);
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

        // Hàm cập nhật thông tin tài khoản
        public bool updateAccountInfor(string employeeID, string address, string phoneNumber, string email)
        {
            bool flag = true;
            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE Employee SET " +
                    "Address = @address, " +
                    "PhoneNumber = @phone, Email = @email " +
                    "WHERE EmployeeID = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", employeeID);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@phone", phoneNumber);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                MessageBox.Show(ex.Message);
                flag = false;
            }
            finally
            {
                // Đảm bảo đóng kết nối
                conn.Close();
            }
            return flag;
        }

        // Hàm cập nhật mật khẩu cho tài khoản
        public bool updateAccountPassword(string employeeID, string password)
        {
            bool flag = true;
            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE Employee SET " +
                    "Password = @password " +
                    "WHERE EmployeeID = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", employeeID);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                MessageBox.Show(ex.Message);
                flag = false;
            }
            finally
            {
                // Đảm bảo đóng kết nối
                conn.Close();
            }
            return flag;
        }
    }
}
