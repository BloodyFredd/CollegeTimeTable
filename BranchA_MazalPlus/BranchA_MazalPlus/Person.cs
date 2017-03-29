using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchA_MazalPlus
{
    class Person
    {
        private int id;
        private string F_name;
        private string L_name;
        private string Telephone;
        private string Email;
        private string Password;
        private string Permission;

        public Person()
        {
            
        }
        public Person(int ID,string FIRname,string LAname,string TELE,string EMA,string PASS,string PERM)
        {
            id = ID;
            F_name = FIRname;
            L_name = LAname;
            Telephone = TELE;
            Email = EMA;
            Password = PASS;
            Permission = PERM;
        }
    }
}
