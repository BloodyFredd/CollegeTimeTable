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
using BranchA_MazalPlus.Forms;

namespace BranchA_MazalPlus.Lecturer
{
    public partial class AddLecture : Form
    {
      //  private string connetionString = null;
        private SqlConnection sqlcon;
        public AddLecture()
        {
            InitializeComponent();
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            try
            {
                 this.sqlcon = General.ConnectToSql();

                SqlCommand cmd = new SqlCommand("select Date, Start_time, Class_number from Lecture_Course where Teacher = '" + Forms.UserID.ID + "' and Course_ID = '" + CourseIDButton.Text + "'", sqlcon);
                this.sqlcon.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    SqlCommand cmd1, cmd2, cmd3;
                    int first, second, third, fourth;
                    string firstString, secondString, thirdString, fourthString;
                    first = Convert.ToInt32(dr[1].ToString());
                    second = Convert.ToInt32(dr[1].ToString()) + 1;
                    third = Convert.ToInt32(dr[1].ToString()) + 2;
                    fourth = Convert.ToInt32(dr[1].ToString()) + 3;
                    firstString = first.ToString();
                    secondString = second.ToString();
                    thirdString = third.ToString();
                    fourthString = fourth.ToString();
                    if (SemesterButton.Text.Equals("A"))
                    {
                        if (first == 8)
                        {
                            cmd1 = new SqlCommand("update Classes_SM1 set [0" + firstString + "-0" + secondString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                            cmd2 = new SqlCommand("update Classes_SM1 set [0" + secondString + "-" + thirdString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                            cmd3 = new SqlCommand("update Classes_SM1 set [" + thirdString + "-" + fourthString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                        }
                        else if (first == 9)
                        {
                            cmd1 = new SqlCommand("update Classes_SM1 set [0" + firstString + "-" + secondString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                            cmd2 = new SqlCommand("update Classes_SM1 set [" + secondString + "-" + thirdString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                            cmd3 = new SqlCommand("update Classes_SM1 set [" + thirdString + "-" + fourthString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                        }
                        else
                        {
                            cmd1 = new SqlCommand("update Classes_SM1 set [" + firstString + "-" + secondString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                            cmd2 = new SqlCommand("update Classes_SM1 set [" + secondString + "-" + thirdString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                            cmd3 = new SqlCommand("update Classes_SM1 set [" + thirdString + "-" + fourthString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                        }
                        SqlDataAdapter sda1 = new SqlDataAdapter();
                        sda1.SelectCommand = cmd1;
                        SqlDataAdapter sda2 = new SqlDataAdapter();
                        sda2.SelectCommand = cmd2;
                        SqlDataAdapter sda3 = new SqlDataAdapter();
                        sda3.SelectCommand = cmd3;
                        DataTable dbdataset = new DataTable();
                        sda1.Fill(dbdataset);
                        sda2.Fill(dbdataset);
                        sda3.Fill(dbdataset);
                        BindingSource bsource = new BindingSource();
                        bsource.DataSource = dbdataset;
                        sda1.Update(dbdataset);
                        sda2.Update(dbdataset);
                        sda3.Update(dbdataset);
                    }
                    else if (SemesterButton.Text.Equals("B"))
                    {
                        if (first == 8)
                        {
                            cmd1 = new SqlCommand("update Classes_SM2 set [0" + firstString + "-0" + secondString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                            cmd2 = new SqlCommand("update Classes_SM2 set [0" + secondString + "-" + thirdString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                            cmd3 = new SqlCommand("update Classes_SM2 set [" + thirdString + "-" + fourthString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                        }
                        else if (first == 9)
                        {
                            cmd1 = new SqlCommand("update Classes_SM2 set [0" + firstString + "-" + secondString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                            cmd2 = new SqlCommand("update Classes_SM2 set [" + secondString + "-" + thirdString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                            cmd3 = new SqlCommand("update Classes_SM2 set [" + thirdString + "-" + fourthString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                        }
                        else
                        {
                            cmd1 = new SqlCommand("update Classes_SM2 set [" + firstString + "-" + secondString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                            cmd2 = new SqlCommand("update Classes_SM2 set [" + secondString + "-" + thirdString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                            cmd3 = new SqlCommand("update Classes_SM2 set [" + thirdString + "-" + fourthString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                        }
                        SqlDataAdapter sda1 = new SqlDataAdapter();
                        sda1.SelectCommand = cmd1;
                        SqlDataAdapter sda2 = new SqlDataAdapter();
                        sda2.SelectCommand = cmd2;
                        SqlDataAdapter sda3 = new SqlDataAdapter();
                        sda3.SelectCommand = cmd3;
                        DataTable dbdataset = new DataTable();
                        sda1.Fill(dbdataset);
                        sda2.Fill(dbdataset);
                        sda3.Fill(dbdataset);
                        BindingSource bsource = new BindingSource();
                        bsource.DataSource = dbdataset;
                        sda1.Update(dbdataset);
                        sda2.Update(dbdataset);
                        sda3.Update(dbdataset);
                    }
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
                AddLecture form2 = new AddLecture();
                form2.Show();
            }
            this.sqlcon.Close();
            this.Close();
        }
    }
}
