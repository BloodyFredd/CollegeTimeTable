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

namespace PRPJECT4NEW.Admin
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
            
        }

        public bool CheckCourse(string value,string other)
        {
            if (other == value) return true;
            return false;
        }

        public string select(SqlCommand cmd)
        {
            string value=null;
            
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                value = dr[0].ToString();
            }
            dr.Close();
            this.sqlcon.Close();

            return value;
        }
            
        private void Sign_student_Click(object sender, EventArgs e)
        {
         
}

        private void button3_Click(object sender, EventArgs e)
        {
            this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            this.sqlcon = new SqlConnection(connetionString);
            try
            {
                SqlCommand cmd1 = new SqlCommand("SELECT course_serial FROM Student_Courses where stud_Id='" + Stud_ID.Text + "'AND course_id='" + Course.Text + "'", sqlcon);
                this.sqlcon.Open();

                if (CheckCourse(select(cmd1), serial.Text)) MessageBox.Show("It is the same course, try again!");
                else
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Student_Courses SET course_serial = '" + serial.Text + "' WHERE stud_Id='" + Stud_ID.Text + "'AND course_id='" + Course.Text + "'", sqlcon);
                    Students.Visible = true;
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = cmd;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    //Paint headers
                    Students.EnableHeadersVisualStyles = false;
                    Students.GridColor = Utility.HeaderBackColor;
                    Students.ColumnHeadersDefaultCellStyle.BackColor = Utility.HeaderBackColor;
                    Students.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    Students.AutoResizeColumns();
                    Students.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                    Students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;


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

        private void My_Lectures_Click(object sender, EventArgs e)
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

                //Paint headers
                Students.EnableHeadersVisualStyles = false;
                Students.GridColor = Utility.HeaderBackColor;
                Students.ColumnHeadersDefaultCellStyle.BackColor = Utility.HeaderBackColor;
                Students.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                Students.AutoResizeColumns();
                Students.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                Students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;


                bsource.DataSource = dbdataset;
                Students.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}