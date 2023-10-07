using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSupermarket.Models
{
    internal class ProductTypeModel
    {
        public DataTable getAllProducts()
        {
            SqlConnection con = Connection.GetConnection();
            // Tạo đối tượng DataTable
            DataTable table = new DataTable();
            try
            {
                // Mở kết nối
                con.Open();
                // Tạo đối tượng SqlCommand
                string sqlQuery = "SELECT TypeID, Name FROM ProductType Where isDeleted = 1";
                SqlCommand command = new SqlCommand(sqlQuery, con);

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
                con.Close();
            }
            return table;
        }
    }
}
