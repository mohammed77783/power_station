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


namespace Power_Station_System.child_form.user
{
    public partial class pre : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-A7NS7CI;Initial Catalog=power_state_station;Integrated Security=true");





        // SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-SVQURFVC;Initial Catalog=power_state_station;Integrated Security=true");


        SqlDataAdapter Da;
        DataTable Dts = new DataTable();
        public pre()
        {
            InitializeComponent();




            LoadData();
        }
        public int priv_user_ID;
        public int priv_screen_ID;
        void LoadData()
        {

            SqlDataAdapter da1 = new SqlDataAdapter("SELECT user_ID, ful_name from add_user", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;


            SqlDataAdapter da = new SqlDataAdapter("SELECT tb_priv.priv_user_ID, tb_priv.priv_screen_ID,tb_screen.name, tb_priv.priv_Dsplay,priv_Add, priv_Edit, priv_Delete FROM tb_screen INNER JOIN tb_priv ON tb_screen.screen_ID = tb_priv.priv_screen_ID", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int win_NUm = Convert.ToInt32(dt.Rows[i][1].ToString());
                string windo_name = dt.Rows[i][2].ToString();
               // MessageBox.Show(dt.Rows[i][3].ToString());
                int dis_win = int.Parse(dt.Rows[i][3].ToString());
                int win_add = int.Parse(dt.Rows[i][4].ToString());
                int win_edit = int.Parse(dt.Rows[i][5].ToString());
                int win_dele = int.Parse(dt.Rows[i][6].ToString());
                object[] row = { win_NUm, windo_name, dis_win, win_add, win_edit, win_dele };
                dataGridView1.Rows.Add(row);
                //dataGridView1.Rows.Add(,
                // ,
                //,
                // dt.Rows[i][4].ToString(),
                //dt.Rows[i][5].ToString(),
                // dt.Rows[i][6].ToString());
            }




        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void Pre_Load(object sender, EventArgs e)
        {
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
             //   dataGridView1.Enabled = true;
                rjButton2.Enabled = true;
                rjButton3.Enabled = true;
                SqlDataAdapter da = new SqlDataAdapter("SELECT tb_priv.priv_screen_ID, tb_priv.priv_screen_ID, tb_screen.name, tb_priv.priv_Dsplay, tb_priv.priv_Add, tb_priv.priv_Edit,tb_priv.priv_Delete FROM tb_screen INNER JOIN tb_priv ON tb_screen.screen_ID = tb_priv.priv_screen_ID where tb_priv.priv_user_ID = " + dataGridView2.CurrentRow.Cells[0].Value, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.Rows.Clear();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                  

                    int win_NUm = Convert.ToInt32(dt.Rows[i][1].ToString());
                    string windo_name = dt.Rows[i][2].ToString();
                    // MessageBox.Show(dt.Rows[i][3].ToString());
                    int dis_win = int.Parse(dt.Rows[i][3].ToString());
                    int win_add = int.Parse(dt.Rows[i][4].ToString());
                    int win_edit = int.Parse(dt.Rows[i][5].ToString());
                    int win_dele = int.Parse(dt.Rows[i][6].ToString());
                    object[] row = { win_NUm, windo_name, dis_win, win_add, win_edit, win_dele };
                    dataGridView1.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void RjButton1_Click(object sender, EventArgs e)
        {
            priv_user_ID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            try
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    priv_screen_ID = Convert.ToInt32
                   (dataGridView1.Rows[j].Cells[0].Value.ToString());

                    string sh =
                    dataGridView1.Rows[j].Cells[2].Value.ToString() == "True" ? "1" : "0";
                    string ins = dataGridView1.Rows[j].Cells[3].Value.ToString() == "True" ?
                    "1" : "0";
                    string upd =
                   dataGridView1.Rows[j].Cells[4].Value.ToString() == "True" ? "1" : "0";
                    string del =
                   dataGridView1.Rows[j].Cells[5].Value.ToString() == "True" ? "1" : "0";
                    string sql = "update tb_priv set priv_Dsplay ='" + sh + "',priv_Add='" + ins + "',priv_Edit='" + upd + "',priv_Delete='" + del + "'where priv_user_ID = " + Convert.ToInt32(priv_user_ID) + "and priv_screen_ID = " + Convert.ToInt32(priv_screen_ID);
                    SqlCommand cmd = new SqlCommand(sql, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
                MessageBox.Show("تم منح الصلاحية");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RjButton2_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < dataGridView1.Rows.Count; j++)
            {
                dataGridView1.Rows[j].Cells[2].Value = "True";

            }
        }

        private void RjButton3_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < dataGridView1.Rows.Count; j++)
            {
                dataGridView1.Rows[j].Cells[3].Value = "True";
            }

        }

        private void Panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RjButton4_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < dataGridView1.Rows.Count; j++)
            {
                dataGridView1.Rows[j].Cells[4].Value = "True";

            }
        }

        private void RjButton5_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < dataGridView1.Rows.Count; j++)
            {
                dataGridView1.Rows[j].Cells[5].Value = "True";

            }
        }
        void sev()
        {
           
                int user_ID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                if (dataGridView2.Rows.Count > 0)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        int Screen_No = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                        int Dis = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value.Equals(true || false));
                        int Add = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value.Equals(true || false));
                        int elit = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value.Equals(true || false));
                        int delete = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value.Equals(true || false));
                        SqlCommand cmd = new SqlCommand("insert into tb_priv values(@priv_Dsplay,@priv_Add,@priv_Edit,@priv_Delete,  @priv_user_ID , @priv_screen_ID )", con);
                        con.Open();
                        cmd.Parameters.Add(new SqlParameter("@priv_Dsplay", SqlDbType.Int)).Value = Dis;
                        cmd.Parameters.Add(new SqlParameter("@priv_Add", SqlDbType.Int)).Value = Add;
                        cmd.Parameters.Add(new SqlParameter("@priv_Edit", SqlDbType.Int)).Value = elit;
                        cmd.Parameters.Add(new SqlParameter("@priv_Delete", SqlDbType.Int)).Value = delete;
                        cmd.Parameters.Add(new SqlParameter("@priv_user_ID", SqlDbType.Int)).Value = user_ID;
                        cmd.Parameters.Add(new SqlParameter("@priv_screen_ID", SqlDbType.Int)).Value = Screen_No;

                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                
            
         }
        private void RjButton6_Click(object sender, EventArgs e)
        {
            
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Search__TextChanged(object sender, EventArgs e)
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

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}