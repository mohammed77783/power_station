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
using Power_Station_System.warning_code;

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
        public void Alert(string msg, Form_alert.enmType type)
        {
            Form_alert frm = new Form_alert();
            frm.showAlert(msg, type);
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
                //MessageBox.Show(ex.Message);
                this.Alert(ex.Message, Form_alert.enmType.Error);
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
                    try { 
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
                    catch(Exception ex)
                    {
                        MessageBox.Show("هناك خطأ في ادخال بيانات العملاء عليك حذف العميل واذخال بيانات بشكل صحيح");
                    }
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
            rjButton1.Enabled = false;
        }
        private void RjButton1_Click(object sender, EventArgs e)
        {
            if (current_reading.Texts.Trim().Length < 1)
            {
                //MessageBox.Show("القراءة الحالية فارغة يحب ادخالها");
                this.Alert("القراءة الحالية فارغة يحب ادخالها", Form_alert.enmType.Warning);
                current_reading.Focus();

            }
            else
            {
                if (Convert.ToInt16(current_reading.Texts) <= Convert.ToInt16(privosu_reading.Texts))
                {
                   // MessageBox.Show("هناك خطأ ما لا ينبغي ان تكون القراءة الحالية اقل من السابقة");
                    this.Alert("هناك خطأ ما لا ينبغي ان تكون القراءة الحالية اقل من السابقة", Form_alert.enmType.Warning);
                    return;
                }
                if (current_reading.Texts.Trim().Length < 1)
                {
                    //MessageBox.Show("القراءة الحالية فاضية ");
                    this.Alert("القراءة الحالية فاضية", Form_alert.enmType.Warning);
                    return;
                }
                else
                {
                    rea.Add_reading_withoutbill(current_reading.Texts, privosu_reading.Texts, dateTimePicker1.Text, meter_.Texts, id, block);
                    rea.update_opeiningreading(meter_.Texts.Trim(), current_reading.Texts, dateTimePicker1.Text);
                    rea.reading_doe(meter_.Texts.Trim());
                    this.Add_reading_Load(null, null);
                    //MessageBox.Show("تم اضاقة القراءة بنجاح");
                    this.Alert(" تم اضاقة القراءة بنجاح", Form_alert.enmType.Success);

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
                //MessageBox.Show(ex.Message);
                this.Alert(ex.Message, Form_alert.enmType.Error);
            }

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RjButton3_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
