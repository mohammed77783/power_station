
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Station_System.DataBase
{
    class reading
    {
        DataBase.Access_layer access;

        public DataTable manth_customer_name()
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            DataTable dt = new DataTable();
            dt = access.selec_table("select_manth_customer", null);
            return dt;
        }
        public DataTable get_name_and_privious(string meter_Id)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            DataTable dt = new DataTable();
            SqlParameter[] pr = new SqlParameter[1];
            access.open();
            pr[0] = new SqlParameter("@meter_ID", SqlDbType.VarChar,100);
            pr[0].Value = meter_Id; ;
            dt = access.selec_table("select_sub_name_and_prvios_reading", pr);
            access.close();
            return dt;
        }

       
            public void Add_reading(string current,string privous,string date,string subscriper_metrer,int id,int block)
            {
                DataBase.Access_layer access = new DataBase.Access_layer();
                SqlParameter[] pr = new SqlParameter[6];
                access.open();
                pr[0] = new SqlParameter("@current_read", SqlDbType.VarChar, 200);
                pr[0].Value = current;
                pr[1] = new SqlParameter("@privos_reading", SqlDbType.VarChar, 200);
                pr[1].Value = privous;
                pr[2] = new SqlParameter("@Dat_e", SqlDbType.Date);
                pr[2].Value = date;
                pr[3] = new SqlParameter("@meter_ID", SqlDbType.VarChar, 200);
                pr[3].Value = subscriper_metrer;
                pr[4] = new SqlParameter("@ID_subscriper", SqlDbType.Int);
                pr[4].Value = id;
                pr[5] = new SqlParameter("@ID_block", SqlDbType.VarChar, 200);
                pr[5].Value = block;
                access.executor("insert_reading", pr);
                access.close();
            }





        public void Add_reading_withoutbill(string current, string privous, string date, string subscriper_metrer, int id, int block)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            SqlParameter[] pr = new SqlParameter[6];
            access.open();
            pr[0] = new SqlParameter("@current_read", SqlDbType.VarChar, 200);
            pr[0].Value = current;
            pr[1] = new SqlParameter("@privos_reading", SqlDbType.VarChar, 200);
            pr[1].Value = privous;
            pr[2] = new SqlParameter("@Dat_e", SqlDbType.Date);
            pr[2].Value = date;
            pr[3] = new SqlParameter("@meter_ID", SqlDbType.VarChar, 200);
            pr[3].Value = subscriper_metrer;
            pr[4] = new SqlParameter("@ID_subscriper", SqlDbType.Int);
            pr[4].Value = id;
            pr[5] = new SqlParameter("@ID_block", SqlDbType.VarChar, 200);
            pr[5].Value = block;
            access.executor("insert_reading_without_bill", pr);
            access.close();
        }
        public void udate_reading(int id, string cur,string privous, string date, string meter__number)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            SqlParameter[] pr = new SqlParameter[5];
            access.open();
            pr[0] = new SqlParameter("@i_d", SqlDbType.BigInt);
            pr[0].Value = id;
            pr[1] = new SqlParameter("@curr_read", SqlDbType.VarChar, 200);
            pr[1].Value = cur;
            pr[2] = new SqlParameter("@priviou", SqlDbType.VarChar, 200);
            pr[2].Value = privous;
            pr[3] = new SqlParameter("@d_ate", SqlDbType.Date);
            pr[3].Value = date;
            pr[4] = new SqlParameter("@meter_number", SqlDbType.VarChar, 200);
            pr[4].Value = meter__number;
            access.executor("update_elect_meter", pr);
            access.close();
        }
        public void udate_reading_date_of_bill(int id)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            SqlParameter[] pr = new SqlParameter[1];
            access.open();
            pr[0] = new SqlParameter("@ID", SqlDbType.BigInt);
            pr[0].Value = id;
            access.executor("update_read_bill_rease", pr);
            access.close();

        }

            public void update_opeiningreading(string meter_num,string reading,string s)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            SqlParameter[] pr = new SqlParameter[3];
            access.open();
            pr[0] = new SqlParameter("@meter_num", SqlDbType.VarChar, 200);
            pr[0].Value = meter_num;
            pr[1] = new SqlParameter("@reading", SqlDbType.VarChar, 200);
            pr[1].Value = reading;
            pr[2] = new SqlParameter("@Dat_e", SqlDbType.Date);
            pr[2].Value = s;
            access.executor("update_opening_reading", pr);
            access.close();

        }
        public void reading_doe(string s)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            SqlParameter[] pr = new SqlParameter[1];
            access.open();
            pr[0] = new SqlParameter("@meter_num", SqlDbType.VarChar, 200);
            pr[0].Value = s;
            access.executor("reading_done", pr);
            access.close();
        }
        public DataTable get_sub_with_reading(string from,string to)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            DataTable dt = new DataTable();
            SqlParameter[] pr = new SqlParameter[2];
            access.open();
            pr[0] = new SqlParameter("@date_from", SqlDbType.Date);
            pr[0].Value = from;
            pr[1] = new SqlParameter("@date_to", SqlDbType.Date);
            pr[1].Value = to;
            dt = access.selec_table("select_reading_from_elect_reading", pr);
            return dt;
        }
        public DataTable loadded()
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            DataTable dt = new DataTable();
            access.open();
            dt = access.selec_table("Loaddata_to_GV", null);
            return dt;
        }
        //opening readin 
        public DataTable get_opening_reading()
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            DataTable dt = new DataTable();
            dt = access.selec_table("select_opening", null);
            return dt;
        }

        //add opeing reading when add subscriper first time
        public void insert_opening_first_time(string meter_number,string read,string date)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            SqlParameter[] prr = new SqlParameter[3];
            access.open();
            prr[0] = new SqlParameter("@meter_num", SqlDbType.VarChar, 200);
            prr[0].Value = meter_number;
            prr[1] = new SqlParameter("@reading", SqlDbType.VarChar, 200);
            prr[1].Value = read;
            prr[2] = new SqlParameter("@Dat_e", SqlDbType.Date);
            prr[2].Value = date;

            access.executor("insert_opening_reading", prr);
            access.close();
        }
        public void insert_manth_customer_name ()
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            access.open();
            access.executor("upadate_manth_customer_name", null);
            access.close();
        }

    }

    }

