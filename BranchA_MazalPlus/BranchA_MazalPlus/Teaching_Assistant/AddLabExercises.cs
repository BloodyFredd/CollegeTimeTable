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
                SqlCommand cmd = new SqlCommand("select Date, Start_time, Class_number from Lecture_Course where Teacher = '" + Forms.UserID.ID + "'", sqlcon);
                this.sqlcon.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                string date = returnDate("Sunday", "A");
                if (dr.Read() == true)
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
                    if (first == 8)
                    {
                        cmd1 = new SqlCommand("update Classes_SM1 set [0" + firstString + "-0" + secondString + "]=[0" + firstString + "-0" + secondString + "] + 1 where date ='" + date + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                        cmd2 = new SqlCommand("update Classes_SM1 set [0" + secondString + "-" + thirdString + "]=[0" + secondString + "-" + thirdString + "] + 1 where date ='" + date + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                    }
                    else if(first == 9)
                    {
                        cmd1 = new SqlCommand("update Classes_SM1 set [0" + firstString + "-" + secondString + "]=[0" + firstString + "-" + secondString + "] + 1 where date ='" + date + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                        cmd2 = new SqlCommand("update Classes_SM1 set [" + secondString + "-" + thirdString + "]=[" + secondString + "-" + thirdString + "] + 1 where date ='" + date + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                    }
                    else
                    {
                        cmd1 = new SqlCommand("update Classes_SM1 set [" + firstString + "-" + secondString + "]=[" + firstString + "-" + secondString + "] + 1 where date ='" + date + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                        cmd2 = new SqlCommand("update Classes_SM1 set [" + secondString + "-" + thirdString + "]=[" + secondString + "-" + thirdString + "] + 1 where date ='" + date + "' and Class_Id = '" + dr[2].ToString() + "'", sqlcon);
                    }
                    dr.Close();
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = cmd;
                    SqlDataAdapter sda1 = new SqlDataAdapter();
                    sda1.SelectCommand = cmd1;
                    SqlDataAdapter sda2 = new SqlDataAdapter();
                    sda2.SelectCommand = cmd2;                   
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    sda1.Fill(dbdataset);
                    sda2.Fill(dbdataset);                    
                    BindingSource bsource = new BindingSource();
                    bsource.DataSource = dbdataset;
                    sda.Update(dbdataset);
                    sda1.Update(dbdataset);
                    sda2.Update(dbdataset);
                    MessageBox.Show("Added a new lab and exercise!");
                    this.sqlcon.Close();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
                AddLabExercises form2 = new AddLabExercises();
                form2.Show();
            }
            this.sqlcon.Close();
            this.Close();
        }

        public string returnDate(string day, string sem)
        {
            if (day.Equals("Sunday") && sem.Equals("A"))
            {
                return "2016-08-07";
            }
            throw new ArgumentException("Try again, no such day.");
        }

        private bool checkString(string id, string check)
        {
            if (check == "ID")
            {
                bool allDigits = id.All(char.IsDigit);
                if (id.Length != 9 || allDigits == false)
                {
                    throw new ArgumentException("ID should be only digits and with length of 9.");
                }
            }
            if (check == "Course")
            {
                bool allDigits = id.All(char.IsDigit);
                if (id.Length != 3 || allDigits == false)
                {
                    throw new ArgumentException("Course ID should be only digits and with length of 3.");
                }
            }
            return true;
        }
    }
}
