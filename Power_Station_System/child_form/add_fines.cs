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
    public partial class add_fines : Form
    {
        DataBase.fines fines = new DataBase.fines();
<<<<<<< HEAD
        DataBase.users users = new DataBase.users();

        int id;
=======
        int id=-1;
>>>>>>> ee46c36d85989259d9cb87b1d6d4743b5edc23dd
        string type;
        string fines_cost;

        public add_fines()
        {
            InitializeComponent();
           
                datagride_view_fines.DataSource = fines.get_fines();
            Loadpriv();

        }
        void Loadpriv()
        {


            DataTable Dt = users.priv_Add_priv_Edit(6, Convert.ToInt32(Program.user_ID));


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
            rjTextBox1.Texts = String.Empty;
            rjTextBoxy.Texts = string.Empty;
        }
        public void Alert(string msg, Form_alert.enmType type)
        {
            Form_alert frm = new Form_alert();
            frm.showAlert(msg, type);
        }
        public void Clear()
        {
            rjTextBox1.Texts = rjTextBoxy.Texts = String.Empty;
             
        }
        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RjButton1_Click(object sender, EventArgs e)
        {

        }

        private void RjButton3_Click(object sender, EventArgs e)
        {

        }

        private void RjButton2_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RjTextBox2__TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void RjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void OurPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Datagride_view_customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Datagride_view_customer_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RjButton1_Click_1(object sender, EventArgs e)
        {

            if(rjButton1.Text =="اضافة")
            {

                if (rjTextBox1.Texts.Trim().Length < 1)
                {
                   // MessageBox.Show("إسم الغرامة فارغ ");
                    this.Alert(" إسم الغرامة فارغ", Form_alert.enmType.Warning);
                    return;
                }
               else if  (rjTextBoxy.Texts.Trim().Length < 1 )
                {
                   // MessageBox.Show(" تكلفة الغرامة فارغ ");
                    this.Alert(" تكلفة الغرامة فارغ", Form_alert.enmType.Warning);
                    return;
                }
                else
                    try
                    {
                        fines.Add_fines (rjTextBox1.Texts, rjTextBoxy.Texts);

                       //MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Alert(" تمت الإضافة بنجاح", Form_alert.enmType.Success);

                        Clear();
                        this.Add_fines_Load(null, null);

                    }
                    catch (Exception ex)
                    {
                       // MessageBox.Show(ex.Message);
                        this.Alert(ex.Message, Form_alert.enmType.Error);
                    }

            }
            if (rjButton1.Text == "حقظ التغيرات")
            {

                if (rjTextBox1.Texts.Trim().Length < 1)
                {
                    //MessageBox.Show("إسم الغرامة فارغ ");
                    this.Alert(" إسم الغرامة فارغ", Form_alert.enmType.Warning);
                    return;
                }
                else if (rjTextBoxy.Texts.Trim().Length < 1)
                {
                    //MessageBox.Show(" تكلفة الغرامة فارغ ");
                    this.Alert(" تكلفة الغرامة فارغ ", Form_alert.enmType.Warning);
                    return;
                }
                else
                    try
                    {
                        fines.Update_fines_add(rjTextBox1.Texts,rjTextBoxy.Texts, id);

                        //MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Alert(" تمت التعديل بنجاح", Form_alert.enmType.Success);
                        unmod();
                        Clear();
                        this.Add_fines_Load(null, null);
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show(ex.Message);
                        this.Alert(ex.Message, Form_alert.enmType.Error);
                    }
            }




        }

        public void mod()
        {
            if (id != null && type != null && fines_cost != null)
            {
                datagride_view_fines.Enabled = false;
                rjTextBox1.Texts = type;
                rjTextBoxy.Texts = fines_cost;
                rjButton3.Text = "الغاء";
                rjButton1.Text = "حقظ التغيرات";
                rjButton2.Enabled = false;

            }
        }
        public void unmod()
        {
            datagride_view_fines.Enabled = true;
            rjButton1.Enabled = true;
            rjButton2.Enabled = true;
            rjButton3.Enabled = true;
            rjButton1.Text = "اضافة";
            rjButton3.Text = "حذف";
        }


        private void RjTextBox2_Load(object sender, EventArgs e)
        {

        }

        private void Add_fines_Load(object sender, EventArgs e)
        {
            rjTextBox1.Focus();
            try
            {
                datagride_view_fines.DataSource = fines.get_fines();

            }

            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
                this.Alert(ex.Message, Form_alert.enmType.Error);
            }

        }

        private void Datagride_view_fines_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Datagride_view_fines_Click(object sender, EventArgs e)
        {
            try { 
            id = Convert.ToInt16(datagride_view_fines.CurrentRow.Cells[0].Value.ToString());
            type = datagride_view_fines.CurrentRow.Cells[1].Value.ToString();
            fines_cost = datagride_view_fines.CurrentRow.Cells[2].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void RjButton2_Click_1(object sender, EventArgs e)
        {
            mod();
        }

        private void RjButton3_Click_1(object sender, EventArgs e)
        {
            if (rjButton3.Text == "حذف")
            {
                if (id >0)
                {
                    if (MessageBox.Show("هل أنت متأكد من عملية الحذف؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        fines.Delete_fines_add(this.datagride_view_fines.CurrentRow.Cells[0].Value.ToString());
                       // MessageBox.Show("تمت عملية الحذف بنجاح", "عمليةالحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Alert("تمت عملية الحذف بنجاح", Form_alert.enmType.Success);
                        this.Add_fines_Load(null, null);
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

        private void RjTextBoxy_Click(object sender, EventArgs e)
        {

        }

        private void Add_fines_Activated(object sender, EventArgs e)
        {
            
        }
    }
}
