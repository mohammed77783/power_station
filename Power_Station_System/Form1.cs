using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace Power_Station_System
{
    public partial class Form1 : Form

    {
        




        TabPage tabCont;
        int panal_width;
        bool iscolapsed;
        int x, y, move;
        private Size formSize;
        Form page = null;
        void endform(Form pag, TabPage tab)//دالة لاغلاق كل الصفحات والعودة الى الصفحة الرئيسية
        {
            if (pag != null && tab != null)
            {
                pag.Close();
                foreach (TabPage s in tabControlZ1.TabPages)
                {
                    tabControlZ1.Controls.Remove(s);
                }
                
            }
        }

        public Form1()
        {
            InitializeComponent();
            panal_width = side_panal.Width;
            iscolapsed = false;
            this.BackColor = Color.FromArgb(240, 245, 249);
            if (DateTime.Now.Day == 21)
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
            {
                side_panal.Width -= 10;
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
        private void Loadpage(Form pagee ,TabPage tab)
        {
            try
            {


                pagee.Dock = DockStyle.Fill;

                pagee.TopLevel = false;
                tab.Controls.Add(pagee);
                pagee.Show();


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
            
            label2.Show();
            endform(page, tabCont);
            label3.Hide();






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
            label3.Hide();






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
            bool IsOpen = false;
            foreach (TabPage f in tabControlZ1.TabPages)
            {
                if (f.Text == "بيانات المناطق")
                {
                    IsOpen = true;
                    tabControlZ1.SelectTab(f);
                    label3.Text = "بيانات المناطق";
                    break; 



                }
            }




            if (IsOpen == false)
            {


                label3.Text = "بيانات المناطق";
               page = new chid_form.Add_Area1();
                tabCont = new TabPage("بيانات المناطق");



                label2.Hide();
                label3.Show();



                tabControlZ1.TabPages.Add(tabCont);



                tabControlZ1.SelectTab(tabCont);
                Loadpage(page , tabCont);


            }









        }


        private void Button4_Click_2(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (TabPage x in tabControlZ1.TabPages)
            {
                if (x.Text == "بيانات المربعات")
                {
                    IsOpen = true;
                    tabControlZ1.SelectTab(x);
                    label3.Text = "بيانات المربعات";

                    break;

                }
            }



            if (IsOpen == false)
            {



              Form  page1 = new chid_form.Add_Square1();
               TabPage tabCont1 = new TabPage("بيانات المربعات");


                label3.Text = "بيانات المربعات";
                label2.Hide();
                label3.Show();



                tabControlZ1.TabPages.Add(tabCont1);


                tabControlZ1.SelectTab(tabCont1);
                Loadpage(page1 , tabCont1);



            }


        }

        private void Button9_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (TabPage s in tabControlZ1.TabPages)
            {
                if (s.Text == "إصدار غرامة")
                {
                    IsOpen = true;
                    tabControlZ1.SelectTab(s);
                    label3.Text = "إصدار غرامة";
                    break;

                }
            }


            if (IsOpen == false)
            {

                tabCont = new TabPage("إصدار غرامة");
                page = new chid_form.fines();



                label3.Text = "إصدار غرامة";
                label2.Hide();
                label3.Show();



                tabControlZ1.TabPages.Add(tabCont);
                tabControlZ1.SelectTab(tabCont);
                Loadpage(page , tabCont);



            }

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
            label2.Hide();
            label3.Show();
            label3.Text = ("إضافة قراءة مركزية");
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            showsubmenu(panel6);
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (TabPage s in tabControlZ1.TabPages)
            {
                if (s.Text == "إضافة غرامة")
                {
                    IsOpen = true;
                    tabControlZ1.SelectTab(s);
                    label3.Text = "إضافة غرامة";
                    break;

                }
            }


            if (IsOpen == false)
            {

                page = new chid_form.add_fines();
                tabCont = new TabPage("إضافة غرامة");



                label3.Text = "بيانات غرامة";
                label2.Hide();
                label3.Show();



                tabControlZ1.TabPages.Add(tabCont);
                tabControlZ1.SelectTab(tabCont);
                Loadpage(page , tabCont);



            }

        }

        private void Button15_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (TabPage s in tabControlZ1.TabPages)
            {
                if (s.Text == "إضافة اشتراكات")
                {
                    IsOpen = true;
                    this.tabControlZ1.SelectTab(s);
                    label3.Text = "إضافة اشتراكات";
                    break;

                }
            }


            if (IsOpen == false)
            {

                page = new chid_form.Subscription();
                tabCont = new TabPage("إضافة اشتراكات");



                label3.Text = "إضافة اشتراكات";
                label2.Hide();
                label3.Show();



                tabControlZ1.TabPages.Add(tabCont);
                tabControlZ1.SelectTab(tabCont);
                Loadpage(page , tabCont);



            }
        }



        private void Button17_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (TabPage s in tabControlZ1.TabPages)
            {
                if (s.Text == "إدارة القراءات المركزية")
                {
                    IsOpen = true;
                    tabControlZ1.SelectTab(s);
                    label3.Text = "إدارة القراءات المركزية";
                    break;

                }
            }


            if (IsOpen == false)
            {

                tabCont = new TabPage("إدارة القراءات المركزية");
                page = new chid_form.centarreading();




                label3.Text = "إدارة القراءات المركزية";
                label2.Hide();
                label3.Show();



                tabControlZ1.TabPages.Add(tabCont);
                tabControlZ1.SelectTab(tabCont);
                  Loadpage(page , tabCont);



            }

        }

        private void Button14_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (TabPage s in tabControlZ1.TabPages)
            {
                if (s.Text == "إضافة محصلين")
                {
                    IsOpen = true;
                    tabControlZ1.SelectTab(s);
                    label3.Text = "إضافة محصلين";
                    break;

                }
            }


            if (IsOpen == false)
            {

                tabCont = new TabPage("إضافة محصلين");

                page = new chid_form.mhasel();



                label3.Text = "إضافة محصلين";
                label2.Hide();
                label3.Show();



                tabControlZ1.TabPages.Add(tabCont);
                tabControlZ1.SelectTab(tabCont);
                Loadpage(page , tabCont);



            }

        }



        private void Button27_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (TabPage s in tabControlZ1.TabPages)
            {
                if (s.Text == "إضافة رصيد إفتتاحي")
                {
                    IsOpen = true;
                    tabControlZ1.SelectTab(s);
                    label3.Text = "إضافة رصيد إفتتاحي";
                    break;

                }
            }


            if (IsOpen == false)
            {

                tabCont = new TabPage("إضافة رصيد إفتتاحي");
                page = new chid_form.read();




                label3.Text = "إضافة رصيد إفتتاحي";
                label2.Hide();
                label3.Show();



                tabControlZ1.TabPages.Add(tabCont);
                tabControlZ1.SelectTab(tabCont);
                Loadpage(page , tabCont);



            }

        }

        private void Button19_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (TabPage s in tabControlZ1.TabPages)
            {  
                if (s.Text == "إدارة القراءات")
                {
                    IsOpen = true;
                    tabControlZ1.SelectTab(s);
                    label3.Text = "إدارة القراءات";
                    break;

                }
            }

            if (IsOpen == false)
            {

                tabCont = new TabPage("إدارة القراءات");
                page = new chid_form.Reading_managment();



                label3.Text = "إدارة القراءات";
                label2.Hide();
                label3.Show();



                tabControlZ1.TabPages.Add(tabCont);
                tabControlZ1.SelectTab(tabCont);
                Loadpage(page , tabCont);



            }

        }

        private void Button18_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (TabPage s in tabControlZ1.TabPages)
            {
                if (s.Text == "إضافة قراءة")
                {
                    IsOpen = true;
                    tabControlZ1.SelectTab(s);
                    label3.Text = "إضافة قراءة";
                    break;

                }
            }


            if (IsOpen == false)
            {

                tabCont = new TabPage("إضافة قراءة");
                page = new chid_form.Add_reading();




                label3.Text = "إضافة قراءة";
                label2.Hide();
                label3.Show();



                tabControlZ1.TabPages.Add(tabCont);
                tabControlZ1.SelectTab(tabCont);
                Loadpage(page , tabCont);



            }


        }

        private void Button12_Click(object sender, EventArgs e)
        {
            label2.Hide();
            label3.Show();
            label3.Text = ("إدارة الفواتير");
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (TabPage s in tabControlZ1.TabPages)
            {
                if (s.Text == "إصدار فاتورة")
                {
                    IsOpen = true;
                    tabControlZ1.SelectTab(s);
                    label3.Text = "إصدار فاتورة";
                    break;

                }
            }

            if (IsOpen == false)
            {

                tabCont = new TabPage("إصدار فاتورة");
                page = new child_form.Add_bill();




                label3.Text = "إصدار فاتورة";
                label2.Hide();
                label3.Show();



                tabControlZ1.TabPages.Add(tabCont);
                tabControlZ1.SelectTab(tabCont);
                Loadpage(page ,tabCont);



            }


        }

        private void Button13_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (TabPage s in tabControlZ1.TabPages)
            {
                if (s.Text == "الاصدار السريع للفاتورة")
                {
                    IsOpen = true;
                    tabControlZ1.SelectTab(s);
                    label3.Text = "الاصدار السريع للفاتورة";
                    break;

                }
            }


            if (IsOpen == false)
            {

                page = new child_form.bill_quacliy_rease();
                tabCont = new TabPage("الاصدار السريع للفاتورة");



                label3.Text = ("الاصدار السريع للفاتورة");
                label2.Hide();
                label3.Show();



                tabControlZ1.TabPages.Add(tabCont);
                tabControlZ1.SelectTab(tabCont);
                Loadpage(page , tabCont);



            }

        }

        private void Home_btn_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void Panel_contener_Enter(object sender, EventArgs e)
        {

        }






        private void Button28_Click(object sender, EventArgs e)
        {
           bool IsOpen = false;
            foreach (TabPage s in tabControlZ1.TabPages)
            {
                if (s.Text == "بيانات المحطة")
                {
                    IsOpen = true;
                     tabControlZ1.SelectTab(s);
                   
                    label3.Text = "بيانات المحطة";
                    break;

                }
            }


            if (IsOpen == false)
            {

               page = new child_form.NewFolder1.Station_Name();
                tabCont= new TabPage("بيانات المحطة");
                


                label3.Text = "بيانات المحطة";
                label2.Hide();
                label3.Show();



                tabControlZ1.TabPages.Add(tabCont);
                tabControlZ1.SelectTab(tabCont);
                Loadpage(page , tabCont);



            }
        }


        private void Button25_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (TabPage s in tabControlZ1.TabPages)
            {
                if (s.Text == "فواتير المشتركين")
                {
                    IsOpen = true;
                    tabControlZ1.SelectTab(s);
                    label3.Text = "فواتير المشتركين";
                    break;

                }
            }


            if (IsOpen == false)
            {

                page = new child_form.Add_bill();
               tabCont = new TabPage("فواتير المشتركين");

                label3.Text = ("فواتير المشتركين");




                label2.Hide();
                label3.Show();



                tabControlZ1.TabPages.Add(tabCont);
                tabControlZ1.SelectTab(tabCont);
                Loadpage(page , tabCont);



            }

        }

        private void Button24_Click(object sender, EventArgs e)
        {
            label2.Hide();
            label3.Show();
            label3.Text = ("تقرير النزول الميداني لتسجيل القراءات");
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            label2.Hide();
            label3.Show();
            label3.Text = ("اجمالي استهلاك المشتركين");
        }

        private void TabPage5_Click(object sender, EventArgs e)
        {

        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TabControl1_DpiChangedBeforeParent(object sender, EventArgs e)
        {

        }


        public void TabControl1_Click(object sender, EventArgs e)
        {



        }

        private void TabControl1_MouseClick(object sender, MouseEventArgs e)
        {



        }


        private void TabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {




        }

        private void Button1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Button28_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {




        }

        private void TabControl1_Selecting_1(object sender, TabControlCancelEventArgs e)
        {




        }

        private void TabControlZ1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TabControlZ1_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void TabControlZ1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            try
            {
                label3.Text = e.TabPage.Text;
            }
            catch (Exception) { }
        }

        private void TabControlZ1_MouseHover(object sender, EventArgs e)
        {
            

        }

        private void TabControlZ1_MouseLeave(object sender, EventArgs e)
        {
            if (tabCont.Capture == true)
            {
                    tabControlZ1.NonActiveTabEndColor = Color.FromArgb(51, 55, 66);
                    tabControlZ1.NonActiveTabStartColor = Color.FromArgb(51, 55, 66);
                
            }

        }


        private void TabControlZ1_MouseEnter(object sender, EventArgs e)
        {

           //if( tabCont.Capture == true) 
           //     {
           //         tabControlZ1.NonActiveTabEndColor = Color.DodgerBlue;
           //         tabControlZ1.NonActiveTabStartColor = Color.DodgerBlue;
           //     }
            
        }

    private void IconButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button8_Click_1(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (TabPage s in tabControlZ1.TabPages)
            {   
                if (s.Text == "إدارة العملاء")
                {
                    IsOpen = true;
                    tabControlZ1.SelectTab(s);
                    label3.Text = "إدارة العملاء";
                    break;

                }
            }


            if (IsOpen == false)
            {



                page = new chid_form.customer_management();
                tabCont = new TabPage("إدارة العملاء");



                label3.Text = ("إدارة العملاء");
                label2.Hide();
                label3.Show();



                tabControlZ1.TabPages.Add(tabCont);
                tabControlZ1.SelectTab(tabCont);
                Loadpage(page , tabCont);



            }




        }
    }
} 

