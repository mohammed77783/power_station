using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using PSS.chid_form;
namespace Power_Station_System
{
    public partial class Form1 : Form
    {
       
        int panal_width;
        bool iscolapsed;
        int x, y, move;
        private Size formSize;
        public Form1()
        {
            InitializeComponent();
            panal_width = side_panal.Width;
            iscolapsed = false;
            this.BackColor = Color.FromArgb(240, 245, 249);
            if (DateTime.Now.Day==21)
            {


            }
            
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(0, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != 2)
                        this.Padding = new Padding(2);
                    break;
            }
        }
        private void Menu_timer_Tick(object sender, EventArgs e)
        {
            if (iscolapsed)
            {
               side_panal.Width += 10;
                if (side_panal.Width >= panal_width)
                {
                    menu_timer.Stop();
                    iscolapsed = false;
                    this.Refresh();
                }
            }
            else
            {   side_panal.Width -= 10;
                if (side_panal.Width <= 59)
                {
                    menu_timer.Stop();
                    iscolapsed = true;
                    this.Refresh();


                }
            }
        }

       
    

       

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void Button1_Click_1(object sender, EventArgs e)
        {
            showsubmenu(panel_system_prepar);
           

        }
        void showsubmenu(Panel sube)
        {
            if (sube.Visible == false)
            {
             
                sube.Visible = true;
            }
            else
            {
                sube.Visible = false;
            }
        }
        void hidesubmenu()
        {
            if (panel_system_prepar.Visible == true)
                panel_system_prepar.Visible = false;
            if (customer_panal.Visible == true)
                customer_panal.Visible = false;
            if (panel4.Visible == true)
                panel4.Visible = false;
            if (panel5.Visible == true)
                panel5.Visible = false;
            if (panel6.Visible == true)
                panel6.Visible = false;
        }
        private void IconButton1_Click(object sender, EventArgs e)
        {
            menu_timer.Start();
        }


        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void Panel5_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel3_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            x = e.X;
            y = e.Y;
           
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
        private void Loadpage(Form page)
        {
            try
            {
                panel_contener.Controls.Clear();
                page.Dock = DockStyle.Fill;
          
                page.TopLevel = false;
                panel_contener.Controls.Add(page);
                page.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
           
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Button8_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click_1(object sender, EventArgs e)
        {

        }

        private void IconButton2_Click(object sender, EventArgs e)
        {
      
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
           

        }

        private void Button2_Click_2(object sender, EventArgs e)
        {

            showsubmenu(customer_panal);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Panel3_MouseMove(object sender, MouseEventArgs e)
        {

            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
        }

        private void Panel3_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form page = new chid_form.Add_Area1();
            Loadpage(page);
        }

        private void Button4_Click_2(object sender, EventArgs e)
        {
            Form page = new chid_form.Add_Square1();
            Loadpage(page);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Form page = new chid_form.fines();
            Loadpage(page);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            showsubmenu(panel4);
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            showsubmenu(panel5);
        }

        private void Button20_Click(object sender, EventArgs e)
        {

        }

        private void Button21_Click(object sender, EventArgs e)
        {
            showsubmenu(panel6);
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            Form page = new chid_form.add_fines();
            Loadpage(page);
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            Form page = new chid_form.Subscription();
            Loadpage(page);
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            Form page = new chid_form.centarreading();
            Loadpage(page);
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            Form page = new chid_form.mhasel();
            Loadpage(page);
        }

        private void Button27_Click(object sender, EventArgs e)
        {
            Form page = new chid_form.read();
            Loadpage(page);
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            Form page = new chid_form.Reading_managment();
            Loadpage(page);
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            Form page = new chid_form.Add_reading();
            Loadpage(page);

        }

        private void Button12_Click(object sender, EventArgs e)
        {

        }

        private void Button11_Click(object sender, EventArgs e)
        {

        }

        private void Button13_Click(object sender, EventArgs e)
        {

        }

        private void IconButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button8_Click_1(object sender, EventArgs e)
        {


          Form page = new chid_form.customer_management();

            Loadpage(page);
        }
    }
}
