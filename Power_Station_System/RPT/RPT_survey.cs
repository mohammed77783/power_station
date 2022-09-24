using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Power_Station_System.RPT
{
    public partial class RPT_survey : Form
    {
        DataBase.RPT_DB RPT_DB = new DataBase.RPT_DB();

        public RPT_survey()
        {
            InitializeComponent();
        }

        private void RjButton10_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            panel4.Controls.Add(pl_1);
            pl_1.Show();
            


        }

        private void RjButton9_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            panel4.Controls.Add(pl_2);
            pl_2.Show();
          
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RjButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = RPT_DB.RPT_survet(dateTimePicker1.Text, dateTimePicker2.Text);
            dataGridView1.Columns[0].HeaderText = "اسم العميــــل";
            dataGridView1.Columns[1].HeaderText = " اسم المنطقة";
            dataGridView1.Columns[2].HeaderText = " رقم العداد ";

            dataGridView1.Columns[3].HeaderText = "اخر قراءة ";
        }

        private void IconButton1_Click(object sender, EventArgs e)
        {
            RPT.Servay myrpt = new RPT.Servay();
            myrpt.SetDataSource(RPT_DB.RPT_survet(dateTimePicker1.Text, dateTimePicker2.Text));
            RPT.RPTForm myform = new RPT.RPTForm();
            myform.crystalReportViewer1.ReportSource = myrpt;
            myform.ShowDialog();
        }

        private void RjButton6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = RPT_DB.RPT_reading_detailes(dateTimePicker5.Text, dateTimePicker6.Text);
            dataGridView1.Columns[0].HeaderText = "اسم العميــــل";
            dataGridView1.Columns[1].HeaderText = "رقم العداد  ";
            dataGridView1.Columns[2].HeaderText = "اسم المربع ";
            dataGridView1.Columns[3].HeaderText = " القراءة السابقة  ";
            dataGridView1.Columns[4].HeaderText = " القراءة الحالية ";
            dataGridView1.Columns[5].HeaderText = " التاريخ";
        }

        private void IconButton3_Click(object sender, EventArgs e)
        {
            RPT.ReadingDet myrpt = new RPT.ReadingDet();
            myrpt.SetDataSource(RPT_DB.RPT_reading_detailes(dateTimePicker5.Text, dateTimePicker6.Text));
            RPT.RPTForm myform = new RPT.RPTForm();
            myform.crystalReportViewer1.ReportSource = myrpt;
            myform.ShowDialog();
        }
    }
}
