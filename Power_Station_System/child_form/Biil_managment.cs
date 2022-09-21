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
    public partial class Biil_managment : Form
    {
        DataBase.bill bill = new DataBase.bill();
        DataBase.reading rea = new DataBase.reading();
        public Biil_managment()
        {
            InitializeComponent();
        }
        public void loaddate_to_GV()
        {
            dataGridView1.DataSource = bill.get_reading_to_relase_bill();
        }
        public void get_reading()
        {

            int priv, cur;
            DataTable tbb;
            string debit;
            double x;
            if (dataGridView1.Rows.Count > -1)
            {
                try
                {
                    loaddate_to_GV();
                    for (int item = 0; item < dataGridView1.Rows.Count; item++)
                    {

                        int reading_id = Convert.ToInt32(dataGridView1.Rows[item].Cells["ID_reading"].Value.ToString());
                        int sub_id = Convert.ToInt32(dataGridView1.Rows[item].Cells["ID"].Value.ToString());
                        string name = dataGridView1.Rows[item].Cells["gr_name"].Value.ToString();
                        string meter_number = dataGridView1.Rows[item].Cells["gr_meter"].Value.ToString();
                        string privi_reading = dataGridView1.Rows[item].Cells["gr_privio"].Value.ToString();
                        string current_reading = dataGridView1.Rows[item].Cells["gr_current"].Value.ToString();
                        string date = dataGridView1.Rows[item].Cells["gr_date"].Value.ToString();
                        priv = Convert.ToInt32(privi_reading.ToString());
                        cur = Convert.ToInt32(current_reading.ToString());
                        int kw_used = cur - priv;
                        int kw_price = Convert.ToInt32(dataGridView1.Rows[item].Cells["Kw_price"].Value.ToString());
                        dataGridView1.Rows[item].Cells["gr_alistihlak"].Value = kw_used;
                        dataGridView1.Rows[item].Cells["gr_mony"].Value = kw_used * kw_price;
                        tbb = bill.get_debit(sub_id);
                        debit = tbb.Rows[0][0].ToString();
                        x = -1;
                        if (debit == "")
                        {
                            x = 0;
                        }
                        else
                        {
                            x = Double.Parse(debit);
                        }
                        dataGridView1.Rows[item].Cells["gr_almtikhrat"].Value = x;

                        dataGridView1.Rows[item].Cells["gr_hol_mony"].Value = x + kw_used * kw_price;

                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }


        }
        private void Biil_managment_Load(object sender, EventArgs e)
        {

        }

        private void RjButton3_Click(object sender, EventArgs e)
        {
            get_reading();
        }
        int id = -1;
        private void RjButton1_Click(object sender, EventArgs e)
        {
            DataTable t= bill.gei_id_to_bill();
            int j =Convert.ToInt32(t.Rows[0][0].ToString());
            if (dataGridView1.Rows.Count > -1)
            {
                try
                {
                    for (int item = 0; item < dataGridView1.Rows.Count; item++)
                    {
                        ++j;
                        int sub_id = Convert.ToInt32(dataGridView1.Rows[item].Cells["ID"].Value.ToString());
                        string name = dataGridView1.Rows[item].Cells["gr_name"].Value.ToString();
                        string meter_number = dataGridView1.Rows[item].Cells["gr_meter"].Value.ToString();
                        string privi_reading = dataGridView1.Rows[item].Cells["gr_privio"].Value.ToString();
                        string current_reading = dataGridView1.Rows[item].Cells["gr_current"].Value.ToString();
                        string date = dataGridView1.Rows[item].Cells["gr_date"].Value.ToString();
                        //   string month_flos= dataGridView1.Rows[item].Cells["gr_mony"].Value.ToString();
                        string month_flos = dataGridView1.Rows[item].Cells["gr_mony"].Value.ToString();
                        int bloc_k = Convert.ToInt32(dataGridView1.Rows[item].Cells["blok"].Value.ToString());
                      
                        //
                        int reading_id = int.Parse(dataGridView1.Rows[item].Cells["ID_reading"].Value.ToString());
                        //
                        string kw_used = dataGridView1.Rows[item].Cells["gr_alistihlak"].Value.ToString();
                        string kw_price = dataGridView1.Rows[item].Cells["Kw_price"].Value.ToString();
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



                        bill.inset_Bill(name, meter_number, amonut_maony, sub_id, date, reading_id, privi_reading,
                            current_reading, kw_used, kw_price, block_id, gr_almtikhrat, month_flos, mang_writing, j);

                        rea.udate_reading_date_of_bill(reading_id);
                        //  bill.update_depet(meter_number, amonut_maony);


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    for (int item = dataGridView1.Rows.Count - 1; item >= 0; item--)
                    {
                        dataGridView1.Rows.RemoveAt(item);
                    }
                    MessageBox.Show("done");
                 

                }

            }
        }
    }
}
