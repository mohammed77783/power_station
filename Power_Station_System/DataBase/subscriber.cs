using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Power_Station_System.DataBase
{
  
    class subscriber
    {
        DataBase.Access_layer SqlDataAdapteraccess;
        public void Add_csut (string customer_num,string Phone_nem, string address, string Identification_Type, string Identification_numb, int subcription_ID,string Sub_Ectri_ID,string Da_te,int Block_id)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            SqlParameter[] pr = new SqlParameter[9];
            access.open();
            pr[0] = new SqlParameter("@name", SqlDbType.VarChar, 200);
            pr[0].Value = customer_num;
            pr[1] = new SqlParameter("@phone_number", SqlDbType.VarChar, 50);
            pr[1].Value = Phone_nem;
            pr[2] = new SqlParameter("@address", SqlDbType.VarChar);
            pr[2].Value = address;
            pr[3] = new SqlParameter("@Ind_type", SqlDbType.VarChar, 50);
            pr[3].Value = Identification_Type;
            pr[4] = new SqlParameter("@Ind_num", SqlDbType.VarChar, 50);
            pr[4].Value = Identification_numb;
            pr[5] = new SqlParameter("@Id_subscription", SqlDbType.Int);
            pr[5].Value = subcription_ID;
            pr[6] = new SqlParameter("@sub_Elec_ID", SqlDbType.VarChar, 50);
            pr[6].Value = Sub_Ectri_ID;
            pr[7] = new SqlParameter("@Date_sub", SqlDbType.Date);
            pr[7].Value = Da_te;
            pr[8] = new SqlParameter("@Block_ID", SqlDbType.Int);
            pr[8].Value = Block_id;
            access.executor("insert_subscriper", pr);
            access.close();
        }

        //update customer
        public void update_csut(int ID,string customer_num, string Phone_nem, string address, string Identification_Type, string Identification_numb, int subcription_ID, string Sub_Ectri_ID, string Da_te, int Block_id)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            SqlParameter[] pr = new SqlParameter[10];
            access.open();
            pr[0] = new SqlParameter("@I_D", SqlDbType.Int);
            pr[0].Value = ID;
            pr[1] = new SqlParameter("@name", SqlDbType.VarChar, 100);
            pr[1].Value = customer_num;
            pr[2] = new SqlParameter("@phone_number", SqlDbType.VarChar);
            pr[2].Value = Phone_nem;
            pr[3] = new SqlParameter("@address", SqlDbType.VarChar, 50);
            pr[3].Value = address;
            pr[4] = new SqlParameter("@Ind_type", SqlDbType.VarChar, 50);
            pr[4].Value = Identification_Type;
            pr[5] = new SqlParameter("@Ind_num", SqlDbType.VarChar,10);
            pr[5].Value = Identification_numb;
            pr[6] = new SqlParameter("@Id_subscription", SqlDbType.VarChar, 50);
            pr[6].Value = subcription_ID;
            pr[7] = new SqlParameter("@sub_Elec_ID", SqlDbType.VarChar, 50);
            pr[7].Value = Sub_Ectri_ID;
            pr[8] = new SqlParameter("@Date_sub", SqlDbType.Date);
            pr[8].Value = Da_te;
            pr[9] = new SqlParameter("@Block_ID", SqlDbType.Int);
            pr[9].Value = Block_id;
            access.executor("Update_subsecriper", pr);
            access.close();
        }



        public DataTable get_subscription()
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            DataTable dt = new DataTable();
            dt = access.selec_table("selection_sebscription", null);
            return dt;
        }
        public DataTable get_spacific_subscription(int ID)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            DataTable dt = new DataTable();
            SqlParameter[] pr = new SqlParameter[1];
            access.open();
            pr[0] = new SqlParameter("@ID", SqlDbType.Int);
            pr[0].Value = ID; ;

            dt = access.selec_table("slecte_spacial_subscriper", pr);
            access.close();
            return dt;
        }
        public DataTable get_subscriber()
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            DataTable dt = new DataTable();
            dt = access.selec_table("select_subscriper", null);
            return dt;
        }
        public DataTable search(String s)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            DataTable dt = new DataTable();
            SqlParameter[] pr = new SqlParameter[1];
            access.open();
            pr[0] = new SqlParameter("@serch", SqlDbType.VarChar,150);
            pr[0].Value = s; ;
            dt = access.selec_table("[search_subscriper]", pr);
            access.close();
            return dt;
        }
        public void Delete_Sub(String ID)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            SqlParameter[] pr = new SqlParameter[1];
            access.open();
            pr[0] = new SqlParameter("@ID", SqlDbType.Int);
            pr[0].Value = ID; ;

            access.executor("Delete_Sub", pr);
            access.close();
        }

    }
}
