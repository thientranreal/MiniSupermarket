using MiniSupermarket.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSupermarket.BUS {
    internal class CustomerBus {
        private DataTable customers;
        static List<Customer> customerList = new List<Customer>();

        public CustomerBus() {
            customers = getAllCustomer();

            foreach (DataRow row in customers.Rows) {
                Customer customer = new Customer(row);
                customerList.Add(customer);
            }
        }

        public DataTable getAllCustomer() {
            string storedProcedureName = "SelectAllCustomer";
            return Connection.Execute(storedProcedureName, null);
        }

        public List<Customer> getAllCustomers() {
            return customerList;
        }
        // Nếu tồn tại trả về true, nếu không tồn tại trả về false
        public bool checkIdExist(string id) {
            // TypeID, Name
            foreach (DataRow row in customers.Rows) {
                if (row["CustomerID"].ToString() == id) {
                    return true;
                }
            }
            return false;
        }
        // Hàm tự tạo mã mới
        private string generateNewID() {
            int i = 1;
            string id;
            while (true) {
                id = "C00" + i.ToString();
                // Nếu ID chưa tồn tại
                if (!checkIdExist(id)) {
                    return id;
                }
                ++i;
            }
        }
        public bool addProduct(string id, string name, string phoneNumber, string sex, string point, string isDeleted) {
            // Nếu không nhập mã id thì sẽ tự tạo mã mới
            if (id == "") {
                id = generateNewID();
            }

            string storedProcedureName = "InsertCustomer";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@CustomerID", id),
                new SqlParameter("@Name", name),
                new SqlParameter("@PhoneNumber", phoneNumber),
                new SqlParameter("@Sex", sex),
                new SqlParameter("@Point", point),
                new SqlParameter("@isDeleted",isDeleted)
            };

            bool result = Connection.ExecuteNonQuery(storedProcedureName, parameters);

            // Nếu thêm thành công thì sẽ cập nhật lại danh sách
            if (result) {
                customerList.Add(new Customer(id, name, phoneNumber, sex, point, isDeleted));
            }
            return result;
        }
        public bool deleteProduct(string id) {
            string storedProcedureName = "DeleteCustomer";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@CustomerID", id)
            };
            bool result = Connection.ExecuteNonQuery(storedProcedureName, parameters);
            // Nếu xóa thành công thì cập nhật lại danh sách
            if (result) {
                // Sử dụng RemoveAll để xóa tất cả các khách hàng có CustomerID trùng khớp
                customerList.RemoveAll(customer => customer.CustomerID == id);
            }
            return result;
        }
        public bool updateProduct(string id, string name, string phoneNumber, string sex, string point, string isDeleted) {
            string storedProcedureName = "UpdateCustomer";
            SqlParameter[] parameters = new SqlParameter[]
            {
                 new SqlParameter("@CustomerID", id),
                new SqlParameter("@Name", name),
                new SqlParameter("@PhoneNumber", phoneNumber),
                new SqlParameter("@Sex", sex),
                new SqlParameter("@Point", point),
                new SqlParameter("@isDeleted",isDeleted)
            };
            bool result = Connection.ExecuteNonQuery(storedProcedureName, parameters);
            // Nếu cập nhật thành công thì cập nhật lại danh sách
            if (result) {
                foreach (var customer in customerList) {
                    if (customer.CustomerID == id) {
                        customer.Name = name;
                        customer.PhoneNumber = phoneNumber;
                        customer.Sex = sex;
                        customer.Point = point;
                        customer.IsDeleted = isDeleted;
                    }
                }
            }
            return result;
        }

        public List<Customer> FindCustomer(string checkType, string input, string sex) {
            List<Customer> foundCustomers = new List<Customer>();

            if(input == "") {
                return customerList;
            }

            if (string.IsNullOrEmpty(checkType)) {
                // Nếu không có checkType, tìm kiếm tất cả các trường có ký tự trùng với input
                foundCustomers = customerList.FindAll(customer =>
                    customer.CustomerID.Contains(input) ||
                    customer.Name.Contains(input) ||
                    customer.PhoneNumber.Contains(input) ||
                    customer.Sex.Contains(input) ||
                    customer.Point.Contains(input)
                );
            } else {
                switch (checkType) {
                    case "Mã khách hàng":
                        foundCustomers = customerList.FindAll(customer => customer.CustomerID.Contains(input));
                        break;
                    case "Tên khách hàng":
                        foundCustomers = customerList.FindAll(customer => customer.Name.Contains(input));
                        break;
                    case "Số điện thoại":
                        foundCustomers = customerList.FindAll(customer => customer.PhoneNumber.Contains(input));
                        break;
                    default:
                        Console.WriteLine("Không hỗ trợ loại tìm kiếm này.");
                        break;
                }
            }

            if (!string.IsNullOrEmpty(sex)) {
                // Lọc theo giới tính nếu sex không rỗng
                foundCustomers = foundCustomers.FindAll(customer => customer.Sex.ToString().ToLower() == sex.ToLower());
            }
            return foundCustomers;
        }
    }
}
