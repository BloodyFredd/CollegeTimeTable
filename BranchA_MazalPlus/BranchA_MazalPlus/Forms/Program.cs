using BranchA_MazalPlus.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BranchA_MazalPlus
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Person ptemp = new Person();
            ptemp.print();

            Application.Run(new Login());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        }

    }
}









//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace BranchA_MazalPlus
//{
//    static class Program
//    {
//        /// <summary>
//        /// The main entry point for the application.
//        /// </summary>
//        [STAThread]
//        static void Main()
//        {
//            Application.EnableVisualStyles();
//            Application.SetCompatibleTextRenderingDefault(false);
//            //Application.Run(new Form1());
//            Application.Run(new Login());
//            // Application.Run(new Lecturer.Menu());
//        }
//    }
//}
