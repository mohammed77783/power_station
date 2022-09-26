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
    public partial class read : Form
    {
        DataBase.reading cus = new DataBase.reading();
        DataBase.subscriber subs = new DataBase.subscriber();
        DataBase.users users = new DataBase.users();

        string meter_id , open_read; 
        string name, date;

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        public read()
        {
            InitializeComponent();
             Loadpriv();


        }

        void Loadpriv()
        {


            DataTable Dt = users.priv_Add_priv_Edit(10, Convert.ToInt32(Program.user_ID));




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

        private void Read_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = cus.get_opening_reading();
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
                this.Alert(ex.Message, Form_alert.enmType.Error);
            }
        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            meter_id = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            open_read = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            date = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

    

        public void Clear()
        {
            textBox_Custom1.Texts = String.Empty;

            textBox_Custom3.Texts = String.Empty;
            textBox_Custom2.Texts = String.Empty;
        }
        public void unmod()
        {
            dataGridView1.Enabled = true;
            //rjButton3.Enabled = false;
            //rjButton2.Enabled = true;
            rjButton2.Text = "تعديل";
        }
        public void mod()
        {
           // if (name!= null && meter_id != null)
            {
                dataGridView1.Enabled = false;
                textBox_Custom1.Texts = name;
                textBox_Custom3.Texts = meter_id;
                rjButton3.Text = "إلغاء";
                rjButton2.Text = "حفظ التغيرات";
                textBox_Custom1.Enabled = false;
                textBox_Custom3.Enabled = false;
            }
            


            

        }
        private void RjButton2_Click(object sender, EventArgs e)
        {
            if (rjButton2.Text == "تعديل")
            {

                mod();
            }

            else if (rjButton2.Text == "حفظ التغيرات")
            {

                {
                    if (textBox_Custom2.Texts.Trim().Length < 1)  

                    {
                       // MessageBox.Show("القراءة الافتتاحية فارغة ");
                        this.Alert("القراءة الافتتاحية فارغة", Form_alert.enmType.Warning);
                        return;
                    }
                    else
                    {
                        try
                        {
                            cus.update_opeiningreading(textBox_Custom3.Texts, textBox_Custom2.Texts, dateTimePicker1.Text);

                           // MessageBox.Show("تمت التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Alert(" تمت التعديل بنجاح", Form_alert.enmType.Success);
                            unmod();
                            Clear();
                            this.Read_Load(null, null); 



                        }
                        catch (Exception ex)
                        {
                           // MessageBox.Show(ex.Message);
                            this.Alert(ex.Message, Form_alert.enmType.Error);
                        }
                    }


                }
            }
        }
  

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RjButton3_Click(object sender, EventArgs e)
        {
            if (rjButton3.Text == "إلغاء")
            {

                unmod();
                Clear();
            }
           
           
        }

        private void TextBox_Custom2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void RjButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
