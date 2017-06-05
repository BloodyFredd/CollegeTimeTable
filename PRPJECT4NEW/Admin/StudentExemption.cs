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
    public partial class StudentExemption : Form
    {
        private string connetionString = null;
        private SqlConnection sqlcon;

        public StudentExemption()
        {
            InitializeComponent();
        }

        private void ShowStudents_Click(object sender, EventArgs e)
        {
            
        }

        private void Exemption_Click(object sender, EventArgs e)
        {
            
        }

        private void Students_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            this.sqlcon = new SqlConnection(connetionString);
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Student_Courses SET course_serial = -1,final_grade=100 WHERE stud_Id='" + Stud_ID.Text + "'AND course_id='" + Course.Text + "'", sqlcon);
                Students.Visible = true;
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;
                Students.DataSource = bsource;
                sda.Update(dbdataset);
                MessageBox.Show("The student got an exemption!");
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Course_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
