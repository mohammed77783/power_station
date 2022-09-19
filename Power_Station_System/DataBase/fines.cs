using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Power_Station_System.DataBase
{
    class fines
    {
        DataBase.Access_layer access;
        public void Add_fines(string type, string fines_cost)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            SqlParameter[] pr = new SqlParameter[2];
            access.open();
            pr[0] = new SqlParameter("@fine_name", SqlDbType.VarChar, 200);
            pr[0].Value = type;
            pr[1] = new SqlParameter("@fines_cost", SqlDbType.VarChar, 50);
            pr[1].Value = fines_cost;
            access.executor("fines_type_insert", pr);
            access.close();
        }
         public DataTable get_fines()
         {
             DataBase.Access_layer access = new DataBase.Access_layer();
             DataTable dt = new DataTable();
             dt = access.selec_table("select_fines_type", null);
             return dt;
         }
         
        public void Delete_fines_add(String ID)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            SqlParameter[] pr = new SqlParameter[1];
            access.open();
            pr[0] = new SqlParameter("@Id", SqlDbType.Int);
            pr[0].Value = ID; ;

            access.executor("delete_Fine_type", pr);
            access.close();
        }

        public void Update_fines_add(string type,string fines_cost, int id)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            SqlParameter[] para = new SqlParameter[3];
            access.open();
            para[0] = new SqlParameter("@ID", SqlDbType.Int);
            para[0].Value = id;
            para[1] = new SqlParameter("@fines_type", SqlDbType.VarChar, 200);
            para[1].Value = type;
            para[2] = new SqlParameter("@fines_cost", SqlDbType.VarChar, 200);
            para[2].Value = fines_cost;
            access.executor("udete_finse_type", para);
            access.close();
        }


        public void Add_fines_reales(int ID_Subscriber , int fines_type_ID, string fine_data)
        {
            access = new DataBase.Access_layer();
            SqlParameter[] prarm = new SqlParameter[3]; 
            access.open();
            prarm[2] = new SqlParameter("@iD_Subscriber", SqlDbType.Int); 
            prarm[2].Value = ID_Subscriber;
            prarm[1] = new SqlParameter("@fine_type", SqlDbType.Int);
            prarm[1].Value = fines_type_ID;
            prarm[0] = new SqlParameter("@Fine_data", SqlDbType.Date);
            prarm[0].Value = fine_data;
            access.executor("insert_fines", prarm);
            access.close();
        }
        public void Delete_fines_reales(String ID)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            SqlParameter[] pr = new SqlParameter[1];
            access.open();
            pr[0] = new SqlParameter("@Id", SqlDbType.Int);
            pr[0].Value = ID; ;

            access.executor("delete_fines", pr);
            access.close();
        }
        public void ubdate_fines_reales(int ID_Subscriber, int fines_type_ID, string fine_data,int ID)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            SqlParameter[] para = new SqlParameter[4];
            access.open();
            para[0] = new SqlParameter("@subscriper_id", SqlDbType.Int); 
             para[0].Value = ID_Subscriber;
            para[1] = new SqlParameter("@fine_type", SqlDbType.Int);
            para[1].Value = fines_type_ID;
            para[2] = new SqlParameter("@d_ate", SqlDbType.Date);
            para[2].Value = fine_data;
            para[2] = new SqlParameter("@id", SqlDbType.Int, 200);
            para[2].Value = ID;
            access.executor("update_fine", para);
            access.close();

        }

        public DataTable get_fines_reales()
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            DataTable dt = new DataTable();
            dt = access.selec_table("select_fines_substriber", null);
            return dt;
        }
    }
}
