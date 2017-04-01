using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchA_MazalPlus
{
     abstract class  Person
    {
        protected string id;
        protected string F_name;
        protected string L_name;
        protected string Telephone;
        protected string Email;
        protected string Password;
        protected string Permission;

        public Person()
        {
            id=null;
            F_name = null;
            L_name = null;
            Telephone = null;
            Email = null;
            Password = null;
            Permission = null;

    }
        public Person(string ID,string FIRname,string LAname,string TELE,string EMA,string PASS,string PERM)
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
