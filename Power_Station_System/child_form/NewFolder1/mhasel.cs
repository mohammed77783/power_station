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
    public partial class mhasel : Form
    {
        DataBase.mhasell mhasell = new DataBase.mhasell();
        DataBase.Block_aned_area aree = new DataBase.Block_aned_area();
        int id=-1;
        string Block_name;
        string adres;
        string number;
        string name;

        public mhasel()
        {
            InitializeComponent();
            comboBox1.DisplayMember = "Block_name";
            comboBox1.ValueMember = "ID";
            comboBox1.DataSource = aree.get_Block();
           
          

        

        }
        public void Alert(string msg, Form_alert.enmType type)
        {
            Form_alert frm = new Form_alert();
            frm.showAlert(msg, type);
        }
        public void clea()
        {
            comboBox1.Text = String.Empty;
            textBox_name.Texts = String.Empty;
            textBox_adres.Texts = String.Empty;
            textBox_numbr.Texts = String.Empty;
        }
        public void Clear()
        {
            comboBox1.Text = textBox_name.Texts = textBox_adres.Texts = textBox_numbr.Texts = String.Empty;

        }
        public void mod()
        {
            if (id >0)
            {
                dataGridView1.Enabled = false;
                textBox_name.Texts = name;
                textBox_adres.Texts = adres;
                textBox_numbr.Texts = number;
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
        private void RjButton1_Click(object sender, EventArgs e)
        {
            if (rjButton1.Text == "اضافة")
            {
                if (textBox_name.Texts.Trim().Length < 1)
                {
                    //MessageBox.Show("إسم المحصل فارغ ");
                    this.Alert("إسم المحصل فارغ", Form_alert.enmType.Warning);
                    return;
                }
                else if (textBox_adres.Texts.Trim().Length < 1)
                {
                   // MessageBox.Show("  عنوان المحصل فارغ ");
                    this.Alert("عنوان المحصل فارغ", Form_alert.enmType.Warning);
                    return;
                }
                else if (comboBox1.SelectedIndex == -1)
                {
                   // MessageBox.Show(" إسم المريع   فارغ ");
                    this.Alert("إسم المريع   فارغ", Form_alert.enmType.Warning);
                    return;
                }
                else if (textBox_numbr.Texts.Trim().Length < 1)
                {
                    //MessageBox.Show("  رقم الجوال   فارغ ");
                    this.Alert("رقم الجوال   فارغ", Form_alert.enmType.Warning);
                    return;
                }
                else
                    try
                    {
                        mhasell.Add_mhasel(Convert.ToInt16(comboBox1.SelectedValue), textBox_name.Texts,textBox_adres.Texts, textBox_numbr.Texts);

                       // MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Alert(" تمت الإضافة بنجاح", Form_alert.enmType.Success);

                        Clear();
                        this.Mhasel_Load(null, null);

                    }
                    catch (Exception ex)
                    {
                       // MessageBox.Show(ex.Message);
                        this.Alert(ex.Message, Form_alert.enmType.Error);
                    }

            }
            if (rjButton1.Text == "حقظ التغيرات")
            {


                if (textBox_name.Texts.Trim().Length < 1)
                {
                  //  MessageBox.Show("إسم المحصل فارغ ");
                    this.Alert("إسم المحصل فارغ", Form_alert.enmType.Warning);
                    return;
                }
                else if (textBox_adres.Texts.Trim().Length < 1)
                {
                   // MessageBox.Show("  عنوان المحصل فارغ ");
                    this.Alert("عنوان المحصل فارغ", Form_alert.enmType.Warning);
                    return;
                }
                else if (comboBox1.SelectedIndex == -1)
                {
                   // MessageBox.Show(" إسم المريع   فارغ ");
                    this.Alert("إسم المريع   فارغ", Form_alert.enmType.Warning);
                    return;
                }
                else if (textBox_numbr.Texts.Trim().Length < 1)
                {
                  //  MessageBox.Show("  رقم الجوال   فارغ ");
                    this.Alert("رقم الجوال   فارغ", Form_alert.enmType.Warning);
                    return;
                }
                else
                    try
                    {
                        mhasell.Update_mhsdel_add(Convert.ToInt16(comboBox1.SelectedValue), textBox_name.Texts, textBox_adres.Texts,  textBox_numbr.Text,id);

                        //MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Alert(" تم التعديل بنجاح", Form_alert.enmType.Success);
                        unmod();
                        Clear();
                        this.Mhasel_Load(null, null);
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show(ex.Message);
                        this.Alert(ex.Message, Form_alert.enmType.Error);
                    }
            }
        }

        private void Mhasel_Load(object sender, EventArgs e)
        {
            textBox_name.Focus();
            try
            {
                dataGridView1.DataSource = mhasell.get_mhasel();
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
                this.Alert(ex.Message, Form_alert.enmType.Error);
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void RjButton3_Click(object sender, EventArgs e)
        {
            if (rjButton3.Text == "حذف")
            {
                if (id>0)
                {
                    if (MessageBox.Show("هل أنت متأكد من عملية الحذف؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        mhasell.Delete_mhsesel(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                       // MessageBox.Show("تمت عملية الحذف بنجاح", "عمليةالحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Alert(" تمت عملية الحذف بنجاح", Form_alert.enmType.Success);
                        this.Mhasel_Load(null, null);
                    
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

        private void RjButton2_Click(object sender, EventArgs e)
        {
            mod();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            try { 
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Block_name = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            adres = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            number = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
            catch(Exception ex)
            {

            }
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

