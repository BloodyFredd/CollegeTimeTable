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

namespace PRPJECT4NEW.Lecturer
{
    public partial class ReceptionHours : Form
    {
        private string connetionString = null;
        private SqlConnection sqlcon;
        public ReceptionHours()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False; MultipleActiveResultSets=true";
            this.sqlcon = new SqlConnection(connetionString);
            try
            {

                SqlCommand cmd14 = new SqlCommand("select * from Teaching_Stuff where ID ='" + Forms.UserID.ID + "' and Course_id='" + CourseID_Button.Text + "'", sqlcon);
                SqlCommand cmd15 = new SqlCommand("select [08-09] from Classes_SM1 where Class_Id ='" + Office_Button.Text + "'", sqlcon);
                this.sqlcon.Open();
                SqlDataReader dr = cmd14.ExecuteReader();
                if (dr.Read() == true)
                {
                    if (dr[2] == DBNull.Value)
                    {
                        dr.Close();
                        dr = cmd15.ExecuteReader();
                        if (dr.Read() == true)
                        {
                            if (Int32.Parse(dr[0].ToString()) == 0)
                            {
                                SqlCommand cmd = new SqlCommand("update Teaching_Stuff set Office ='" + Office_Button.Text + "' where Course_id ='" + CourseID_Button.Text + "' and ID = '" + Forms.UserID.ID + "'", sqlcon);
                                SqlCommand cmd1 = new SqlCommand("update Classes_SM1 set [08-09]=[08-09] + 1 where Class_Id ='" + Office_Button.Text + "'", sqlcon);
                                SqlCommand cmd2 = new SqlCommand("update Classes_SM1 set [09-10]=[09-10] + 1 where Class_Id ='" + Office_Button.Text + "'", sqlcon);
                                SqlCommand cmd3 = new SqlCommand("update Classes_SM1 set [10-11]=[10-11] + 1 where Class_Id ='" + Office_Button.Text + "'", sqlcon);
                                SqlCommand cmd4 = new SqlCommand("update Classes_SM1 set [11-12]=[11-12] + 1 where Class_Id ='" + Office_Button.Text + "'", sqlcon);
                                SqlCommand cmd5 = new SqlCommand("update Classes_SM1 set [12-13]=[12-13] + 1 where Class_Id ='" + Office_Button.Text + "'", sqlcon);
                                SqlCommand cmd6 = new SqlCommand("update Classes_SM1 set [13-14]=[13-14] + 1 where Class_Id ='" + Office_Button.Text + "'", sqlcon);
                                SqlCommand cmd7 = new SqlCommand("update Classes_SM1 set [14-15]=[14-15] + 1 where Class_Id ='" + Office_Button.Text + "'", sqlcon);
                                SqlCommand cmd8 = new SqlCommand("update Classes_SM1 set [15-16]=[15-16] + 1 where Class_Id ='" + Office_Button.Text + "'", sqlcon);
                                SqlCommand cmd9 = new SqlCommand("update Classes_SM1 set [16-17]=[16-17] + 1 where Class_Id ='" + Office_Button.Text + "'", sqlcon);
                                SqlCommand cmd10 = new SqlCommand("update Classes_SM1 set [17-18]=[17-18] + 1 where Class_Id ='" + Office_Button.Text + "'", sqlcon);
                                SqlCommand cmd11 = new SqlCommand("update Classes_SM1 set [18-19]=[18-19] + 1 where Class_Id ='" + Office_Button.Text + "'", sqlcon);
                                SqlCommand cmd12 = new SqlCommand("update Classes_SM1 set [19-20]=[19-20] + 1 where Class_Id ='" + Office_Button.Text + "'", sqlcon);
                                SqlCommand cmd13 = new SqlCommand("update Classes_SM1 set [20-21]=[20-21] + 1 where Class_Id ='" + Office_Button.Text + "'", sqlcon);
                                SqlDataAdapter sda = new SqlDataAdapter();
                                sda.SelectCommand = cmd;
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
                                sda.Fill(dbdataset);
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
                                sda.Update(dbdataset);
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
                                cmd1 = new SqlCommand("update Classes_SM2 set [08-09]=[08-09] + 1 where Class_Id ='" + Office_Button.Text + "'", sqlcon);
                                cmd2 = new SqlCommand("update Classes_SM2 set [09-10]=[09-10] + 1 where Class_Id ='" + Office_Button.Text + "'", sqlcon);
                                cmd3 = new SqlCommand("update Classes_SM2 set [10-11]=[10-11] + 1 where Class_Id ='" + Office_Button.Text + "'", sqlcon);
                                cmd4 = new SqlCommand("update Classes_SM2 set [11-12]=[11-12] + 1 where Class_Id ='" + Office_Button.Text + "'", sqlcon);
                                cmd5 = new SqlCommand("update Classes_SM2 set [12-13]=[12-13] + 1 where Class_Id ='" + Office_Button.Text + "'", sqlcon);
                                cmd6 = new SqlCommand("update Classes_SM2 set [13-14]=[13-14] + 1 where Class_Id ='" + Office_Button.Text + "'", sqlcon);
                                cmd7 = new SqlCommand("update Classes_SM2 set [14-15]=[14-15] + 1 where Class_Id ='" + Office_Button.Text + "'", sqlcon);
                                cmd8 = new SqlCommand("update Classes_SM2 set [15-16]=[15-16] + 1 where Class_Id ='" + Office_Button.Text + "'", sqlcon);
                                cmd9 = new SqlCommand("update Classes_SM2 set [16-17]=[16-17] + 1 where Class_Id ='" + Office_Button.Text + "'", sqlcon);
                                cmd10 = new SqlCommand("update Classes_SM2 set [17-18]=[17-18] + 1 where Class_Id ='" + Office_Button.Text + "'", sqlcon);
                                cmd11 = new SqlCommand("update Classes_SM2 set [18-19]=[18-19] + 1 where Class_Id ='" + Office_Button.Text + "'", sqlcon);
                                cmd12 = new SqlCommand("update Classes_SM2 set [19-20]=[19-20] + 1 where Class_Id ='" + Office_Button.Text + "'", sqlcon);
                                cmd13 = new SqlCommand("update Classes_SM2 set [20-21]=[20-21] + 1 where Class_Id ='" + Office_Button.Text + "'", sqlcon);
                                sda1 = new SqlDataAdapter();
                                sda1.SelectCommand = cmd1;
                                sda2 = new SqlDataAdapter();
                                sda2.SelectCommand = cmd2;
                                sda3 = new SqlDataAdapter();
                                sda3.SelectCommand = cmd3;
                                sda4 = new SqlDataAdapter();
                                sda4.SelectCommand = cmd4;
                                sda5 = new SqlDataAdapter();
                                sda5.SelectCommand = cmd5;
                                sda6 = new SqlDataAdapter();
                                sda6.SelectCommand = cmd6;
                                sda7 = new SqlDataAdapter();
                                sda7.SelectCommand = cmd7;
                                sda8 = new SqlDataAdapter();
                                sda8.SelectCommand = cmd8;
                                sda9 = new SqlDataAdapter();
                                sda9.SelectCommand = cmd9;
                                sda10 = new SqlDataAdapter();
                                sda10.SelectCommand = cmd10;
                                sda11 = new SqlDataAdapter();
                                sda11.SelectCommand = cmd11;
                                sda12 = new SqlDataAdapter();
                                sda12.SelectCommand = cmd12;
                                sda13 = new SqlDataAdapter();
                                sda13.SelectCommand = cmd13;
                                dbdataset = new DataTable();
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
                                bsource = new BindingSource();
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
                                MessageBox.Show("Added succesfully.");
                                this.Close();
                                this.sqlcon.Close();
                            }
                            else
                            {
                                throw new ArgumentException("Try again, there is a lecturer in this office.");
                            }
                        }
                        else
                        {
                            throw new ArgumentException("Try again, there's no such class.");
                        }
                    }
                    else
                    {
                        throw new ArgumentException("No need to add reception hours, you have already an office: " + dr[2].ToString());
                    }
                }
                else
                {
                    throw new ArgumentException("Try again, you're not teaching this class yet.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
                ReceptionHours form2 = new ReceptionHours();
                form2.Show();
            }
        }

        private void ReceptionHours_Load(object sender, EventArgs e)
        {

        }
    }
}
