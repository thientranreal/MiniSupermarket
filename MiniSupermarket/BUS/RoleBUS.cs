using MiniSupermarket.BUS;
using MiniSupermarket.DAO;
using MiniSupermarket.ImageAndFont;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSupermarket.BUS
{
    internal class RoleBUS
    {
        private DataTable role;

        public RoleBUS() 
        {
            role = getAllRole();
        }

        public DataTable getAllRole()
        {
            string storedProcedureName = "SelectAllFromRole";
            return Connection.Execute(storedProcedureName, null);
        }

        public bool checkIdExist(string id)
        {
            string query = "SELECT COUNT(*) FROM dbo.Role WHERE RoleID = @RoleID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@RoleID", id)
            };

            int count = (int)Connection.ExecuteScalar(query, parameters);

            return count > 0;
        }

        private string generateNewID()
        {
            int i = 1;
            string id;
            int maxAttempts = 1000;

            while (i <= maxAttempts)
            {
                id = "R" + i.ToString("D4");
                if (!checkIdExist(id))
                {
                    return id;
                }
                ++i;
            }
            throw new Exception("Không thể tạo ID mới sau " + maxAttempts + " lần thử.");
        }

        public static void Reset(Control.ControlCollection controls, DataGridView dataGridView)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
                else if (control is RichTextBox richTextBox)
                {
                    richTextBox.Text = string.Empty;
                }
            }
            dataGridView.ClearSelection();

        }

        public bool addRole(string id, string name, string description)
        {
            if (string.IsNullOrEmpty(id))
            {
                id = generateNewID();
            }

            string storedProcedureName = "InsertIntoRole";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@RoleID", id),
                new SqlParameter("@Name", name),
                new SqlParameter("@Description", description),
            };

            bool result = Connection.ExecuteNonQuery(storedProcedureName, parameters);

            // Nếu thêm thành công thì sẽ cập nhật lại danh sách
            if (result)
            {
                role = getAllRole();
            }
            return result;
        }

        public bool deleteRole(string id)
        {
            string storedProcedureName = "DeleteRole";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@RoleID", id)
            };
            bool result = Connection.ExecuteNonQuery(storedProcedureName, parameters);
            // Nếu xóa thành công thì cập nhật lại danh sách
            if (result)
            {
                role = getAllRole();
            }
            return result;
        }

        public bool editRole(string id, string name, string description)
        {
            string storedProcedureName = "EditRole";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@RoleID", id),
                new SqlParameter("@Name", name),
                new SqlParameter("@Description", description),
            };
            bool result = Connection.ExecuteNonQuery(storedProcedureName, parameters);
            // Nếu cập nhật thành công thì cập nhật lại danh sách
            if (result)
            {
                role = getAllRole();
            }
            return result;
        }

    }
}

