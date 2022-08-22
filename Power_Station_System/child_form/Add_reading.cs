using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Power_Station_System.DataBase;
namespace Power_Station_System.chid_form
{
    public partial class Add_reading : Form
    {
        reading rea = new reading();
        string meter_iD;
        int block,id;
        DataTable tb;
        public Add_reading()
        {
            InitializeComponent();
            
            
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Datagride_view_customer_Click(object sender, EventArgs e)
        {
            try { 
            meter_iD= datagride_view_customer.CurrentRow.Cells[3].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void RjButton2_Click(object sender, EventArgs e)
        {
            CheckBox ck = new CheckBox();
            bool d= Convert.ToBoolean(Convert.ToInt32( datagride_view_customer.CurrentRow.Cells[4].Value.ToString())); 
            ck.Checked = d;
            if (!ck.Checked)
            {
                if (meter_iD != null)
                {
                    tb = rea.get_name_and_privious(meter_iD);
                    name_sub.Texts = tb.Rows[0][1].ToString();
                    meter_.Texts = meter_iD;
                    privosu_reading.Texts = tb.Rows[0][3].ToString();
                    rjButton2.Enabled = false;
                    rjButton1.Enabled = true;
                    datagride_view_customer.Enabled = false;
                    id = Convert.ToInt16(tb.Rows[0][0].ToString());
                    block = Convert.ToInt16(tb.Rows[0][2].ToString());
                }
            }
         
        }
        public void clear()
        {
            name_sub.Texts= String.Empty;
            privosu_reading.Texts= String.Empty;
           current_reading.Texts= String.Empty;
            meter_.Texts = String.Empty;
            meter_iD = null;
            rjButton2.Enabled = false;
            datagride_view_customer.Enabled = true;
            rjButton2.Enabled = true;
            tb = null;
        }
        private void RjButton1_Click(object sender, EventArgs e)
        {
            if (current_reading.Texts.Trim().Length < 1)
            {
                MessageBox.Show("القراءة الحالية فارغة يحب ادخالها");
                current_reading.Focus();

            }
            else
            {
                if (Convert.ToInt16(current_reading.Texts) <= Convert.ToInt16(privosu_reading.Texts))
                {
                    MessageBox.Show("هناك خطأ ما لا ينبغي ان تكون القراءة الحالية اقل من السابقة");
                    return;
                }
                if (current_reading.Texts.Trim().Length < 1)
                {
                    MessageBox.Show("القراءة الحالية فاضية ");
                    return;
                }
                else
                {
                    rea.Add_reading(current_reading.Texts, privosu_reading.Texts, dateTimePicker1.Text, meter_.Texts, id, block);
                    rea.update_opeiningreading(meter_.Texts.Trim(), current_reading.Texts, dateTimePicker1.Text);
                    rea.reading_doe(meter_.Texts.Trim());
                    this.Add_reading_Load(null, null);
                    MessageBox.Show("تم اضاقة القراءة بنجاح");

                    clear();


                }
            }
        }

            private void Add_reading_Load(object sender, EventArgs e)
        {
            try
            {
                datagride_view_customer.DataSource = rea.manth_customer_name();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void RjButton3_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
