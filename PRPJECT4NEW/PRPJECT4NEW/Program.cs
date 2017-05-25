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


        //Get Color By ID
        public static Color getColorByID(int index)
        {
            index = index % 12;
            switch (index) {
                case 0:
                    return Color.AliceBlue;
                case 1:
                    return Color.Yellow;
                case 2:
                    return Color.Brown;
                case 3:
                    return Color.Magenta;
                case 4:
                    return Color.Orange;
                case 5:
                    return Color.Purple;
                case 6:
                    return Color.Green;
                case 7:
                    return Color.Silver;
                case 8:
                    return Color.Olive;
                case 9:
                    return Color.Coral;
                case 10:
                    return Color.Orchid;
                case 11:
                    return Color.Red;
                default:
                    return Color.White;
            }

        }
    }
}
