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
        List<DetailBill> detailBillList = new List<DetailBill>();
        public DetalBillBus() {

            DataTable dt = getAllDetalBill();

            foreach (DataRow row in dt.Rows) {
                DetailBill detailBill = new DetailBill {
                    BillID = row["BillID"].ToString(),
                    ProductID = row["ProductID"].ToString(),
                    OrderID = row["OrderID"].ToString(),
                    ProductName = row["Name"].ToString(),
                    ProductCurrentPrice = float.Parse(row["CurrentPrice"].ToString()),
                    ProductUnit = row["Unit"].ToString(),
                    SalePrice = float.Parse(row["SalePrice"].ToString()),
                    Quantity = int.Parse(row["Quantity"].ToString())
                };

                detailBillList.Add(detailBill);
            }
        }

        private DataTable getAllDetalBill() {
            string storedProcedureName = "GetAllDetailBills";
            return Connection.Execute(storedProcedureName, null);
        }
        public List<DetailBill> getAllDetalBills() {
            return detailBillList;
        }
        // Nếu tồn tại trả về true, nếu không tồn tại trả về false

        public bool AddDetailBill(DetailBill detailBill) {
            string storedProcedureName = "AddDetailBill";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@BillID", detailBill.BillID),
                new SqlParameter("@ProductID", detailBill.ProductID),
                new SqlParameter("@OrderID", detailBill.OrderID),
                new SqlParameter("@SalePrice", detailBill.SalePrice),
                new SqlParameter("@Quantity", detailBill.Quantity),
            };

            bool result = Connection.ExecuteNonQuery(storedProcedureName, parameters);

            if (result) {
                // Thêm DetailBill mới vào List nếu thêm thành công
                detailBillList.Add(detailBill);
            }

            return result;
        }

        public bool UpdateDetailBill(DetailBill detailBill) {
            string storedProcedureName = "UpdateDetailBill";
            float salePrice = detailBill.ProductCurrentPrice * detailBill.Quantity;
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@BillID", detailBill.BillID),
                new SqlParameter("@ProductID", detailBill.ProductID),
                new SqlParameter("@OrderID", detailBill.OrderID),
                new SqlParameter("@SalePrice", detailBill.SalePrice),
                new SqlParameter("@Quantity", detailBill.Quantity),
                // Các tham số khác tương ứng
            };

            bool result = Connection.ExecuteNonQuery(storedProcedureName, parameters);

            if (result) {
                // Cập nhật DetailBill trong List nếu sửa thành công
                DetailBill existingDetailBill = detailBillList.FirstOrDefault(d => d.BillID == detailBill.BillID && d.ProductID == detailBill.ProductID && d.OrderID == detailBill.OrderID);

                if (existingDetailBill != null) {
                    existingDetailBill.Quantity = detailBill.Quantity;
                    existingDetailBill.SalePrice = salePrice; // Gán giá trị đã tính toán
                }
            }

            return result;
        }

        public bool DeleteDetailBill(string billID, string productID, string orderID) {
            string storedProcedureName = "DeleteDetailBill";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@BillID", billID),
                new SqlParameter("@ProductID", productID),
                new SqlParameter("@OrderID", orderID),
            };

            bool result = Connection.ExecuteNonQuery(storedProcedureName, parameters);

            if (result) {
                // Xóa DetailBill khỏi List nếu xóa thành công
                DetailBill detailBillToRemove = detailBillList.FirstOrDefault(d => d.BillID == billID && d.ProductID == productID && d.OrderID == orderID);

                if (detailBillToRemove != null) {
                    detailBillList.Remove(detailBillToRemove);
                }
            }

            return result;
        }

    }
}
