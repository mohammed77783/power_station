using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace Power_Station_System.child_form.NewFolder1
{
    public partial class Station_Name : Form
        

    { DataBase.Station_Data SD = new DataBase.Station_Data();
        DataBase.users users = new DataBase.users();

        string name_station;
        string owner_name;
        string address;
        string phone1;
        string phone2;
        public Station_Name()
        {
            InitializeComponent();
            Loadpriv();
        }


        void Loadpriv()
        {


            DataTable Dt = users.priv_Add_priv_Edit(1, Convert.ToInt32(Program.user_ID));


            if (Dt.Rows[0][0].ToString() == "0" || Dt.Rows[0][0].ToString() == String.Empty)
            {
                rjButton1.Enabled = false;

            }


            if (Dt.Rows[0][1].ToString() == "0" || Dt.Rows[0][1].ToString() == String.Empty)
            {

                rjButton3.Enabled = false;


            }
            
        }


        public void mod()
        {

            
            
                textBox_Custom1.Texts = name_station;
                textBox_Custom2.Texts = owner_name;
                textBox_Custom3.Texts = address;
                textBox_Custom4.Texts = phone1;
                textBox_Custom5.Texts = phone2;

                rjButton3.Text = "الغاء";
                rjButton1.Text = "حقظ التغيرات";


            

        }
        public void unmod()
        {
           
            rjButton1.Enabled = true;
          
            rjButton3.Enabled = true;
            rjButton1.Text = "إضافة";
            rjButton3.Text = "الغاء";


        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void RjButton7_Click(object sender, EventArgs e)
        {
            /*  openFileDialog1.Filter = "Image Files | *.JPG;*.PNG;*.GIF";
              openFileDialog1.InitialDirectory = "C:\\Desktop";
              if (openFileDialog1.ShowDialog()== DialogResult.OK)
              {
                  pictureBox2.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
                  pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
              }*/
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "صور المنتجات |*.jpg;*.png;*.Gif;*.BMp";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.BackgroundImage = Image.FromFile(op.FileName);
                pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            }



        }

        private void RjButton6_Click(object sender, EventArgs e)
        {

        }

        private void RjButton1_Click(object sender, EventArgs e)
       {
            if (rjButton1.Text == "اضافة")
            {
                DataTable tb = SD.get_SD();
                if (tb.Rows.Count > 0) return;
                /* SD.AddSD(textBox_Custom1.Texts, textBox_Custom2.Texts, textBox_Custom3.Texts,textBox_Custom4.Texts,textBox_Custom5.Texts);
                 MessageBox.Show("done");*/
                MemoryStream mee = new MemoryStream();
                pictureBox2.BackgroundImage.Save(mee, pictureBox2.BackgroundImage.RawFormat);
                byte[] byimag = mee.ToArray();
                SD.AddSD(textBox_Custom1.Texts, textBox_Custom2.Texts, textBox_Custom3.Texts, textBox_Custom4.Texts, textBox_Custom5.Texts, byimag);
                MessageBox.Show("تم عملية الادخال بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            if (rjButton1.Text == "حقظ التغيرات")
            {
                try
                {
                    MemoryStream mee = new MemoryStream();
                    pictureBox2.BackgroundImage.Save(mee, pictureBox2.BackgroundImage.RawFormat);
                    byte[] byimag = mee.ToArray();
                    SD.Update_Data_Station(textBox_Custom1.Texts, textBox_Custom2.Texts, textBox_Custom3.Texts, textBox_Custom4.Texts, textBox_Custom5.Texts, byimag);
                    Image image = pictureBox2.Image;

                    MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   // this.Alert(" تم التعديل بنجاح", Form_alert.enmType.Success);
                    unmod();
                    
                   // this.Mhasel_Load(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                  //  this.Alert(ex.Message, Form_alert.enmType.Error);
                }
            }


        }

        private void Station_Name_Load(object sender, EventArgs e)
        {
            DataTable tb = SD.get_SD();
            if (tb.Rows.Count > 0)
            {
                textBox_Custom1.Texts = tb.Rows[0][0].ToString();
                textBox_Custom2.Texts = tb.Rows[0][1].ToString();
                textBox_Custom3.Texts = tb.Rows[0][2].ToString();
                textBox_Custom4.Texts = tb.Rows[0][3].ToString();
                textBox_Custom5.Texts = tb.Rows[0][4].ToString();


                //byte[] imag = (byte[])SD.get_image().Rows[0][0];





                byte[] imag = (byte[])SD.get_SD().Rows[0][5];


                MemoryStream mm = new MemoryStream(imag);
                // var bytes = mm.ToArray();


                if (mm == null) MessageBox.Show("done");

                pictureBox2.BackgroundImage = Image.FromStream(mm);
                pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;

                //Bitmap imag = (Bitmap)SD.get_image().Rows[0][0];
                //if (imag != null)
                //{
                //    pictureBox2.BackgroundImage = imag;
                //    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                //    pictureBox2.Refresh();
                //}




            }

        }

        private void RjButton2_Click(object sender, EventArgs e)
        {

        }

        private void RjButton3_Click(object sender, EventArgs e)
        {
            if (rjButton3.Text == "تعديل")
            {
                mod();
            }

            if (rjButton3.Text == "الغاء ")
                {
                   unmod();

               

            }

            


        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    }
