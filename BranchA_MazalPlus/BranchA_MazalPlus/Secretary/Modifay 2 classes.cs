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
            
            try
            {
                this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
                this.sqlcon = new SqlConnection(connetionString);

                if (dateSem1.Text.Equals("") && !dateSem2.Text.Equals(""))
                {
                    try
                    {


                        SqlCommand cmd = new SqlCommand("UPDATE Classes_SM2 SET Class_Id =REPLACE(Class_Id, '" + class2.Text + "', 'tmp') WHERE date='" + dateSem2.Text + "'", sqlcon);
                        SqlDataAdapter sda = new SqlDataAdapter();
                        sda.SelectCommand = cmd;
                        DataTable dbdataset = new DataTable();
                        sda.Fill(dbdataset);
                        BindingSource bsource = new BindingSource();
                        bsource.DataSource = dbdataset;
                        sda.Update(dbdataset);

                        SqlCommand cmd2 = new SqlCommand("UPDATE Classes_SM2 SET Class_Id =REPLACE(Class_Id, '" + class1.Text + "','" + class2.Text + "') WHERE date='" + dateSem2.Text + "'", sqlcon);
                        SqlDataAdapter sda2 = new SqlDataAdapter();
                        sda2.SelectCommand = cmd2;
                        DataTable dbdataset2 = new DataTable();
                        sda2.Fill(dbdataset2);
                        BindingSource bsource2 = new BindingSource();
                        bsource2.DataSource = dbdataset2;
                        sda2.Update(dbdataset2);

                        SqlCommand cmd3 = new SqlCommand("UPDATE Classes_SM2 SET Class_Id =REPLACE(Class_Id, 'tmp','" + class1.Text + "') WHERE date='" + dateSem2.Text + "'", sqlcon);
                        SqlDataAdapter sda3 = new SqlDataAdapter();
                        sda3.SelectCommand = cmd3;
                        DataTable dbdataset3 = new DataTable();
                        sda3.Fill(dbdataset3);
                        BindingSource bsource3 = new BindingSource();
                        bsource3.DataSource = dbdataset3;
                        sda3.Update(dbdataset3);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    MessageBox.Show("Change completed.");
                }

                else if (dateSem2.Text.Equals("") && !dateSem1.Text.Equals(""))
                {
                    try
                    {

                        SqlCommand cmd = new SqlCommand("UPDATE Classes_SM1 SET Class_Id =REPLACE(Class_Id, '" + class2.Text + "', 'tmp') WHERE date='" + dateSem1.Text + "'", sqlcon);
                        SqlDataAdapter sda = new SqlDataAdapter();
                        sda.SelectCommand = cmd;
                        DataTable dbdataset = new DataTable();
                        sda.Fill(dbdataset);
                        BindingSource bsource = new BindingSource();
                        bsource.DataSource = dbdataset;
                        sda.Update(dbdataset);

                        SqlCommand cmd2 = new SqlCommand("UPDATE Classes_SM1 SET Class_Id =REPLACE(Class_Id, '" + class1.Text + "','" + class2.Text + "') WHERE date='" + dateSem1.Text + "'", sqlcon);
                        SqlDataAdapter sda2 = new SqlDataAdapter();
                        sda2.SelectCommand = cmd2;
                        DataTable dbdataset2 = new DataTable();
                        sda2.Fill(dbdataset2);
                        BindingSource bsource2 = new BindingSource();
                        bsource2.DataSource = dbdataset2;
                        sda2.Update(dbdataset2);

                        SqlCommand cmd3 = new SqlCommand("UPDATE Classes_SM1 SET Class_Id =REPLACE(Class_Id, 'tmp','" + class1.Text + "') WHERE date='" + dateSem1.Text + "'", sqlcon);
                        SqlDataAdapter sda3 = new SqlDataAdapter();
                        sda3.SelectCommand = cmd3;
                        DataTable dbdataset3 = new DataTable();
                        sda3.Fill(dbdataset3);
                        BindingSource bsource3 = new BindingSource();
                        bsource3.DataSource = dbdataset3;
                        sda3.Update(dbdataset3);
                    }
                    catch (SqlException ex)
                    {
                        this.Close();
                        MessageBox.Show("Error selecting class id, try again!");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    MessageBox.Show("Change completed.");
                }
                else
                {
                    this.Close();
                    MessageBox.Show("Error selecting dates, try again!");
                    Modifay_2_classes form2 = new Modifay_2_classes();
                    form2.Show();

                }
                this.sqlcon.Close();
                this.Close();
                
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
