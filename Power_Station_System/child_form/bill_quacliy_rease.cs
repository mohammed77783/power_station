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
    public partial class bill_quacliy_rease : Form
    {
        DataBase.bill bill = new DataBase.bill();
        DataBase.Block_aned_area BA = new DataBase.Block_aned_area();
        int index = -1;
        DataBase.subscriber su = new DataBase.subscriber();
        DataBase.reading rea = new DataBase.reading();
     
        public bill_quacliy_rease()
        {
            InitializeComponent();
            comboBox3.DisplayMember = "Block_name";
            comboBox3.ValueMember = "ID";
            comboBox2.DisplayMember = "are_name";
            comboBox2.ValueMember = "ID";
            comboBox3.DataSource = BA.get_Block();
            comboBox2.DataSource = BA.get_area();
        
          
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        string oldcu;
        private void DataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                oldcu = dataGridView1.CurrentRow.Cells["gr_privio"].Value.ToString();

            }
        }

        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string newcur = null;
                try
                {

                    newcur = dataGridView1.CurrentRow.Cells["gr_current"].Value.ToString();

                    if (!Regex.IsMatch(newcur, "^\\d+$"))
                    {
                        return;

                    }
                    else
                    {
                        double curre = double.Parse(dataGridView1.CurrentRow.Cells["gr_current"].Value.ToString());
                        double pri = double.Parse(dataGridView1.CurrentRow.Cells["gr_privio"].Value.ToString());

                        if (curre == pri)
                        {
                            dataGridView1.CurrentRow.Cells["gr_current"].Value = "";
                            return;
                        }
                        if (curre < pri)
                        {
                            dataGridView1.CurrentRow.Cells["gr_current"].Value = "";
                            return;
                        }
                        // MessageBox.Show(x + "ee");

                        if (curre > pri)
                        {

                            double _manthe_fes = double.Parse(dataGridView1.CurrentRow.Cells["gr_manthe_fes"].Value.ToString());
                            double kwpr = double.Parse(dataGridView1.CurrentRow.Cells["gr_Kw_price"].Value.ToString());

                            double almti = double.Parse(dataGridView1.CurrentRow.Cells["gr_almtikhrat"].Value.ToString());
                            double _hol_mony;
                            double alistih = curre - pri;
                            dataGridView1.CurrentRow.Cells["gr_alistihlak"].Value = alistih.ToString();
                            if (MessageBox.Show("هل ترشد فاتور معا اشتراك", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                            {
                                _hol_mony = alistih * kwpr;
                                dataGridView1.CurrentRow.Cells["gr_mony"].Value = _hol_mony.ToString();
                                _hol_mony += +almti;
                                _hol_mony += _manthe_fes;
                            }
                            else
                            {
                                _hol_mony = alistih * kwpr;
                                dataGridView1.CurrentRow.Cells["gr_mony"].Value = _hol_mony.ToString();
                                _hol_mony += +almti;

                            }

                            dataGridView1.CurrentRow.Cells["gr_hol_mony"].Value = _hol_mony.ToString();
                            dataGridView1.CurrentRow.Cells["gr_date"].Value = DateTime.UtcNow.ToString("yyyy-dd-MM");
                        }
                    }
                }

                catch (Exception ex)
                {

                }

            }
        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text!=null)
            {
           

                dataGridView1.DataSource = bill.get_togr_block(comboBox3.Text);
            }


        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text!= null)
           {
            dataGridView1.DataSource = bill.get_togr_are(Convert.ToInt32(comboBox2.SelectedValue));
           }
        }

        private void RjButton1_Click(object sender, EventArgs e)
        {
            DataTable t = bill.gei_id_to_bill();
            int j = Convert.ToInt32(t.Rows[0][0].ToString());
            if (dataGridView1.Rows.Count > -1)
            {
                try
                {
                    for (int item = 0; item < dataGridView1.Rows.Count; item++)
                    {
                        ++j;
                    if (dataGridView1.Rows[item].Cells["gr_current"].Value==null) continue;
                        int sub_id = Convert.ToInt32(dataGridView1.Rows[item].Cells["ID"].Value.ToString());
                        string name = dataGridView1.Rows[item].Cells["gr_name"].Value.ToString();
                        string meter_number = dataGridView1.Rows[item].Cells["gr_meter"].Value.ToString();
                        string privi_reading = dataGridView1.Rows[item].Cells["gr_privio"].Value.ToString();
                        string current_reading = dataGridView1.Rows[item].Cells["gr_current"].Value.ToString();
                        string date =dataGridView1.Rows[item].Cells["gr_date"].Value.ToString();
                        //   string month_flos= dataGridView1.Rows[item].Cells["gr_mony"].Value.ToString();
                        string month_flos = dataGridView1.Rows[item].Cells["gr_mony"].Value.ToString();
                        int bloc_k = Convert.ToInt32(dataGridView1.Rows[item].Cells["blok"].Value.ToString());
                        rea.Add_reading(current_reading, privi_reading, DateTime.Now.ToString(), meter_number, sub_id, bloc_k);
                        rea.update_opeiningreading(meter_number, current_reading, DateTime.Now.ToString());
                        rea.reading_doe(meter_number);
                        DataTable tb = bill.getreading_id(meter_number);
                        if (tb.Rows.Count < 0)
                        {
                            MessageBox.Show("error");
                            return;
                        }
                        //
                        int reading_id = int.Parse(tb.Rows[0][0].ToString());
                        //
                        string kw_used = dataGridView1.Rows[item].Cells["gr_alistihlak"].Value.ToString();
                        string kw_price = dataGridView1.Rows[item].Cells["gr_Kw_price"].Value.ToString();
                        //
                        string amonut_maony = dataGridView1.Rows[item].Cells["gr_hol_mony"].Value.ToString();
                        int block_id = Convert.ToInt32(dataGridView1.Rows[item].Cells["blok"].Value.ToString());
                        //
                        string gr_almtikhrat = dataGridView1.Rows[item].Cells["gr_almtikhrat"].Value.ToString();

                        string mang_writing = other_class.number_to_text.convertcurrency(amonut_maony, " ", " ريال ");
                        string messag = "عزيزي العميل لدي فاتورة كهرباء بمبلغ مقدارة" + block_id + " عليك الاسراع بسداد المبلغ حتى لا يعرضك للفصل /n ولكم جزيل الشكر";
                        //serialPort1.PortName = "COM4";
                        //serialPort1.ReadTimeout = 2000;

                        //serialPort1.Open();
                        //serialPort1.Write("AT\r");
                        //serialPort1.Write("AT+CMGF=1\r");
                        //System.Threading.Thread.Sleep(2000);
                        //serialPort1.WriteLine("AT+CSCS=\"CDMA\"" + Environment.NewLine);
                        //serialPort1.Write("AT+CMGF=\""+"774373601"+"\""+ Environment.NewLine);
                        //System.Threading.Thread.Sleep(2000);
                        //serialPort1.Write(messag +Environment.NewLine);
                        //System.Threading.Thread.Sleep(2000);
                        //serialPort1.Write(new Byte[] { 26 }, 0, 1);
                        //System.Threading.Thread.Sleep(2000);
                        //var dd = serialPort1.ReadExisting();
                        //if (dd.Contains("ERRCR"))
                        //{
                        //    MessageBox.Show("faild");
                        //}
                        //MessageBox.Show("Sucsse");
                        //serialPort1.Close();
                        //  send();
                        bill.inset_Bill(name, meter_number, amonut_maony, sub_id, DateTime.Now.ToString(), 
                            reading_id, privi_reading, current_reading, kw_used, kw_price, block_id, gr_almtikhrat, month_flos, mang_writing,j);                 
                        dataGridView1.Rows.RemoveAt(item);
                        dataGridView1.Refresh();

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
        }

        private void RjButton3_Click(object sender, EventArgs e)
        {

        }

        private void RjButton2_Click(object sender, EventArgs e)
        {
        }

        private void RjButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void RjButton2_Click_2(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = bill.get_togrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Search__TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("Subscriber_ElectricMeter_ID + Subscriber_name like '%" + search.Texts + "%'");
        }
    }
}


        
    
