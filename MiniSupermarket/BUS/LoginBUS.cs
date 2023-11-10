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
    internal class LoginBUS
    {
        private DataTable funcs;
        

        public int countAccount()
        {
            return funcs.Rows.Count;
        }

        public List<string> getFunctionFromAccount(string username, string password)
        {
            string storedProcedureName = "SelectFunctionNameFromAccount";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@userName", username),
                new SqlParameter("@Password", password)
            };
            funcs = Connection.Execute(storedProcedureName, parameters);
            List<string> functions = new List<string>();
            foreach (DataRow row in funcs.Rows)
            {
                functions.Add(row[0].ToString());
            }
            return functions;
        }
    }
}
