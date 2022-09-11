using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Power_Station_System.DataBase
{
   
    class Access_layer
    {
        SqlConnection con;
        //connection with database 
        public Access_layer()
        {




            con = new SqlConnection(@"Data Source=DESKTOP-SDKSRTB;Initial Catalog=power_state_station;Integrated Security=true");

        }
        //opent the connection to the database



        public SqlConnection getconnection
        {
            get
            {
                return con;
            }
        }

        //create a function to Open conncetion
  
        public void open()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }
        //close the connection with database 
        public void close()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        //method for select the Data from Database
        public DataTable selec_table(string stor_pr, SqlParameter[] p)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.Connection = con;
            comm.CommandText = stor_pr;
            if (p != null)
            {
                comm.Parameters.AddRange(p);
            }
            SqlDataAdapter adap = new SqlDataAdapter(comm);
            DataTable ta = new DataTable();
            adap.Fill(ta);

            return ta;
        }

        //method for Update and insert and Delete
        public void executor(string stor_pro, SqlParameter[] par)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = stor_pro;
            command.Connection = con;
            if (par != null)
            {
                command.Parameters.AddRange(par);
            }

            command.ExecuteNonQuery();
        }


        public DataTable using_command(string stor_pr)
        {
            SqlCommand comm = new SqlCommand(stor_pr, con);
            SqlDataAdapter adap = new SqlDataAdapter(comm);
            DataTable taa = new DataTable();
            adap.Fill(taa);
            return taa;
        }
    }
}
