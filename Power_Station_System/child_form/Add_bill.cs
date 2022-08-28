using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Power_Station_System.child_form
{
    public partial class Add_bill : Form
    {
        DataBase.subscriber su = new DataBase.subscriber();
        DataBase.reading rea = new DataBase.reading();
        DataBase.bill bill = new DataBase.bill();
        DataTable tb,kwpric;
        other_class.number_to_text numb = new other_class.number_to_text();
        int Block,subscriber_id;
        public Add_bill()
        {
            InitializeComponent();
            comboBox1.DataSource = su.get_subscriber();
            comboBox1.DisplayMember = "Subscriber_name";
            comboBox1.ValueMember = "Subscriber_ElectricMeter_ID";
            comboBox1.SelectedIndex = -1; 
         
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void RjTextBox4__TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RjTextBox3__TextChanged(object sender, EventArgs e)
        {
         
        }

        private void Meter_ber__TextChanged(object sender, EventArgs e)
        {

        }

        private void Meter_ber_TextChanged(object sender, EventArgs e)
        {

        }

        private void Current_reading_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double x = Double.Parse(current_reading.Text);
                double y = Double.Parse(privious_reding.Text);
                double amo = (x - y);
                double mont = Double.Parse(textBox1.Text);
                alisthlak.Text = Convert.ToString(amo);
                y = Double.Parse(textBox1.Text);
                if (checkbo.Checked) {
                x = (amo * y) + mont;
                }
                else
                {
                    x = (amo * y);
                }
                amout.Text = Convert.ToString(x);

            }
            catch(Exception ex)
            {

            }
            }

        private void Current_reading_Validated(object sender, EventArgs e)
        {
           

        }

        private void ComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                tb = rea.get_name_and_privious(comboBox1.SelectedValue.ToString());
                meter_ber.Text = comboBox1.SelectedValue.ToString();
                kwpric = bill.killoWat(meter_ber.Text);
                
                meter_ber.Text = comboBox1.SelectedValue.ToString();
                textBox1.Text= kwpric.Rows[0][1].ToString();
                privious_reding.Text = tb.Rows[0][3].ToString();
                // datagride_view_customer.Enabled = false;
                Block = Convert.ToInt16(tb.Rows[0][2].ToString());
                rjButton3.Text = "الغاء";
                subscriber_id = Convert.ToInt16(tb.Rows[0][0].ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
               
            }

        }

        private void Alisthlak_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Amout_TextChanged(object sender, EventArgs e)
        {
            try { 
            textBox2.Text=numb.convertcurrency(amout.Text," ", " ريال ");
            }
            catch(Exception ex)
            {
                
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }
    }
}
