using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Station_System.DataBase
{
    class bill
    {
        DataBase.Access_layer access;
        public DataTable get_name_and_privious(string meter_Id)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            DataTable dt = new DataTable();
            SqlParameter[] pr = new SqlParameter[1];
            access.open();
            pr[0] = new SqlParameter("@meter_ID", SqlDbType.VarChar, 100);
            pr[0].Value = meter_Id; ;
            dt = access.selec_table("select_sub_name_and_prvios_reading", pr);
            access.close();
            return dt;
        }
        public DataTable getreading_id(string meter_Id)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            DataTable dt = new DataTable();
            SqlParameter[] pr = new SqlParameter[1];
            access.open();
            pr[0] = new SqlParameter("@meter", SqlDbType.VarChar, 100);
            pr[0].Value = meter_Id; ;
            dt = access.selec_table("getblock_id_form_add_bill", pr);
            access.close();
            return dt;
        }

        public DataTable killoWat(string meter)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            DataTable dt = new DataTable();
            SqlParameter[] pr = new SqlParameter[1];
            access.open();
            pr[0] = new SqlParameter("@supscription_meter", SqlDbType.NVarChar,100);
            pr[0].Value = meter; 
            dt = access.selec_table("select_sebscription_Kw", pr);
            access.close();
            return dt;
        }


        public void relase_update(int  id)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            SqlParameter[] pr = new SqlParameter[1];
            access.open();
            pr[0] = new SqlParameter("@id", SqlDbType.Int);
            pr[0].Value = id;
            access.executor("relace_bill", pr);
            access.close();
        }
        public DataTable get_debit(string m)
        {

              DataBase.Access_layer access = new DataBase.Access_layer();
            DataTable dt = new DataTable();
            SqlParameter[] pr = new SqlParameter[1];
            access.open();
            pr[0] = new SqlParameter("@meter", SqlDbType.NVarChar,100);
            pr[0].Value = m; 
            dt = access.selec_table("get_debit", pr);
            access.close();
            return dt;

        }
        public DataTable get_subscriber_for_bill()
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            DataTable dt = new DataTable();
            dt = access.selec_table("select_manth_customerto_bill", null);
            return dt;
        }

        public void inset_Bill(string name,string meter_number,string amonut_maony,int sub_id,string date,int reading_id,string privi_reading,
            string current_reading,string kw_used,string kw_price,int block_id,string privio_mony,string month_flos) { 
            DataBase.Access_layer access = new DataBase.Access_layer();
            SqlParameter[] pr = new SqlParameter[13];
            access.open();
            pr[0] = new SqlParameter("@name", SqlDbType.NVarChar, 200);
            pr[0].Value = name;
            pr[1] = new SqlParameter("@meter_number", SqlDbType.NVarChar, 100);
            pr[1].Value = meter_number;
            pr[2] = new SqlParameter("@tot_du", SqlDbType.NVarChar, 30);
            pr[2].Value = amonut_maony;
            pr[3] = new SqlParameter("@subscriper_id", SqlDbType.BigInt);
            pr[3].Value = sub_id;
            pr[4] = new SqlParameter("@datati", SqlDbType.Date);
            pr[4].Value = date;
            pr[5] = new SqlParameter("@sub_reading_iD", SqlDbType.Int);
            pr[5].Value = reading_id;
            pr[6] = new SqlParameter("@priv_reading", SqlDbType.NVarChar, 50);
            pr[6].Value = privi_reading;
            pr[7] = new SqlParameter("@current_Readin", SqlDbType.NVarChar, 50);
            pr[7].Value = current_reading;
            pr[8] = new SqlParameter("@Kw_used", SqlDbType.NVarChar, 50);
            pr[8].Value = kw_used;
            pr[9] = new SqlParameter("@kw_price", SqlDbType.NVarChar,50);
            pr[9].Value = kw_price;
            pr[10] = new SqlParameter("@block_id", SqlDbType.Int);
            pr[10].Value = block_id;
            pr[11] = new SqlParameter("@priviou_mony", SqlDbType.NVarChar,50);
            pr[11].Value = privio_mony;
            //pr[11] = new SqlParameter("@subscriper_id", SqlDbType.Int);
            //pr[11].Value = id;
            pr[12] = new SqlParameter("@manth_manth", SqlDbType.NVarChar,50);
            pr[12].Value = month_flos;

            access.executor("insert_bill", pr);
            access.close();
        }
        public DataTable get_togrid()
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            DataTable dt = new DataTable();
            dt = access.selec_table("get_data_to_grid", null);
            return dt;
        }


        public DataTable get_togr_block(string id)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            DataTable dt = new DataTable();
            SqlParameter[] pr = new SqlParameter[1];
            access.open();
            pr[0] = new SqlParameter("@ar_bock", SqlDbType.NVarChar,100);
            pr[0].Value = id;
            dt = access.selec_table("get_data_to_grid_block", pr);
            return dt;
        }
        public DataTable get_togr_are(int id)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            DataTable dt = new DataTable();
            SqlParameter[] pr = new SqlParameter[1];
            access.open();
            pr[0] = new SqlParameter("@ar_area", SqlDbType.Int);
            pr[0].Value = id;
            dt = access.selec_table("get_data_to_grid_are", pr);
            return dt;
        }


        public void update_depet(string meter_number,string new_many)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            SqlParameter[] pr = new SqlParameter[2];
            access.open();
            pr[0] = new SqlParameter("@meter_number", SqlDbType.NVarChar, 200);
            pr[0].Value = meter_number;
            pr[1] = new SqlParameter("@new_amount", SqlDbType.NVarChar, 100);
            pr[1].Value = new_many;
            access.executor("udete_debti", pr);
            access.close();
        
        }
        public DataTable get_bill_to_print()
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            DataTable dt = new DataTable();
            dt = access.selec_table("slect_bill_to_print", null);
            return dt;
        }
        public DataTable get_bill_to_print_by_id(int id)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            DataTable dt = new DataTable();
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("@bill_id/", SqlDbType.Int);
            pr[0].Value = id;
            dt = access.selec_table("slect_bill_to_print_By_id", pr);
            return dt;
        }

    }
}
