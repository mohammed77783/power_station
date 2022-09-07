using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Power_Station_System
{

    public partial class @long : Form
    {
        DataBase.users us = new DataBase.users();

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1NI3GAJ\SQLEXPRESS;Initial Catalog=power_state_station;Integrated Security=true");
        
        public @long()
        {
            InitializeComponent();

            comboBox1.DataSource = us.get_user();
            comboBox1.DisplayMember = "user_name";
            comboBox1.ValueMember = "user_ID";
            comboBox1.Text = "";
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void RjButton1_Click(object sender, EventArgs e)
        {


            SqlCommand cmd = new SqlCommand("select user_ID,pass,ful_name from add_user where user_name=@user_name and pass=@pass ",con);
            
            cmd.Parameters.Add(new SqlParameter("@user_name", SqlDbType.VarChar)).Value = comboBox1.Text;
            cmd.Parameters.Add(new SqlParameter("@pass", SqlDbType.VarChar)).Value = rjTextBox2.Texts;

            con.Open();
            SqlDataReader ra = cmd.ExecuteReader();
            ra.Read();
            if (ra.HasRows)
            {
                Program.user_ID = ra[0].ToString();
                MessageBox.Show("ok" +
               Program.user_ID.ToString());
                Form1 main = new Form1();
                main.lb_user.Text = ra[2].ToString();
                main.Show(); 
                
                this.Hide();
            }
            else
                MessageBox.Show("no login");
            con.Close();
            ra.Close();
        }

        private void long_Load(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
