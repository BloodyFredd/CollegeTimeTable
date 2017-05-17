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
    public partial class MergeAuditorium : Form
    {
        private string connetionString = null;
        private SqlConnection sqlcon;

        public MergeAuditorium()
        {
            InitializeComponent();
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
                    throw new ArgumentException("Error selecting dates,try again!");
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
                this.Close();
                MessageBox.Show(ex.Message);
                MergeAuditorium form2 = new MergeAuditorium();
                form2.Show();
            }
        }

        private void Merge_Click(object sender, EventArgs e)
        {
            string str = null;


            try
            {
                this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
                this.sqlcon = new SqlConnection(connetionString);
                SqlCommand cmd = new SqlCommand("select * from Classes_SM1 where date='" + "1990-01-01" + "'", sqlcon);
                SqlCommand cmd1 = new SqlCommand("select * from Classes_SM1 where date='" + "1990-01-01" + "'", sqlcon);
                if (toolStripComboBox1.Text.Equals("") && !toolStripComboBox2.Text.Equals(""))

                {
                    str = toolStripComboBox2.Text;
                    cmd = new SqlCommand("UPDATE Classes_SM1 SET Capacity= 20 where class_Id='" + "a101" + "'AND date='" + str + "'", sqlcon);
                    cmd1 = new SqlCommand("UPDATE Classes_SM1 SET Capacity= 0 where class_Id='" + "a102" + "' AND date='" + str + "'", sqlcon);

                    Lecture.Visible = true;
                }
                else if (toolStripComboBox2.Text.Equals("") && !toolStripComboBox1.Text.Equals(""))
                {
                    str = toolStripComboBox1.Text;
                    cmd = new SqlCommand("UPDATE Classes_SM2 SET Capacity= 20 where class_Id='" + "a101" + "'AND date='" + str + "'", sqlcon);
                    cmd1 = new SqlCommand("UPDATE Classes_SM2 SET Capacity= 0 where class_Id='" + "a102" + "' AND date='" + str + "'", sqlcon);
                    Lecture.Visible = true;
                }
                else
                {
                    throw new ArgumentException("Error selecting dates,try again!");
                }

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                SqlDataAdapter sda1 = new SqlDataAdapter();
                sda1.SelectCommand = cmd1;
                DataTable dbdataset1 = new DataTable();
                sda1.Fill(dbdataset1);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;
                Lecture.DataSource = bsource;
                sda.Update(dbdataset);
                sda1.Update(dbdataset);
            }
            catch (Exception ex)
            {
                this.Close();
                MessageBox.Show(ex.Message);
                MergeAuditorium form2 = new MergeAuditorium();
                form2.Show();
            }
        }

    }
   
}
