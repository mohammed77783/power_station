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

namespace Power_Station_System.child_form
{
    public partial class Add_bill : Form
    {
        DataBase.subscriber su = new DataBase.subscriber();
        DataBase.reading rea = new DataBase.reading();
        DataBase.bill bill = new DataBase.bill();
        DataTable tb,kwpric;
        string address=null;
        other_class.number_to_text numb = new other_class.number_to_text();
        int Block,subscriber_id;
        public Add_bill()
        {
            InitializeComponent();
            comboBox1.DataSource = bill.get_subscriber_for_bill();
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "Subscriber_ElectricMeter_ID";

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            clear();
            try
            {
                tb = rea.get_name_and_privious(comboBox1.SelectedValue.ToString());
                meter_ber.Text = comboBox1.SelectedValue.ToString();
                kwpric = bill.killoWat(meter_ber.Text);
                manth_fee.Text = kwpric.Rows[0][2].ToString();
                meter_ber.Text = comboBox1.SelectedValue.ToString();
                kW_pric.Text = kwpric.Rows[0][1].ToString();
                privious_reding.Text = tb.Rows[0][3].ToString();
                // datagride_view_customer.Enabled = false;
                Block = Convert.ToInt16(tb.Rows[0][2].ToString());
                rjButton3.Text = "الغاء";
                subscriber_id = Convert.ToInt16(tb.Rows[0][0].ToString());
                address = tb.Rows[0][4].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {

            }
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
                if (x < y) return;
                if (x > y) { 
                double amo = (x - y);
                double mont = Double.Parse(kW_pric.Text);
                alisthlak.Text = Convert.ToString(amo);
                y = Double.Parse(kW_pric.Text);
                    x = (amo * y);
                amout.Text = Convert.ToString(x);
                if (checkbo.Checked == true)
                {
                    x +=Convert.ToUInt32(manth_fee.Text);
                }

                ho_money.Text = x.ToString();
                }
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

        }

        private void Alisthlak_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Amout_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Checkbo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbo.Checked) { 
            int y = int.Parse(manth_fee.Text)+int.Parse(amout.Text);
            ho_money.Text = Convert.ToString(y);
            }
            else
            {
                ho_money.Text = amout.Text;
            }
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void RjButton1_Click(object sender, EventArgs e)
        {

        }

        private void RjButton4_Click(object sender, EventArgs e)
        {
            if (current_reading.Text.Length > 0 && ho_money.Text.Length > 0)
            {
                if (dataGridView1.Rows.Count>-1) { 
                for (int item = 0; item < dataGridView1.Rows.Count; item++)
                {
                    if (meter_ber.Text == dataGridView1.Rows[item].Cells["gr_meter"].Value.ToString())
                    {
                        MessageBox.Show("قد تم اضافة العميل مسبقا");
                        clear();
                        return;

                    }
                    
                }
                }

                addtogridview();

            }
        }

        public void addtogridview()
        {

            string name = comboBox1.Text;
            string meter_nu = meter_ber.Text;
            string prvi = privious_reding.Text;
            string cuu = current_reading.Text;
            string manth_f = manth_fee.Text;
            string use_kw = alisthlak.Text;
            string kw_pric = kW_pric.Text;
            string all_mny = ho_money.Text;
            DataTable tbb = bill.get_debit(meter_nu);
            string debit=tbb.Rows[0][0].ToString();
            double x = Double.Parse(debit);
            double y= Double.Parse(all_mny);
            double all_mney = x + y;
            string date = dateTimePicker1.Text;

            Object[] row = { name,address ,meter_nu, cuu , prvi, manth_f, use_kw, kw_pric, all_mny, debit, all_mney, date };
            dataGridView1.Rows.Add(row);
            clear();
        }
        public void clear()
        {
            comboBox1.Text = String.Empty;
            meter_ber.Text = String.Empty;
            privious_reding.Text = String.Empty;
            current_reading.Text = String.Empty;
            manth_fee.Text = String.Empty;
            alisthlak.Text = String.Empty;
            kW_pric.Text = String.Empty;
            ho_money.Text = String.Empty;


        }
        private void Current_reading_Enter(object sender, EventArgs e)
        {
            
        }

        private void Current_reading_DragEnter(object sender, DragEventArgs e)
        {
           
        }

        private void Current_reading_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        string oldcu;
        private void DataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
          if (dataGridView1.CurrentRow != null) {
                oldcu = dataGridView1.CurrentRow.Cells["gr_current"].Value.ToString();

                    }
        }

        private void DataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void Current_reading_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&& !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Ho_money_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = numb.convertcurrency(ho_money.Text, " ", " ريال ");
            }
            catch (Exception ex)
            {

            }
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Manth_fee_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void KW_pric_TextChanged(object sender, EventArgs e)
        {

        }

        private void Privious_reding_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
             if (dataGridView1.CurrentRow != null)
            {
              
                string newcur = dataGridView1.CurrentRow.Cells["gr_current"].Value.ToString();
                int x = int.Parse(newcur);
                if (newcur == oldcu) return;
             
                if (!Regex.IsMatch(newcur, "^\\d+$"))
                {
                  
                    dataGridView1.CurrentRow.Cells["gr_current"].Value = oldcu;
                }
                else
                {
                    MessageBox.Show(x + "ee");
                    double curre = double.Parse(dataGridView1.CurrentRow.Cells["gr_current"].Value.ToString());
                    double pri = double.Parse(dataGridView1.CurrentRow.Cells["gr_privio"].Value.ToString());
                    if (x > pri) { 
                 
                    double _manthe_fes = double.Parse(dataGridView1.CurrentRow.Cells["gr_manthe_fes"].Value.ToString());
                    double kwpr = double.Parse(dataGridView1.CurrentRow.Cells["Kw_price"].Value.ToString());
                   
                    double almti = double.Parse(dataGridView1.CurrentRow.Cells["gr_almtikhrat"].Value.ToString());
                    double _hol_mony;
                    double alistih = curre- pri ;
                    dataGridView1.CurrentRow.Cells["gr_alistihlak"].Value = alistih.ToString();
                    if(MessageBox.Show("هل ترشد فاتور معا اشتراك","", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes) { 
                    _hol_mony = alistih * kwpr+ almti;
                        _hol_mony += _manthe_fes;
                    }
                    else
                    {
                        _hol_mony = alistih * kwpr+ almti;
                    }

                    dataGridView1.CurrentRow.Cells["gr_hol_mony"].Value=_hol_mony.ToString();
                }
                }
            }
        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }
    }
}
