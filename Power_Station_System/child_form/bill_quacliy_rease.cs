using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Power_Station_System.child_form
{
    public partial class bill_quacliy_rease : Form
    {
        DataBase.bill bill = new DataBase.bill();
        DataBase.Block_aned_area BA = new DataBase.Block_aned_area();
        public bill_quacliy_rease()
        {
            InitializeComponent();
            comboBox3.DisplayMember = "Block_name";
            comboBox3.ValueMember = "ID";
            comboBox2.DisplayMember = "are_name";
            comboBox2.ValueMember = "ID";
            comboBox3.DataSource = BA.get_Block();
            comboBox2.DataSource = BA.get_area();
        
          
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text =="كافة المشتركين")
            {
                dataGridView1.DataSource = bill.get_togrid();
            }
        }
        string oldcu;
        private void DataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                oldcu = dataGridView1.CurrentRow.Cells["gr_privio"].Value.ToString();

            }
        }

        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string newcur = null;
                try
                {

                    newcur = dataGridView1.CurrentRow.Cells["gr_current"].Value.ToString();




                    if (!Regex.IsMatch(newcur, "^\\d+$"))
                    {
                        return;

                    }
                    else
                    {
                        double curre = double.Parse(dataGridView1.CurrentRow.Cells["gr_current"].Value.ToString());
                        double pri = double.Parse(dataGridView1.CurrentRow.Cells["gr_privio"].Value.ToString());

                        if (curre == pri)
                        {
                            dataGridView1.CurrentRow.Cells["gr_current"].Value = "";
                            return;
                        }
                        if (curre < pri)
                        {
                            dataGridView1.CurrentRow.Cells["gr_current"].Value = "";
                            return;
                        }
                        // MessageBox.Show(x + "ee");

                        if (curre > pri)
                        {

                            double _manthe_fes = double.Parse(dataGridView1.CurrentRow.Cells["gr_manthe_fes"].Value.ToString());
                            double kwpr = double.Parse(dataGridView1.CurrentRow.Cells["gr_Kw_price"].Value.ToString());

                            double almti = double.Parse(dataGridView1.CurrentRow.Cells["gr_almtikhrat"].Value.ToString());
                            double _hol_mony;
                            double alistih = curre - pri;
                            dataGridView1.CurrentRow.Cells["gr_alistihlak"].Value = alistih.ToString();
                            if (MessageBox.Show("هل ترشد فاتور معا اشتراك", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                            {
                                _hol_mony = alistih * kwpr;
                                dataGridView1.CurrentRow.Cells["gr_mony"].Value = _hol_mony.ToString();
                                _hol_mony += +almti;
                                _hol_mony += _manthe_fes;
                            }
                            else
                            {
                                _hol_mony = alistih * kwpr;
                                dataGridView1.CurrentRow.Cells["gr_mony"].Value = _hol_mony.ToString();
                                _hol_mony += +almti;

                            }

                            dataGridView1.CurrentRow.Cells["gr_hol_mony"].Value = _hol_mony.ToString();
                            dataGridView1.CurrentRow.Cells["gr_date"].Value = DateTime.UtcNow.ToString("yyyy-dd-MM");
                        }
                    }
                }

                catch (Exception ex)
                {

                }

            }
        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text!=null)
            {
           

                dataGridView1.DataSource = bill.get_togr_block(comboBox3.Text);
            }


        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text!= null)
           {
            dataGridView1.DataSource = bill.get_togr_are(Convert.ToInt32(comboBox2.SelectedValue));
           }
        }

        private void RjButton1_Click(object sender, EventArgs e)
        {

        }
    }
}


        
    
