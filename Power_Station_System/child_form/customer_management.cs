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


        DataBase.users users = new DataBase.users();

        string username=null,meter=null;

        int id=-1;

      
       /* string name_upd, phone, addrss, inde_type, tden_num, electronic_number, subscription_id;*/
        public customer_management( )
        {
            InitializeComponent();
            Loadpriv();

        }
        void Loadpriv()
        {


            DataTable Dt = users.priv_Add_priv_Edit(8, Convert.ToInt32(Program.user_ID));


            if (Dt.Rows[0][0].ToString() == "0" || Dt.Rows[0][0].ToString() == String.Empty)
            {
                rjButton1.Enabled = false;

            }


            if (Dt.Rows[0][1].ToString() == "0" || Dt.Rows[0][1].ToString() == String.Empty)
            {

                rjButton2.Enabled = false;


            }
            if (Dt.Rows[0][2].ToString() == "0" || Dt.Rows[0][2].ToString() == String.Empty)
            {
                rjButton3.Enabled = false;
            }
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
            if (id > 0) { 
           chid_form.Udate_subscriper udate = new chid_form.Udate_subscriper(id,this);
            udate.ShowDialog();
                id = -1;
            }
            else
            {
                MessageBox.Show("يجب تحديد العميل المقصود اولا");
            }
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
                try
                {
                    cus.Delete_Sub(this.datagride_view_customer.CurrentRow.Cells[0].Value.ToString());
                    // MessageBox.Show("تمت عملية الحذف بنجاح", "عمليةالحذف", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Alert(" تمت عملية الحذف بنجاح", Form_alert.enmType.Success);


                    datagride_view_customer.DataSource = cus.get_subscriber();

                    datagride_view_customer.Refresh();
                  
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }
        }

        private void Datagride_view_customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Datagride_view_customer_Click(object sender, EventArgs e)
        {
            try
            {



                id = Convert.ToInt16(datagride_view_customer.CurrentRow.Cells[0].Value.ToString());
                username = datagride_view_customer.CurrentRow.Cells[1].Value.ToString();
                meter = datagride_view_customer.CurrentRow.Cells[7].Value.ToString();

            }

            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                //  this.Alert(ex.Message, Form_alert.enmType.Error);
            }
        }
    private void Panel3_BindingContextChanged(object sender, EventArgs e)
        {
            
        }

        private void Customer_management_Enter(object sender, EventArgs e)
        {
            
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
           if (meter !=null && username!=null) { 
            child_form.print_barcode1 print_Bar = new child_form.print_barcode1(meter,username);
            print_Bar.ShowDialog();
            meter = null;
            username = null;
            }
        }
    }
}
