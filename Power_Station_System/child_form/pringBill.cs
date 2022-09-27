using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Power_Station_System.child_form
{
    public partial class pringBill : Form
    {
        int move;
        int movx;
        int movy;
        DataBase.bill bill = new DataBase.bill();
        public pringBill()
        {

            InitializeComponent();
          
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RjButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RjButton1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > -1) {
                if (checkBox1.Checked)
                {

                    //Reports.BILL all_bill = new Reports.BILL();
                    //Reports.reort_viwer Vi = new Reports.reort_viwer();
                    //all_bill.SetDataSource(bill.get_bill_to_print());
                    //Vi.crystalReportViewer1.ReportSource = all_bill;
                    //Vi.ShowDialog();
                    DataTable DT = other_class.other_function.gridview_to_datatabel(dataGridView1);
                    //  dataGridView1.DataSource = DT;
                    Reports.BILL all_bill = new Reports.BILL();
                    Reports.reort_viwer Vi = new Reports.reort_viwer();
                    all_bill.SetDataSource(DT);
                    Vi.crystalReportViewer1.ReportSource = all_bill;
                    Vi.ShowDialog();

                }
                else
                {
                    checkBox1.Enabled = false;
                    DataTable DT = other_class.other_function.gridview_to_datatabel(dataGridView1);
                  //  dataGridView1.DataSource = DT;
                    Reports.BILL all_bill = new Reports.BILL();
                    Reports.reort_viwer Vi = new Reports.reort_viwer();
                    all_bill.SetDataSource(DT);
                    Vi.crystalReportViewer1.ReportSource = all_bill;
                    Vi.ShowDialog();
                  

                }

            }

        }

        
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (dataGridView1.Rows.Count > -1)
                {
                    for (int item = 0; item < dataGridView1.Rows.Count; item++)
                    {
                        dataGridView1.Rows[item].Cells["checkedBOX"].Value = true;

                    }
                }
            }
            else
            {
                for (int item = 0; item < dataGridView1.Rows.Count; item++)
                {
                    dataGridView1.Rows[item].Cells["checkedBOX"].Value = false;

                }
            }
            }

        private void OurPanel1_MouseDown(object sender, MouseEventArgs e)
        {

            move = 1;
            movx = e.X;
            movy = e.Y;
        }

        private void OurPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movx, MousePosition.Y - movy);
            }
        }

        private void OurPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }


        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PringBill_Load(object sender, EventArgs e)
        {

        }

        private void RjButton3_Click(object sender, EventArgs e)
        {
            try { 
             dataGridView1.DataSource = bill.get_bill_to_print(from_taime.Text, to_time.Text);
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
    }
    }

