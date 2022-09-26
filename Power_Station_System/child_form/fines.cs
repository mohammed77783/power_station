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
    

    public partial class fines : Form
    {
        DataBase.users users = new DataBase.users();

        DataBase.fines finess = new DataBase.fines();
        DataBase.subscriber su = new DataBase.subscriber();

        int id;
        string fine_data;
        string fines_type_ID;
        string ID_Subscriber;
        bool pay_it;
        public fines()
        {
            InitializeComponent();
          
            comboBox1.DisplayMember = "Subscriber_name";
            comboBox1.ValueMember = "ID_Subscriber";
<<<<<<< HEAD
            comboBox1.DataSource = su.get_subscriber();
=======
            comboBox1.Text = "";
            comboBox2.DataSource = finess.get_fines();
>>>>>>> ee46c36d85989259d9cb87b1d6d4743b5edc23dd
            comboBox2.DisplayMember = "typee";
            comboBox2.ValueMember = "id";
            comboBox2.DataSource = finess.get_fines();
            Loadpriv();

        }
        void Loadpriv()
        {


            DataTable Dt = users.priv_Add_priv_Edit(9, Convert.ToInt32(Program.user_ID));


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

        public void clea()
        {
            comboBox1.Text = String.Empty;
            comboBox2.Text = string.Empty;
        }
        public void Clear()
        {
            comboBox1.Text = comboBox2.Text = String.Empty;

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RjButton1_Click(object sender, EventArgs e)
        {
            if (rjButton1.Text == "اضافة")
            {
                if (this.comboBox1.SelectedIndex==-1)
                {
                    //MessageBox.Show("إسم المشترك فارغ ");
                    this.Alert("إسم المشترك فارغ", Form_alert.enmType.Warning);
                    return;
                }
                else if (this.comboBox2.SelectedIndex == -1)
                {
                   // MessageBox.Show(" إسم الغرامة فارغ ");
                    this.Alert("إسم الغرامة فارغ", Form_alert.enmType.Warning);
                    return;
                }
                else if (dateTimePicker1.Text.Trim().Length < 1)
                {
                   // MessageBox.Show("  التقويم فارغ ");
                    this.Alert("التقويم فارغ", Form_alert.enmType.Warning);
                    return;
                }
                else
                    try
                    {
                        finess.Add_fines_reales(Convert.ToInt16(comboBox1.SelectedValue), Convert.ToInt16(comboBox2.SelectedValue), dateTimePicker1.Text);

                       // MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Alert(" تمت الإضافة بنجاح", Form_alert.enmType.Success);

                        Clear();
                        this.Fines_Load(null, null);

                    }
                    catch (Exception ex)
                    {
                      // MessageBox.Show(ex.Message);
                        this.Alert(ex.Message, Form_alert.enmType.Error);
                    }

            }
            if (rjButton1.Text == "حقظ التغيرات")
            {

                if (comboBox1.SelectedIndex == -1)
                {
                    //MessageBox.Show("إسم المشترك فارغ ");
                    this.Alert("إسم المشترك فارغ", Form_alert.enmType.Warning);
                    return;
                }
                else if (comboBox2.SelectedIndex == -1)
                {
                   // MessageBox.Show(" إسم الغرامة فارغ ");
                    this.Alert("إسم الغرامة فارغ", Form_alert.enmType.Warning);
                    return;
                }
                else if (dateTimePicker1.Text.Trim().Length < 1)
                {
                   // MessageBox.Show("  التقويم فارغ ");
                    this.Alert("التقويم فارغ", Form_alert.enmType.Warning);
                    return;
                }
                else
                    try
                    {
                        finess.ubdate_fines_reales( Convert.ToInt16(comboBox1.SelectedValue), Convert.ToInt16(comboBox2.SelectedValue), dateTimePicker1.Text,id);

                       // MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Alert(" تم التعديل بنجاح", Form_alert.enmType.Success);
                        unmod();
                        Clear();
                        this.Fines_Load(null, null);
                    }
                    catch (Exception ex)
                    {
                       // MessageBox.Show(ex.Message);
                        this.Alert(ex.Message, Form_alert.enmType.Error);
                    }
            }

        }




        public void mod()
        {
            if (id  >0)
            {
                dataGridView1.Enabled = false;
                //comboBox1.SelectedValue = Convert.ToInt16( ID_Subscriber);
                //comboBox2.SelectedValue = fines_type_ID;
                dateTimePicker1.Text = fine_data;


                rjButton3.Text = "الغاء";
                rjButton1.Text = "حقظ التغيرات";
                rjButton2.Enabled = false;

            }


        }
        public void unmod()
        {
            dataGridView1.Enabled = true;
            rjButton1.Enabled = true;
            rjButton2.Enabled = true;
            rjButton3.Enabled = true;
            rjButton1.Text = "اضافة";
            rjButton3.Text = "حذف";
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
           
        

        private void OurPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Fines_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = finess.get_fines_reales();

            }

            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
                this.Alert(ex.Message, Form_alert.enmType.Error);
            }
        }

        private void RjButton2_Click(object sender, EventArgs e)
        {
            mod();
        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            try
            {



               id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                ID_Subscriber =dataGridView1.CurrentRow.Cells[1].Value.ToString();
                fines_type_ID = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                fine_data = dataGridView1.CurrentRow.Cells[3].Value.ToString();
             //   pay_it  = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[4].Value.ToString());

            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
                this.Alert(ex.Message, Form_alert.enmType.Error);
            }


=======
            try { 
            id = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            fine_data = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            fines_type_ID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            ID_Subscriber = Convert.ToInt16(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            }
            catch(Exception ex)
            {

            }
>>>>>>> ee46c36d85989259d9cb87b1d6d4743b5edc23dd
        }

        private void RjButton3_Click(object sender, EventArgs e)
        {

            if (rjButton3.Text == "حذف")
            {
                if (id != null)
                {
                    if (MessageBox.Show("هل أنت متأكد من عملية الحذف؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        finess.Delete_fines_reales(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                        // MessageBox.Show("تمت عملية الحذف بنجاح", "عمليةالحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Alert("تمت عملية الحذف بنجاح", Form_alert.enmType.Success);
                        this.Fines_Load(null, null);
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
    }
}
