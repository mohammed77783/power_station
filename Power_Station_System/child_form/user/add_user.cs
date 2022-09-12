using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;



namespace Power_Station_System.child_form.user
{
    public partial class add_user : Form

    {
       // SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-SVQURFVC\SQLEXPRESS;Initial Catalog=power_state_station;Integrated Security=true");
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-SVQURFVC;Initial Catalog=power_state_station;Integrated Security=true");

        DataBase.users users = new DataBase.users();
        string ful_name;
        string number;
        string adres;
        string user_name;
        string pass;
        int user_ID;
        public add_user()
        {
            InitializeComponent();
          
        }
        void LoadData()
        {
            DataTable Dt = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter("select *from add_user",con);
            Da.Fill(Dt);
        }
        public void Clear()
        {
            textBox_Custom1.Texts = textBox_Custom2.Texts = textBox_Custom7.Texts = textBox_Custom4.Texts= textBox_Custom5.Texts= passw.Texts = textBox_Custom3.Texts= String.Empty;

        }

        public void clea()
        {
            textBox_Custom1.Text =  String.Empty;
            textBox_Custom2.Texts = String.Empty;
            textBox_Custom7.Texts = String.Empty;
            textBox_Custom4.Texts = String.Empty;
            textBox_Custom5.Texts = String.Empty;
            textBox_Custom3.Texts = String.Empty;
        }
        private String SHA512(string pass)
        {
            SHA512Managed SHA512 = new SHA512Managed();
            Byte[] Hash = System.Text.Encoding.UTF8.GetBytes(pass);
            Hash = SHA512.ComputeHash(Hash);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in Hash)
            {
                sb.Append(b.ToString("x2").ToLower());

            }
            return sb.ToString();

        }

        public void mod()
        {
            if (user_ID != null)
            {
                dataGridView2.Enabled = false;
                textBox_Custom1.Texts = ful_name;
                textBox_Custom2.Texts = number;
                textBox_Custom7.Texts = adres;
                textBox_Custom5.Texts = user_name;
                passw.Texts = pass;
               
                rjButton3.Text = "الغاء";
                rjButton1.Text = "حقظ التغيرات";
                rjButton2.Enabled = false;

            }
        }

        public void unmod()
        {
            dataGridView2.Enabled = true;
            rjButton1.Enabled = true;
            rjButton2.Enabled = true;
            rjButton3.Enabled = true;
            rjButton1.Text = "إضافة";
            rjButton3.Text = "حذف";
        }
        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RjButton1_Click(object sender, EventArgs e)
        {
            string pass = SHA512(passw.Texts);

            if (rjButton1.Text == "اضافة")
            {
                if (textBox_Custom1.Texts.Trim().Length < 1)
                {
                    MessageBox.Show("إسم المستخدم  فارغ ");
                    return;
                }
                else if (textBox_Custom2.Texts.Trim().Length < 1)
                {
                    MessageBox.Show("  رقم الهاتف فارغ ");
                    return;
                }
                else if (textBox_Custom7.Texts.Trim().Length < 1)
                {
                    MessageBox.Show(" إسم العنوان المستخدم   فارغ ");
                    return;
                }
                else if (textBox_Custom3.Texts.Trim().Length < 1)
                {
                    MessageBox.Show(" إسم العنوان رقم المستخدم   فارغ ");
                    return;
                }
                else if (textBox_Custom5.Texts.Trim().Length < 1)
                {
                    MessageBox.Show("  اسم الدخول    فارغ ");
                    return;
                }
                else if (passw.Texts.Trim().Length < 1)
                {
                    MessageBox.Show("  كلمة المرور  فارغ    ");
                    return;
                }
                else
                {
                    try
                    {


                        SqlCommand cmd = new SqlCommand("insert into add_user values(@user_ID,@ful_name,@number,@user_name,@pass,@adres) " +
                             "insert into tb_priv(priv_screen_ID,priv_user_ID) select screen_ID,@user_ID from tb_screen ", con);
                        cmd.Parameters.Add(new SqlParameter("@user_ID", SqlDbType.Int)).Value = Convert.ToInt32(textBox_Custom3.Texts);
                        cmd.Parameters.Add(new SqlParameter("@ful_name", SqlDbType.NVarChar, (50))).Value = textBox_Custom1.Texts;
                        cmd.Parameters.Add(new SqlParameter("@number", SqlDbType.NVarChar, (50))).Value = textBox_Custom2.Texts;

                        cmd.Parameters.Add(new SqlParameter("@user_name", SqlDbType.NVarChar, (50))).Value = textBox_Custom5.Texts;

                        cmd.Parameters.Add(new SqlParameter("@pass", SqlDbType.NVarChar, (50))).Value = pass;
                        cmd.Parameters.Add(new SqlParameter("@adres", SqlDbType.NVarChar, (50))).Value = textBox_Custom7.Texts;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
                if (rjButton1.Text == "حقظ التغيرات")
            {

                if (textBox_Custom1.Texts.Trim().Length < 1)
                {
                    MessageBox.Show("إسم المستخدم  فارغ ");
                    return;
                }
                else if (textBox_Custom2.Texts.Trim().Length < 1)
                {
                    MessageBox.Show("  رقم الهاتف فارغ ");
                    return;
                }
                else if (textBox_Custom7.Texts.Trim().Length < 1)
                {
                    MessageBox.Show(" إسم العنوان المستخدم   فارغ ");
                    return;
                }
                else if (textBox_Custom5.Texts.Trim().Length < 1)
                {
                    MessageBox.Show("  اسم الدخول    فارغ ");
                    return;
                }
                else if (passw.Texts.Trim().Length < 1)
                {
                    MessageBox.Show("  كلمة المرور  فارغ    ");
                    return;
                }
                else
                    try
                    {
                        users.Update_add_user(textBox_Custom1.Texts, textBox_Custom2.Texts, textBox_Custom7.Texts, textBox_Custom5.Texts, passw.Texts, user_ID);

                        MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        unmod();
                        Clear();
                        this.Add_user_Load(null, null);
            }
                    catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        }

        private void Add_user_Load(object sender, EventArgs e)
        {
            textBox_Custom3.Focus();
            try
            {
                dataGridView2.DataSource = users.get_user();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RjButton2_Click(object sender, EventArgs e)
        {
            mod();
        }

        private void RjButton3_Click(object sender, EventArgs e)
        {
            if (rjButton3.Text == "حذف")
            {
                if (user_ID != null)
                {
                    if (MessageBox.Show("هل أنت متأكد من عملية الحذف؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                       users.Delete_user(this.dataGridView2.CurrentRow.Cells[0].Value.ToString());
                        MessageBox.Show("تمت عملية الحذف بنجاح", "عمليةالحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Add_user_Load(null, null);
                    }
                }
            }
            if (rjButton3.Text == "الغاء")
            {
                unmod();
                Clear();
                user_ID = -1;

            }
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }   

        private void TextBox_Custom4_Validated(object sender, EventArgs e)
        {
            /*
           if (textBox_Custom4.Texts != passw.Texts)
            {
                MessageBox.Show("عذراً كلمة المرور غير متطابقتين ", "خطاء ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBox_Custom4.Focus();
                return;
            }*/

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void TextBox_Custom3_Load(object sender, EventArgs e)
        {

        }

        private void TextBox_Custom4__TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_Custom4__TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_Custom7__TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {


        }

        private void RjButton5_Click(object sender, EventArgs e)
        {
            child_form.user.pre add = new child_form.user.pre();
            add.ShowDialog();
        }

        private void DataGridView2_Click(object sender, EventArgs e)
        {
            user_ID = Convert.ToInt16(dataGridView2.CurrentRow.Cells[0].Value.ToString());
             ful_name =dataGridView2.CurrentRow.Cells[1].Value.ToString();
            number = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            adres = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            user_name = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            pass = dataGridView2.CurrentRow.Cells[5].Value.ToString();

        }
    }
}
