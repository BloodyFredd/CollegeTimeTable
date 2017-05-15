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

namespace BranchA_MazalPlus.Lecturer
{
    public partial class Factor : Form
    {
        private string connetionString = null;
        private SqlConnection sqlcon;
        public Factor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
                this.sqlcon = new SqlConnection(connetionString);
                //check which courses this lecturer is teaching
                SqlCommand cmd = new SqlCommand("select course_serial from lecture_course where Teacher ='" + Forms.UserID.ID + "' and Course_id='" + class_num.Text + "'", sqlcon);
                this.sqlcon.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                   // dr.Close();
                  //  dr = cmd.ExecuteReader();
                    cmd = new SqlCommand("update Student_Courses set final_grade =final_grade+10  where course_id='" + class_num.Text + "' and course_serial = '" + dr[0].ToString() + "' and Type = 1", sqlcon);
                    MessageBox.Show("lalalalal");
                    dr.Close();
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
                    //dr.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }
    



    private void Factor_Load(object sender, EventArgs e)
        {

        }

        private void class_num_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
