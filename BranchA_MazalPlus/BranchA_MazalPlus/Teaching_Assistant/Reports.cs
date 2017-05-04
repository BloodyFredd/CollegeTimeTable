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


namespace BranchA_MazalPlus.Teaching_Assistant
{
    public partial class Reports : Form
    {
        private string connetionString = null;
        private SqlConnection sqlcon;
        public Reports()
        {
            InitializeComponent();
        }

        private void Load_table_Click(object sender, EventArgs e)
        {
        }

        private void StudentsReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Load_table_Click_1(object sender, EventArgs e)
        {
            this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            this.sqlcon = new SqlConnection(connetionString);
            //SqlCommand cmd = new SqlCommand("SELECT DISTINCT t.ID, t.Course_id FROM Teaching_Stuff t WHERE not EXISTS( SELECT t2.ID FROM Teaching_Stuff t2 WHERE (t2.ID = '" + Forms.UserID.ID + "' and t.Course_id != t2.Course_id))", sqlcon);
            SqlCommand cmd = new SqlCommand("select Person.F_name, Person.L_name FROM Person LEFT join (SELECT DISTINCT t.ID, t.Course_id FROM Teaching_Stuff t WHERE not EXISTS( SELECT t2.ID FROM Teaching_Stuff t2 WHERE (t2.ID = '" + Forms.UserID.ID + "' and t.Course_id != t2.Course_id))", sqlcon);
            try
            {

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;
                StudentsReport.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            this.sqlcon = new SqlConnection(connetionString);

            SqlCommand cmd = new SqlCommand("select Course_id from Teaching_Stuff where ID ='" + Forms.UserID.ID + "'", sqlcon);
            this.sqlcon.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            SqlCommand cmd1 = new SqlCommand("select ID from Teaching_Stuff where Course_id ='" + dr[0].ToString() + "'", sqlcon);
            try
            {
                
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd1;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;
                StudentsReport.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Grades_Button_Click(object sender, EventArgs e)
        {
            this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False; MultipleActiveResultSets=true";
            this.sqlcon = new SqlConnection(connetionString);
            try
            {
                SqlCommand cmd = new SqlCommand("select Student_Courses.stud_Id,Student_Courses.course_id, Student_Courses.grade_a, Student_Courses.grade_b, Student_Courses.grade_c, Student_Courses.quiz1, Student_Courses.quiz2, Student_Courses.final_grade FROM Student_Courses LEFT join Teaching_Stuff on Student_Courses.course_id=Teaching_Stuff.Course_ID where ID='" + Forms.UserID.ID + "'", sqlcon);
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;
                StudentsReport.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
                this.sqlcon.Close();
            }
        }
    }
}
