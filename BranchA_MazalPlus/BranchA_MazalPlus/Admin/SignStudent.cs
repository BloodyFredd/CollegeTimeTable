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

namespace BranchA_MazalPlus.Admin
{
    public partial class SignStudent : Form
    {
        private string connetionString = null;
        private SqlConnection sqlcon;

        public SignStudent()
        {
            InitializeComponent();
        }

        private void ShowStudents_Click(object sender, EventArgs e)
        {
            this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            this.sqlcon = new SqlConnection(connetionString);
            try
            {
                SqlCommand cmd = new SqlCommand("select stud_Id, course_id, course_serial,final_grade from Student_Courses ", sqlcon);
                Students.Visible = true;
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;
                Students.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Sign_student_Click(object sender, EventArgs e)
        {
            string value = null;
            this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            this.sqlcon = new SqlConnection(connetionString);
            try
            {
                SqlCommand cmd1 = new SqlCommand("SELECT course_serial FROM Student_Courses where stud_Id='" + Stud_ID.Text + "'AND course_id='" + Course.Text + "'", sqlcon);
                this.sqlcon.Open();
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    value = dr[0].ToString();
                }
                dr.Close();
                this.sqlcon.Close();

                if (serial.Text == value) MessageBox.Show("It is the same course, try again!");
                else
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Student_Courses SET course_serial = '" + serial.Text + "' WHERE stud_Id='" + Stud_ID.Text + "'AND course_id='" + Course.Text +"'", sqlcon);
                    Students.Visible = true;
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = cmd;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    Students.DataSource = bsource;
                    sda.Update(dbdataset);
                    MessageBox.Show("The student was assigned!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
