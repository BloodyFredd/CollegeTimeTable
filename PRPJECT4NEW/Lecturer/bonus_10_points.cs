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
    public partial class bonus_10_points : Form
    {
        private string connetionString = null;
        private SqlConnection sqlcon;
        public bonus_10_points()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False; MultipleActiveResultSets=true";
                this.sqlcon = new SqlConnection(connetionString);
                SqlCommand cmd = new SqlCommand("select * from Person where ID ='" + stud_id.Text + "' and Permission = 'Student'", sqlcon);
                if (!checkString(stud_id.Text, "ID") || !checkString(course_id.Text, "Course"))
                {
                    this.Close();
                    MessageBox.Show("Try again, this is not a correct ID!");
                    bonus_10_points form2 = new bonus_10_points();
                    form2.Show();
                }
                else
                {
                    this.sqlcon.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read() == true)
                    {
                        dr.Close();
                        cmd = new SqlCommand("select * from Teaching_Stuff where ID ='" + Utility.User.ID + "' and Course_id='" + course_id.Text + "'", sqlcon);
                        dr = cmd.ExecuteReader();
                        if (dr.Read() == true)
                        {

                            dr.Close();
                            cmd = new SqlCommand("select * from Teaching_Stuff where ID ='" + Utility.User.ID + "' and Course_id='" + course_id.Text + "'", sqlcon);
                            dr = cmd.ExecuteReader();
                            if (dr.Read() == true)
                            {
                                if (Int32.Parse(dr[0].ToString()) >= 90 && Int32.Parse(dr[0].ToString()) < 100)
                                {
                                    cmd = new SqlCommand("update Student_Courses set [final_grade] = 100 where course_id='" + course_id.Text + "' and stud_Id = '" + stud_id.Text + "' and Type = 1", sqlcon);

                                    SqlDataAdapter sda1 = new SqlDataAdapter();
                                    sda1.SelectCommand = cmd;
                                    DataTable dbdataset1 = new DataTable();
                                    sda1.Fill(dbdataset1);
                                    BindingSource bsource1 = new BindingSource();
                                    bsource1.DataSource = dbdataset1;
                                    sda1.Update(dbdataset1);
                                    MessageBox.Show("Changed grade succesfully!");
                                    this.sqlcon.Close();
                                    this.Close();
                                }
                                else if (Int32.Parse(dr[0].ToString()) < 90)
                                {
                                    dr.Close();
                                    cmd = new SqlCommand("update Student_Courses set [final_grade] = [final_grade]+10 where course_id='" + course_id.Text + "' and stud_Id = '" + stud_id.Text + "' and Type = 1", sqlcon);
                                    SqlDataAdapter sda = new SqlDataAdapter();
                                    sda.SelectCommand = cmd;
                                    DataTable dbdataset = new DataTable();
                                    sda.Fill(dbdataset);
                                    BindingSource bsource = new BindingSource();
                                    bsource.DataSource = dbdataset;
                                    sda.Update(dbdataset);
                                    MessageBox.Show("Changed grade succesfully!");
                                    this.sqlcon.Close();
                                    this.Close();
                                }
                                else  
                                {

                                    throw new ArgumentException("This student have 100 at this course!");

                                }
                            }

                        }
                        else
                        {
                            throw new ArgumentException("Try again, you do not teach such a course!");
                        }
                    }
                    else
                    {
                        throw new ArgumentException("Try again, there is not such student in our department!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
                bonus_10_points form2 = new bonus_10_points();
                form2.Show();
            }
            this.sqlcon.Close();
            this.Close();
        }


        private void Factor_Load(object sender, EventArgs e)
        {

        }

        private void class_num_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
