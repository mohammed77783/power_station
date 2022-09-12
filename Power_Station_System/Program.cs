using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Power_Station_System.child_form.user;

namespace Power_Station_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static string user_ID;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
           Application.Run(new @long());
           
           //Application.Run(new Form1());
=======
            //Application.Run(new @long());
            //Application.Run(new add_user());
            Application.Run(new Form1());
>>>>>>> 5e38ade13c9e8577da92a910f28c0284ef4ed254
        }
    }
}
