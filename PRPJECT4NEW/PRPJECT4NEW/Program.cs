using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRPJECT4NEW
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Menu());
            Application.Run(new Login());
           // Application.Run(new Exams_Section.Menu());
        }
    }



    static class Utility
    {
        public static Person User;
        public const float feePerNakaz = 300;
        public static Color menuColor = Color.FromArgb(255, 37, 90, 180);
        public static Color HeaderBackColor = Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
    }
}
