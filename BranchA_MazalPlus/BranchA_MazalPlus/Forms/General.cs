using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace BranchA_MazalPlus.Forms
{
   public  class General
    {
        public static  bool ConnectToSql(SqlConnection sqlcon)
        {
            string connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            sqlcon = new SqlConnection(connetionString);
            sqlcon.Open();
            if (sqlcon.State != ConnectionState.Open)
            {
                return false;

            }
            return true;
        }


    }
}
