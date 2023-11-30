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
    internal class StatisticsBUS
    {
        // Chứa dữ liệu lấy lên từ database
        private DataTable billinfor;
        public StatisticsBUS()
        {
            billinfor = getAllBillInfors();
        }

        private DataTable getAllBillInfors()
        {
            string storedProcedureName = "SelectBillInformation";
            return Connection.Execute(storedProcedureName, null);
        }
        public DataTable getAllBillInfor()
        {
            return getAllBillInfors();
        }

        //Lấy các hóa đơn với nhân viên làm chính khoảng thời gian từ fromDate đến toDate
        public DataTable GetEmployEEsByDateRange(DateTime fromDate, DateTime toDate)
        {
            string procedureName = "GetEmployEEsByDateRange";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@FromDate", fromDate),
            new SqlParameter("@ToDate", toDate)
            };

            DataTable billsByDateRange = Connection.Execute(procedureName, parameters);
            return billsByDateRange;
        }

        //nhân viên có doanh thu cao nhất 
        public string GetEmployeeWithMaxTotalSales()
        {
            DataTable allBills = getAllBillInfor();
            Dictionary<string, decimal> employeeSales = new Dictionary<string, decimal>();

            if (allBills != null && allBills.Rows.Count > 0)
            {
                foreach (DataRow row in allBills.Rows)
                {
                    string employeeID = row["EmployeeID"].ToString();
                    decimal totalPrice = Convert.ToDecimal(row["TotalPrice"]);

                    if (employeeSales.ContainsKey(employeeID))
                    {
                        employeeSales[employeeID] += totalPrice;
                    }
                    else
                    {
                        employeeSales.Add(employeeID, totalPrice);
                    }
                }

                // Tìm nhân viên có tổng doanh thu cao nhất
                string employeeWithMaxSales = employeeSales.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;

                return employeeWithMaxSales;
            }

            return null;
        }

        //nhân viên có doanh thu thấp nhất 
        public string GetEmployeeWithMinTotalSales()
        {
            DataTable allBills = getAllBillInfor();
            Dictionary<string, decimal> employeeSales = new Dictionary<string, decimal>();

            if (allBills != null && allBills.Rows.Count > 0)
            {
                foreach (DataRow row in allBills.Rows)
                {
                    string employeeID = row["EmployeeID"].ToString();
                    decimal totalPrice = Convert.ToDecimal(row["TotalPrice"]);

                    if (employeeSales.ContainsKey(employeeID))
                    {
                        employeeSales[employeeID] += totalPrice;
                    }
                    else
                    {
                        employeeSales.Add(employeeID, totalPrice);
                    }
                }

                // Tìm nhân viên có tổng doanh thu thấp nhất
                string employeeWithMinSales = employeeSales.Aggregate((x, y) => x.Value < y.Value ? x : y).Key;

                return employeeWithMinSales;
            }

            return null;
        }
    }
}
