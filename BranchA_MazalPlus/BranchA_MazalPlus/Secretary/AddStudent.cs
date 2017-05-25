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


namespace BranchA_MazalPlus.Secretary
{
    public partial class AddStudent : Form
    {

        private string connetionString = null;
        private SqlConnection sqlcon;

        public AddStudent()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string capacity = null;
            string capacity1 = null;
            string StudentCount = null;
            int x = 0,y=0,z=0;
            try
            {
                this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
                this.sqlcon = new SqlConnection(connetionString);
                this.sqlcon.Open();
                SqlCommand cmd = new SqlCommand("select Capacity from Classes_SM1 where date='" + "2016-08-07" + "'AND Class_Id='" + Class.Text + "'", sqlcon);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    capacity = dr[0].ToString();
                    int.TryParse(capacity, out y);
                }
                dr.Close();

                SqlCommand cmd1 = new SqlCommand("select Capacity from Classes_SM2 where date='" + "2017-01-01" + "'AND Class_Id='" + Class.Text + "'", sqlcon);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                if (dr1.Read())
                {
                    capacity1 = dr1[0].ToString();
                    int.TryParse(capacity1, out z);
                }
                dr1.Close();

                SqlCommand cmd2 = new SqlCommand("select Student_Count from Lecture_Course WHERE [Course_ID] = '" + CourseID.Text + "' AND [Course_Serial] = '" + CourseSerial.Text + "'", sqlcon);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                if (dr2.Read())
                {
                    StudentCount = dr2[0].ToString();
                    int.TryParse(StudentCount, out x);
                }
                dr2.Close();


                if(Semester.Text=="1")
                {
                    if (x >= y)
                    {
                        SqlCommand cmd3 = new SqlCommand("UPDATE Lecture_Course SET [Student_Count]=[Student_Count]+1 WHERE [Course_ID] = '" + CourseID.Text + "' AND [Course_Serial] = '" + CourseSerial.Text + "'", sqlcon);
                        MessageBox.Show("Updated!");
                        this.sqlcon.Close();
                        SqlDataAdapter sda = new SqlDataAdapter();
                        sda.SelectCommand = cmd3;
                        DataTable dbdataset = new DataTable();
                        sda.Fill(dbdataset);
                        BindingSource bsource = new BindingSource();

                        bsource.DataSource = dbdataset;
                        sda.Update(dbdataset);
                    }

                    else
                    {
                        SqlCommand cmd3 = new SqlCommand("UPDATE Lecture_Course SET [Student_Count]=[Student_Count] WHERE [Course_ID] = '" + CourseID.Text + "' AND [Course_Serial] = '" + CourseSerial.Text + "'", sqlcon);
                        MessageBox.Show("didnt update");
                        this.sqlcon.Close();
                        SqlDataAdapter sda = new SqlDataAdapter();
                        sda.SelectCommand = cmd3;
                        DataTable dbdataset = new DataTable();
                        sda.Fill(dbdataset);
                        BindingSource bsource = new BindingSource();

                        bsource.DataSource = dbdataset;
                        sda.Update(dbdataset);
                    }
                }

                if (Semester.Text == "2")
                {
                    if (x >= z)
                    {
                        SqlCommand cmd3 = new SqlCommand("UPDATE Lecture_Course SET [Student_Count]=[Student_Count]+1 WHERE [Course_ID] = '" + CourseID.Text + "' AND [Course_Serial] = '" + CourseSerial.Text + "'", sqlcon);
                        MessageBox.Show("Updated!");
                        this.sqlcon.Close();
                        SqlDataAdapter sda = new SqlDataAdapter();
                        sda.SelectCommand = cmd3;
                        DataTable dbdataset = new DataTable();
                        sda.Fill(dbdataset);
                        BindingSource bsource = new BindingSource();

                        bsource.DataSource = dbdataset;
                        sda.Update(dbdataset);
                    }

                    else
                    {
                        SqlCommand cmd3 = new SqlCommand("UPDATE Lecture_Course SET [Student_Count]=[Student_Count] WHERE [Course_ID] = '" + CourseID.Text + "' AND [Course_Serial] = '" + CourseSerial.Text + "'", sqlcon);
                        MessageBox.Show("didnt update");
                        this.sqlcon.Close();
                        SqlDataAdapter sda = new SqlDataAdapter();
                        sda.SelectCommand = cmd3;
                        DataTable dbdataset = new DataTable();
                        sda.Fill(dbdataset);
                        BindingSource bsource = new BindingSource();

                        bsource.DataSource = dbdataset;
                        sda.Update(dbdataset);
                    }
                }
            }

            

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}