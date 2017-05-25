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

namespace PRPJECT4NEW.Teaching_Assistant
{
    public partial class Grade56 : Form
    {
        private string connetionString = null;
        private SqlConnection sqlcon;
        public Grade56()
        {
            InitializeComponent();
        }

        private void Apply_Button_Click(object sender, EventArgs e)
        {
            try
            {
                this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False; MultipleActiveResultSets=true";
                this.sqlcon = new SqlConnection(connetionString);
                SqlCommand cmd = new SqlCommand("select * from Person where ID ='" + StudentID.Text + "' and Permission = 'Student'", sqlcon);
                if (!checkString(StudentID.Text, "ID") || !checkString(CourseID.Text, "Course"))
                {
                    this.Close();
                    MessageBox.Show("Try again, this is not a correct ID!");
                    Grade56 form2 = new Grade56();
                    form2.Show();
                }
                else
                {
                    this.sqlcon.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read() == true)
                    {
                        dr.Close();
                        cmd = new SqlCommand("select * from Teaching_Stuff where ID ='" + Forms.UserID.ID + "' and Course_id='" + CourseID.Text + "'", sqlcon);
                        dr = cmd.ExecuteReader();
                        if (dr.Read() == true)
                        {
                            dr.Close();
                            cmd = new SqlCommand("select * from Student_Courses where stud_Id ='" + StudentID.Text + "' and course_id='" + CourseID.Text + "' and final_grade < 56", sqlcon);
                            dr = cmd.ExecuteReader();
                            if (dr.Read() == true)
                            {
                                dr.Close();
                                cmd = new SqlCommand("update Student_Courses set final_grade = 56 where course_id='" + CourseID.Text + "' and stud_Id = '" + StudentID.Text + "' and Type = 1", sqlcon);
                                SqlDataAdapter sda = new SqlDataAdapter();
                                sda.SelectCommand = cmd;
                                DataTable dbdataset = new DataTable();
                                sda.Fill(dbdataset);
                                BindingSource bsource = new BindingSource();
                                bsource.DataSource = dbdataset;
                                sda.Update(dbdataset);
                                MessageBox.Show("Changed grade succesfully!");
                                this.sqlcon.Close();
                                this.Close();
                            }
                            else
                            {
                                throw new ArgumentException("This student have a grade greater than 56!");
                            }
                        }
                        else
                        {
                            throw new ArgumentException("Try again, you do not teach such a course!");
                        }
                    }
                    else
                    {
                        throw new ArgumentException("Try again, there is not such student in our department!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
                Grade56 form2 = new Grade56();
                form2.Show();
            }
            this.sqlcon.Close();
            this.Close();
        }

        private bool checkString(string id, string check)
        {
            if (check == "ID")
            {
                bool allDigits = id.All(char.IsDigit);
                if (id.Length != 9 || allDigits == false)
                {
                    throw new ArgumentException("ID should be only digits and with length of 9.");
                }
            }
            if(check == "Course")
            {
                bool allDigits = id.All(char.IsDigit);
                if (id.Length != 3 || allDigits == false)
                {
                    throw new ArgumentException("Course ID should be only digits and with length of 3.");
                }
            }
            return true;
        }
    }
}
