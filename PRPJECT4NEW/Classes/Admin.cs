using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PRPJECT4NEW.Classes
{
    public class Admin : PersonStuff
    {

        public Admin(string id) : base(id) { }

        public Admin() : base() { }

        public SqlDataReader SelectStuff()
        {
            try
            {
                string connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False; MultipleActiveResultSets=true";
                SqlConnection sqlcon = new SqlConnection(connetionString);
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("select * from Teaching_Stuff ", sqlcon);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    dr.Close();
                    sqlcon.Close();
                    return dr;
                }
                else
                {
                    throw new ArgumentException("Try again, the person isnt in the teaching stuff!");

                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public SqlConnection classesByDate(string date)
        {

            string connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False; MultipleActiveResultSets=true";
            SqlConnection sqlcon = new SqlConnection(connetionString);
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("select * from Classes_SM2 Where date='" + date + "'", sqlcon);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                sqlcon.Close();
                return sqlcon;
            }
            sqlcon.Close();
            dr.Close();

            return null;

        }

        public SqlConnection FindLecturer(string ID)
        {

            string connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False; MultipleActiveResultSets=true";
            SqlConnection sqlcon = new SqlConnection(connetionString);
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("select * from Lecture_Course Where Teacher='" + ID + "'", sqlcon);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                sqlcon.Close();
                return sqlcon;
            }
            sqlcon.Close();
            dr.Close();

            return null;

        }
    }
}







