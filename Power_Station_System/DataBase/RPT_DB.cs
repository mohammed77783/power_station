using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Power_Station_System.DataBase
{
    class RPT_DB
    {
        DataBase.Access_layer access;


        public DataTable RPT_Account_details (string da ,string data)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            DataTable dt = new DataTable();
            SqlParameter[] pr = new SqlParameter[2];
            access.open();
            pr[0] = new SqlParameter("@data", SqlDbType.Date);
            pr[0].Value = da;
            pr[1] = new SqlParameter("@dataa", SqlDbType.Date);
            pr[1].Value = data;
            dt = access.selec_table("RPT_Account_details", pr);
            access.close();
            return dt;
        }

        public DataTable RPT_reading_detailes(string da, string data)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            DataTable dt = new DataTable();
            SqlParameter[] pr = new SqlParameter[2];
            access.open();
            pr[0] = new SqlParameter("@from_date", SqlDbType.Date);
            pr[0].Value = da;
            pr[1] = new SqlParameter("@ot_date", SqlDbType.Date);
            pr[1].Value = data;
            dt = access.selec_table("RPT_reading_detailes", pr);
            access.close();
            return dt;
        }

        public DataTable RPT_survet(string da, string data)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            DataTable dt = new DataTable();
            SqlParameter[] pr = new SqlParameter[2];
            access.open();
            pr[0] = new SqlParameter("@from_date", SqlDbType.Date);
            pr[0].Value = da;
            pr[1] = new SqlParameter("@ot_date", SqlDbType.Date);
            pr[1].Value = data;
            dt = access.selec_table("RPT_survet", pr);
            access.close();
            return dt;
        }

        public DataTable RPT_money_detalil(string da, string data)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            DataTable dt = new DataTable();
            SqlParameter[] pr = new SqlParameter[2];
            access.open();
            pr[0] = new SqlParameter("@date_from", SqlDbType.Date);
            pr[0].Value = da;
            pr[1] = new SqlParameter("@date_to", SqlDbType.Date);
            pr[1].Value = data;
            dt = access.selec_table("RPT_money_detalil", pr);
            access.close();
            return dt;
        }
        public DataTable RPT_unpaidd()
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            DataTable dt = new DataTable();
            dt = access.selec_table("RPT_unpaid", null);
            return dt;
        }

        public DataTable RPT_money_detalil_block(string da, string data , Int32 id)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            DataTable dt = new DataTable();
            SqlParameter[] pr = new SqlParameter[3];
            access.open();
            pr[0] = new SqlParameter("@date_from", SqlDbType.Date);
            pr[0].Value = da;
            pr[1] = new SqlParameter("@date_to", SqlDbType.Date);
            pr[1].Value = data;
            pr[2] = new SqlParameter("@ID_block", SqlDbType.Int);
            pr[2].Value = id;
            dt = access.selec_table("RPT_money_detalil_block", pr);
            access.close();
            return dt;
        }
    }
}
