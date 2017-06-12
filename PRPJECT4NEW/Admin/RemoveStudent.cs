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
    public partial class RemoveStudent : Form
    {
        private string connetionString = null;
        private SqlConnection sqlcon;
        public RemoveStudent()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try {
                this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
                this.sqlcon = new SqlConnection(connetionString);
                this.sqlcon.Open();
                SqlCommand command = new SqlCommand("DELETE FROM person WHERE ID = '" + this.IDbutton.Text + "'AND Permission = '" + "Student" + "'", sqlcon);
                int dr = command.ExecuteNonQuery();
                if(dr == 1)
                {
                    MessageBox.Show("Deleted!");
                    this.sqlcon.Close();
                   // this.Close();
                }
                else
                {
                    MessageBox.Show("No such id exists!");
                    this.sqlcon.Close();
                   // this.Close();
                }
                
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
                this.sqlcon.Close();
                this.Close();
            }
        }

        private void Id_Click(object sender, EventArgs e)
        {

        }

        private void RemoveStudent_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
