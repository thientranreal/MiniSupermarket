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
    internal class PromotionBUS
    {
        private DataTable promotions;

        public PromotionBUS() {
            promotions = getAllPromotions();
            
        }

        public DataTable getAllPromotions()
        {
            string storedProcedureName = "SelectAllPromotionsToShow";
            promotions = Connection.Execute(storedProcedureName, null);
            return promotions;
        }

        public DataTable getAllPromotionsToCreateID()
        {
            string storedProcedureName = "SelectAllPromotionsToCreateID";
            DataTable promotionsToCreateID = Connection.Execute(storedProcedureName, null);
            return promotionsToCreateID;
        }

        public Boolean checkExistedID(string id)
        {
            DataTable promotionsToCreateID = getAllPromotionsToCreateID();
            foreach (DataRow row in promotionsToCreateID.Rows)
            {
                if (id.Equals(row[0].ToString())) {
                    return true;
                }
            }
            return false;
        }

        public string createNewPromotionID()
        {
            string id = "";
            int currentID = 1;
            while(true){
                id = "PM"+currentID.ToString("D4");
                if (!checkExistedID(id))
                {
                    break;
                }
                ++currentID;
            }
            return id;
        }

        public Boolean insertPromotion(string Name, string dateStart, string dateEnd, string discount)
        {
            DateTime dateS, dateE;
            DateTime.TryParse(dateStart, out dateS);
            DateTime.TryParse(dateEnd, out dateE);
            string storedProcedure = "InsertPromotion";
            string newIDPromotion = createNewPromotionID();
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@PromotionID",newIDPromotion),
                new SqlParameter("@Name",Name),
                new SqlParameter("@StartDate",dateS),
                new SqlParameter("@EndDate",dateE),
                new SqlParameter("@Discount",discount)
            };
            return Connection.ExecuteNonQuery(storedProcedure, parameters); 
        }

        public Boolean updatePromotion(string ID, string Name, string dateStart, string dateEnd, string discount)
        {
            DateTime dateS, dateE;
            DateTime.TryParse(dateStart, out dateS);
            DateTime.TryParse(dateEnd, out dateE);
            string storedProcedure = "UpdatePromotion";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@PromotionID",ID),
                new SqlParameter("@Name",Name),
                new SqlParameter("@StartDate",dateS),
                new SqlParameter("@EndDate",dateE),
                new SqlParameter("@Discount",discount)
            };
            return Connection.ExecuteNonQuery(storedProcedure, parameters);
        }

        public Boolean deletePromotion(string ID) {
            string storedProcedure = "DeletePromotion";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@PromotionID",ID)
            };
            return Connection.ExecuteNonQuery(storedProcedure, parameters);
        }

        public Boolean startWorkPromotion(string ID)
        {
            string storedProcedure = "StartWork";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@PromotionID",ID)
            };
            return Connection.ExecuteNonQuery(storedProcedure, parameters);
        }

        public Boolean stopWorkPromotion(string ID)
        {
            string storedProcedure = "StopWork";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@PromotionID",ID)
            };
            return Connection.ExecuteNonQuery(storedProcedure, parameters);
        }

        public Boolean clearAllProductsFromPromotion(string ID)
        {
            string storedProcedure = "ClearAllProductsFromPromotion";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@PromotionID",ID)
            };
            return Connection.ExecuteNonQuery(storedProcedure, parameters);
        }



        //Công ANh thêm==============
        //Lấy ra id và tên khuyến mãi theo dạng: [id]name
        public string[] getPromotionsWithIdAndName()
        {
            List<(string Id, string Name)> types = new List<(string Id, string Name)>();

            // Kiểm tra xem promotions có dữ liệu không trước khi truy cập
            if (promotions != null && promotions.Rows.Count > 0 && promotions.Columns.Contains("PromotionID") && promotions.Columns.Contains("Name"))
            {
                foreach (DataRow row in promotions.Rows)
                {
                    // Lấy thông tin mã khuyến mãi mà không cần kiểm tra isDeleted
                    string PromotionID = row["PromotionID"].ToString();
                    string name = row["Name"].ToString();
                    types.Add((PromotionID, name));
                }
            }
            return types.Select(t => $"[{t.Id}] {t.Name}").ToArray();
        }

    }
}
