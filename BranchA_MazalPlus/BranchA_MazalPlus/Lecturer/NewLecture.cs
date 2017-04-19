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
    public partial class NewLecture : Form
    {
            private string connetionString = null;
            private SqlConnection sqlcon;
            public NewLecture()
        {
            InitializeComponent();
        }

        private void Lecture_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    Lecture.Visible = true;
                }
                else if (toolStripComboBox2.Text.Equals("") && !toolStripComboBox1.Text.Equals(""))
                {
                    str = toolStripComboBox1.Text;
                    //MessageBox.Show(str);
                    cmd = new SqlCommand("select * from Classes_SM2 where date='" + str + "'", sqlcon);
                    Lecture.Visible = true;
                }
                else
                {
                    this.Close();
                    MessageBox.Show("Error selecting dates,try again!");
                    Reports form2 = new Reports();
                    form2.Show();

                }

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;
                Lecture.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //TODO:: there is a problem accessing the values in the sql 
        private void NewLec_Click(object sender, EventArgs e)
        {
            string str = null;


            //try
            //{
            //    this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            //    this.sqlcon = new SqlConnection(connetionString);
            //    SqlCommand cmd = new SqlCommand("select * from Classes_SM1 where date='" + "1990-01-01" + "'", sqlcon);
            //    if (toolStripComboBox1.Text.Equals("") && !toolStripComboBox2.Text.Equals(""))

            //    {
            //        str = toolStripComboBox2.Text;
            //        //MessageBox.Show(str);
            //        cmd = new SqlCommand("select * from Classes_SM1 where date='" + str + "'", sqlcon);
            //        Lecture.Visible = true;
            //    }
            //    else if (toolStripComboBox2.Text.Equals("") && !toolStripComboBox1.Text.Equals(""))
            //    {
            //        str = toolStripComboBox1.Text;
            //        //MessageBox.Show(str);
            //        cmd = new SqlCommand("select * from Classes_SM2 where date='" + str + "'", sqlcon);
            //        Lecture.Visible = true;
            //    }
            //    else
            //    {
            //        this.Close();
            //        MessageBox.Show("Error selecting dates,try again!");
            //        Reports form2 = new Reports();
            //        form2.Show();

            //    }

            //    SqlDataAdapter sda = new SqlDataAdapter();
            //    sda.SelectCommand = cmd;
            //    DataTable dbdataset = new DataTable();
            //    sda.Fill(dbdataset);
            //    BindingSource bsource = new BindingSource();

            //    bsource.DataSource = dbdataset;
            //    Lecture.DataSource = bsource;
            //    sda.Update(dbdataset);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            this.sqlcon = new SqlConnection(connetionString);
            str = toolStripComboBox2.Text;
            SqlCommand cmd = new SqlCommand("UPDATE Classes_SM1 set date='"+str+ "',Class_Id='"+Hour.Text + NewLec.Text + "' = 1 where date='" + str + "'and Class_Id='"+Hour.Text+"'and where'" + NewLec.Text +"' = 0", sqlcon);
            MessageBox.Show("Changed!");
        }

        private void NewLecture_Load(object sender, EventArgs e)
        {
            
        }
    }
}
