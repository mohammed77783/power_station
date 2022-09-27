
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Station_System.DataBase
{
    class subscription_1
    {
        DataBase.Access_layer access;
        public void Add_subs(string sub_peiod, string sub_stype, int Kw_price, int month_fee)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            SqlParameter[] pr = new SqlParameter[4];
            access.open();
            pr[0] = new SqlParameter("@sub_peiod", SqlDbType.VarChar, 200);
            pr[0].Value = sub_peiod;
            pr[1] = new SqlParameter("@sub_stype", SqlDbType.VarChar, 50);
            pr[1].Value = sub_stype;
            pr[2] = new SqlParameter("@Kw_price", SqlDbType.Int);
            pr[2].Value = Kw_price;
            pr[3] = new SqlParameter("@month_fee", SqlDbType.Int);
            pr[3].Value = month_fee;

            access.executor("insert_subscription", pr);
            access.close();
        }

        public void update_subsription(int ID, string sub_period, string Sub_Type, int KW_p, int mo_fee)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            SqlParameter[] pr = new SqlParameter[5];
            access.open();
            pr[0] = new SqlParameter("@I_D", SqlDbType.Int);
            pr[0].Value = ID;
            pr[1] = new SqlParameter("@sub_period", SqlDbType.VarChar, 100);
            pr[1].Value = sub_period;
            pr[2] = new SqlParameter("@Sub_Type", SqlDbType.VarChar, 100);
            pr[2].Value = Sub_Type;
            pr[3] = new SqlParameter("@KW_p", SqlDbType.Int);
            pr[3].Value = KW_p;
            pr[4] = new SqlParameter("@mo_fee", SqlDbType.Int);
            pr[4].Value = mo_fee;

            access.executor("Update_subscription", pr);
            access.close();
        }
        public DataTable get_subscrip()
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            DataTable dt = new DataTable();
            dt = access.selec_table("select_sebscription", null);
            return dt;

        }
        public void Delete_subscrip(String ID)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            SqlParameter[] pr = new SqlParameter[1];
            access.open();
            pr[0] = new SqlParameter("@ID", SqlDbType.Int);
            pr[0].Value = ID; ;

            access.executor("Delete_subscription", pr);
            access.close();
        }


        public DataTable Check_if_subsc_exists(string type)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            DataTable dt = new DataTable();
            SqlParameter[] pr = new SqlParameter[1];
            access.open();
            pr[0] = new SqlParameter("@type", SqlDbType.VarChar, 50);
            pr[0].Value = type;


            dt = access.selec_table("Check_if_subsc_exists", pr);
            return dt;


        }
    }
}
