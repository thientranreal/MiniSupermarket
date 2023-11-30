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

        //Sản phẩm bán chạy nhất
        public string GetMostSoldProduct()
        {
            Dictionary<string, int> productSales = new Dictionary<string, int>();

            foreach (DataRow row in detalBill.Rows)
            {
                string productId = row.Field<string>("ProductID");
                int quantity = row.Field<int>("Quantity");

                if (productSales.ContainsKey(productId))
                {
                    productSales[productId] += quantity;
                }
                else
                {
                    productSales.Add(productId, quantity);
                }
            }

            if (productSales.Count > 0)
            {
                string mostSoldProduct = productSales.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
                return mostSoldProduct;
            }

            return "No data available";
        }
        //Sản phẩm bán ít nhất
        public string GetLeastSoldProduct()
        {
            Dictionary<string, int> productSales = new Dictionary<string, int>();

            foreach (DataRow row in detalBill.Rows)
            {
                string productId = row.Field<string>("ProductID");
                int quantity = row.Field<int>("Quantity");

                if (productSales.ContainsKey(productId))
                {
                    productSales[productId] += quantity;
                }
                else
                {
                    productSales.Add(productId, quantity);
                }
            }

            if (productSales.Count > 0)
            {
                string leastSoldProduct = productSales.Aggregate((x, y) => x.Value < y.Value ? x : y).Key;
                return leastSoldProduct;
            }

            return "No data available";
        }
        //Số lượng bán ra của sản phẩm bán chạy
        public int GetMostSoldProductQuantity()
        {
            Dictionary<string, int> productSales = new Dictionary<string, int>();

            foreach (DataRow row in detalBill.Rows)
            {
                string productId = row.Field<string>("ProductID");
                int quantity = row.Field<int>("Quantity");

                if (productSales.ContainsKey(productId))
                {
                    productSales[productId] += quantity;
                }
                else
                {
                    productSales.Add(productId, quantity);
                }
            }

            if (productSales.Count > 0)
            {
                var mostSoldProduct = productSales.Aggregate((x, y) => x.Value > y.Value ? x : y);
                return mostSoldProduct.Value;
            }

            return 0;
        }
        //Số lượng bán ra của sản phẩm bán ít
        public int GetLeastSoldProductQuantity()
        {
            Dictionary<string, int> productSales = new Dictionary<string, int>();

            foreach (DataRow row in detalBill.Rows)
            {
                string productId = row.Field<string>("ProductID");
                int quantity = row.Field<int>("Quantity");

                if (productSales.ContainsKey(productId))
                {
                    productSales[productId] += quantity;
                }
                else
                {
                    productSales.Add(productId, quantity);
                }
            }

            if (productSales.Count > 0)
            {
                var leastSoldProduct = productSales.Aggregate((x, y) => x.Value < y.Value ? x : y);
                return leastSoldProduct.Value;
            }

            return 0;
        }
        
    }
}
