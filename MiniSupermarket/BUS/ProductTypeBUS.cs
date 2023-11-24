﻿using MiniSupermarket.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MiniSupermarket.BUS
{
    internal class ProductTypeBUS
    {
        // Chứa dữ liệu lấy lên từ database
        private DataTable productTypes;
        public ProductTypeBUS()
        {
            productTypes = getAllProductTypes();
        }

        private DataTable getAllProductTypes()
        {
            string storedProcedureName = "SelectAllFromProductType";
            return Connection.Execute(storedProcedureName, null);
        }

        public DataTable getAllProducts()
        {
            return getAllProductTypes();
        }

        // Nếu tồn tại trả về true, nếu không tồn tại trả về false
        public bool checkIdExist(string id)
        {
            // TypeID, Name
            foreach (DataRow row in productTypes.Rows)
            {
                if (row["TypeID"].ToString() == id)
                {
                    return true;
                }
            }
            return false;
        }
        // Nếu tồn tại trả về true, nếu không tồn tại trả về false
        public bool checkNameExist(string name)
        {
            // TypeID, Name
            foreach (DataRow row in productTypes.Rows)
            {
                if (row["Name"].ToString() == name)
                {
                    return true;
                }
            }
            return false;
        }

        // Hàm tự tạo mã mới
        private string generateNewID()
        {
            int i = 1;
            string id;
            while (true)
            {
                id = "LSP" + i.ToString();
                // Nếu ID chưa tồn tại
                if (!checkIdExist(id))
                {
                    return id;
                }
                ++i;
            }
        }
        public bool addProductType(string name, string id = null)
        {
            // Nếu không nhập mã id thì sẽ tự tạo mã mới
            if (id  == null)
            {
                id = generateNewID();
            }

            string storedProcedureName = "InsertIntoProductType";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TypeID", id),
                new SqlParameter("@Name", name)
            };

            bool result = Connection.ExecuteNonQuery(storedProcedureName, parameters);

            // Nếu thêm thành công thì sẽ cập nhật lại danh sách
            if (result)
            {
                productTypes = getAllProducts();
            }
            return result;
        }
        public bool deleteProductType(string id)
        {
            string storedProcedureName = "DeleteProductType";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TypeID", id)
            };
            bool result = Connection.ExecuteNonQuery(storedProcedureName, parameters);
            // Nếu xóa thành công thì cập nhật lại danh sách
            if (result)
            {
                productTypes = getAllProducts();
            }
            return result;
        }

        public bool updateProductType(string id, string name)
        {
            string storedProcedureName = "UpdateProductType";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TypeID", id),
                new SqlParameter("@Name", name)
            };
            bool result = Connection.ExecuteNonQuery(storedProcedureName, parameters);
            // Nếu cập nhật thành công thì cập nhật lại danh sách
            if (result)
            {
                productTypes = getAllProducts();
            }
            return result;
        }

        // Lấy tất cả các tên loại sp bỏ vào hộp gợi ý
        public string[] getNameForSuggestionBox()
        {
            List<string> names = new List<string>();

            foreach (DataRow row in productTypes.Rows)
            {
                names.Add(row["Name"].ToString());
            }
            return names.ToArray();
        }
        // Lấy tất cả các mã loại sp bỏ vào hộp gợi ý
        public string[] getIdForSuggestionBox()
        {
            List<string> ids = new List<string>();

            foreach (DataRow row in productTypes.Rows)
            {
                ids.Add(row["TypeID"].ToString());
            }
            return ids.ToArray();
        }
        public DataTable getProductsByName(string name)
        {
            DataTable result = new DataTable();
            DataRow rowTemp;
            // Thêm tên cột
            result.Columns.Add("TypeID", typeof(string));
            result.Columns.Add("Name", typeof(string));

            foreach (DataRow row in productTypes.Rows)
            {
                // Nếu dòng đó chứa name như name cần tìm thì thêm dòng đó vào result
                if (row["Name"].ToString().ToLower().Contains(name.ToLower()))
                {
                    // Thêm dữ liệu
                    rowTemp = result.NewRow();
                    rowTemp["TypeID"] = row["TypeID"].ToString();
                    rowTemp["Name"] = row["Name"].ToString();
                    result.Rows.Add(rowTemp);
                }
            }

            return result;
        }

        public DataTable getProductsById(string id)
        {
            DataTable result = new DataTable();
            DataRow rowTemp;
            // Thêm tên cột
            result.Columns.Add("TypeID", typeof(string));
            result.Columns.Add("Name", typeof(string));

            foreach (DataRow row in productTypes.Rows)
            {
                // Nếu dòng đó chứa id như id cần tìm thì thêm dòng đó vào result
                if (row["TypeID"].ToString().ToLower().Contains(id.ToLower()))
                {
                    // Thêm dữ liệu
                    rowTemp = result.NewRow();
                    rowTemp["TypeID"] = row["TypeID"].ToString();
                    rowTemp["Name"] = row["Name"].ToString();
                    result.Rows.Add(rowTemp);
                }
            }

            return result;
        }

        //=====================Công Anh thêm======================= 

        public string[] getProductTypesWithIdAndName()
        {
            List<(string Id, string Name)> types = new List<(string Id, string Name)>();

            foreach (DataRow row in productTypes.Rows)
            {
                string typeId = row["TypeID"].ToString();
                string name = row["Name"].ToString();
                types.Add((typeId, name));
            }

            return types.Select(t => $"[{t.Id}] {t.Name}").ToArray();
        }
        public string GetNameFromId(string id)
        {
            foreach (DataRow row in productTypes.Rows)
            {
                // Nếu TypeID khớp với ID cần tìm, trả về Name tương ứng
                if (row["TypeID"].ToString().Equals(id, StringComparison.OrdinalIgnoreCase))
                {
                    return row["Name"].ToString();
                }
            }

            // Trường hợp không tìm thấy
            return "Không tìm thấy"; // hoặc có thể trả về một giá trị mặc định khác
        }

    }
}
