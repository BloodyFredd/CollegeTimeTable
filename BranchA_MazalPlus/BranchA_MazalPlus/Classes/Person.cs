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
        string ID;
        string Fname;
        string Lname;
        string Telephone;
        string Email;
        string Password;
        string Permission;
        
        public void print()
        {
            string connetionString = "Data Source  = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

            SqlConnection sqlcon = new SqlConnection(connetionString);
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("select * from person where ID='123456789'", sqlcon);
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
                System.Console.WriteLine(ID);
                System.Console.WriteLine(Fname);
                System.Console.WriteLine(Lname);
                System.Console.WriteLine(Telephone);
                System.Console.WriteLine(Email);
                System.Console.WriteLine(Password);
                System.Console.WriteLine(Permission);


            }

        }
    }
}
