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
    public partial class RPT_ACCOUNT : Form
    {
        DataBase.RPT_DB RPT_DB = new DataBase.RPT_DB();
        DataBase.Block_aned_area block = new DataBase.Block_aned_area();

        public RPT_ACCOUNT()
        {
            InitializeComponent();
            comboBox1.DataSource = block.get_Block();
            comboBox1.DisplayMember = "Block_name";
            comboBox1.ValueMember = "ID";
            comboBox1.Text = "";

        }

        private void RPT_ACCOUNT_Load(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            panel3.Controls.Add(pl_1);
        }

        private void CrystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void RjButton1_Click(object sender, EventArgs e)
        {

           



        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RjButton3_Click(object sender, EventArgs e)
        {

            panel3.Controls.Clear();
            panel3.Controls.Add(pl_3);
            pl_3.Show();
            panel4.Controls.Clear();
            panel4.Controls.Add(pl_g);
            pl_g.Show();


        }

        private void RjButton4_Click(object sender, EventArgs e)
        {
         

        }

        private void RjButton5_Click(object sender, EventArgs e)
        {

            panel3.Controls.Clear();
            panel3.Controls.Add(pl_1);
            pl_1.Show();
            panel4.Controls.Clear();
            panel4.Controls.Add(pl_g);
            pl_g.Show();



        }

        private void RjButton2_Click(object sender, EventArgs e)
        {

         

            panel3.Controls.Clear();
            panel3.Controls.Add(panel5);
            panel5.Show();

            panel4.Controls.Clear();
            panel4.Controls.Add(pl_g);
            pl_g.Show();


        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
          
        }

        private void RjButton1_Click_1(object sender, EventArgs e)
        {
          
        }

        private void RjButton6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = RPT_DB.RPT_Account_details(dateTimePicker1.Text, dateTimePicker2.Text);
            dataGridView1.Columns[0].HeaderText = "اسم العميــــل";
            dataGridView1.Columns[1].HeaderText = "المبلــــغ المستحق";
            dataGridView1.Columns[2].HeaderText = "المبلــــغ المدفوع";
            dataGridView1.Columns[3].HeaderText = "المبلــــغ المتبقي ";
        }

        private void RjButton1_Click_2(object sender, EventArgs e)
        {


        }

        private void IconButton3_Click(object sender, EventArgs e)
        {
            RPT.Sub_Money_Det myrpt = new RPT.Sub_Money_Det();
            myrpt.SetDataSource(RPT_DB.RPT_Account_details(dateTimePicker1.Text, dateTimePicker2.Text));
            RPT.RPTForm myform = new RPT.RPTForm();
            myform.crystalReportViewer1.ReportSource = myrpt;
            myform.ShowDialog();
        }

        private void RjButton1_Click_3(object sender, EventArgs e)
        {

            dataGridView1.DataSource = RPT_DB.RPT_money_detalil_block(dateTimePicker3.Text, dateTimePicker4.Text, Convert.ToInt32(comboBox1.SelectedValue));
            dataGridView1.Columns[0].HeaderText = "رقم السند ";
            dataGridView1.Columns[1].HeaderText = "  اسم العميل";
            dataGridView1.Columns[2].HeaderText = " المبلغ المحصل";
            dataGridView1.Columns[3].HeaderText = " التاريخ ";
            dataGridView1.Columns[4].HeaderText = " الملاحظة ";
            dataGridView1.Columns[5].HeaderText = " المنطقة ";

            /*RPT.collectedMoney myrpt = new RPT.collectedMoney();
            myrpt.SetDataSource(RPT_DB.RPT_money_detalil(dateTimePicker1.Text, dateTimePicker2.Text));
            RPT.RPTForm myform = new RPT.RPTForm();
            myform.crystalReportViewer1.ReportSource = myrpt;
            myform.ShowDialog();*/
        }

        private void IconButton1_Click(object sender, EventArgs e)
        {
            RPT.collectedMoney myrpt = new RPT.collectedMoney();
            myrpt.SetDataSource(RPT_DB.RPT_money_detalil(dateTimePicker3.Text, dateTimePicker4.Text));
            RPT.RPTForm myform = new RPT.RPTForm();
            myform.crystalReportViewer1.ReportSource = myrpt;
            myform.ShowDialog();
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Pa_bu1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RjButton7_Click(object sender, EventArgs e)
        {

        }

        private void RjButton8_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = RPT_DB.RPT_unpaidd();
            dataGridView1.Columns[0].HeaderText = "اسم العميــــل";
            dataGridView1.Columns[1].HeaderText = " اسم المنطقة";
            dataGridView1.Columns[2].HeaderText = "العنوان";
            dataGridView1.Columns[3].HeaderText = "المبلــــغ المتاخر";
        }

        private void IconButton2_Click(object sender, EventArgs e)
        {
            RPT.Unpaid myrpt = new RPT.Unpaid();
            myrpt.SetDataSource(RPT_DB.RPT_unpaidd());
            RPT.RPTForm myform = new RPT.RPTForm();
            myform.crystalReportViewer1.ReportSource = myrpt;
            myform.ShowDialog();
        }

        private void IconButton4_Click(object sender, EventArgs e)
        {
            RPT.collectedMoney myrpt = new RPT.collectedMoney();
            myrpt.SetDataSource(RPT_DB.RPT_money_detalil_block(dateTimePicker3.Text, dateTimePicker4.Text, Convert.ToInt32(comboBox1.SelectedValue)));
            RPT.RPTForm myform = new RPT.RPTForm();
            myform.crystalReportViewer1.ReportSource = myrpt;
            myform.ShowDialog();
        }

        private void RjButton4_Click_1(object sender, EventArgs e)
        {

            dataGridView1.DataSource = RPT_DB.RPT_money_detalil(dateTimePicker3.Text, dateTimePicker4.Text);
            dataGridView1.Columns[0].HeaderText = "رقم السند ";
            dataGridView1.Columns[1].HeaderText = "  اسم العميل";
            dataGridView1.Columns[2].HeaderText = " المبلغ المحصل";
            dataGridView1.Columns[3].HeaderText = " التاريخ ";
            dataGridView1.Columns[4].HeaderText = " الملاحظة ";
            dataGridView1.Columns[5].HeaderText = " المنطقة ";
        }
    }
}
