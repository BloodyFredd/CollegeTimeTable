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
               
                try
                {
                    
                    SqlCommand cmd = new SqlCommand("UPDATE Student_Courses SET final_grade = final_grade+10 where '" + class_num.Text + "'", sqlcon);
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
               
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sql exception");
            }
            MessageBox.Show("complate");
        }

        






                







        private void Factor_Load(object sender, EventArgs e)
        {

        }

        private void class_num_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
