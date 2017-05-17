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
using System.IO;


namespace BranchA_MazalPlus.Secretary
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
            SqlCommand cmd = new SqlCommand("select ID,F_name,L_name,Telephone,Email,Password from person where Permission='" + "Student"+"'", sqlcon);

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

            SqlCommand cmd = new SqlCommand("select ID,F_name,L_name,Telephone,Email,Password from person where Permission='Teaching_Assistant' OR Permission='Lecturer' ", sqlcon);


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

        private void button2_Click(object sender, EventArgs e)
        {
            this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            this.sqlcon = new SqlConnection(connetionString);
            try
            {
                SqlCommand cmd = new SqlCommand("select stud_Id, final_grade from Student_Courses where final_grade <= 56 and course_id='" + CourseID.Text + "'", sqlcon);
                StudentsReport.Visible = true;
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;
                StudentsReport.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (SqlException ex)
            {
                this.Close();
                MessageBox.Show("Error selecting course id, try again!");
                Reports form2 = new Reports();
                form2.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void SM1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sM1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sEMESTERToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Class_ID_1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Print_Click(object sender, EventArgs e)
        {
            string str = "Course Detailes";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path = path.Replace(@"\", @"\\");
            path += "\\";

            try
            {
                this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
                //this.sqlcon = new SqlConnection(connetionString);
                string query = "select * from courses ";
                //if (toolStripComboBox1.Text.Equals("") && !toolStripComboBox2.Text.Equals(""))
                //{
                //    str = toolStripComboBox2.Text;


                    // MessageBox.Show(path);


                    StreamWriter myFile = new StreamWriter(@"" + path + "'" + str + "'.xls");

                    using (SqlConnection connection = new SqlConnection(connetionString))
                    {
                        query = "select * from courses ";

                        SqlCommand command = new SqlCommand(query, connection);
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        try
                        {
                            myFile.WriteLine(String.Format("Course_id\tCourse_name\tNakaz\tYear\tSemester\tBlocking_Course\n"));
                            while (reader.Read())
                            {
                                myFile.WriteLine(String.Format("{0}\t {1}\t {2}\t {3}\t {4}\t {5}\t ",
                                reader["Course_id"], reader["Course_name"], reader["Nakaz"], reader["Year"], reader["Semester"], reader["Blocking_Cource"]));
                            }
                            MessageBox.Show("The file created");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                            //Dts.TaskResult = (int)ScriptResults.Failure;
                        }
                        finally
                        {

                            reader.Close();
                            myFile.Close();
                        }

                    }
                //}
                //else if (toolStripComboBox2.Text.Equals("") && !toolStripComboBox1.Text.Equals(""))
                ////MessageBox.Show(str);
                //{
                //    str = toolStripComboBox1.Text;
                //    StreamWriter myFile = new StreamWriter(@"" + path + "'" + str + "'.xls");

                //    using (SqlConnection connection = new SqlConnection(connetionString))
                //    {
                //        query = "select * from Classes_SM2 where date='" + str + "'";

                //        SqlCommand command = new SqlCommand(query, connection);
                //        connection.Open();


                //        SqlDataReader reader = command.ExecuteReader();
                //        try
                //        {
                //            myFile.WriteLine(String.Format("Date\tClass_ID\tType\tCapacity\t08:00-09:00\t09:00-10:00\t10:00-11:00\t11:00-12:00\t12:00-13:00\t13:00-14:00\t14:00-15:00\t15:00-16:00\t16:00-17:00\t17:00-18:00\t18:00-19:00\t19:00-20:00\t20:00-21:00\tHoliday\n"));
                //            while (reader.Read())
                //            {
                //                myFile.WriteLine(String.Format("{0}\t {1}\t {2}\t {3}\t {4}\t {5}\t {6}\t {7}\t {8}\t {9}\t {10}\t {11}\t {12}\t {13}\t {14}\t {15}\t {16}\t {17}",
                //                reader["date"], reader["Class_Id"], reader["Type"], reader["Capacity"], reader["08-09"], reader["09-10"], reader["10-11"], reader["11-12"], reader["12-13"], reader["13-14"], reader["14-15"], reader["15-16"], reader["16-17"], reader["17-18"], reader["18-19"], reader["19-20"], reader["20-21"], reader["holiday"]));
                //            }
                //            MessageBox.Show("The file created");

                //        }
                //        catch (Exception ex)
                //        {
                //            MessageBox.Show(ex.ToString());
                //            //Dts.TaskResult = (int)ScriptResults.Failure;
                //        }
                //        finally
                //        {
                //            reader.Close();
                //            myFile.Close();

                //        }
                //    }

                //}
                FileInfo fi = new FileInfo(@"" + path + "'" + str + "'.xls");
                if (fi.Exists)
                {
                    System.Diagnostics.Process.Start(@"" + path + "'" + str + "'.xls");

                }
                else
                {
                    MessageBox.Show("File not exsits");
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
    

    //private void Class_Num_SelectedIndexChanged(object sender, EventArgs e)
      //  {
      //
        //}
    //}

