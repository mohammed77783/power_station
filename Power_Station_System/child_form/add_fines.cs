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
        int id;
        string type;
        string fines_cost;

        public add_fines()
        {
            InitializeComponent();
            try
            {
                datagride_view_fines.DataSource = fines.get_fines();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void clea()
        {
            rjTextBox1.Texts = String.Empty;
            rjTextBoxy.Texts = string.Empty;
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
                    MessageBox.Show("إسم الغرامة فارغ ");
                    return;
                }
               else if  (rjTextBoxy.Texts.Trim().Length < 1 )
                {
                    MessageBox.Show(" تكلفة الغرامة فارغ ");
                    return;
                }
                else
                    try
                    {
                        fines.Add_fines (rjTextBox1.Texts, rjTextBoxy.Texts);

                        MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        Clear();
                        this.Add_fines_Load(null, null);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

            }
            if (rjButton1.Text == "حقظ التغيرات")
            {

                if (rjTextBox1.Texts.Trim().Length < 1)
                {
                    MessageBox.Show("إسم الغرامة فارغ ");
                    return;
                }
                else if (rjTextBoxy.Texts.Trim().Length < 1)
                {
                    MessageBox.Show(" تكلفة الغرامة فارغ ");
                    return;
                }
                else
                    try
                    {
                        fines.Update_fines_add(rjTextBox1.Texts,rjTextBoxy.Texts, id);

                        MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        unmod();
                        Clear();
                        this.Add_fines_Load(null, null);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
            }




        }

        public void mod()
        {
            if (id != null)
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
            rjButton1.Text = "إضافة";
            rjButton3.Text = "حذف";
        }


        private void RjTextBox2_Load(object sender, EventArgs e)
        {

        }

        private void Add_fines_Load(object sender, EventArgs e)
        {
            try
            {
                datagride_view_fines.DataSource = fines.get_fines();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Datagride_view_fines_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Datagride_view_fines_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt16(datagride_view_fines.CurrentRow.Cells[0].Value.ToString());
            type = datagride_view_fines.CurrentRow.Cells[1].Value.ToString();
            fines_cost = datagride_view_fines.CurrentRow.Cells[2].Value.ToString();

        }

        private void RjButton2_Click_1(object sender, EventArgs e)
        {
            mod();
        }

        private void RjButton3_Click_1(object sender, EventArgs e)
        {
            if (rjButton3.Text == "حذف")
            {
                if (id != null)
                {
                    if (MessageBox.Show("هل أنت متأكد من عملية الحذف؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        fines.Delete_fines_add(this.datagride_view_fines.CurrentRow.Cells[0].Value.ToString());
                        MessageBox.Show("تمت عملية الحذف بنجاح", "عمليةالحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
