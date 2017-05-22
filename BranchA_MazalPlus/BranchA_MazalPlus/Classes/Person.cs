using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BranchA_MazalPlus;
using BranchA_MazalPlus.Forms;

namespace BranchA_MazalPlus.Classes
{
    class Person
    {
        private string ID;
        private string Fname;
        private string Lname;
        private string Telephone;
        private string Email;
        private string Password;
        private string Permission;


        public Person(string id)
        {
            SqlConnection sqlcon = General.ConnectToSql();
            SqlCommand cmd = new SqlCommand("select * from person where ID='"+id+"'", sqlcon);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                ID = dr[0].ToString();
                Fname= dr[1].ToString();
                Lname = dr[2].ToString();
                Telephone = dr[3].ToString();
                Email = dr[4].ToString();
                Password = dr[5].ToString();
                Permission = dr[6].ToString();
            }

        }
    }
}
