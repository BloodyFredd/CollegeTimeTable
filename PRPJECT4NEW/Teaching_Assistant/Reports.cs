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


namespace PRPJECT4NEW.Teaching_Assistant
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

            SqlCommand cmd = new SqlCommand("declare @results varchar(50) select @results = convert(varchar(50),Course_id) from Teaching_Stuff  WHERE Teaching_Stuff.ID = '" + Utility.User.ID + "' SELECT Person.F_name,Person.L_name,Teaching_Stuff.ID,Teaching_Stuff.Course_id,Teaching_Stuff.office,Person.Email FROM Teaching_Stuff JOIN Person on Person.ID=Teaching_Stuff.ID WHERE Course_id  = @results AND Teaching_Stuff.ID  != '" + Utility.User.ID + "'", sqlcon);
             
            try
            {

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();


                //Paint headers
                StudentsReport.EnableHeadersVisualStyles = false;
                StudentsReport.GridColor = Utility.HeaderBackColor;
                StudentsReport.ColumnHeadersDefaultCellStyle.BackColor = Utility.HeaderBackColor;
                StudentsReport.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                StudentsReport.AutoResizeColumns();
                StudentsReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                StudentsReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;


                bsource.DataSource = dbdataset;
                StudentsReport.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
                Reports form2 = new Reports();
                form2.StartPosition = FormStartPosition.Manual;
                form2.SetDesktopBounds(218, 46, 1520, 820);
                form2.ShowDialog();
            }
            this.sqlcon.Close();
            //this.Close();
        }

        private void Grades_Button_Click(object sender, EventArgs e)
        {
            this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False; MultipleActiveResultSets=true";
            this.sqlcon = new SqlConnection(connetionString);
            try
            {
                SqlCommand cmd = new SqlCommand("select Student_Courses.stud_Id,Student_Courses.course_id, Student_Courses.grade_a, Student_Courses.grade_b, Student_Courses.grade_c, Student_Courses.quiz1, Student_Courses.quiz2, Student_Courses.final_grade FROM Student_Courses LEFT join Teaching_Stuff on Student_Courses.course_id=Teaching_Stuff.Course_ID where ID='" + Utility.User.ID + "' and Student_Courses.Type = 1", sqlcon);
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();


                //Paint headers
                StudentsReport.EnableHeadersVisualStyles = false;
                StudentsReport.GridColor = Utility.HeaderBackColor;
                StudentsReport.ColumnHeadersDefaultCellStyle.BackColor = Utility.HeaderBackColor;
                StudentsReport.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                StudentsReport.AutoResizeColumns();
                StudentsReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                StudentsReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;


                bsource.DataSource = dbdataset;
                StudentsReport.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
                Reports form2 = new Reports();
                form2.Show();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False; MultipleActiveResultSets=true";
            this.sqlcon = new SqlConnection(connetionString);
            StudentsReport.Visible = true;

            try
            {
                SqlCommand cmd = new SqlCommand("select Student_Courses.stud_Id,Student_Courses.course_id FROM Student_Courses LEFT join Teaching_Stuff on Student_Courses.course_id=Teaching_Stuff.Course_ID where ID='" + Utility.User.ID + "' and Type = 1", sqlcon);
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();


                //Paint headers
                StudentsReport.EnableHeadersVisualStyles = false;
                StudentsReport.GridColor = Utility.HeaderBackColor;
                StudentsReport.ColumnHeadersDefaultCellStyle.BackColor = Utility.HeaderBackColor;
                StudentsReport.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                StudentsReport.AutoResizeColumns();
                StudentsReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                StudentsReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;


                bsource.DataSource = dbdataset;
                StudentsReport.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
                Reports form2 = new Reports();
                form2.StartPosition = FormStartPosition.Manual;
                form2.SetDesktopBounds(218, 46, 1520, 820);
                form2.ShowDialog();

            }
        }

        private void EmptyClasses_Click(object sender, EventArgs e)
        {
            string str = null;


            try
            {
                this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
                this.sqlcon = new SqlConnection(connetionString);
                SqlCommand cmd = new SqlCommand("select * from Classes_SM1 where date='" + "1990-01-01" + "'", sqlcon);
                if (toolStripComboBox1.Text.Equals("") && !toolStripComboBox2.Text.Equals(""))

                {
                    str = toolStripComboBox2.Text;
                    //MessageBox.Show(str);
                    cmd = new SqlCommand("select * from Classes_SM1 where date='" + str + "'", sqlcon);
                    StudentsReport.Visible = true;
                }
                else if (toolStripComboBox2.Text.Equals("") && !toolStripComboBox1.Text.Equals(""))
                {
                    str = toolStripComboBox1.Text;
                    //MessageBox.Show(str);
                    cmd = new SqlCommand("select * from Classes_SM2 where date='" + str + "'", sqlcon);
                    StudentsReport.Visible = true;
                }
                else
                {
                    throw new ArgumentException("Error selecting dates,try again!");
                }

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                //Paint headers
                StudentsReport.EnableHeadersVisualStyles = false;
                StudentsReport.GridColor = Utility.HeaderBackColor;
                StudentsReport.ColumnHeadersDefaultCellStyle.BackColor = Utility.HeaderBackColor;
                StudentsReport.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                StudentsReport.AutoResizeColumns();
                StudentsReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                StudentsReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;


                bsource.DataSource = dbdataset;
                StudentsReport.DataSource = bsource;
                sda.Update(dbdataset);

                int i = 0;
                for (int j = 0; j <= 9; j++)
                {
                    paintCells2(i);
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                toolStripComboBox1.Text = "";
                toolStripComboBox2.Text = "";
            }
        }

        private void paintCells2(int i)
        {
            for (int j = 5; j < 18; j++)
            {
                if (Convert.ToInt32(StudentsReport.Rows[i].Cells[j].Value) == 1)
                {
                    StudentsReport.Rows[i].Cells[j].Style.BackColor = Color.Red;
                    StudentsReport.Rows[i].Cells[j].Style.ForeColor = Color.Red;
                }

                else
                {
                    StudentsReport.Rows[i].Cells[j].Style.BackColor = Color.LawnGreen;
                    StudentsReport.Rows[i].Cells[j].Style.ForeColor = Color.LawnGreen;
                }


            }

        }

        private void My_Lectures_Click(object sender, EventArgs e)
        {
            this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            this.sqlcon = new SqlConnection(connetionString);
            SqlCommand cmd = new SqlCommand("select Teaching_Stuff.Course_id, courses.Course_Name from Teaching_Stuff LEFT JOIN courses on Teaching_Stuff.Course_id = courses.Course_id where Teaching_Stuff.ID ='" + Utility.User.ID + "'", sqlcon);
            StudentsReport.Visible = true;
            //Lecture_Course.Course_ID=courses.Course_id where 
            try
            {

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();


                //Paint headers
                StudentsReport.EnableHeadersVisualStyles = false;
                StudentsReport.GridColor = Utility.HeaderBackColor;
                StudentsReport.ColumnHeadersDefaultCellStyle.BackColor = Utility.HeaderBackColor;
                StudentsReport.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                StudentsReport.AutoResizeColumns();
                StudentsReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                StudentsReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;


                bsource.DataSource = dbdataset;
                StudentsReport.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Print_Click(object sender, EventArgs e)
        {
            string str = "Student Detailes",string2= Utility.User.ID;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path = path.Replace(@"\", @"\\");
            path += "\\";

            try
            {
                this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

                StreamWriter myFile = new StreamWriter(@"" + path + "'" + str + "'.xls");

                using (SqlConnection connection = new SqlConnection(connetionString))
                {
                    string query = "select Student_Courses.stud_Id,Student_Courses.course_id FROM Student_Courses LEFT join Teaching_Stuff on Student_Courses.course_id=Teaching_Stuff.Course_ID where ID='" + Utility.User.ID + "'" ;

                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    try
                    {
                        myFile.WriteLine(String.Format("Stud_ID\tCourse_id\tTeacher_ID\n"));
                        while (reader.Read())
                        {
                            myFile.WriteLine(String.Format("{0}\t {1}\t {2}\t", reader["stud_Id"], reader["course_id"], string2));
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
   
}
