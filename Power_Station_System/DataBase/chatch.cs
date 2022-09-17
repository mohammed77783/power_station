using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Power_Station_System.DataBase
{
    class chatch
    {
        DataBase.Access_layer access;
        public void Add_Catch(int id_catch, string name, float total_Catch, int sub_id,string data,string nots)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            SqlParameter[] pr = new SqlParameter[6];
            access.open();
            pr[0] = new SqlParameter("@ID_Catch", SqlDbType.Int);
            pr[0].Value = id_catch;
            pr[1] = new SqlParameter("@name", SqlDbType.NVarChar, 100);
            pr[1].Value = name;
            pr[2] = new SqlParameter("@total_Catch", SqlDbType.Float);
            pr[2].Value = total_Catch;
            pr[3] = new SqlParameter("@Catch_ID_Subscriber", SqlDbType.Int);
            pr[3].Value = sub_id;
            pr[4] = new SqlParameter("@Data_time", SqlDbType.Date);
            pr[4].Value = data;
            pr[5] = new SqlParameter("@note", SqlDbType.NVarChar, 60);
            pr[5].Value = nots;
            access.executor("insert_Catch", pr);
            access.close();
        }

        public DataTable get_Catch()
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            DataTable dt = new DataTable();
            dt = access.selec_table("get_catch", null);
            return dt;
        }


        public void up_catch(int id_catch, string name, float total_Catch, int sub_id, string data, string nots,int ID )
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            SqlParameter[] pr = new SqlParameter[7];
            access.open();
            pr[0] = new SqlParameter("@ID_Catch", SqlDbType.Int);
            pr[0].Value = id_catch;
            pr[1] = new SqlParameter("@name", SqlDbType.NVarChar, 100);
            pr[1].Value = name;
            pr[2] = new SqlParameter("@total_Catch", SqlDbType.Float);
            pr[2].Value = total_Catch;
            pr[3] = new SqlParameter("@Catch_ID_Subscriber", SqlDbType.Int);
            pr[3].Value = sub_id;
            pr[4] = new SqlParameter("@Data_time", SqlDbType.Date);
            pr[4].Value = data;
            pr[5] = new SqlParameter("@note", SqlDbType.NVarChar, 60);
            pr[5].Value = nots;
            pr[6] = new SqlParameter("@id", SqlDbType.Int);
            pr[6].Value = ID;
            access.executor("update_catch", pr);
            access.close();
        }

        public DataTable get_total(int sub_id)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            DataTable dt = new DataTable();
            SqlParameter[] pr = new SqlParameter[1];
            access.open();
            pr[0] = new SqlParameter("@subs_id", SqlDbType.Int);
            pr[0].Value = sub_id; ;
            dt = access.selec_table("get_pro", pr);
            access.close();
            return dt;
        }

        public DataTable get_Account(int ID_Subscriber)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            DataTable dt = new DataTable();
            SqlParameter[] pr = new SqlParameter[1];
            access.open();
            pr[0] = new SqlParameter("@ID_Subscriber", SqlDbType.VarChar, 100);
            pr[0].Value = ID_Subscriber; ;
            dt = access.selec_table("select_Account_statement", pr);
            access.close();
            return dt;
        }

    }


   
}
