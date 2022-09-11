using Power_Station_System.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Power_Station_System.warning_code
{
    public partial class Form_alert : Form
    {
        public Form_alert()
        {
            InitializeComponent();
        }
        public enum enmAction
        {
            wait,
            start,
            close

        }
        public enum enmType
        {
            Success,
            Warning,
            Error,
            Info

        }
        private Form_alert.enmAction action;

        private int x, y;

        


        private void Form_alert_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = enmAction.close;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    timer1.Interval = 5000;
                    action = enmAction.close;
                    break;
                case enmAction.start:
                    timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = enmAction.wait;

                        }
                    }
                    break;
                case enmAction.close:

                    timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }

                    break;
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LblMsg_Click(object sender, EventArgs e)
        {

        }

        private void Form_alert_Load_1(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        public void showAlert(string msg, enmType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                Form_alert frm = (Form_alert)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (type)
            {

                case enmType.Success:
                    this.pictureBox1.Image = Resources.success11;
                    this.BackColor = Color.SeaGreen;
                    
                    break;
                case enmType.Error:
                    this.pictureBox1.Image = Resources.error11;
                    this.BackColor = Color.DarkRed;
                    break;
                case enmType.Info:
                    this.pictureBox1.Image = Resources.info11;
                    this.BackColor = Color.RoyalBlue;
                    break;
                case enmType.Warning:
                    this.pictureBox1.Image = Resources.warning11;
                    this.BackColor = Color.DarkOrange;
                    break;


            }

            this.lblMsg.Text = msg;

            this.Show();
            this.action = enmAction.start;
            this.timer1.Interval = 1;
            timer1.Start();
        }
    }
}

