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
            string storedProcedureName = "SelectAllPromotions";
            return Connection.Execute(storedProcedureName, null);
        }

        public Boolean checkExistedID(string id)
        {
            foreach(DataRow row in promotions.Rows)
            {
                if (id.Equals(row["ID"].ToString())) {
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
                new SqlParameter("EndDate",dateE),
                new SqlParameter("@Discount",discount)
            };
            return Connection.ExecuteNonQuery(storedProcedure, parameters); 
        }
    }
}
