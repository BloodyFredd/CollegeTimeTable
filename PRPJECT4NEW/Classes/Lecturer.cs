using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace PRPJECT4NEW.Classes
{
    public class Lecturer : PersonStuff
    {
        private string connetionString = null;
        private SqlConnection sqlcon;
        public Lecturer(string id) : base(id)
        {

        }
        public Lecturer()
        {
            ID = "123456789";
        }

        public Boolean checker_dates_sql()
        {
            this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            this.sqlcon = new SqlConnection(connetionString);
            this.sqlcon.Open();
            SqlCommand cmd = new SqlCommand("select * from Classes_SM1 where date='" + "1990-01-01" + "'", sqlcon);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                this.sqlcon.Close();
                return true;
            }
            else
            {
                this.sqlcon.Close();
                return false;
            }
        }

        public Boolean report_dates_from_sm1(string str)
        {

            this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            this.sqlcon = new SqlConnection(connetionString);
            this.sqlcon.Open();
            SqlCommand cmd = new SqlCommand("select * from Classes_SM1 where date='" + str + "'", sqlcon);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                this.sqlcon.Close();
                return true;
            }
            else
            {
                this.sqlcon.Close();
                return false;
            }
        }






        public Boolean report_dates_from_sm2(string str)
        {

            this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            this.sqlcon = new SqlConnection(connetionString);
            this.sqlcon.Open();
            SqlCommand cmd = new SqlCommand("select * from Classes_SM2 where date='" + str.ToString() + "'", sqlcon);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                this.sqlcon.Close();
                return true;
            }
            else
            {
                this.sqlcon.Close();
                return false;
            }
        }
    }
}
    





