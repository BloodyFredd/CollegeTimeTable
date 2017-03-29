using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchA_MazalPlus
{
    class Admin : Person
        {
            private static Boolean only_one = false;
            public Admin() : base() {; }

            public Admin(string ID, string FIRname, string LAname, string TELE, string EMA, string PASS) : base(ID, FIRname, LAname, TELE, EMA, PASS, "Secretary")
            {
                if (only_one == false)
                {
                    only_one = true;
                }
                else System.Windows.Forms.MessageBox.Show("ERROR:\nThere is only one Admin possible\n");
            }




        }

    }
}
