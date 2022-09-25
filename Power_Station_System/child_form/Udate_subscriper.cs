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
    public partial class Udate_subscriper : Form
    {
        DataBase.subscriber sub = new DataBase.subscriber();
        DataBase.Block_aned_area block = new DataBase.Block_aned_area();
        //for moving form
        int x, y, move;

        int ID;
        customer_management father;
        DataTable table;
        public Udate_subscriper(int ID, customer_management fat)
        {
            InitializeComponent();
            this.ID = ID;
            this.father = fat;

            comboBox1.DataSource = sub.get_subscription();
            comboBox1.DisplayMember = "Subscription_Type";
            comboBox1.ValueMember = "ID_Subscription";
            this.table = sub.get_spacific_subscription(ID);
            comboBox2.DisplayMember = "Block_name";
            comboBox2.ValueMember = "ID";
            comboBox2.DataSource = block.get_Block();
         

        }
        public void Alert(string msg, Form_alert.enmType type)
        {
            Form_alert frm = new Form_alert();
            frm.showAlert(msg, type);
        }
        private void OurPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void RjButton1_Click(object sender, EventArgs e)
        {

            if (subscriper_name_upd.Texts.Trim().Length < 1)
            {
                MessageBox.Show("إسم المشترك فارغ ");
                this.Alert("Warning Alert", Form_alert.enmType.Warning);
                return;
            }

            else if (subscr_phnum_upd.Texts.Trim().Length < 3)
            {
              //  MessageBox.Show("رقم المشترك فارغ ");
                this.Alert("رقم المشترك فارغ", Form_alert.enmType.Warning);
                return;
            }

            else if (sub_address_upda.Texts.Trim().Length < 3)
            {
                //MessageBox.Show("عنوان المشترك فارغ ");
                this.Alert("عنوان المشترك فارغ", Form_alert.enmType.Warning);
                return;
            }

            else if (indenity_number_upda.Texts.Trim().Length < 3)
            {
              //  MessageBox.Show("رقم الهوية فارغ ");
                this.Alert("رقم الهوية فارغ", Form_alert.enmType.Warning);
                return;
            }
            else if (this.identity_ty.SelectedIndex == -1)
            {
               // MessageBox.Show("نوع الهوية فارغ ");
                this.Alert("نوع الهوية فارغ", Form_alert.enmType.Warning);
                return;
            }

            else if (this.comboBox1.SelectedIndex == -1)
            {
                //MessageBox.Show("نوع الاشتراك فارغ ");
                this.Alert("نوع الاشتراك فارغ", Form_alert.enmType.Warning);
                return;
            }
            else
            {
                try
                {
                    sub.update_csut(ID, subscriper_name_upd.Texts, subscr_phnum_upd.Texts, sub_address_upda.Texts,identity_ty.Text, indenity_number_upda.Texts,
                  Convert.ToInt16(comboBox1.SelectedValue), meter_number_UP.Texts,dateTimePicker1.Text, Convert.ToInt16(comboBox2.SelectedValue));

                   // MessageBox.Show("تمت التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Alert(" تمت التعديل بنجاح", Form_alert.enmType.Success);
                    customer_management dd = new customer_management();
                    father.upGrid();
                    ///father.Add_customer_1_Load(null,null);
                }
                catch (Exception ex)
                {
                   // MessageBox.Show(ex.Message);
                    this.Alert(ex.Message, Form_alert.enmType.Error);
                }
            }
        }

        private void Subscr_phnum_upd__TextChanged(object sender, EventArgs e)
        {

        }

        private void OurPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
        }

        private void OurPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            x = e.X;
            y = e.Y;
        }

        private void Udate_subscriper_Load(object sender, EventArgs e)
        {
            try
            {
                subscriper_name_upd.Texts = table.Rows[0][1].ToString();
                subscr_phnum_upd.Texts = table.Rows[0][2].ToString();
                sub_address_upda.Texts = table.Rows[0][3].ToString();
                identity_ty.Text = table.Rows[0][4].ToString();
                indenity_number_upda.Texts = table.Rows[0][5].ToString();
                comboBox1.Text = table.Rows[0][6].ToString();
                meter_number_UP.Texts = table.Rows[0][7].ToString();
                dateTimePicker1.Text = table.Rows[0][9].ToString();
            }
            catch (Exception)
            {
                this.Alert(" يجب اختيار احد المشتركين", Form_alert.enmType.Error);
                //this.Alert(ex.Message, Form_alert.enmType.Error);
            }
          

        }



        private void OurPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                meter_number_UP.Enabled = true;
            }
            else meter_number_UP.Enabled = false;
        }

        private void Subscriper_name_upd__TextChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RjButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sub_address__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
