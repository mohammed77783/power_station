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
        DataBase.Access_layer access;

        public RPT_ACCOUNT()
        {
            InitializeComponent();
        }

        private void RPT_ACCOUNT_Load(object sender, EventArgs e)
        {

        }

        private void CrystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void RjButton1_Click(object sender, EventArgs e)
        {
            RPT.CrystalReport1 myrpt = new RPT.CrystalReport1();
            myrpt.SetParameterValue("@data", this.dateTimePicker1.Text);
            myrpt.SetParameterValue("@dataa",this.dateTimePicker2.Text);
            RPT.RPTForm myform = new RPT.RPTForm();
            myform.crystalReportViewer1.ReportSource = myrpt;
            myform.ShowDialog();

        }
    }
}
