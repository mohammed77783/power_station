using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Station_System.DataBase
{
    class Block_aned_area
    {
        DataBase.Access_layer access;
        public void Add_area(string area_name)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            SqlParameter[] pr = new SqlParameter[1];
            access.open();
            pr[0] = new SqlParameter("@area_name", SqlDbType.VarChar, 200);
            pr[0].Value = area_name;
            access.executor("insert_area", pr);
            access.close();
        }
        public DataTable get_area()
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            DataTable dt = new DataTable();
            dt = access.selec_table("select_area", null);
            return dt;
        }
        public DataTable get_Block()
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            DataTable dt = new DataTable();
            dt = access.selec_table("Select_Block", null);
            return dt;
        }

        public void Delete_are(String ID)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            SqlParameter[] pr = new SqlParameter[1];
            access.open();
            pr[0] = new SqlParameter("@Id", SqlDbType.Int);
            pr[0].Value = ID; ;

            access.executor("Delete_are", pr);
            access.close();
        }

        public void Delete_block(String ID)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            SqlParameter[] pr = new SqlParameter[1];
            access.open();
            pr[0] = new SqlParameter("@id", SqlDbType.Int);
            pr[0].Value = ID; ;

            access.executor("delecte_block", pr);
            access.close();
        }


        public void Update_area(string Area_name,int ID)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            SqlParameter []para = new SqlParameter[2];
            access.open();
            para[0] = new SqlParameter("@I_D", SqlDbType.Int);
            para[0].Value = ID;
            para[1] = new SqlParameter("@name", SqlDbType.VarChar, 200);
            para[1].Value = Area_name;
            access.executor("update_area", para);
            access.close();
        }
        public void Add_Block(string block_name, int area_ID,string center_meter)
        {
             access = new DataBase.Access_layer();
            SqlParameter [] prarm = new SqlParameter[3];
            access.open();
            prarm[2] = new SqlParameter("@block_name", SqlDbType.VarChar, 100);
            prarm[2].Value = block_name;
            prarm[1] = new SqlParameter("@area_ID", SqlDbType.Int);
            prarm[1].Value = area_ID;
            prarm[0] = new SqlParameter("@Block_meter_number", SqlDbType.VarChar, 100);
            prarm[0].Value = center_meter;
            access.executor("insert_block", prarm);
            access.close();
        }
        public void update_Block(int ID, string name,int area_id,string center_meter)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            SqlParameter[] prr = new SqlParameter[4];
            access.open();
            prr[0] = new SqlParameter("@ID_block", SqlDbType.Int);
            prr[0].Value = ID;
            prr[1] = new SqlParameter("@block_name", SqlDbType.VarChar,50);
            prr[1].Value = name;
            prr[2] = new SqlParameter("@center_meter", SqlDbType.VarChar,100);
            prr[2].Value = center_meter;
            prr[3] = new SqlParameter("@are_id", SqlDbType.Int);
            prr[3].Value = area_id;
            access.executor("update_block", prr);
            access.close();
        }
        public DataTable Check_if_area_exists(string name)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            DataTable dt = new DataTable();
            SqlParameter[] pr = new SqlParameter[1];
            access.open();
            pr[0] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            pr[0].Value = name;


            dt = access.selec_table("Check_if_area_exists", pr);
            return dt;


        }

        public DataTable Check_if_block_exists(string name)
        {
            DataBase.Access_layer access = new DataBase.Access_layer();
            DataTable dt = new DataTable();
            SqlParameter[] pr = new SqlParameter[1];
            access.open();
            pr[0] = new SqlParameter("@name", SqlDbType.VarChar, 50);
            pr[0].Value = name;


            dt = access.selec_table("Check_if_block_exists", pr);
            return dt;


        }



    }
}
