using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace FinalProject
{
    class Database
    {

        private string connetionString = null;
        private SqlConnection con;

        public Database() // ctor
        {
            initializeConnection();
        }

        public void initializeConnection()
        {
            connetionString = "Data Source=localhost;Initial Catalog=ProjectDB;Integrated Security=SSPI;"
            + "User ID=TAKA;Password=123";
            con = new SqlConnection(connetionString);
        }

        public Boolean OpenConn()
        {
            try
            {
                con.Open();
                //MessageBox.Show ("Connection Open ! ");

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
                return false;
            }

        }

        public void CloseConn(Boolean ConnStatus)
        {
            if (ConnStatus == true)
            {
                con.Close();
            }

        }

        public DataSet LoadSpecificWBSFromDB(int proj_ID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM WBS WHERE PROJ_ID=" + proj_ID;

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");

            return ds;
        }

        public int Get_NumOfDept()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT COUNT(*) FROM DEPARTMENT";

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");

            return Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0].ToString());
        }

        public List<int> LoadProjectsIDFromDB()
        {
            List<int> _lst_ProjectsID = new List<int>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT PROJ_ID FROM PROJECT";

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                _lst_ProjectsID.Add(Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[0].ToString()));
            }

            return _lst_ProjectsID;
        }

        public bool CheckIfEmpID_Exist(int empid)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT EMPID FROM EMPLOYEES WHERE EMPID=" + empid;

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");

            if (ds.Tables[0].Rows.Count > 0)
                return true;

            return false;
        }

        public List<string> getAllDerecognitionWO_Details()
        {
            List<string> _lst_DerecognitionsWo = new List<string>();
            string row, DatePlanned, DateMade;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT W2.PROJ_ID, W1.* FROM WO W1, WBS W2"
                + " WHERE (W1.WBS_ID=W2.WBS_ID)"
                + " AND ( (W1.HOURS_PLANNED<W1.HOURS_MADE) OR (W1.DATE_PLANNED < W1.DATE_MADE) )";
            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                DatePlanned = Convert.ToDateTime(ds.Tables[0].Rows[i].ItemArray[6]).ToShortDateString();
                DateMade = Convert.ToDateTime(ds.Tables[0].Rows[i].ItemArray[7]).ToShortDateString();
                row = "ProjID: " + ds.Tables[0].Rows[i].ItemArray[0].ToString()
                    + ", woID: " + ds.Tables[0].Rows[i].ItemArray[1].ToString()
                    + ", wbsID: " + ds.Tables[0].Rows[i].ItemArray[5].ToString()
                    + ", Description: " + ds.Tables[0].Rows[i].ItemArray[2].ToString()
                    + ", Hours Planned: " + ds.Tables[0].Rows[i].ItemArray[3].ToString()
                    + ", Hours Made: " + ds.Tables[0].Rows[i].ItemArray[4].ToString()
                    + ", Date Planned: " + DatePlanned
                    + ", Date Made: " + DateMade;
                _lst_DerecognitionsWo.Add(row);
            }

            return _lst_DerecognitionsWo;
        }

        public void UpdateTotalHoursForProject()
        {
            try
            {
                List<int> _lst_ProjectsID = new List<int>();
                _lst_ProjectsID = LoadProjectsIDFromDB();
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                for (int i = 0; i < _lst_ProjectsID.Count; i++)
                {
                    cmd.CommandText = "UPDATE PROJECT "
                        + "SET TOTAL_HOURS = " + getSumOfTotalHoursWBS(_lst_ProjectsID[i])
                        + " WHERE PROJ_ID=" + _lst_ProjectsID[i];
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("An Error Occured ! Something Went Wrong with Queries !", "Message Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        // help function for the function above
        public int getSumOfTotalHoursWBS(int proj_id)
        {
            List<int> _lst_ProjectsID = new List<int>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT SUM(HOURS_MADE) FROM WBS WHERE PROJ_ID=" + proj_id;

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");

            int sumHours;
            if (ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0].ItemArray[0].ToString() != "")
            {
                sumHours = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0].ToString());
            }
            else
            {
                sumHours = 0;
            }
            return sumHours;
        }

        public void UpdateTotalHoursForWBS()
        {
            try
            {
                List<int> _lst_WBS_ID = new List<int>();
                _lst_WBS_ID = LoadWBSIDFromDB();
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                for (int i = 0; i < _lst_WBS_ID.Count; i++)
                {
                    cmd.CommandText = "UPDATE WBS "
                        + "SET HOURS_MADE = " + getSumOfHoursMadeFromWO(_lst_WBS_ID[i])
                        + " , HOURS_PLANNED = " + getSumOfHoursPlannedFromWO(_lst_WBS_ID[i])
                        + " WHERE WBS_ID=" + _lst_WBS_ID[i];
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                // error message
            }
        }

        // help function for the function above
        public int getSumOfHoursMadeFromWO(int wbs_id)
        {
            List<int> _lst_ProjectsID = new List<int>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT SUM(HOURS_MADE) FROM WO WHERE WBS_ID=" + wbs_id;

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");
            int SUM = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0].ToString());

            return SUM;
        }

        // help function for the function above
        public int getSumOfHoursPlannedFromWO(int wbs_id)
        {
            List<int> _lst_ProjectsID = new List<int>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "SELECT SUM(HOURS_PLANNED) FROM WO WHERE WBS_ID=" + wbs_id;

            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "Conn_DB");
            int SUM = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0].ToString());

            return SUM;
        }

        public void UpdateTotalHoursForWO()
        {
            try
            {
                List<int> _lst_WO_ID = new List<int>();
                _lst_WO_ID = getAllWO_ID();
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                for (int i = 0; i < _lst_WO_ID.Count; i++)
                {
                    cmd.CommandText = "UPDATE WO "
                        + "SET HOURS_MADE = " + getSumHoursMadeFromWO(_lst_WO_ID[i])
                        + " WHERE WO_ID=" + _lst_WO_ID[i];
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                // error message
            }
        }

        public bool AddNewDH(int empid, int deptno, int proj_id, int wbs_id, int wo)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.CommandText = "INSERT INTO DERECOGNITION_HOURS "
                                + "VALUES(" + empid + "," + deptno + "," + proj_id + "," + wbs_id + "," + wo + ",0)";
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
