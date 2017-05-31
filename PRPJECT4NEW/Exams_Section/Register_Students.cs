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
    public partial class Register_Students : Form
    {
        public Register_Students()
        {
            InitializeComponent();
            Exams_List_Load();
            Students_List_Load();
            Combo_Course_Load();
        }

        /// <summary>
        /// Load a courses list to "Combo_Course_Load" Combo box </summary>
        private void Combo_Course_Load()
        {
            using (Entities context = new Entities())
            {
                foreach (var s in context.Course_detail)
                    if(s.Year == DateTime.Now.Year)
                        Combo_Course_name.Items.Add(getCourseName(s.Course_id)+" - "+ s.Course_Serial);
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
            Exams_Grid.Columns.Add("Class", "Class (capacity)");
            Exams_Grid.Columns.Add("Students_Enrolled", "Students Enrolled");
            Exams_Grid.Columns.Add("Date", "Date");

            //Create check box column
            
            DataGridViewCheckBoxColumn column = new DataGridViewCheckBoxColumn();
            {
                column.HeaderText = "Choose Course";
                column.Name = "Choose_Course";
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                column.FlatStyle = FlatStyle.Standard;
                column.ThreeState = false;
                column.IndeterminateValue = false;
                column.CellTemplate = new DataGridViewCheckBoxCell();
            }
            Exams_Grid.Columns.Insert(Exams_Grid.Columns.Count, column);

            //Paint headers
            Exams_Grid.EnableHeadersVisualStyles = false;
            Exams_Grid.GridColor = Utility.HeaderBackColor;
            Exams_Grid.ColumnHeadersDefaultCellStyle.BackColor = Utility.HeaderBackColor;
            Exams_Grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            Exams_Grid.AutoResizeColumns();

            Exams_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            Exams_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
       
        }

        /// <summary>
        /// Reload "Exams_Grid" with the exams at Exam table that in sql</summary>
        private void Exam_List_Reload()
        {
            Exams_Grid.Rows.Clear();
            using (Entities context = new Entities())
            {
                foreach (Exam s in context.Exams)
                {
                    if (s.Course_ID == getCourseId(Combo_Course_name.Text.Substring(0, Combo_Course_name.Text.Length - 7)))
                        Exams_Grid.Rows.Add(s.ID, getCourseName(s.Course_ID), s.Class + " (" + classCapacity(s.Class) + ")", s.Student_Enrolled,s.Date.ToShortDateString());
                }
                Exams_Grid.Refresh();
            }
        }


        /// <summary>
        /// Load the details from Exams table from sql to new grid
        /// by the parameters: ID, Course Name, Start Time, End Time, Classes, Supervisors, Students enrolled and date
        /// in adittion design the grid by color blue</summary>
        private void Students_List_Load()
        {
            
            //Create Columns
            Students_List.Columns.Add("ID", "ID");
            Students_List.Columns.Add("ExtraTime", "Extra Time");
            //Exams_Grid.Columns.Add("Date", "Date");

            //Create check box column
            DataGridViewCheckBoxColumn column = new DataGridViewCheckBoxColumn();
            {
                column.HeaderText = "Check";
                column.Name = "check";
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                column.FlatStyle = FlatStyle.Standard;
                column.ThreeState = false;
                column.IndeterminateValue = false;
                column.CellTemplate = new DataGridViewCheckBoxCell();
            }
            Students_List.Columns.Insert(Students_List.Columns.Count, column);

            //Paint headers
            Students_List.EnableHeadersVisualStyles = false;
            Students_List.GridColor = Color.White;
            Students_List.ColumnHeadersDefaultCellStyle.BackColor = Utility.HeaderBackColor;
            Students_List.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            Students_List.AutoResizeColumns();

            Students_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            Students_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
           
        }

        private void Students_List_Reload()
        {
            using (Entities context = new Entities())
            {
                Students_List.Rows.Clear();
                foreach (Person s in context.Person)
                {
                    if (s.Permission == "Student" && studentInCourse(s.ID, getCourseId(Combo_Course_name.Text.Substring(0, Combo_Course_name.Text.Length - 7))))
                        Students_List.Rows.Add(s.ID, "True");
                }
                Students_List.Refresh();
            }

        }
  

        /// <summary>
        /// Check if student learn at course</summary>
        /// <param name="StudID">Student ID</param> 
        /// <param name="CourseID">Course ID</param> 
        /// <value>if student learn at specific course</value>  
        private bool studentInCourse(String StudID, int CourseID)
        {
            using (Entities context = new Entities())
            {

                foreach (var s in context.Student_Courses)
                    if(s.stud_Id == StudID)
                       foreach (var courseDet in context.Course_detail)
                           if (courseDet.Course_id == CourseID
                              && courseDet.Year == DateTime.Now.Year)
                                return true;
            }
            return false;
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

        private int classCapacity(string className)
        {
            using (Entities context = new Entities())
            {
                foreach (var s in context.Classes_SM2)
                    if (s.Class_Id == className)
                        return Convert.ToInt32(s.Capacity);
            }
            return 0;
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
            Students_List.Rows.Clear();
            Students_List_Reload();
            Exams_Grid.Rows.Clear();
            Exam_List_Reload();
        }

        private void Combo_Class_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
