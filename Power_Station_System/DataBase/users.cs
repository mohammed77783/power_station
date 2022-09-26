using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Power_Station_System.DataBase
{
    class users
    {

        public void Add_user( int Id ,string ful_name, string number, string adres,string user_name,string pass)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            SqlParameter[] pr = new SqlParameter[6];
            access.open();
            pr[0] = new SqlParameter("@user_ID", SqlDbType.Int);
            pr[0].Value = Id;
            pr[1] = new SqlParameter("@ful_name", SqlDbType.NVarChar, 50);
            pr[1].Value = ful_name;
            pr[2] = new SqlParameter("@number", SqlDbType.NVarChar, 50);
            pr[2].Value = number;
            pr[3] = new SqlParameter("@adres", SqlDbType.NVarChar, 50);
            pr[3].Value = adres;
            pr[4] = new SqlParameter("@user_name", SqlDbType.NVarChar, 50);
            pr[4].Value = user_name;
            pr[5] = new SqlParameter("@pass", SqlDbType.NVarChar, 50);
            pr[5].Value = pass;

            access.executor("insert_add_user", pr);
            access.close();
        }
       
        public DataTable get_user()
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            DataTable dt = new DataTable();
            dt = access.selec_table("select_add_user", null);
            return dt;
        }

        


        public void Delete_user(String user_ID)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            SqlParameter[] pr = new SqlParameter[1];
            access.open();
            pr[0] = new SqlParameter("@user_ID", SqlDbType.Int);
            pr[0].Value = user_ID;

            access.executor("delet_add_user", pr);
            access.close();
        }

        public void Update_add_user(string ful_name, string number, string adres, string user_name, string pass,int user_ID)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            SqlParameter[] pr = new SqlParameter[6];
            access.open();
            pr[0] = new SqlParameter("@ful_name", SqlDbType.NVarChar, 50);
            pr[0].Value = ful_name;
            pr[1] = new SqlParameter("@number", SqlDbType.NVarChar, 50);
            pr[1].Value = number;
            pr[2] = new SqlParameter("@adres", SqlDbType.NVarChar, 50);
            pr[2].Value = adres;
            pr[3] = new SqlParameter("@user_name", SqlDbType.NVarChar, 50);
            pr[3].Value = user_name;
            pr[4] = new SqlParameter("@pass",SqlDbType.NVarChar, 50);
            pr[4].Value = pass;
            pr[5] = new SqlParameter("@user_ID", SqlDbType.Int);
            pr[5].Value = user_ID;
            access.executor("udete_add_user", pr);
            access.close();
        }
        public DataTable login_user(string ID, string PWd)
        {
            DataBase.Access_layer dA = new DataBase.Access_layer();
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("@user_name", SqlDbType.VarChar, 50);
            pr[0].Value = ID;
            pr[1] = new SqlParameter("@pass", SqlDbType.VarChar, 50);
            pr[1].Value = PWd;
            DataTable dt = new DataTable();
            dA.open();
            dt = dA.selec_table("usser_login", pr);
            dA.close();
            return dt;

        }
    

        public DataTable priv_Dsplay(int user_ID)
        {
            DataBase.Access_layer dA = new DataBase.Access_layer();
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("@user_ID", SqlDbType.Int);
            pr[0].Value = user_ID;
            DataTable dt = new DataTable();
            dA.open();
            dt = dA.selec_table("select_priv_Dsplay", pr);
            dA.close();
            return dt;
        }
        public DataTable priv_Add_priv_Edit(int priv_screen_ID, int user_ID)
        {
            DataBase.Access_layer dA = new DataBase.Access_layer();
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("@priv_screen_ID", SqlDbType.Int);
            pr[0].Value = @priv_screen_ID;
            pr[1] = new SqlParameter("@user_ID", SqlDbType.Int);
            pr[1].Value = user_ID;
            DataTable dt = new DataTable();
            dA.open();
            dt = dA.selec_table("select_priv_Add_priv_Edit", pr);
            dA.close();
            return dt;
        }

    }
}
