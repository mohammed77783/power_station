using System;
using Power_Station_System.warning_code;
using System.Data.SqlClient;
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

    public partial class receiptt : Form
    {
        DataTable tb;
        int id_catch; string name; float total_Catch; int sub_id; string nots; int ID;
        int val;
        string Data_time;
        DataBase.users users = new DataBase.users();

        DataBase.subscriber su = new DataBase.subscriber();
        DataBase.chatch chatch = new DataBase.chatch();
        public receiptt()
        {

            InitializeComponent();
            comboBox1.DisplayMember = "Subscriber_name";
            comboBox1.ValueMember = "ID_Subscriber";
            comboBox1.DataSource = su.get_subscriber();
            Loadpriv();


        }


        private void Receiptt_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = chatch.get_Catch ();

            }

            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message);
               // this.Alert(ex.Message, Form_alert.enmType.Error);
            }
        }
        void Loadpriv()
        {


            DataTable Dt = users.priv_Add_priv_Edit(21, Convert.ToInt32(Program.user_ID));


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

        public void clea()
        {
            comboBox1.Text = String.Empty;
            textBox_numbr.Texts = String.Empty;
            textBox_Custom1.Texts = String.Empty;
            dateTimePicker1.Text = String.Empty;
            textBox_Custom2.Texts = String.Empty;
        }
        public void Clear()
        {
            comboBox1.Text = textBox_numbr.Texts = textBox_Custom1.Texts = dateTimePicker1.Text = textBox_Custom2.Texts= String.Empty;

        }
        public void unmod()
        {
            dataGridView1.Enabled = true;
            rjButton1.Enabled = true;
            rjButton2.Enabled = true;
            rjButton3.Enabled = true;
            rjButton1.Text = "إضافة";
            rjButton3.Text = "حذف";
        }
        public void mod()
        {
            if (ID != null)
            {
                dataGridView1.Enabled = false;

                dateTimePicker1.Text = Data_time;

                rjButton3.Text = "الغاء";
                rjButton1.Text = "حقظ التغيرات";
                rjButton2.Enabled = false;

            }
        }
        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RjButton1_Click(object sender, EventArgs e)
        {
            if (rjButton1.Text == "اضافة")
            {
                if (textBox_numbr.Texts.Trim().Length < 1)
                {
                    MessageBox.Show("إسم المحصل فارغ ");
                    //this.Alert("إسم المحصل فارغ", Form_alert.enmType.Warning);
                    return;
                }
                else if (comboBox1.SelectedIndex == -1)
                {
                     MessageBox.Show(" إسم المريع   فارغ ");
                    // this.Alert("إسم المريع   فارغ", Form_alert.enmType.Warning);
                    return;
                }
                else if (textBox_Custom1.Texts.Trim().Length < 1)
                {
                     MessageBox.Show("  عنوان المحصل فارغ ");
                    // this.Alert("عنوان المحصل فارغ", Form_alert.enmType.Warning);
                    return;
                }
              
               
                else
                    try
                    {
                        chatch.Add_Catch(Convert.ToInt32(textBox_numbr.Texts), comboBox1.Text, float.Parse(textBox_Custom1.Texts), Convert.ToInt32(comboBox1.SelectedValue) , dateTimePicker1.Text, textBox_Custom2.Texts);

                         MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //this.Alert(" تمت الإضافة بنجاح", Form_alert.enmType.Success);

                        Clear();
                        this.Receiptt_Load(null, null);

                    }
                    catch (Exception ex)
                    {
                         MessageBox.Show(ex.Message);
                        // this.Alert(ex.Message, Form_alert.enmType.Error);
                    }

            }

            if (rjButton1.Text == "حقظ التغيرات")
            {


                if (textBox_numbr.Texts.Trim().Length < 1)
                {
                    MessageBox.Show("رقم السند  فارغ ");
                    //this.Alert("إسم المحصل فارغ", Form_alert.enmType.Warning);
                    return;
                }
                else if (comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show(" إسم العميل    فارغ ");
                    // this.Alert("إسم المريع   فارغ", Form_alert.enmType.Warning);
                    return;
                }
                else if (textBox_Custom1.Texts.Trim().Length < 1)
                {
                    MessageBox.Show("  قيمة السند  فارغ ");
                    // this.Alert("عنوان المحصل فارغ", Form_alert.enmType.Warning);
                    return;
                }

                else
                    try
                    {
                        chatch.up_catch(Convert.ToInt32(textBox_numbr.Texts), comboBox1.Text, float.Parse(textBox_Custom1.Texts), Convert.ToInt32(comboBox1.ValueMember), dateTimePicker1.Text, textBox_Custom2.Texts,ID);

                         MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //this.Alert(" تم التعديل بنجاح", Form_alert.enmType.Success);
                        unmod();
                        Clear();
                        this.Receiptt_Load(null, null);
                    }
                    catch (Exception ex)
                    {
                         MessageBox.Show(ex.Message);
                       // this.Alert(ex.Message, Form_alert.enmType.Error);
                    }
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       /* private void AutoID()
        {
            access.open();
            SqlCommand cmd = new SqlCommand("selectcount( ID_Catch) from[tb_Catch_Receipt] ");

            int i = Convert.ToInt32(cmd.ExecuteScalar());
            access.close();
            i++;

            label4.Text - val + i.ToString();


        }*/
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            id_catch = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            total_Catch = float.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());

            Data_time = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            nots = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }

        private void RjButton2_Click(object sender, EventArgs e)
        {
            mod();
        }

        private void RjButton3_Click(object sender, EventArgs e)
        {
            if (rjButton3.Text == "الغاء")
            {
                unmod();
                Clear();
                ID = -1;

            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void IconButton3_Click(object sender, EventArgs e)
        {
            RPT.Recepit myrpt = new RPT.Recepit();
            myrpt.SetParameterValue("@ID_Catch", this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            RPT.RPTForm myform = new RPT.RPTForm();
            myform.crystalReportViewer1.ReportSource = myrpt;
            myform.ShowDialog();
        }
    }
}
