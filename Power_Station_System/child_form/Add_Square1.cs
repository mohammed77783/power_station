﻿using System;
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
    public partial class Add_Square1 : Form
    {
        DataBase.Block_aned_area block = new DataBase.Block_aned_area();
        int id;
        string Blockname, center_meterID;
        public Add_Square1()
        {

            InitializeComponent();
            comboBox1.DataSource = block.get_area();
            comboBox1.DisplayMember = "are_name";
            comboBox1.ValueMember = "ID";
            comboBox1.Text = "";
          
        }

      
       

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Blockname = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            center_meterID = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void RjButton1_Click_2(object sender, EventArgs e)
        {
            if (rjButton1.Text == "إضافة")
            {
                if (rjTextBox1.Texts.Trim().Length < 1)
                {
                    MessageBox.Show("إسم المربع فارغ ");
                    return;
                }

                else if (this.comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("المنطقة فارغة ");
                    return;
                }


                else
                {
                    try
                    {
                        block.Add_Block(rjTextBox1.Texts, Convert.ToInt16(comboBox1.SelectedValue), rjTextBox2.Texts);


                        MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        this.Add_Square1_Load(null, null);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
            if (rjButton1.Text == "حقظ التغيرات")
            {

                if (rjTextBox1.Texts.Trim().Length < 1)
                {
                    MessageBox.Show("إسم المنطقة فارغ ");
                    return;
                }

                else { 
                    try
                    {
                        block.update_Block(id, rjTextBox1.Texts, Convert.ToInt32(comboBox1.SelectedValue), rjTextBox2.Texts);

                        MessageBox.Show("تمت التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        unmod();
                        Clear();
                        this.Add_Square1_Load(null, null);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }


            }
            }

         public   void mod()
        {
            if (id != null && Blockname != null)
            {
                dataGridView1.Enabled = false;
                rjTextBox2.Texts = center_meterID;
                rjTextBox1.Texts = Blockname;
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
        public void Clear()
        {
            rjTextBox1.Texts = String.Empty;
         //  comboBox1.Items[comboBox1.SelectedIndex] = String.Empty;
            rjTextBox2.Texts = String.Empty;
        }

        private void RjButton3_Click(object sender, EventArgs e)
        {
            if (rjButton3.Text == "حذف")
            {
                if (MessageBox.Show("هل أنت متأكد من عملية الحذف؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    block.Delete_block(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show("تمت عملية الحذف بنجاح", "عمليةالحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Add_Square1_Load(null, null);
                }

            }
            if (rjButton3.Text == "الغاء")
            {

                unmod();
                Clear();
                id = -1;
                Blockname =null;


            }


            }

        private void Add_Square1_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = block.get_Block();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
        public void ClearText()
        {
            rjTextBox1.Texts = string.Empty;
        }
        private void RjTextBox1_Validated(object sender, EventArgs e)
        {
            DataTable dd = new DataTable();


            dd = block.Check_if_block_exists(rjTextBox1.Texts);
            if (dd.Rows.Count > 0)
            {
                MessageBox.Show("إسم المربع موجود مسبقا", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearText();
                rjTextBox1.Focus();
                rjTextBox1.SelectionStart = 0;
            }
        }

        private void RjTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DataGridView1_Click_1(object sender, EventArgs e)
        {
            id = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Blockname = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            center_meterID = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RjButton2_Click(object sender, EventArgs e)
        {
            mod();
        
            }

      
    }
}
