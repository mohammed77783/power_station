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
    public partial class print_barcode1 : Form
    {
        string number_eter,name;
        public print_barcode1(string m,string n)
        {
            InitializeComponent();
            this.number_eter = m;
            this.name = n;
        }

        private void RjButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Print_barcode1_Load(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw bar = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBox1_bar.Image = bar.Draw(number_eter, 100);
        }

        private void RjButton3_Click(object sender, EventArgs e)
        {
            string s;
          
           if(folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    s = folderBrowserDialog1.SelectedPath;
                    pictureBox1_bar.Image.Save(s + "\\" + name + ".jpg");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    this.Close();
                }
            }
           
        }
    }
}
