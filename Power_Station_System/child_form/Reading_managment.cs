using Power_Station_System.warning_code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Power_Station_System.chid_form
{
    public partial class Reading_managment : Form
    {
        DataBase.users users = new DataBase.users();

        DataBase.reading rea = new DataBase.reading();
        private object dataGridView1;
        string meternum = null;
        DataTable tb;
        DataGridViewRow row = null;
        string name_mod, pri, current, met_id;
        int block = -1,id,id_res=-1;
        

        public Reading_managment()
        {
            InitializeComponent();
            try
            {
                datagride_view_customer.DataSource = rea.get_sub_with_reading();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Loadpriv();

        }


        void Loadpriv()
        {


            DataTable Dt = users.priv_Add_priv_Edit(14, Convert.ToInt32(Program.user_ID));


            if (Dt.Rows[0][0].ToString() == "0" || Dt.Rows[0][0].ToString() == String.Empty)
            {
                rjButton1.Enabled = false;

            }


            if (Dt.Rows[0][1].ToString() == "0" || Dt.Rows[0][1].ToString() == String.Empty)
            {

                rjButton2.Enabled = false;


            }
            if (Dt.Rows[0][2].ToString() == "0" || Dt.Rows[0][2].ToString() == String.Empty)
            {
                rjButton3.Enabled = false;
            }
        }

        public void Alert(string msg, Form_alert.enmType type)
        {
            Form_alert frm = new Form_alert();
            frm.showAlert(msg, type);
        }
        public void mod(int meter)
        {
            rjButton1.Text = "حفظ التغيرات";
            rjButton2.Enabled = false;
            custo_name.Texts = row.Cells[5].Value.ToString();
            meter_id.Texts= row.Cells[4].Value.ToString();
            current_reading.Texts= row.Cells[1].Value.ToString();
            privosu_reading.Texts= row.Cells[2].Value.ToString();
            privosu_reading.Enabled = true;
            // meternum = datagride_view_customer.CurrentRow.Cells[4].Value.ToString();
            //  custo_name.Texts = tb.Rows[0][1].ToString();
            //   meter_id.Texts = meter;
            //privosu_reading.Texts = tb.Rows[0][3].ToString();
            datagride_view_customer.Enabled = false;
         //   block = Convert.ToInt16(tb.Rows[0][2].ToString());
            rjButton3.Text = "الغاء";
            // id = Convert.ToInt16(tb.Rows[0][0].ToString());
            
        }
        public void unmod()
        {
            rjButton1.Enabled = true;
            rjButton2.Enabled = true;
            rjButton3.Enabled = true;
            rjButton1.Text = "اضافة";
            rjButton3.Text = "حذف";
            meternum = null;
             tb = null;
            privosu_reading.Enabled = false;
            custo_name.Texts = String.Empty;
            meter_id.Texts = String.Empty;
            privosu_reading.Texts = String.Empty;
            current_reading.Texts = String.Empty;
            datagride_view_customer.Enabled = true;
            block = -1;
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Search__TextChanged(object sender, EventArgs e)
        {

        }

        private void RjButton1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                privosu_reading.Enabled = true;
            }
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RjButton3_Click(object sender, EventArgs e)
        {
            unmod();
        }

        private void RjButton1_Click_1(object sender, EventArgs e)
        {

            if (rjButton1.Text == "اضافة" && meternum != null)
            {
                add(meternum);
            }
            else if (rjButton1.Text == "حفظ" && meternum != null)
            {
                if (current_reading.Texts.Trim().Length < 1)
                {
                    //MessageBox.Show("القراءة الحالية فارغة يحب ادخالها");
                    this.Alert("القراءة الحالية فارغة يحب ادخالها", Form_alert.enmType.Warning);
                    current_reading.Focus();

                }
                else
                {
                    if (Convert.ToInt32(current_reading.Texts) <= Convert.ToInt32(privosu_reading.Texts))
                    {
                       // MessageBox.Show("هناك خطأ ما لا ينبغي ان تكون القراءة الحالية اقل من السابقة");
                        this.Alert("هناك خطأ ما لا ينبغي ان تكون القراءة الحالية اقل من السابقة", Form_alert.enmType.Warning);
                        return;
                    }

                    else { 
                    rea.Add_reading(current_reading.Texts, privosu_reading.Texts, dateTimePicker1.Text, meter_id.Texts, id, block);
                    rea.update_opeiningreading(meter_id.Texts.Trim(), current_reading.Texts, dateTimePicker1.Text);
                    rea.reading_doe(meter_id.Texts.Trim());
                    this.Reading_managment_Load(null, null);
                    //MessageBox.Show("تم اضاقة القراءة بنجاح");
                    this.Alert(" تتم اضاقة القراءة بنجاح", Form_alert.enmType.Success);

                        unmod();
                    }

                }
            }
            else if (rjButton1.Text == "حفظ التغيرات")
            {
                if (current_reading.Texts.Trim().Length < -1)
                {
                    MessageBox.Show("القراءة الحالية فارغة يحب ادخالها");
                    current_reading.Focus();

                }
                else if (privosu_reading.Texts.Trim().Length < -1)
                {
                    MessageBox.Show("القراءة السابقة فارغة يحب ادخالها");
                    privosu_reading.Focus();

                }
                else
                {

                    if (Convert.ToInt32(current_reading.Texts) <= Convert.ToInt32(privosu_reading.Texts))
                    {
                        MessageBox.Show("هناك خطأ ما لا ينبغي ان تكون القراءة الحالية اقل من السابقة");
                        return;
                    }
                    rea.udate_reading(id_res, current_reading.Texts, privosu_reading.Texts, dateTimePicker1.Text, meter_id.Texts);
                    rea.update_opeiningreading(meter_id.Texts.Trim(), current_reading.Texts, dateTimePicker1.Text);
                    rea.reading_doe(meter_id.Texts.Trim());
                    this.Reading_managment_Load(null, null);
                    MessageBox.Show("تمت عملية التعديل بنجاح");
                    unmod();
                }
            }
        }

        void add(string meter)
        {
            rjButton1.Text = "حفظ";
            rjButton2.Enabled = false;
           
            tb = rea.get_name_and_privious(meter);
            custo_name.Texts= tb.Rows[0][1].ToString();
            meter_id.Texts = meter;
            privosu_reading.Texts= tb.Rows[0][3].ToString();
            datagride_view_customer.Enabled = false;
            block= Convert.ToInt16(tb.Rows[0][2].ToString());
            rjButton3.Text = "الغاء";
            id = Convert.ToInt16(tb.Rows[0][0].ToString());

        }

        private void Reading_managment_Load(object sender, EventArgs e)
        {
            try
            {
                datagride_view_customer.DataSource = rea.get_sub_with_reading();
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
                this.Alert(ex.Message, Form_alert.enmType.Error);
            }
        }

        private void RjButton2_Click(object sender, EventArgs e)
        {
            if (id_res != -1)
            {
                mod(id_res);
            }
        }

        private void Datagride_view_customer_Click(object sender, EventArgs e)
        {
            meternum = datagride_view_customer.CurrentRow.Cells[4].Value.ToString();
            id_res = Convert.ToInt32(datagride_view_customer.CurrentRow.Cells[0].Value.ToString());
            row = datagride_view_customer.CurrentRow;
        }
    }
    }

