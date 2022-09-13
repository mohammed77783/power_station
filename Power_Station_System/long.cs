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
            DataTable DD = us.login_user(comboBox1.Text, rjTextBox2.Texts);
            if (DD.Rows.Count > 0)
            {
                Form1 main = new Form1();
                main.lb_user.Text = DD.Rows[0][2].ToString();
                main.Show();

                this.Hide();

            }
            else
            {
                MessageBox.Show("اسم المستخدم أو كلمة المرور خاطئة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
          
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
