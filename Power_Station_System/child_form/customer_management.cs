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
    public partial class customer_management : Form
    {
        DataBase.subscriber cus = new DataBase.subscriber();
        int id;
      
       /* string name_upd, phone, addrss, inde_type, tden_num, electronic_number, subscription_id;*/
        public customer_management( )
        {
            InitializeComponent();
        

        }
        public void Alert(string msg, Form_alert.enmType type)
        {
            Form_alert frm = new Form_alert();
            frm.showAlert(msg, type);
        }

        private void RjButton1_Click(object sender, EventArgs e)
        {
            chid_form.Add_customer_window add = new Add_customer_window(this);
            add.ShowDialog();
          
        }

        private void RjButton2_Click(object sender, EventArgs e)
        {
           chid_form.Udate_subscriper udate = new chid_form.Udate_subscriper(id,this);
            udate.ShowDialog();
        }

        private void IconButton1_Click(object sender, EventArgs e)
        {
      
        }

        private void Button1_Click(object sender, EventArgs e)
        {
        
        }

        private void Search_Validated(object sender, EventArgs e)
        {
            
        }

        private void Search_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void Search_TabStopChanged(object sender, EventArgs e)
        {
           
        }

        private void Search__TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string t = search.Texts;
            dt = cus.search(t);
            this.datagride_view_customer.DataSource = dt;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Add_customer_1_Activated(object sender, EventArgs e)
        {
            datagride_view_customer.DataSource = cus.get_subscriber();
            //var sql = "select_subscriper";
        }
        public void upGrid()
        {
            datagride_view_customer.DataSource = cus.get_subscriber();
            
        }

        private void Add_customer_1_Load(object sender, EventArgs e)
        {
            try
            {
                datagride_view_customer.DataSource = cus.get_subscriber();
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
                this.Alert(ex.Message, Form_alert.enmType.Error);
            }

        }


        private void RjButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل أنت متأكد من عملية الحذف؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                cus.Delete_Sub(this.datagride_view_customer.CurrentRow.Cells[0].Value.ToString());
               // MessageBox.Show("تمت عملية الحذف بنجاح", "عمليةالحذف", MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Alert(" تمت عملية الحذف بنجاح", Form_alert.enmType.Success);
                datagride_view_customer.Refresh();
             


            }
        }

        private void Datagride_view_customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Datagride_view_customer_Click(object sender, EventArgs e)
        {

            id=Convert.ToInt16( datagride_view_customer.CurrentRow.Cells[0].Value.ToString());
           
        }

        private void Panel3_BindingContextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
