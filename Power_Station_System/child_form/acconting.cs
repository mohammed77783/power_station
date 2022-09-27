using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;



namespace Power_Station_System.child_form
{
    public partial class acconting : Form
    {
        int subscriber_id;

        DataBase.subscriber su = new DataBase.subscriber();
        DataBase.chatch chatch = new DataBase.chatch();
        DataTable tb;
        public acconting()
        {
            InitializeComponent();
        }
     
        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "Subscriber_name";
            comboBox1.ValueMember = "ID_Subscriber";
            comboBox1.DataSource = su.get_subscriber();

            comboBox1.Text = "";
        }
        public void clear()
        {
            comboBox1.Text = String.Empty;
            textBox_Custom3.Texts = String.Empty;
            textBox_Custom1.Texts = String.Empty;
            textBox_Custom2.Texts = String.Empty;
        }
            private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            clear();

            try
            {
               
                {
                    tb = chatch.get_total(int.Parse(comboBox1.SelectedValue.ToString()));
                    textBox_Custom3.Texts = tb.Rows[0][1].ToString();

                    textBox_Custom1.Texts = tb.Rows[0][2].ToString();

                    textBox_Custom2.Texts = tb.Rows[0][3].ToString();
                    dataGridView2.DataSource = chatch.get_Account(Convert.ToInt16(comboBox1.SelectedValue));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {

            }

        }

        private void TextBox_Custom1__TextChanged(object sender, EventArgs e)
        {

        }

        private void Acconting_Load(object sender, EventArgs e)
        {
          
        }

        private void RjButton1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_Custom3__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
