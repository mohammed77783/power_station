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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Alert(string msg, Form_alert.enmType type)
        {
            Form_alert frm = new Form_alert();
            frm.showAlert(msg, type);
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Alert(" تمت الإضافة بنجاح", Form_alert.enmType.Success);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Alert("Warning Alert", Form_alert.enmType.Warning);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Alert("Error Alert", Form_alert.enmType.Error);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Alert("Info Alert", Form_alert.enmType.Info);
        }
    }
}
