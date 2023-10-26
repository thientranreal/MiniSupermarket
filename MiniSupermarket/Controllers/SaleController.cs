using MiniSupermarket.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSupermarket.Controllers
{
    internal class SaleController
    {
        private SaleModel model = new SaleModel();
        // Chứa dữ liệu lấy lên từ database
        private DataTable bills;

        public DataTable getAllBills()
        {
            bills = model.getAllBills();
            return bills;
        }
    }
}
