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
    class mhasell
    {
        DataBase.Access_layer access;
        public void Add_mhasel(int id_block, string name , string adres, string number )
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            SqlParameter[] pr = new SqlParameter[4];
            access.open();
            pr[0] = new SqlParameter("@id_block", SqlDbType.Int);
            pr[0].Value = id_block;
            pr[1] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            pr[1].Value = name;
            pr[2] = new SqlParameter("@adreas", SqlDbType.VarChar, 50);
            pr[2].Value = adres;
            pr[3] = new SqlParameter("@number", SqlDbType.VarChar, 50);
            pr[3].Value = number;

            access.executor("insert_mhseal", pr);
            access.close();
        }

        public DataTable get_mhasel()
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            DataTable dt = new DataTable();
            dt = access.selec_table("select_mhsel", null);
            return dt;
        }

        public void Delete_mhsesel(String ID)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            SqlParameter[] pr = new SqlParameter[1];
            access.open();
            pr[0] = new SqlParameter("@id", SqlDbType.Int);
            pr[0].Value = ID; ;

            access.executor("delet_mhseal", pr);
            access.close();
        }

        public void Update_mhsdel_add(int id_block, string name, string adres, string number ,int id)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter("@id_block", SqlDbType.Int);
            pr[0].Value = id_block;
            pr[1] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            pr[1].Value = name;
            pr[2] = new SqlParameter("@adreas", SqlDbType.VarChar, 50);
            pr[2].Value = adres;
            pr[3] = new SqlParameter("@number", SqlDbType.VarChar, 50);
            pr[3].Value = number;
            pr[4] = new SqlParameter("@id", SqlDbType.Int);
            pr[4].Value = id;
            access.executor("udete_mhseal", pr);
            access.close();
        }

    }
}
