using MiniSupermarket.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSupermarket.BUS
{
    internal class SaleBUS
    {
        private SaleModel model = new SaleModel();
        // Chứa dữ liệu lấy lên từ database
        private DataTable bills;

        public SaleBUS()
        {
            updateBills();
        }

        public DataTable getAllBills()
        {
            return bills;
        }

        public void updateBills()
        {
            bills = model.getAllBills();
            // Clone DataTable
            DataTable dtCloned = bills.Clone();

            // Thay đổi kiểu dữ liệu của cột
            dtCloned.Columns["Status"].DataType = typeof(bool);

            // Import dữ liệu từ DataTable cũ
            foreach (DataRow row in bills.Rows)
            {
                dtCloned.ImportRow(row);
            }

            bills = dtCloned;
        }
    }
}
