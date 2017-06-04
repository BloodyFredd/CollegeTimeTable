using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRPJECT4NEW.Exams_Section
{
    public partial class Exams_Assignment : Form
    {
        public Exams_Assignment()
        {
            InitializeComponent();
            Exams_List_Load();
            Combo_Course_Load();
            Combo_Class_Load();
            Combo_Supervisor_Load();
        }


        /// <summary>
        /// Load a courses list to "Combo_Course_Load" Combo box </summary>
        private void Combo_Course_Load()
        {
            using (Entities context = new Entities())
            {
                foreach (var s in context.courses)
                    Combo_Course_name.Items.Add(s.Course_name);
            }
        }

        /// <summary>
        /// Load a classes list to "Combo_Class_ID" Combo box </summary>
        private void Combo_Class_Load()
        {
            using (Entities context = new Entities())
            {

                foreach (var c in context.Classes_SM1)
                    Combo_Class_ID.Items.Add(c.Class_Id);
            }
        }

        /// <summary>
        /// Load a supervisors list to "Super1_box" &  "Super2_box" Combo boxes </summary>
        private void Combo_Supervisor_Load()
        {
            using (Entities context = new Entities())
            {
                foreach (var c in context.Person)
                    if(c.Permission == "Supervisor")
                    {
                        Super1_box.Items.Add(c.F_name + " " + c.L_name);
                        Super2_box.Items.Add(c.F_name + " " + c.L_name);
                    }
            }
        }

        /// <summary>
        /// Load the details from Exams table from sql to new grid
        /// by the parameters: ID, Course Name, Start Time, End Time, Classes, Supervisors, Students enrolled and date
        /// in adittion design the grid by color blue</summary>
        private void Exams_List_Load()
        {

            //Create Columns
            Exams_Grid.Columns.Add("ID", "ID");
            Exams_Grid.Columns.Add("Course_Name", "Course Name");
            Exams_Grid.Columns.Add("Start_Time", "Start Time");
            Exams_Grid.Columns.Add("End_Time", "End Time");
            Exams_Grid.Columns.Add("Class", "Class");
            Exams_Grid.Columns.Add("Supervisor1_ID", "First Supervisor ID");
            Exams_Grid.Columns.Add("Supervisor2_ID", "Second Supervisor ID");
            Exams_Grid.Columns.Add("Students_Enrolled", "Students Enrolled");
            Exams_Grid.Columns.Add("Date", "Date");
            Exams_Grid.Columns.Add("DueIn", "Due In");

            //Paint headers
            Exams_Grid.EnableHeadersVisualStyles = false;
            Exams_Grid.GridColor = Utility.HeaderBackColor;
            Exams_Grid.ColumnHeadersDefaultCellStyle.BackColor = Utility.HeaderBackColor;
            Exams_Grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            Exams_Grid.AutoResizeColumns();

            Exams_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            Exams_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            using (Entities context = new Entities())
            {
                Exams_Grid.Rows.Clear();
                foreach (Exam s in context.Exams)
                {
                    Exams_Grid.Rows.Add(s.ID, getCourseName(s.Course_ID), s.Start_Time + ":00", s.End_Time + ":00", s.Class, s.Superviser1_ID, s.Superviser2_ID, s.Student_Enrolled, s.Date.ToShortDateString(),s.Due_in);
                }             
            }
            Exams_Grid.Refresh();
        }


        /// <summary>
        /// Takes all the details from the form and check that we dont have any conflicts
        /// if we have conflict: throw message, else add the exam to exam table at sql</summary>
        /// <param name="sender">User that click on "Add Exam" Button"</param>  
        /// <param name="e">new event after click the button"</param>  
        private void newScholarshipBtn_Click(object sender, EventArgs e)
        {
            if (CheckDateTime(datePicker.Value, Convert.ToInt32(Start_Time_Box.Value), Convert.ToInt32(End_Time_Box.Value), Combo_Class_ID.Text) 
                && SuperviserAvailable(getSupereId(Super1_box.Text))
                && SuperviserAvailable(getSupereId(Super2_box.Text))
                && !SameSuperviser(Super1_box.Text, Super2_box.Text)
                && checkDifference() && CheckClassDB())
            {
                using (Entities context = new Entities())
                {
                    Exam new_Exam = new Exam
                    {
                        ID = nextID(),
                        Course_ID = Convert.ToInt32(getCourseId(Combo_Course_name.Text)),
                        Start_Time = Convert.ToInt32(Start_Time_Box.Value),
                        End_Time = Convert.ToInt32(End_Time_Box.Value),
                        Class = Combo_Class_ID.Text,
                        Superviser1_ID = getSupereId(Super1_box.Text),
                        Superviser2_ID = getSupereId(Super2_box.Text),
                        Date = datePicker.Value,
                        Student_Enrolled = 0,
                    };

                    context.Exams.Add(new_Exam);
                    context.SaveChanges();
                    reloadDataGridView(context);
                    markClasses();


                    string mesage1 = "Dear " + Super1_box.Text + "\nyou have new exam at " + Start_Time_Box.Value + ":00 - " + End_Time_Box.Value + ":00 at class " + Combo_Class_ID.Text;
                    string mesage2 = "Dear " + Super2_box.Text + "\nyou have new exam at " + Start_Time_Box.Value + ":00 - " + End_Time_Box.Value + ":00 at class " + Combo_Class_ID.Text;
                    SendMail senders = new SendMail();
                    senders.Send(Getmail(Super1_box.Text), "New exam!", mesage1);
                    senders.Send(Getmail(Super2_box.Text), "New exam!", mesage2);

                }
            }          
        }

        /// <summary>
        /// return course ID that match to Course Name</summary>
        /// <param name="name">Course name</param> 
        /// <value>Course ID</value>  
        private int getCourseId(String name)
        {
            using (Entities context = new Entities())
            {

                foreach (var s in context.courses)
                    if (s.Course_name == name)
                        return s.Course_id;
            }
            return 0;
        }

        private bool CheckClassDB()
        {
            using (Entities context = new Entities())
            {

                foreach (var s in context.Classes_SM2)
                    if(s.Class_Id == Combo_Class_ID.Text && s.date== datePicker.Value.ToShortDateString().Substring(3,3)+ datePicker.Value.ToShortDateString().Substring(0, 3)+ datePicker.Value.ToShortDateString().Substring(6, 4))
                        switch (Convert.ToInt32(Start_Time_Box.Value))
                        {
                            case 8:
                                if(s.C08_09==0 && s.C09_10 == 0 && s.C10_11 == 0 && s.C11_12 == 0)
                                    return true;
                                break;
                            case 9:
                                if ( s.C09_10 == 0 && s.C10_11 == 0 && s.C11_12 == 0 && s.C12_13 == 0)
                                    return true;
                                break;
                            case 10:
                                if (s.C10_11 == 0 && s.C11_12 == 0 && s.C12_13 == 0 && s.C13_14 == 0)
                                    return true;
                                break;
                            case 11:
                                if (s.C11_12 == 0 && s.C12_13 == 0 && s.C13_14 == 0 && s.C14_15 == 0)
                                    return true;
                                break;
                            case 12:
                                if (s.C12_13 == 0 && s.C13_14 == 0 && s.C14_15 == 0 && s.C15_16 == 0)
                                    return true;
                                break;
                            case 13:
                                if (s.C13_14 == 0 && s.C14_15 == 0 && s.C15_16 == 0 && s.C16_17 == 0)
                                    return true;
                                break;
                            case 14:
                                if (s.C14_15 == 0 && s.C15_16 == 0 && s.C16_17 == 0 && s.C17_18 == 0)
                                    return true;
                                break;
                            case 15:
                                if (s.C15_16 == 0 && s.C16_17 == 0 && s.C17_18 == 0 && s.C18_19 == 0)
                                    return true;
                                break;
                            case 16:
                                if (s.C16_17 == 0 && s.C17_18 == 0 && s.C18_19 == 0 && s.C19_20 ==0)
                                    return true;
                                break;
                            case 17:
                                if (s.C17_18 == 0 && s.C18_19 == 0 && s.C19_20 == 0 && s.C20_21 == 0)
                                    return true;
                                break;
                        }             
            }
            MessageBox.Show("There is a Exam at this Time at the same class!", "Error!");
            return false;
        }



        private void markClasses()
        {
            using (Entities context = new Entities())
            {

                foreach (var s in context.Classes_SM2)
                    if (s.Class_Id == Combo_Class_ID.Text && s.date == datePicker.Value.ToShortDateString().Substring(3, 3) + datePicker.Value.ToShortDateString().Substring(0, 3) + datePicker.Value.ToShortDateString().Substring(6, 4))
                        switch (Convert.ToInt32(Start_Time_Box.Value))
                        {
                            case 8:
                                s.C08_09 = 1;
                                s.C09_10 = 1;
                                s.C10_11 = 1;
                                s.C11_12 = 1;
                                break;
                            case 9:
                                s.C09_10 = 1;
                                s.C10_11 = 1;
                                s.C11_12 = 1;
                                s.C12_13 = 1;
                                break;
                            case 10:
                                s.C10_11 = 1;
                                s.C11_12 = 1;
                                s.C12_13 = 1;
                                s.C13_14 = 1;
                                break;
                            case 11:
                                s.C11_12 = 1;
                                s.C12_13 = 1;
                                s.C13_14 = 1;
                                s.C14_15 = 1;
                                break;
                            case 12:
                                s.C12_13 = 1;
                                s.C13_14 = 1;
                                s.C14_15 = 1;
                                s.C15_16 = 1;
                                break;
                            case 13:
                                s.C13_14 = 1;
                                s.C14_15 = 1;
                                s.C15_16 = 1;
                                s.C16_17 = 1;
                                break;
                            case 14:
                                s.C14_15 = 1;
                                s.C15_16 = 1;
                                s.C16_17 = 1;
                                s.C17_18 = 1;
                                break;
                            case 15:
                                s.C15_16 = 1;
                                s.C16_17 = 1;
                                s.C17_18 = 1;
                                s.C18_19 = 1;
                                break;
                            case 16:
                                s.C16_17 = 1;
                                s.C17_18 = 1;
                                s.C18_19 = 1;
                                s.C19_20 = 1;
                                break;
                            case 17:
                                s.C17_18 = 1;
                                s.C18_19 = 1;
                                s.C19_20 = 1;
                                s.C20_21 = 1;
                                break;
                        }
                context.SaveChanges();
            }
        }


        /// <summary>
        /// return course Name that match to Course ID</summary>
        /// <param name="name">Course ID</param> 
        /// <value>Course Name</value>  
        private string getCourseName(int ID)
        {
            using (Entities context = new Entities())
            {

                foreach (var s in context.courses)
                    if (s.Course_id == ID)
                        return s.Course_name;
            }
            return "Null";
        }

        /// <summary>
        /// Reload "Exams_Grid" with the exams at Exam table that in sql</summary>
        private void reloadDataGridView(Entities context)
        {
            Exams_Grid.Rows.Clear();
            foreach (Exam s in context.Exams)
            {
                Exams_Grid.Rows.Add(s.ID, getCourseName(s.Course_ID), s.Start_Time+":00", s.End_Time + ":00", s.Class, s.Superviser1_ID, s.Superviser2_ID, s.Student_Enrolled, s.Date.ToShortDateString(),s.Due_in);
            }
            Exams_Grid.Refresh();
        }

        /// <summary>
        /// Check if class is empty by date and time</summary>
        /// <param name="new_Date">The date by "Year-Month-Day"</param> 
        /// <param name="new_Start">Start time of the exam</param>
        /// <param name="new_End">End time of the exam</param>
        /// <param name="Class_Name">The class that the user want to take"</param>
        /// <value>if the class is empty or not at this date and time</value>  
        private bool CheckDateTime(DateTime new_Date, int new_Start, int new_End, String Class_Name)
        {
            using (Entities context = new Entities())
            {

                foreach (var s in context.Exams)
                    if (s.Date.Year == new_Date.Year && s.Date.Month == new_Date.Month && s.Date.Day == new_Date.Day && s.Class == Class_Name && !CheckTime(new_Start, new_End, s.Start_Time, s.End_Time))
                    {
                        MessageBox.Show("There is a Exam at this Time at the same class!", "Error!");
                        return false;
                    }
            }
            return true;
        }


        /// <summary>
        /// Check if 2 exams times are overlapping</summary>
        /// <param name="s1">First Exam start time</param> 
        /// <param name="e1">First Exam end time</param> 
        /// <param name="s2">Second Exam start time</param> 
        /// <param name="e2">Second Exam end time</param> 
        /// <value>return if the exam are overlapping</value>  
        private bool CheckTime(int s1, int e1, int s2, int e2)
        {
            if (e1 > s2 && e1 < s2)
                return false;
            else if (s1 > s2 && s1 < e2)
                return false;
            else if (s1 > s2 && e1 < e2)
                return false;
            else if (s1 == s2 && e1 == e2)
                return false;
            else
                return true;
        }

        /// <summary>
        /// Check if 2 supervisors are diffrent persons by person ID</summary>
        /// <param name="Sup1">First supervisor</param> 
        /// <param name="Sup2">Second supervisor</param> 
        /// <value>return if the ID's are equals</value>
        private bool SameSuperviser(string Sup1, string Sup2)
        {
            return getSupereId(Sup1) == getSupereId(Sup2);
        }

        private bool SuperviserAvailable(string SupID)
        {
            using (Entities context = new Entities())
            {

                foreach (var s in context.Exams)
                    if (s.Date.ToShortDateString()==datePicker.Value.ToShortDateString() && s.Start_Time == Convert.ToInt32(Start_Time_Box.Value) && s.End_Time == Convert.ToInt32(End_Time_Box.Value) && (s.Superviser1_ID.Contains(SupID) || s.Superviser2_ID.Contains(SupID)))
                    {
                        MessageBox.Show(SupID+" at the exam of "+ getCourseName(s.Course_ID) + " at this time!", "Error!");
                        return false;                      
                    }
            }
            return true;
        }

        /// <param name="name">Supervisor full name</param> 
        /// <value>return supervisor ID</value>
        private string getSupereId(String name)
        {
            using (Entities context = new Entities())
            {

                foreach (var s in context.Person)
                    if (s.F_name+" " +s.L_name == name)
                        return s.ID;
            }
            return "NULL";
        }

        /// <summary>
        /// Check what is the next exam ID</summary>
        /// <value>Next ID</value>
        private int nextID()
        {
            int max = 0;
            using (Entities context = new Entities())
            {
                foreach (var s in context.Exams)
                    if (max < s.ID)
                        max = s.ID;
            }
            return max+1;
        }

        /// <summary>
        /// Check if difference between start time and end time of exam is bigger than 1 hour </summary>
        /// <value>if the diffrence bigger than 1</value>
        private bool checkDifference()
        {
            if(End_Time_Box.Value - Start_Time_Box.Value<1)
            {
                MessageBox.Show("The diffrence need to be at least 1 hour", "Error!");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Check if difference between start time and end time of exam is bigger than 1 hour </summary>
        /// <value>if the diffrence bigger than 1</value>
        private string Getmail(string name)
        {
            using (Entities context = new Entities())
            {
                foreach (var s in context.Person)
                    if (s.F_name + " " + s.L_name == name)
                        return s.Email;
            }
            return "NULL";
        }


        private void Exams_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void GetIdBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void Super2_box_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
        }

        private void Combo_Course_name_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Combo_Class_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Due_In_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
