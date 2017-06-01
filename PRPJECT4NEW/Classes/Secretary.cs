using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PRPJECT4NEW.Forms;

namespace PRPJECT4NEW.Classes
{
    public class Secretary : PersonStuff
    {
        private SqlConnection sqlcon;
        public Secretary()
        {
        }

        public Secretary(string id) : base(id)
        {

        }

        public double AVG(int []grades, int size)
        {
            int sum = 0;
            for(int i = 0; i < size; i++)
            {
                sum += grades[i];
            }
            return (float) sum / size;
        }

        public bool checkIfTrue(bool flag)
        {
            return flag;
        }
        
        public bool checkForTeacher(string id)
        {
            this.sqlcon = General.ConnectToSql();
            SqlCommand cmd = new SqlCommand("select * from Teaching_Stuff where ID = '" + id + "'", sqlcon);
            SqlDataReader dre = cmd.ExecuteReader();
            if (dre.Read() == false)
            {
                dre.Close();
                return false;
            }
            dre.Close();
            return true;
        }

        public bool checkForStudent(string id)
        {
            this.sqlcon = General.ConnectToSql();
            SqlCommand cmd = new SqlCommand("select * from Person where ID = '" + id + "' and Permission = 'Student'" , sqlcon);
            SqlDataReader dre = cmd.ExecuteReader();
            if (dre.Read() == false)
            {
                dre.Close();
                return false;
            }
            dre.Close();
            return true;
        }

    }
}
