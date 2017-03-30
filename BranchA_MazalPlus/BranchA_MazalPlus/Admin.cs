using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchA_MazalPlus
{
    class Admin : Person
    {
        private static bool only_one = false;
        public Admin() : base() {; }

        public Admin(string ID, string FIRname, string LAname, string TELE, string EMA, string PASS) : base(ID, FIRname, LAname, TELE, EMA, PASS, "Secretary")
        {
            if (only_one == false)
            {
                only_one = true;
            }
            else System.Windows.Forms.MessageBox.Show("ERROR:\nThere is only one Admin possible\n");
        }
        public void makeUser()
        {
            System.Windows.Forms.MessageBox.Show("Hello " + this.F_name + "! Please enter which user you would like to add:\n");
            //System.Windows.Forms.MessageBox.Show();
            // Add here a box for adding a new person.
        }

    }
}
