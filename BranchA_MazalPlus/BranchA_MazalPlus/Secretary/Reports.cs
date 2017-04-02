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
            SqlCommand cmd = new SqlCommand("select * from person where Permission='"+"Student"+"'", sqlcon);

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

            SqlCommand cmd = new SqlCommand("select * from person where Permission='Teaching_Assistant' OR Permission='Lecturer' ", sqlcon);


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
    }
}
