using MiniSupermarket.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MiniSupermarket.BUS {
    internal class DetalBillBus {
        // Chứa dữ liệu lấy lên từ database
        private DataTable detalBill;
        public DetalBillBus() {
            detalBill = getAllDetalBill();
        }

        private DataTable getAllDetalBill() {
            string storedProcedureName = "GetAllDetailBills";
            return Connection.Execute(storedProcedureName, null);
        }
        public DataTable getAllDetalBills() {
            return getAllDetalBill();
        }
        // Nếu tồn tại trả về true, nếu không tồn tại trả về false

    }
}
