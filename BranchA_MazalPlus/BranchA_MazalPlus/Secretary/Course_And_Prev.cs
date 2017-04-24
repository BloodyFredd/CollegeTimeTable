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
    public partial class Course_And_Prev : Form
    {
        private string connetionString = null;
        private SqlConnection sqlcon;
        public Course_And_Prev()
        {
            InitializeComponent();
        }

        private void Course_And_Prev_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Link_courses_Click(object sender, EventArgs e)
        {
            this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            this.sqlcon = new SqlConnection(connetionString);

            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE courses SET Blocking_cource = "+this.prev_course.Text+" WHERE Course_id = '" + Curr_Course.Text + "'", sqlcon);
                MessageBox.Show("Changed!");
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dbdataset;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Change completed.");
            this.sqlcon.Close();
            this.Close();

        }

        private void curr_course_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
