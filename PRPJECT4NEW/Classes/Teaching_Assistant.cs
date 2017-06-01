using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRPJECT4NEW.Classes
{
    public class Teaching_Assistant : PersonStuff
    {

        public Teaching_Assistant(string id) : base(id)
        {
        }
        public Teaching_Assistant() : base()
        {
        }

        public SqlDataReader SelectStuff()
        { try
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
                    throw new ArgumentException("Try again, you do not teach such a course!");
                    
                }

            }
            catch (Exception ex)
            { 
                return null;
            }
        }


        public SqlConnection RecepH(string date)
        {

                string connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False; MultipleActiveResultSets=true";
                SqlConnection sqlcon = new SqlConnection(connetionString);
            sqlcon.Open();
                SqlCommand cmd = new SqlCommand("select * from Classes_SM2 Where date='"+ date + "'", sqlcon);
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

        public SqlConnection LectureWith(string ID)
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

        public SqlDataReader GradeStud(string ID,string Course)
        {
            string connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False; MultipleActiveResultSets=true";
            SqlConnection sqlcon = new SqlConnection(connetionString);
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("select * from Student_Courses Where stud_id='" + ID + "' and course_id ='" + Course + "'", sqlcon);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                dr.Close();
                sqlcon.Close();
                return dr ;
            }
            return null;
        }

    }

}
