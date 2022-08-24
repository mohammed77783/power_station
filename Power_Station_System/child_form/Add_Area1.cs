using System;
using Power_Station_System.chid_form;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Power_Station_System.warning_code;


namespace Power_Station_System.chid_form
{
    public partial class Add_Area1 : Form
    {
        DataBase.Block_aned_area aree = new DataBase.Block_aned_area();
        int id;
        string name;
        public Add_Area1()
        {
            InitializeComponent();
            //try
            //{
                dataGridView1.DataSource = aree.get_area();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        public void Alert(string msg, Form_alert.enmType type)
        {
            Form_alert frm = new Form_alert();
            frm.showAlert(msg, type);
        }

        public void clea()
        {
            rjTextBox1.Texts = String.Empty;
        }

        private void RjButton1_Click(object sender, EventArgs e)
        {
            
            
        }

      

        private void RjButton1_Click_1(object sender, EventArgs e)
        {

            if (rjButton1.Text == "إضافة")
            {

                if (rjTextBox1.Texts.Trim().Length < 1)
                {
                    //MessageBox.Show("إسم المنطقة فارغ تمام ");
                    this.Alert("إسم المنطقة فارغ تمام ", Form_alert.enmType.Warning);
                    return;
                }
                else
                    try
                    {
                        aree.Add_area(rjTextBox1.Texts);

                        //MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Alert(" تمت الإضافة بنجاح", Form_alert.enmType.Success);
                        Clear();
                        this.Add_Area1_Activated(null, null);
                    }
                    catch (Exception ex)
                    {
                       // MessageBox.Show(ex.Message);
                        this.Alert(ex.Message, Form_alert.enmType.Error);
                    }
            }
            if(rjButton1.Text == "حقظ التغيرات")
            {

                if (rjTextBox1.Texts.Trim().Length < 1)
                {
                    // MessageBox.Show("إسم المنطقة فارغ ");
                    this.Alert("إسم المنطقة فارغ تمام ", Form_alert.enmType.Warning);
                    return;
                }
                else
                    try
                    {
                       aree.Update_area(rjTextBox1.Texts, id);

                        // MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Alert(" تم التعديل بنجاح", Form_alert.enmType.Success);
                        unmod();
                        Clear();
                        this.Add_Area1_Activated(null, null);
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show(ex.Message);
                        this.Alert(ex.Message, Form_alert.enmType.Error);
                    }
            }

        }
        public void Clear()
        {
            rjTextBox1.Texts = String.Empty;
        }
      public   void mod()
        {
            if (id != null && name != null)
            {
                dataGridView1.Enabled = false;
                rjTextBox1.Texts = name;
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
            rjButton1.Text = "إضافة";
            rjButton3.Text = "حذف";
        }
        private void RjButton2_Click_1(object sender, EventArgs e)
        {
           mod();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void RjButton3_Click(object sender, EventArgs e)
        {
            if (rjButton3.Text == "حذف")
            {
                if (MessageBox.Show("هل أنت متأكد من عملية الحذف؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    aree.Delete_are(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    //  MessageBox.Show("تمت عملية الحذف بنجاح", "عمليةالحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Alert(" تمت عملية الحذف بنجاح", Form_alert.enmType.Success);
                    this.Add_Area1_Activated(null,null);
                }
            }
            if (rjButton3.Text == "الغاء")
                {
                    unmod();
                    Clear();
                    id =-1;
                    name ="";
                }
            }

        private void Add_Area1_Activated(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = aree.get_area();
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
                this.Alert(ex.Message, Form_alert.enmType.Error);
            }
        }
        public void ClearText()
        {
            rjTextBox1.Texts = String.Empty;
        }
        private void Add_Area1_Validated(object sender, EventArgs e)
        {
        }

        private void RjTextBox1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void RjTextBox1_Validated(object sender, EventArgs e)
        {

            DataTable dd = new DataTable();



            dd = aree.Check_if_area_exists(rjTextBox1.Texts);
            if (dd.Rows.Count > 0)
            {
                //MessageBox.Show("اسم المنطقة موجود مسبقا", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Alert("اسم المنطقة موجود مسبقا", Form_alert.enmType.Warning);
                ClearText();
                rjTextBox1.Focus();
                rjTextBox1.SelectionStart = 0;
            }
        }

        private void Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
    }

