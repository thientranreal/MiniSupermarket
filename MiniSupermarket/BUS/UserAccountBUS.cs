using MiniSupermarket.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSupermarket.BUS
{
    internal class UserAccountBUS
    {
        private UserAccountModel model = new UserAccountModel();

        public DataTable getInforFromAccount(string username)
        {
            return model.getInforFromAccount(username);
        }

        public bool updateAccountInfor(string employeeID, string address, string phoneNumber, string email)
        {
            return model.updateAccountInfor(employeeID, address, phoneNumber, email);
        }

        public bool updateAccountPassword(string employeeID, string password)
        {
            return model.updateAccountPassword(employeeID, password);
        }
    }
}
