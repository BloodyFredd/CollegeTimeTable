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
    public partial class CancelLectures : Form
    {
        private string connetionString = null;
        private SqlConnection sqlcon;

        public CancelLectures()
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
                    cmd = new SqlCommand("select * from Classes_SM1 where date='" + str + "'", sqlcon);
                    Lecture.Visible = true;
                }
                else if (toolStripComboBox2.Text.Equals("") && !toolStripComboBox1.Text.Equals(""))
                {
                    str = toolStripComboBox1.Text;
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
                CancelLectures form2 = new CancelLectures();
                form2.Show();
            }
            



        }

        private void Cancel_Lecture_Click(object sender, EventArgs e)
        {

            try
            {
                this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
                this.sqlcon = new SqlConnection(connetionString);


                if (toolStripComboBox1.Text.Equals("") && !toolStripComboBox2.Text.Equals(""))

                {
                    MessageBox.Show("Changed!");
                    Lecture.Visible = true;
                    SqlCommand cmd1 = new SqlCommand("update Classes_SM1 set [08-09]=[08-09] * 0 where Class_Id ='" + Class.Text + "'", sqlcon);
                    SqlCommand cmd2 = new SqlCommand("update Classes_SM1 set [09-10]=[09-10] * 0 where Class_Id ='" + Class.Text + "'", sqlcon);
                    SqlCommand cmd3 = new SqlCommand("update Classes_SM1 set [10-11]=[10-11] * 0 where Class_Id ='" + Class.Text + "'", sqlcon);
                    SqlCommand cmd4 = new SqlCommand("update Classes_SM1 set [11-12]=[11-12] * 0 where Class_Id ='" + Class.Text + "'", sqlcon);
                    SqlCommand cmd5 = new SqlCommand("update Classes_SM1 set [12-13]=[12-13] * 0 where Class_Id ='" + Class.Text + "'", sqlcon);
                    SqlCommand cmd6 = new SqlCommand("update Classes_SM1 set [13-14]=[13-14] * 0 where Class_Id ='" + Class.Text + "'", sqlcon);
                    SqlCommand cmd7 = new SqlCommand("update Classes_SM1 set [14-15]=[14-15] * 0 where Class_Id ='" + Class.Text + "'", sqlcon);
                    SqlCommand cmd8 = new SqlCommand("update Classes_SM1 set [15-16]=[15-16] * 0 where Class_Id ='" + Class.Text + "'", sqlcon);
                    SqlCommand cmd9 = new SqlCommand("update Classes_SM1 set [16-17]=[16-17] * 0 where Class_Id ='" + Class.Text + "'", sqlcon);
                    SqlCommand cmd10 = new SqlCommand("update Classes_SM1 set [17-18]=[17-18] * 0 where Class_Id ='" + Class.Text + "'", sqlcon);
                    SqlCommand cmd11 = new SqlCommand("update Classes_SM1 set [18-19]=[18-19] * 0 where Class_Id ='" + Class.Text + "'", sqlcon);
                    SqlCommand cmd12 = new SqlCommand("update Classes_SM1 set [19-20]=[19-20] * 0 where Class_Id ='" + Class.Text + "'", sqlcon);
                    SqlCommand cmd13 = new SqlCommand("update Classes_SM1 set [20-21]=[20-21] * 0 where Class_Id ='" + Class.Text + "'", sqlcon);
                    
                    SqlDataAdapter sda1 = new SqlDataAdapter();
                    sda1.SelectCommand = cmd1;
                    SqlDataAdapter sda2 = new SqlDataAdapter();
                    sda2.SelectCommand = cmd2;
                    SqlDataAdapter sda3 = new SqlDataAdapter();
                    sda3.SelectCommand = cmd3;
                    SqlDataAdapter sda4 = new SqlDataAdapter();
                    sda4.SelectCommand = cmd4;
                    SqlDataAdapter sda5 = new SqlDataAdapter();
                    sda5.SelectCommand = cmd5;
                    SqlDataAdapter sda6 = new SqlDataAdapter();
                    sda6.SelectCommand = cmd6;
                    SqlDataAdapter sda7 = new SqlDataAdapter();
                    sda7.SelectCommand = cmd7;
                    SqlDataAdapter sda8 = new SqlDataAdapter();
                    sda8.SelectCommand = cmd8;
                    SqlDataAdapter sda9 = new SqlDataAdapter();
                    sda9.SelectCommand = cmd9;
                    SqlDataAdapter sda10 = new SqlDataAdapter();
                    sda10.SelectCommand = cmd10;
                    SqlDataAdapter sda11 = new SqlDataAdapter();
                    sda11.SelectCommand = cmd11;
                    SqlDataAdapter sda12 = new SqlDataAdapter();
                    sda12.SelectCommand = cmd12;
                    SqlDataAdapter sda13 = new SqlDataAdapter();
                    sda13.SelectCommand = cmd13;
                    DataTable dbdataset = new DataTable();
                    
                    sda1.Fill(dbdataset);
                    sda2.Fill(dbdataset);
                    sda3.Fill(dbdataset);
                    sda4.Fill(dbdataset);
                    sda5.Fill(dbdataset);
                    sda6.Fill(dbdataset);
                    sda7.Fill(dbdataset);
                    sda8.Fill(dbdataset);
                    sda9.Fill(dbdataset);
                    sda10.Fill(dbdataset);
                    sda11.Fill(dbdataset);
                    sda12.Fill(dbdataset);
                    sda13.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();
                    bsource.DataSource = dbdataset;
                    
                    sda1.Update(dbdataset);
                    sda2.Update(dbdataset);
                    sda3.Update(dbdataset);
                    sda4.Update(dbdataset);
                    sda5.Update(dbdataset);
                    sda6.Update(dbdataset);
                    sda7.Update(dbdataset);
                    sda8.Update(dbdataset);
                    sda9.Update(dbdataset);
                    sda10.Update(dbdataset);
                    sda11.Update(dbdataset);
                    sda12.Update(dbdataset);
                    sda13.Update(dbdataset);
                }
                else if (toolStripComboBox2.Text.Equals("") && !toolStripComboBox1.Text.Equals(""))
                {
                    MessageBox.Show("Changed!");
                    Lecture.Visible = true;
                    SqlCommand cmd1 = new SqlCommand("update Classes_SM2 set [08-09]=[08-09] * 0 where Class_Id ='" + Class.Text + "'", sqlcon);
                    SqlCommand cmd2 = new SqlCommand("update Classes_SM2 set [09-10]=[09-10] * 0 where Class_Id ='" + Class.Text + "'", sqlcon);
                    SqlCommand cmd3 = new SqlCommand("update Classes_SM2 set [10-11]=[10-11] * 0 where Class_Id ='" + Class.Text + "'", sqlcon);
                    SqlCommand cmd4 = new SqlCommand("update Classes_SM2 set [11-12]=[11-12] * 0 where Class_Id ='" + Class.Text + "'", sqlcon);
                    SqlCommand cmd5 = new SqlCommand("update Classes_SM2 set [12-13]=[12-13] * 0 where Class_Id ='" + Class.Text + "'", sqlcon);
                    SqlCommand cmd6 = new SqlCommand("update Classes_SM2 set [13-14]=[13-14] * 0 where Class_Id ='" + Class.Text + "'", sqlcon);
                    SqlCommand cmd7 = new SqlCommand("update Classes_SM2 set [14-15]=[14-15] * 0 where Class_Id ='" + Class.Text + "'", sqlcon);
                    SqlCommand cmd8 = new SqlCommand("update Classes_SM2 set [15-16]=[15-16] * 0 where Class_Id ='" + Class.Text + "'", sqlcon);
                    SqlCommand cmd9 = new SqlCommand("update Classes_SM2 set [16-17]=[16-17] * 0 where Class_Id ='" + Class.Text + "'", sqlcon);
                    SqlCommand cmd10 = new SqlCommand("update Classes_SM2 set [17-18]=[17-18] * 0 where Class_Id ='" + Class.Text + "'", sqlcon);
                    SqlCommand cmd11 = new SqlCommand("update Classes_SM2 set [18-19]=[18-19] * 0 where Class_Id ='" + Class.Text + "'", sqlcon);
                    SqlCommand cmd12 = new SqlCommand("update Classes_SM2 set [19-20]=[19-20] * 0 where Class_Id ='" + Class.Text + "'", sqlcon);
                    SqlCommand cmd13 = new SqlCommand("update Classes_SM2 set [20-21]=[20-21] * 0 where Class_Id ='" + Class.Text + "'", sqlcon);

                    SqlDataAdapter sda1 = new SqlDataAdapter();
                    sda1.SelectCommand = cmd1;
                    SqlDataAdapter sda2 = new SqlDataAdapter();
                    sda2.SelectCommand = cmd2;
                    SqlDataAdapter sda3 = new SqlDataAdapter();
                    sda3.SelectCommand = cmd3;
                    SqlDataAdapter sda4 = new SqlDataAdapter();
                    sda4.SelectCommand = cmd4;
                    SqlDataAdapter sda5 = new SqlDataAdapter();
                    sda5.SelectCommand = cmd5;
                    SqlDataAdapter sda6 = new SqlDataAdapter();
                    sda6.SelectCommand = cmd6;
                    SqlDataAdapter sda7 = new SqlDataAdapter();
                    sda7.SelectCommand = cmd7;
                    SqlDataAdapter sda8 = new SqlDataAdapter();
                    sda8.SelectCommand = cmd8;
                    SqlDataAdapter sda9 = new SqlDataAdapter();
                    sda9.SelectCommand = cmd9;
                    SqlDataAdapter sda10 = new SqlDataAdapter();
                    sda10.SelectCommand = cmd10;
                    SqlDataAdapter sda11 = new SqlDataAdapter();
                    sda11.SelectCommand = cmd11;
                    SqlDataAdapter sda12 = new SqlDataAdapter();
                    sda12.SelectCommand = cmd12;
                    SqlDataAdapter sda13 = new SqlDataAdapter();
                    sda13.SelectCommand = cmd13;
                    DataTable dbdataset = new DataTable();

                    sda1.Fill(dbdataset);
                    sda2.Fill(dbdataset);
                    sda3.Fill(dbdataset);
                    sda4.Fill(dbdataset);
                    sda5.Fill(dbdataset);
                    sda6.Fill(dbdataset);
                    sda7.Fill(dbdataset);
                    sda8.Fill(dbdataset);
                    sda9.Fill(dbdataset);
                    sda10.Fill(dbdataset);
                    sda11.Fill(dbdataset);
                    sda12.Fill(dbdataset);
                    sda13.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();
                    bsource.DataSource = dbdataset;

                    sda1.Update(dbdataset);
                    sda2.Update(dbdataset);
                    sda3.Update(dbdataset);
                    sda4.Update(dbdataset);
                    sda5.Update(dbdataset);
                    sda6.Update(dbdataset);
                    sda7.Update(dbdataset);
                    sda8.Update(dbdataset);
                    sda9.Update(dbdataset);
                    sda10.Update(dbdataset);
                    sda11.Update(dbdataset);
                    sda12.Update(dbdataset);
                    sda13.Update(dbdataset);
                }
                else
                {
                    throw new ArgumentException("Error selecting dates,try again!");

                }

            }
            catch (Exception ex)
            {

                this.Close();
                MessageBox.Show(ex.Message);
                CancelLectures form2 = new CancelLectures();
                form2.Show();
            }
        }
    }
}
