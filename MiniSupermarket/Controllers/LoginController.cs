using MiniSupermarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSupermarket.Controllers
{
    internal class LoginController
    {
        private LoginModel model = new LoginModel();

        public int countAccount(string username, string password)
        {
            return model.countAccount(username, password);
        }

        public List<string> getFunctionFromAccount(string username)
        {
            return model.getFunctionFromAccount(username);
        }
    }
}
