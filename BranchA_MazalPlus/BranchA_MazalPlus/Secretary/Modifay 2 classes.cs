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
    public partial class Modifay_2_classes : Form
    {
   
        private string connetionString = null;
        private SqlConnection sqlcon;
        public Modifay_2_classes()
        {
            InitializeComponent();
        }

        private void Modifay_2_classes_Load(object sender, EventArgs e)
        {

        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void datesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = null;


            try
            {
                this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
                this.sqlcon = new SqlConnection(connetionString);
                SqlCommand cmd = new SqlCommand("select * from Classes_SM1 where date='" + "1990-01-01" + "'", sqlcon);
                if (dateSem1.Text.Equals("") && !dateSem2.Text.Equals(""))
                {
                    //str = bToolStripMenuItem.Text;
                    //MessageBox.Show(str);
                    class2.Text += "hello";
                    SqlCommand cmd1 = new SqlCommand("update Classes_SM2 SET Class_Id ='" + class2.Text + "' WHERE date = '" + dateSem2.Text + "' and Class_Id = '" + class1.Text + "'", sqlcon);
                    SqlCommand cmd2 = new SqlCommand("update Classes_SM2 SET Class_Id ='" + class1.Text + "' WHERE date = '" + dateSem2.Text + "' and Class_Id = '" + class2.Text + "'", sqlcon);

                    // StudentsReport.Visible = true;
                }
                else if (dateSem2.Text.Equals("") && !dateSem1.Text.Equals(""))
                {
                    str = aToolStripMenuItem.Text;
                    //MessageBox.Show(str);
                    SqlCommand cmd1 = new SqlCommand("update Classes_SM1 SET Class_Id ='" + class2.Text + "' WHERE date = '" + dateSem1.Text + "' and Class_Id = '" + class1.Text + "'", sqlcon);
                    SqlCommand cmd2 = new SqlCommand("update Classes_SM1 SET Class_Id ='" + class1.Text + "' WHERE date = '" + dateSem1.Text + "' and Class_Id = '" + class2.Text + "'", sqlcon);
                    //StudentsReport.Visible = true;
                }
                else
                {
                    this.Close();
                    MessageBox.Show("Error selecting dates, try again!");
                    Reports form2 = new Reports();
                    form2.Show();

                }
                MessageBox.Show("Change completed.");
                this.sqlcon.Close();
                this.Close();
                //SqlDataAdapter sda = new SqlDataAdapter();
                //sda.SelectCommand = cmd;
                //DataTable dbdataset = new DataTable();
                //sda.Fill(dbdataset);
                //BindingSource bsource = new BindingSource();

                //bsource.DataSource = dbdataset;
                //StudentsReport.DataSource = bsource;
                //sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
    
}
