using MiniSupermarket.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSupermarket.Controllers
{
    internal class LoginController
    {
        private LoginModel model = new LoginModel();
        private DataTable funcs;
        

        public int countAccount()
        {
            return funcs.Rows.Count;
        }

        public List<string> getFunctionFromAccount(string username, string password)
        {
            funcs = model.getFunctionsFromAccount(username, password);
            List<string> functions = new List<string>();
            foreach (DataRow row in funcs.Rows)
            {
                functions.Add(row[0].ToString());
            }
            return functions;
        }
    }
}
