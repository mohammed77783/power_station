using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Power_Station_System.child_form
{
    public partial class pringBill : Form
    {
        DataBase.bill bill = new DataBase.bill();
        public pringBill()
        {

            InitializeComponent();
            dataGridView1.DataSource = bill.get_bill_to_print();
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
            Reports.BILL all_bill = new Reports.BILL();
            Reports.reort_viwer Vi = new Reports.reort_viwer();
            all_bill.SetDataSource(bill.get_bill_to_print());
            Vi.crystalReportViewer1.ReportSource = all_bill;
            Vi.ShowDialog();
        }
    }
}
