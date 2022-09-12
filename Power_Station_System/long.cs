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
using Power_Station_System.warning_code;

namespace Power_Station_System
{

    public partial class @long : Form
    {
        DataBase.users us = new DataBase.users();


       //SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-SVQURFVC\SQLEXPRESS;Initial Catalog=power_state_station;Integrated Security=true");

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-SVQURFVC;Initial Catalog=power_state_station;Integrated Security=true");


        public @long()
        {
            InitializeComponent();

            comboBox1.DataSource = us.get_user();
            comboBox1.DisplayMember = "user_name";
            comboBox1.ValueMember = "user_ID";
             comboBox1.Text = "";
           
        }
        public void Alert(string msg, Form_alert.enmType type)
        {
            Form_alert frm = new Form_alert();
            frm.showAlert(msg, type);
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

               // this.Alert(" تم الدخول بنجاح", Form_alert.enmType.Success);

               
                /* Program.user_ID.ToString()*/
                Form1 main = new Form1();
                main.lb_user.Text = ra[2].ToString();
                main.Show();
               
                
                this.Hide();
            }
            else
                this.Alert("تاكد من كتابة كلمة المرور  ", Form_alert.enmType.Error);

          
            con.Close();
            ra.Close();
        }

        private void long_Load(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RjTextBox2__TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
                if (comboBox1.SelectedIndex >= 0 )
                {
                    rjTextBox2.Focus();
                }
            
        }

        private void RjTextBox2_Load(object sender, EventArgs e)
        {
            
        }

        private void RjTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void RjTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
        //    if(e.KeyCode == Keys.Enter)
        //    {
        //        RjButton1_Click.
        //    }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void long_Activated(object sender, EventArgs e)
        {
            rjTextBox2.Focus();
        }

    }
}
