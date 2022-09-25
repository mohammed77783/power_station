using Power_Station_System.warning_code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Power_Station_System.chid_form
{
   
    public partial class Add_customer_window : Form
    {
        customer_management father;
        int x, y, move;
        DataBase.subscriber subs = new DataBase.subscriber();
        DataBase.reading red = new DataBase.reading();
        DataBase.Block_aned_area block=new DataBase.Block_aned_area();
        customer_management f;
        public Add_customer_window(customer_management fa)
        {
            InitializeComponent();
            comboBox1.DataSource = subs.get_subscription();
            comboBox1.DisplayMember = "Subscription_Type";
            comboBox1.ValueMember = "ID_Subscription";
            comboBox2.DataSource = block.get_Block();
            comboBox2.DisplayMember = "Block_name";
            comboBox2.ValueMember = "ID";
            this.father = fa;
        }
        public void Alert(string msg, Form_alert.enmType type)
        {
            Form_alert frm = new Form_alert();
            frm.showAlert(msg, type);
        }

        private void OurPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Clear()
        {
        subscriper_name.Texts = subscr_ph_num.Texts = sub_address.Texts =
                indenity_number.Texts = String.Empty;
           
           
            identity_ty.Items[identity_ty.SelectedIndex] = String.Empty;
        }
        private void OurPanel1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void RjButton1_Click(object sender, EventArgs e)
        {
            if (subscriper_name.Texts.Trim().Length < 1)
            {
                // MessageBox.Show("إسم المشترك فارغ ");
                this.Alert("إسم المشترك فارغ", Form_alert.enmType.Warning);
                return;
            }

            else if (subscr_ph_num.Texts.Trim().Length < 3)
            {
                //MessageBox.Show("رقم المشترك فارغ ");
                this.Alert("رقم المشترك فارغ", Form_alert.enmType.Warning);
                return;
            }

            else if (sub_address.Texts.Trim().Length < 3)
            {
               // MessageBox.Show("عنوان المشترك فارغ ");
                this.Alert("عنوان المشترك فارغ ", Form_alert.enmType.Error);
                return;
            }

            else if (indenity_number.Texts.Trim().Length < 3)
            {
                //MessageBox.Show("رقم الهوية فارغ ");
                this.Alert("رقم الهوية فارغ  ", Form_alert.enmType.Warning);
                return;
            }
            else if (this.identity_ty.SelectedIndex == -1)
            {
                //MessageBox.Show("نوع الهوية فارغ ");
                this.Alert("نوع الهوية فارغ  ", Form_alert.enmType.Error);
                return;
            }

            else if (this.comboBox1.SelectedIndex == -1)
            {
               // MessageBox.Show("نوع الاشتراك فارغ ");
                this.Alert("نوع الاشتراك فارغ  ", Form_alert.enmType.Error);
                return;
            }
            else
            {
                //try
              //  {
                    subs.Add_csut(subscriper_name.Texts, subscr_ph_num.Texts, sub_address.Texts, identity_ty.Texts, indenity_number.Texts,
                 Convert.ToInt16(comboBox1.SelectedValue), meter_number.Texts, dateTimePicker1.Text, Convert.ToInt16(comboBox2.SelectedValue));
                    red.insert_opening_first_time(meter_number.Texts, "0", dateTimePicker1.Text);
             //   red.insert_manth_customer_name()
                    //MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Alert(" تمت الإضافة بنجاح", Form_alert.enmType.Success);
                Clear();
                  father.upGrid();
             //   }
              // catch (Exception ex)
             //  {
                   // MessageBox.Show(ex.Message);
             //  }
               
            }
        }

        private void RjTextBox2__TextChanged(object sender, EventArgs e)
        {

        }

        private void RjTextBox6__TextChanged(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void OurPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            x = e.X;
            y = e.Y;
        }

        private void OurPanel1_MouseMove(object sender, MouseEventArgs e)
        {

            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
        }

        private void OurPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void RjButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Indenity_number__TextChanged(object sender, EventArgs e)
        {

        }

        private void Meter_number__TextChanged(object sender, EventArgs e)
        {

        }

        private void Subscriper_name__TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_customer_window_Load(object sender, EventArgs e)
        {

        }

        private void Identity_num_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
