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


namespace PRPJECT4NEW.Lecturer
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

        

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Available_Classes_Click(object sender, EventArgs e)
        {
            
        }

        private void Semester_Click(object sender, EventArgs e)
        {

        }

        private void Reports_Load(object sender, EventArgs e)
        {
            
        }

        private void LecturerCourses_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
        
            
    }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Grades_Button_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Students_Click(object sender, EventArgs e)
        {
            this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False; MultipleActiveResultSets=true";
            this.sqlcon = new SqlConnection(connetionString);
            //Paint headers
            StudentsReport.EnableHeadersVisualStyles = false;
            StudentsReport.GridColor = Utility.HeaderBackColor;
            StudentsReport.ColumnHeadersDefaultCellStyle.BackColor = Utility.HeaderBackColor;
            StudentsReport.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            StudentsReport.AutoResizeColumns();
            StudentsReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            StudentsReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;


            StudentsReport.Visible = true;

            try
            {
                SqlCommand cmd = new SqlCommand("select Student_Courses.stud_Id,Student_Courses.course_id FROM Student_Courses LEFT join Teaching_Stuff on Student_Courses.course_id=Teaching_Stuff.Course_ID where ID='" + Utility.User.ID + "'", sqlcon);
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

        private void button3_Click(object sender, EventArgs e)
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
                    cmd = new SqlCommand("select * from Classes_SM1 where date='" + str + "'", sqlcon);
                    //MessageBox.Show(str);
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
                    //this.Close();
                    toolStripComboBox1.Text = "";
                    toolStripComboBox2.Text = "";
                    MessageBox.Show("Error selecting dates,try again!");
                    //Reports form2 = new Reports();
                    //form2.Show();

                }
                
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                //Preent Sorting
                foreach (DataGridViewColumn column in StudentsReport.Columns)
                {
                    column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

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

                foreach (DataGridViewRow row in StudentsReport.Rows)
                {
                    row.Height = 45;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

       


        private void button4_Click(object sender, EventArgs e)
        {
            this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False; MultipleActiveResultSets=true";
            this.sqlcon = new SqlConnection(connetionString);
            StudentsReport.Visible = true;
            try
            {
                SqlCommand cmd = new SqlCommand("select Student_Courses.stud_Id,Student_Courses.course_id, Student_Courses.grade_a, Student_Courses.grade_b, Student_Courses.grade_c, Student_Courses.quiz1, Student_Courses.quiz2, Student_Courses.final_grade FROM Student_Courses LEFT join Lecture_Course on Student_Courses.course_id=Lecture_Course.Course_ID where Teacher='" + Utility.User.ID + "' and Type = 1", sqlcon);
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
                Reports form2 = new Reports();
                form2.Show();
            }
        }

        private void My_Lectures_Click(object sender, EventArgs e)
        {
            this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            this.sqlcon = new SqlConnection(connetionString);
            SqlCommand cmd = new SqlCommand("select Lecture_Course.Course_ID,Lecture_Course.Course_Serial,courses.Course_Name from Lecture_Course LEFT join courses on Lecture_Course.Course_ID=courses.Course_id where Teacher='" + Utility.User.ID + "'", sqlcon);
            StudentsReport.Visible = true;

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
            this.Close();
        }

        private void StudentsReport_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void True(object sender, DataGridViewAutoSizeColumnsModeEventArgs e)
        {

        }

        private void True(object sender, DataGridViewAutoSizeColumnModeEventArgs e)
        {

        }
    }
}
