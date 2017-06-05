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
using PRPJECT4NEW.Forms;

namespace PRPJECT4NEW.Lecturer
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
                checkString(CourseIDButton.Text, "Course");
                checkString(StartButton.Text, "Start");
                checkString(DayButton.Text, "Day");
                checkString(SemesterButton.Text, "Semester");
                checkString(ClassButton.Text, "Class");
                int first, second, third, fourth;
                string firstString, secondString, thirdString, fourthString;
                first = Convert.ToInt32(StartButton.Text);
                second = Convert.ToInt32(StartButton.Text) + 1;
                third = Convert.ToInt32(StartButton.Text) + 2;
                fourth = Convert.ToInt32(StartButton.Text) + 3;
                firstString = first.ToString();
                secondString = second.ToString();
                thirdString = third.ToString();
                fourthString = fourth.ToString();
                int end = Convert.ToInt32(StartButton.Text) + 3;
                string endString = end.ToString();

                // check if the course and semester are as needed.
                SqlCommand cmd = new SqlCommand("select * from courses where Course_id = '" + CourseIDButton.Text + "' and Semester = '" + SemesterButton.Text + "'", sqlcon);
                SqlDataReader dre = cmd.ExecuteReader();
                if (dre.Read() == false)
                {
                    throw new ArgumentException("The course and the semester are not good!");
                }
                dre.Close();

                // check if the lecturer already teaches this class.
                cmd = new SqlCommand("select * from Teaching_Stuff where ID = '" + Utility.User.ID + "' and Course_id = '" + CourseIDButton.Text + "'", sqlcon);
                dre = cmd.ExecuteReader();
                if (dre.Read())
                {
                    throw new ArgumentException("You have already a course with this id!");
                }
                dre.Close();

                // check if the class is already occupied in this time and class.
                if (SemesterButton.Text.Equals("a"))
                {
                    if (first == 8)
                    {
                        cmd = new SqlCommand("select * from Classes_SM1 where day = '" + DayButton.Text + "' and Class_Id = '" + ClassButton.Text + "' and [0" + firstString + "-0" + secondString + "]= 1 and [0" + secondString + "-" + thirdString + "]= 1", sqlcon);
                    }
                    else if (first == 9)
                    {
                        cmd = new SqlCommand("select * from Classes_SM1 where day = '" + DayButton.Text + "' and Class_Id = '" + ClassButton.Text + "' and [0" + firstString + "-" + secondString + "]= 1 and [" + secondString + "-" + thirdString + "]= 1", sqlcon);
                    }
                    else
                    {
                        cmd = new SqlCommand("select * from Classes_SM1 where day = '" + DayButton.Text + "' and Class_Id = '" + ClassButton.Text + "' and [" + firstString + "-" + secondString + "]= 1 and [" + secondString + "-" + thirdString + "]= 1", sqlcon);
                    }
                }
                else if (SemesterButton.Text.Equals("b"))
                {
                    if (first == 8)
                    {
                        cmd = new SqlCommand("select * from Classes_SM2 where day = '" + DayButton.Text + "' and Class_Id = '" + ClassButton.Text + "' and [0" + firstString + "-0" + secondString + "]= 1 and [0" + secondString + "-" + thirdString + "]= 1 and [" + thirdString + "-" + fourthString + "]= 1", sqlcon);
                    }
                    else if (first == 9)
                    {
                        cmd = new SqlCommand("select * from Classes_SM2 where day = '" + DayButton.Text + "' and Class_Id = '" + ClassButton.Text + "' and [0" + firstString + "-" + secondString + "]= 1 and [" + secondString + "-" + thirdString + "]= 1 and [" + thirdString + "-" + fourthString + "]= 1", sqlcon);
                    }
                    else
                    {
                        cmd = new SqlCommand("select * from Classes_SM2 where day = '" + DayButton.Text + "' and Class_Id = '" + ClassButton.Text + "' and [" + firstString + "-" + secondString + "]= 1 and [" + secondString + "-" + thirdString + "]= 1 and [" + thirdString + "-" + fourthString + "]= 1", sqlcon);
                    }
                }
                dre = cmd.ExecuteReader();
                if (dre.Read() == true)
                {
                    throw new ArgumentException("The class you have chosen is already occupied!");
                }
                dre.Close();

                // check if the teacher is already occupied during this time.
                cmd = new SqlCommand("select * from Lecture_Course where Teacher ='" + Utility.User.ID + "' and Date = '" + DayButton.Text + "' and Start_time = '" + StartButton.Text + "'", sqlcon);
                dre = cmd.ExecuteReader();
                if (dre.Read() == true)
                {
                    throw new ArgumentException("You already teach a class during this time!");
                }
                dre.Close();

                // check if the teacher is already occupied during this time.
                cmd = new SqlCommand("select * from Lecture_Course where Teacher ='" + Utility.User.ID + "' and Date = '" + DayButton.Text + "' and Start_time = '" + secondString + "'", sqlcon);
                dre = cmd.ExecuteReader();
                if (dre.Read() == true)
                {
                    throw new ArgumentException("You already teach a class during this time!");
                }
                dre.Close();

                // check if the teacher is already occupied during this time.
                cmd = new SqlCommand("select * from Lecture_Course where Teacher ='" + Utility.User.ID + "' and Date = '" + DayButton.Text + "' and Start_time = '" + thirdString + "'", sqlcon);
                dre = cmd.ExecuteReader();
                if (dre.Read() == true)
                {
                    throw new ArgumentException("You already teach a class during this time!");
                }
                dre.Close();

                // check if someone is already teaching this lecture.
                cmd = new SqlCommand("select * from Lecture_Course where Course_ID = '" + CourseIDButton.Text + "' and Course_type = 1", sqlcon);
                dre = cmd.ExecuteReader();
                if (dre.Read() == true)
                { // if someone teaches this lecture, add another one with different serial.
                    int num = 1;
                    using (Entities db = new Entities())
                    {
                        foreach(Lecture_Course l in db.Lecture_Course)
                        {
                            if (l.Course_ID == Convert.ToInt32(CourseIDButton.Text) && l.Course_type == 1)
                                num = l.Course_Serial + 1;
                        }
                    }
                    dre.Close();
                    SqlCommand cmd4 = new SqlCommand("insert into Lecture_Course (Course_ID, Course_Serial, Course_type, Teacher, Date, Start_time, End_time, Class_number, Student_Count) Values('" + CourseIDButton.Text + "', '" + num + "', 1, '" + Utility.User.ID + "', '" + DayButton.Text + "', '" + StartButton.Text + "', '" + endString + "', '" + ClassButton.Text + "', 0) ; ", sqlcon);
                    dre = cmd4.ExecuteReader();
                    dre.Close();

                    // insert your course to data base teaching stuff
                    cmd = new SqlCommand("insert into Teaching_Stuff (ID, Course_id) Values ('" + Utility.User.ID + "', '" + CourseIDButton.Text + "' ) ; ", sqlcon);
                    dre = cmd.ExecuteReader();
                    dre.Close();
                }
                else
                { // if no one teaches this lecture, insert it to lecture course.
                    dre.Close();
                    SqlCommand cmd4 = new SqlCommand("insert into Lecture_Course (Course_ID, Course_Serial, Course_type, Teacher, Date, Start_time, End_time, Class_number, Student_Count) Values('" + CourseIDButton.Text + "', '" + CourseIDButton.Text + "1', 1, '" + Utility.User.ID + "', '" + DayButton.Text + "', '" + StartButton.Text + "', '" + endString + "', '" + ClassButton.Text + "', 0) ; ", sqlcon);
                    dre = cmd4.ExecuteReader();
                    dre.Close();

                    // insert your course to data base teaching stuff
                    cmd = new SqlCommand("insert into Teaching_Stuff (ID, Course_id) Values ('" + Utility.User.ID + "', '" + CourseIDButton.Text + "' ) ; ", sqlcon);
                    dre = cmd.ExecuteReader();
                    dre.Close();
                }
                //dre.Close();

                // take specific date, start time and class number from lecture course. 
                SqlCommand cmd5 = new SqlCommand("select Date, Start_time, Class_number from Lecture_Course where Teacher = '" + Utility.User.ID + "' and Course_ID = '" + CourseIDButton.Text + "'", sqlcon);
                SqlDataReader dr = cmd5.ExecuteReader();
                if (dr.Read())
                {

                    // update the database of the classes according to the course.
                    SqlCommand cmd1, cmd2, cmd3;
                    if (SemesterButton.Text.Equals("a"))
                    {
                        if (first == 8)
                        {
                            cmd1 = new SqlCommand("update Classes_SM1 set [0" + firstString + "-0" + secondString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "' and holiday = '0'", sqlcon);
                            cmd2 = new SqlCommand("update Classes_SM1 set [0" + secondString + "-" + thirdString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "' and holiday = '0'", sqlcon);
                            cmd3 = new SqlCommand("update Classes_SM1 set [" + thirdString + "-" + fourthString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "' and holiday = '0'", sqlcon);
                        }
                        else if (first == 9)
                        {
                            cmd1 = new SqlCommand("update Classes_SM1 set [0" + firstString + "-" + secondString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "' and holiday = '0'", sqlcon);
                            cmd2 = new SqlCommand("update Classes_SM1 set [" + secondString + "-" + thirdString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "' and holiday = '0'", sqlcon);
                            cmd3 = new SqlCommand("update Classes_SM1 set [" + thirdString + "-" + fourthString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "' and holiday = '0'", sqlcon);
                        }
                        else
                        {
                            cmd1 = new SqlCommand("update Classes_SM1 set [" + firstString + "-" + secondString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "' and holiday = '0'", sqlcon);
                            cmd2 = new SqlCommand("update Classes_SM1 set [" + secondString + "-" + thirdString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "' and holiday = '0'", sqlcon);
                            cmd3 = new SqlCommand("update Classes_SM1 set [" + thirdString + "-" + fourthString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "' and holiday = '0'", sqlcon);
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
                    else if (SemesterButton.Text.Equals("b"))
                    {
                        if (first == 8)
                        {
                            cmd1 = new SqlCommand("update Classes_SM2 set [0" + firstString + "-0" + secondString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "' and holiday = 0", sqlcon);
                            cmd2 = new SqlCommand("update Classes_SM2 set [0" + secondString + "-" + thirdString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "' and holiday = 0", sqlcon);
                            cmd3 = new SqlCommand("update Classes_SM2 set [" + thirdString + "-" + fourthString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "' and holiday = 0", sqlcon);
                        }
                        else if (first == 9)
                        {
                            cmd1 = new SqlCommand("update Classes_SM2 set [0" + firstString + "-" + secondString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "' and holiday = 0", sqlcon);
                            cmd2 = new SqlCommand("update Classes_SM2 set [" + secondString + "-" + thirdString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "' and holiday = 0", sqlcon);
                            cmd3 = new SqlCommand("update Classes_SM2 set [" + thirdString + "-" + fourthString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "' and holiday = 0", sqlcon);
                        }
                        else
                        {
                            cmd1 = new SqlCommand("update Classes_SM2 set [" + firstString + "-" + secondString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "' and holiday = 0", sqlcon);
                            cmd2 = new SqlCommand("update Classes_SM2 set [" + secondString + "-" + thirdString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "' and holiday = 0", sqlcon);
                            cmd3 = new SqlCommand("update Classes_SM2 set [" + thirdString + "-" + fourthString + "]= 1 where day ='" + dr[0].ToString() + "' and Class_Id = '" + dr[2].ToString() + "' and holiday = 0", sqlcon);
                        }
                        dr.Close();

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
                        //dr = cmd5.ExecuteReader();
                    }
                }
                MessageBox.Show("Added succesfully!");
                //dr.Close();
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

        // this function checks all the strings.
        private bool checkString(string str, string check)
        {
            if (check == "Day")
            {
                if (!str.Equals("Sunday") && !str.Equals("Monday") && !str.Equals("Tuesday") && !str.Equals("Wednesday") && !str.Equals("Thursday") && !str.Equals("Friday"))
                    throw new ArgumentException("Day should only be the day of the week.");

            }
            if (check == "Semester")
            {
                if (!str.Equals("a") && !str.Equals("b"))
                    throw new ArgumentException("Semester should only be a or b.");
            }
            if (check == "Start_Time")
            {
                bool allDigits = str.All(char.IsDigit);
                int num = Convert.ToInt32(str);
                if (allDigits == false)
                {
                    if (num < 8 || num > 19)
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
            if (check == "Class")
            {
                if (str[0] != 'a' && str[0] != 'f' && str[0] != 's')
                {
                    throw new ArgumentException("This is not a correct class.");
                }

                else if (str[1] != '1')
                {
                    throw new ArgumentException("This is not a correct class.");
                }

                else if (str[2] != '0')
                {
                    throw new ArgumentException("This is not a correct class.");
                }

                else if (str[3] < '1' || str[3] > '4')
                {
                    throw new ArgumentException("This is not a correct class.");
                }
            }
            return true;
        }
    }
}
