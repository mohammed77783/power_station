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
    public partial class Subscription : Form
    {
        DataBase.subscription_1 sub = new DataBase.subscription_1();
        int id, Kw_price, month_fee;
        string sub_peiod, sub_stype;
        public Subscription()
        {
            InitializeComponent();
        }
        public void Alert(string msg, Form_alert.enmType type)
        {
            Form_alert frm = new Form_alert();
            frm.showAlert(msg, type);
        }

        private void RjButton1_Click(object sender, EventArgs e)
        {
            if (rjButton1.Text == "إضافة")
            {
                if (rjTextBox1.Texts.Trim().Length < 1)
                {
                    MessageBox.Show("مدة الاشتراك فارغة ");
                    this.Alert("Warning Alert", Form_alert.enmType.Warning);
                    return;
                }

                else if (rjTextBox2.Texts.Trim().Length < 3)
                {
                    //MessageBox.Show("نوع الاشتراك فارغ ");
                    this.Alert("نوع الاشتراك فارغ", Form_alert.enmType.Warning);
                    return;
                }
                else if (rjTextBox4.Texts.Trim().Length < 3)
                {
                    //MessageBox.Show("سعر الوحدة فارغ");
                    this.Alert("سعر الوحدة فارغ", Form_alert.enmType.Warning);
                    return;
                }
                else if (rjTextBox6.Texts.Trim().Length < 3)
                {
                    //MessageBox.Show("الرسوم الشهرية فارغة ");
                    this.Alert("الرسوم الشهرية فارغة", Form_alert.enmType.Warning);
                    return;
                }

                else
                {
                    try
                    {
                        sub.Add_subs(rjTextBox1.Texts, rjTextBox2.Texts, Convert.ToInt16(rjTextBox4.Texts), Convert.ToInt16(rjTextBox6.Texts));
                       // MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Alert(" تمت الإضافة بنجاح", Form_alert.enmType.Success);
                        Clear();
                        this.Subscription_Load(null, null);
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show(ex.Message);
                        this.Alert(ex.Message, Form_alert.enmType.Error);
                    }
                }
            }
            if (rjButton1.Text == "حقظ التغيرات")
            {
          if (rjTextBox1.Texts.Trim().Length < 1)
                {
                    //MessageBox.Show("مدة الاشتراك فارغة ");
                    this.Alert("مدة الاشتراك فارغة", Form_alert.enmType.Warning);
                    return;
                }

                else if (rjTextBox2.Texts.Trim().Length < 3)
                {
                    //MessageBox.Show("نوع الاشتراك فارغ ");
                    this.Alert("نوع الاشتراك فارغ", Form_alert.enmType.Warning);
                    return;
                }
                else if (rjTextBox4.Texts.Trim().Length < 3)
                {
                   // MessageBox.Show("سعر الوحدة فارغ");
                    this.Alert("سعر الوحدة فارغ", Form_alert.enmType.Warning);
                    return;
                }
                else if (rjTextBox6.Texts.Trim().Length < 3)
                {
                    //MessageBox.Show("الرسوم الشهرية فارغة ");
                    this.Alert("الرسوم الشهرية فارغة", Form_alert.enmType.Warning);
                    return;
                }
                else
                {
                    try
                    {
                        sub.update_subsription(id, rjTextBox1.Texts, rjTextBox2.Texts, Convert.ToInt16(rjTextBox4.Texts), Convert.ToInt16(rjTextBox6.Texts));

                        //MessageBox.Show("تمت التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Alert(" تمت التعديل بنجاح", Form_alert.enmType.Success);
                        this.Subscription_Load(null, null);
                        unmod();
                        Clear();
                    }
                    catch (Exception ex)
                    {
                       // MessageBox.Show(ex.Message);
                        this.Alert(ex.Message, Form_alert.enmType.Error);
                    }
                }

            }

            }


        public void mod()
        {
            if (id != null)
            {
                dataGridView1.Enabled = false;
                rjTextBox1.Texts = sub_peiod;
                rjTextBox2.Texts = sub_stype;
                rjTextBox4.Texts =Convert.ToString( Kw_price);
                rjTextBox6.Texts =Convert.ToString( month_fee);
                rjButton3.Text = "الغاء";
                rjButton1.Text = "حقظ التغيرات";
                rjButton2.Enabled = false;

            }
        }

        public void Clear()
        {
            rjTextBox1.Texts = rjTextBox2.Texts = rjTextBox4.Texts =
                    rjTextBox6.Texts = String.Empty;

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
        private void RjButton2_Click_1(object sender, EventArgs e)
        {
            mod();
        }

        private void RjButton3_Click(object sender, EventArgs e)
        {
            if (rjButton3.Text == "حذف")
            {
                if (id != null) { 
                if (MessageBox.Show("هل أنت متأكد من عملية الحذف؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    sub.Delete_subscrip(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                   // MessageBox.Show("تمت عملية الحذف بنجاح", "عمليةالحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Alert(" تمت عملية الحذف بنجاح", Form_alert.enmType.Success);
                        this.Subscription_Load(null, null);
                }
                 }
            }
            if (rjButton3.Text == "الغاء")
            {
                unmod();
                Clear();
                id = -1;
               
            }


        }


        public void ClearText()
        {
            rjTextBox2.Texts = string.Empty;
        }

        private void RjTextBox2__TextChanged(object sender, EventArgs e)
        {
            DataTable dd = new DataTable();


            dd = sub.Check_if_subsc_exists(rjTextBox2.Texts);
            if (dd.Rows.Count > 0)
            {
               // MessageBox.Show("اسم الاشتراك موجود مسبقا", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Alert("اسم الاشتراك موجود مسبقا", Form_alert.enmType.Warning);
                ClearText();
                rjTextBox2.Focus();
                rjTextBox2.SelectionStart = 0;
            }
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)

        {

        }

        private void RjTextBox4__TextChanged(object sender, EventArgs e)
        {

        }

        private void RjButton2_Click(object sender, EventArgs e)
        {
           // Edit_Subscription_window form = new Edit_Subscription_window();
            //form.ShowDialog();
        }

        private void Subscription_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = sub.get_subscrip();
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
                this.Alert(ex.Message, Form_alert.enmType.Error);
            }
        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            sub_peiod = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            sub_stype = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Kw_price = Convert.ToInt16(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            month_fee = Convert.ToInt16(dataGridView1.CurrentRow.Cells[4].Value.ToString());
        }
    }
}
