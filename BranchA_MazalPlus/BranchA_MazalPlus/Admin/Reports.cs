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

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Available_Classes_Click(object sender, EventArgs e)
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
                    this.Close();
                    MessageBox.Show("Error selecting dates, try again!");
                    Reports form2 = new Reports();
                    form2.Show();

                }

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

        private void Semester_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void All_Person_Button_Click(object sender, EventArgs e)
        {
            this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            this.sqlcon = new SqlConnection(connetionString);
            try
            {
                SqlCommand cmd = new SqlCommand("select Email, Password, Permission from person", sqlcon);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
