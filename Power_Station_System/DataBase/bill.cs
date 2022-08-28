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
    }
}
