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
    internal class SupplierBUS
    {
        private DataTable nhaCungCap;
        private DataTable nhaCungCapDetail;
        public SupplierBUS() {
            nhaCungCap = getAllSupplier();
            nhaCungCapDetail = getAllSupplierDetail();
        }
        private DataTable getAllSupplier()
        {
            string storedProcedureName = "SelectAllSupplier";
            return Connection.Execute(storedProcedureName, null);
        }
        private DataTable getAllSupplierDetail()
        {
            string storedProcedureName = "SelectAllSupplierDetail";
            return Connection.Execute(storedProcedureName, null);
        }
        private DataTable getSupplierWithID(string id)
        {
            string storedProcedureName = "FindSupplierWithID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ID",id)
            };
            return Connection.Execute(storedProcedureName, parameters);
        }
        public DataTable getAllFromSupplier() {
            nhaCungCap=getAllSupplier();
            return nhaCungCap;
        }
        public DataTable getAllFromSupplierDetail()
        {
            return nhaCungCapDetail;
        }
        public DataTable getSupplierWithIDFromSupplier(string id)
        {
            nhaCungCap = getSupplierWithID(id);
            return nhaCungCap;
        }
    }
}
