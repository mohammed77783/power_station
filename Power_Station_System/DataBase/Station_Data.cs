using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Station_System.DataBase
{
    class Station_Data
    {
        Access_layer access = new Access_layer();


        public DataTable get_SD()
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            DataTable dt = new DataTable();
            dt = access.selec_table("Selecte_Station_Data", null);
            return dt;
        }
        public DataTable get_image()
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            DataTable dt = new DataTable();
            dt = access.selec_table("Selecte_Station_Data", null);
            return dt;
            
        }

        public void AddSD(string Station_name, string Owner_name, string addres_Station, string phone_number, string phone_number2 , byte [] imag)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            SqlParameter[] pr = new SqlParameter[6];
            access.open();
            pr[0] = new SqlParameter("@Station_name", SqlDbType.NVarChar, 100);
            pr[0].Value = Station_name;
            pr[1] = new SqlParameter("@Owner_name", SqlDbType.NVarChar, 100);
            pr[1].Value = Owner_name;
            pr[2] = new SqlParameter("@addres_Station", SqlDbType.NVarChar,100);
            pr[2].Value = addres_Station;
            pr[3] = new SqlParameter("@phone_number", SqlDbType.NVarChar, 100);
            pr[3].Value = phone_number;
            pr[4] = new SqlParameter("@phone_number2", SqlDbType.NVarChar, 100);
            pr[4].Value = phone_number2;
            pr[5] = new SqlParameter("@Logo_Station", SqlDbType.Image) ;
            pr[5].Value = imag;
            access.executor("Insert_Station_Data", pr);
            access.close();
        }

        public void Update_Data_Station(string Station_name, string Owner_name, string addres_Station, string phone_number, string phone_number2, byte[] imag)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            SqlParameter[] pr = new SqlParameter[6];
            access.open();
            pr[0] = new SqlParameter("@Station_name", SqlDbType.NVarChar, 100);
            pr[0].Value = Station_name;
            pr[1] = new SqlParameter("@Owner_name", SqlDbType.NVarChar, 100);
            pr[1].Value = Owner_name;
            pr[2] = new SqlParameter("@addres_Station", SqlDbType.NVarChar, 100);
            pr[2].Value = addres_Station;
            pr[3] = new SqlParameter("@phone_number", SqlDbType.NVarChar, 100);
            pr[3].Value = phone_number;
            pr[4] = new SqlParameter("@phone_number2", SqlDbType.NVarChar, 100);
            pr[4].Value = phone_number2;
            pr[5] = new SqlParameter("@Logo_Station", SqlDbType.Image);
            pr[5].Value = imag;
            access.executor("Update_Station_Data", pr);
            access.close();
        }

    }
}
