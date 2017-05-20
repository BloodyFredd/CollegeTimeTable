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

namespace BranchA_MazalPlus.Teaching_Assistant
{
    public partial class AddLabExercises : Form
    {
        private string connetionString = null;
        private SqlConnection sqlcon;
        public AddLabExercises()
        {
            InitializeComponent();
        }

        private void Apply_Button_Click(object sender, EventArgs e)
        {
            try
            {
                this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False; MultipleActiveResultSets=true";
                this.sqlcon = new SqlConnection(connetionString);
                SqlCommand cmd = new SqlCommand("select Date, Start_time, Class_number from Lecture_Course where Teacher = '" + Forms.UserID.ID + "' and Course_ID = '" + CourseIDButton.Text + "'", sqlcon);
                this.sqlcon.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    SqlCommand cmd1, cmd2;
                    int first, second, third;
                    string firstString, secondString, thirdString;
                    first = Convert.ToInt32(dr[1].ToString());
                    second = Convert.ToInt32(dr[1].ToString()) + 1;
                    third = Convert.ToInt32(dr[1].ToString()) + 2;
                    firstString = first.ToString();
                    secondString = second.ToString();
                    thirdString = third.ToString();
                    if (SemesterButton.Text.Equals("A"))
                    {
                        if (first == 8)
                        {
                            cmd1 = new SqlCommand("update Classes_SM1 set [0" + firstString + "-0" + secondString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                            cmd2 = new SqlCommand("update Classes_SM1 set [0" + secondString + "-" + thirdString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                        }
                        else if (first == 9)
                        {
                            cmd1 = new SqlCommand("update Classes_SM1 set [0" + firstString + "-" + secondString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                            cmd2 = new SqlCommand("update Classes_SM1 set [" + secondString + "-" + thirdString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                        }
                        else
                        {
                            cmd1 = new SqlCommand("update Classes_SM1 set [" + firstString + "-" + secondString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                            cmd2 = new SqlCommand("update Classes_SM1 set [" + secondString + "-" + thirdString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                        }
                        SqlDataAdapter sda1 = new SqlDataAdapter();
                        sda1.SelectCommand = cmd1;
                        SqlDataAdapter sda2 = new SqlDataAdapter();
                        sda2.SelectCommand = cmd2;
                        DataTable dbdataset = new DataTable();
                        sda1.Fill(dbdataset);
                        sda2.Fill(dbdataset);
                        BindingSource bsource = new BindingSource();
                        bsource.DataSource = dbdataset;
                        sda1.Update(dbdataset);
                        sda2.Update(dbdataset);
                    } 
                    else if (SemesterButton.Text.Equals("B"))
                    {
                        if (first == 8)
                        {
                            cmd1 = new SqlCommand("update Classes_SM1 set [0" + firstString + "-0" + secondString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                            cmd2 = new SqlCommand("update Classes_SM1 set [0" + secondString + "-" + thirdString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                        }
                        else if (first == 9)
                        {
                            cmd1 = new SqlCommand("update Classes_SM1 set [0" + firstString + "-" + secondString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                            cmd2 = new SqlCommand("update Classes_SM1 set [" + secondString + "-" + thirdString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                        }
                        else
                        {
                            cmd1 = new SqlCommand("update Classes_SM1 set [" + firstString + "-" + secondString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                            cmd2 = new SqlCommand("update Classes_SM1 set [" + secondString + "-" + thirdString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                        }
                        SqlDataAdapter sda1 = new SqlDataAdapter();
                        sda1.SelectCommand = cmd1;
                        SqlDataAdapter sda2 = new SqlDataAdapter();
                        sda2.SelectCommand = cmd2;
                        DataTable dbdataset = new DataTable();
                        sda1.Fill(dbdataset);
                        sda2.Fill(dbdataset);
                        BindingSource bsource = new BindingSource();
                        bsource.DataSource = dbdataset;
                        sda1.Update(dbdataset);
                        sda2.Update(dbdataset);
                    }                                    
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
                AddLabExercises form2 = new AddLabExercises();
                form2.Show();
            }
            //MessageBox.Show("Added a new lab and exercise!");
            this.sqlcon.Close();
            this.Close();       
        }

        private bool checkString(string str, string check)
        {
            if (check == "Day")
            {
                if(!str.Equals("Sunday") && !str.Equals("Sunday") && !str.Equals("Sunday") && !str.Equals("Sunday") && !str.Equals("Sunday") && !str.Equals("Sunday"))
                    throw new ArgumentException("Day should only be the day of the week.");

            }
            if (check == "Semester")
            {
                if (!str.Equals("A") && !str.Equals("B"))
                    throw new ArgumentException("Semester should only be A or B.");
            }
            if (check == "Start_Time")
            {
                bool allDigits = str.All(char.IsDigit);
                int num = Convert.ToInt32(str);
                if (allDigits == false)
                {
                   if(num < 8 || num > 19)
                        throw new ArgumentException("Start Time should be between 8-19 and only digits.");
                }
            }
            if (check == "Course")
            {
                bool allDigits = str.All(char.IsDigit);
                if (str.Length != 3 || allDigits == false)
                {
                    throw new ArgumentException("Course ID should be only digits and with length of 3.");
                }
            }
            return true;
        }
    }
}
