using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PRPJECT4NEW.Exams_Section
{
    public partial class Register_Students : Form
    {
        int cnt;
        Entities context;
        public Register_Students()
        {
            InitializeComponent();
            context = new Entities();
            Combo_Course_Load();
            Exams_List_Load();
            Students_List_Load();
            cnt = 0;
        }

        /// <summary>
        /// Load a courses list to "Combo_Course_Load" Combo box </summary>
        private void Combo_Course_Load()
        {
                foreach (Lecture_Course s in context.Lecture_Course)
                    if(s.Course_type==1 && CourseInExam(s.Course_ID))
                        Combo_Course_name.Items.Add(getCourseName(s.Course_ID)+" - "+ s.Course_Serial);
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
            Exams_Grid.Columns.Add("Due_In", "Due In");
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
            context = new Entities();
            foreach (Exam s in context.Exams)
                {
                    if (s.Course_ID == getCourseId(Combo_Course_name.Text.Substring(0, Combo_Course_name.Text.Length - 7)))
                        Exams_Grid.Rows.Add(s.ID, getCourseName(s.Course_ID), s.Class + " (" + classCapacity(s.Class) + ")", s.Student_Enrolled,s.Due_in,s.Date.ToShortDateString());
                
                }
            Exams_Grid.Refresh();

        }


        /// <summary>
        /// Load the details from Exams table from sql to new grid
        /// by the parameters: ID, Course Name, Start Time, End Time, Classes, Supervisors, Students enrolled and date
        /// in adittion design the grid by color blue</summary>
        private void Students_List_Load()
        {
            
            //Create Columns
            Students_List.Columns.Add("ID", "ID");
            Students_List.Columns.Add("Easement", "Easement");
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
            context = new Entities();
            foreach (student s in context.students)
                {
                    if (studentInCourse(s.ID, getCourseId(Combo_Course_name.Text.Substring(0, Combo_Course_name.Text.Length - 7))))
                        Students_List.Rows.Add(s.ID, s.ExtraTime || s.FormulaSheet || s.Laptop);
                }
            Students_List.Refresh();

        }

        private void Students_Extra_List_Reload()
        {
            context = new Entities();
            Students_List.Rows.Clear();
                foreach (student s in context.students)
                {
                    if (studentInCourse(s.ID, getCourseId(Combo_Course_name.Text.Substring(0, Combo_Course_name.Text.Length - 7))) && (s.ExtraTime == true || s.FormulaSheet==true || s.Laptop == true))
                        Students_List.Rows.Add(s.ID, s.ExtraTime || s.FormulaSheet || s.Laptop);
                }
                Students_List.Refresh();
        }

        private void Students_Not_Extra_List_Reload()
        {
            context = new Entities();
            Students_List.Rows.Clear();
                foreach (student s in context.students)
                {
                    if (studentInCourse(s.ID, getCourseId(Combo_Course_name.Text.Substring(0, Combo_Course_name.Text.Length - 7))) && s.ExtraTime == false && s.FormulaSheet == false && s.Laptop == false)
                        Students_List.Rows.Add(s.ID, s.ExtraTime || s.FormulaSheet || s.Laptop);
                Students_List.Refresh();
            }
                
        }


        /// <summary>
        /// Check if student learn at course</summary>
        /// <param name="StudID">Student ID</param> 
        /// <param name="CourseID">Course ID</param> 
        /// <value>if student learn at specific course</value>  
        private bool studentInCourse(string StudID, int CourseID)
        {
                Student_Courses ss = context.Student_Courses.FirstOrDefault(s => s.stud_Id == StudID && s.course_id == CourseID && s.final_grade==null && s.Type==1);
                if (ss != null)
                    return true;
            return false;
        }

        /// <summary>
        /// Check if student learn at course</summary>
        /// <param name="StudID">Student ID</param> 
        /// <param name="CourseID">Course ID</param> 
        /// <value>if student learn at specific course</value>  
        private bool CourseInExam(int CourseID)
        {
            Exam ss = context.Exams.FirstOrDefault(s => s.Course_ID == CourseID);
            if (ss != null)
                return true;
            return false;
        }

        /// <summary>
        /// return course ID that match to Course Name</summary>
        /// <param name="name">Course name</param> 
        /// <value>Course ID</value>  
        private int getCourseId(string name)
        {
            cours ss = context.courses.First(s => s.Course_name == name);
            return ss.Course_id;

        }

        /// <summary>
        /// return course Name that match to Course ID</summary>
        /// <param name="name">Course ID</param> 
        /// <value>Course Name</value>  
        private string getCourseName(int ID)
        {
            cours ss = context.courses.First(s => s.Course_id == ID);
            return ss.Course_name;

        }


     

        /// <summary>
        /// Check what is the next exam ID</summary>
        /// <value>Next ID</value>
        private int nextID()
        {
            context = new Entities();
            int max = 0;
                foreach (Exam s in context.Exams)
                    if (max < s.ID)
                        max = s.ID;
            return max+1;
        }

     

        /// <summary>
        /// Check if difference between start time and end time of exam is bigger than 1 hour </summary>
        /// <value>if the diffrence bigger than 1</value>
        private string Getmail(string name)
        {
                foreach (Person s in context.Person)
                    if (s.F_name + " " + s.L_name == name)
                        return s.Email;
            return "NULL";
        }

        private int classCapacity(string className)
        {
            Classes_SM2 ss = context.Classes_SM2.First(s => s.Class_Id == className);
            return Convert.ToInt32(ss.Capacity);

        }


        private void Exams_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //clean al rows
            foreach (DataGridViewRow row in Exams_Grid.Rows)
            {
                row.Cells["Choose_Course"].Value = false;
            }

            //clean al rows
            foreach (DataGridViewRow row in Students_List.Rows)
            {
                row.Cells["Check"].Value = false;
                cnt = 0;
            }

            foreach (DataGridViewRow srow in Students_List.Rows)
            {
                    srow.ReadOnly = false;
            }

            //check select row
            Exams_Grid.CurrentRow.Cells["Choose_Course"].Value = true;

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
            Exams_Grid.Rows.Clear();
            Exam_List_Reload();
            Students_List.Rows.Clear();
            Students_List_Reload();
            
            
        }

        private void Combo_Class_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Combo_Stud_Type.Text == "All Students")
            {
                Students_List.Rows.Clear();
                Students_List_Reload();
            }
            else if (Combo_Stud_Type.Text == "Have easement")
            {
                Students_List.Rows.Clear();
                Students_Extra_List_Reload();
            }
            else
            {
                Students_List.Rows.Clear();
                Students_Not_Extra_List_Reload();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            context = new Entities();
            int size = 0;

            if (Convert.ToBoolean(Students_List.Rows[e.RowIndex].Cells[2].Value) == false )
            { 
                foreach (DataGridViewRow row in Exams_Grid.Rows)
                    {
                    
                    //MessageBox.Show(Convert.ToBoolean(row.Cells[5].Value).ToString());
                    //MessageBox.Show(Convert.ToBoolean(row.Cells["Choose_Course"].Value).ToString());
                    //if (Convert.ToBoolean(row.Cells["Choose_Course"].Value)==true)
                    //    MessageBox.Show(classCapacity(Convert.ToString(row.Cells["Class"].Value).Substring(0, 4)).ToString()+"\n"+ Convert.ToInt32(row.Cells["Students_Enrolled"].Value).ToString()+"\n"+ cnt);
                    if (Convert.ToBoolean(row.Cells["Choose_Course"].Value) == true)
                    {
                        size = classCapacity(Convert.ToString(row.Cells["Class"].Value).Substring(0, 4)) - Convert.ToInt32(row.Cells["Students_Enrolled"].Value);
                        if (classCapacity(Convert.ToString(row.Cells["Class"].Value).Substring(0, 4)) == Convert.ToInt32(row.Cells["Students_Enrolled"].Value))
                        {
                            foreach (DataGridViewRow srow in Students_List.Rows)
                            {
                                if (Convert.ToBoolean(srow.Cells["Check"].Value) != true)
                                    srow.ReadOnly = true;
                                else
                                    srow.ReadOnly = false;
                            }
                            foreach (DataGridViewRow rowy in Students_List.Rows)
                            {
                                rowy.Cells["Check"].Value = false;
                                cnt = 0;
                            }
                            MessageBox.Show("You cant add more students\nthe class is full.", "Error!");
                        }
                        if ( size == cnt + 1)
                        {

                            foreach (DataGridViewRow srow in Students_List.Rows)
                            {
                                if (Convert.ToBoolean(srow.Cells["Check"].Value) != true)
                                    srow.ReadOnly = true;
                                else
                                    srow.ReadOnly = false;
                            }
                            MessageBox.Show("You choose max students\nif you want another student unselect box.", "Warning!");
                            cnt++;
                            Students_List.Rows[e.RowIndex].Cells[2].ReadOnly = false;
                            return;
                        }
                    }
                }
                if (cnt < size)
                {
                    //Students_List.Rows[e.RowIndex].Cells[2].Value = true;
                    cnt++;
                }
                //MessageBox.Show(cnt.ToString());
                return;
            }
            Students_List.Rows[e.RowIndex].Cells[2].Value = false;
            cnt--;
            if (cnt == size-1)
            {
                foreach (DataGridViewRow srow in Students_List.Rows)
                {

                    srow.ReadOnly = false;
                }
            }
            //MessageBox.Show(cnt.ToString());

        }

        private void newScholarshipBtn_Click(object sender, EventArgs e)
        {
            int ExamID=0;
            int cnt_Add=0;

            foreach (DataGridViewRow row in Exams_Grid.Rows)
            {
                //MessageBox.Show(Convert.ToBoolean(row.Cells["Choose_Course"].Value).ToString());
                if (Convert.ToBoolean(row.Cells["Choose_Course"].Value).ToString() == "True")
                {
                    ExamID = Convert.ToInt32(row.Cells["ID"].Value);
                    break;
                }
            }

            foreach (DataGridViewRow row in Students_List.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Check"].Value) == true)
                        foreach (Student_Courses s in context.Student_Courses)
                        {
                            if (s.stud_Id.Contains(row.Cells["ID"].Value.ToString()))
                            {
                                AddExamToStudents(row.Cells["ID"].Value.ToString(), ExamID);
                                cnt_Add++;
                                break;
                            }                        
                    }
                if (cnt == cnt_Add)
                    break;
            }
                Exam ss = context.Exams.First(s => s.ID == ExamID);
                if (ss != null)
                    ss.Student_Enrolled = cnt_Add+ ss.Student_Enrolled;
                context.SaveChanges();

            Exam_List_Reload();
            MessageBox.Show("Done!");
            return;
        }

        private bool AddExamToStudents(string StudID, int ExamID)
        {
            context = new Entities();
            double a = courseByExam(ExamID);
                Student_Courses ss = context.Student_Courses.FirstOrDefault(s => s.stud_Id == StudID && s.course_id == a && s.Type==1);
                switch (returnDueIn(ExamID))
                {
                    case 1:
                        if(ss.Exam1_ID==null)
                        {
                            ss.Exam1_ID = ExamID;
                            context.SaveChanges();
                            return true;
                        }
                        else
                        {
                            MessageBox.Show(ss.stud_Id+" already registered to exam");
                            return false;
                        }
                    case 2:
                            ss.Exam2_ID = ExamID;
                            context.SaveChanges();
                            return true;
                    case 3:
                            ss.Exam3_ID = ExamID;
                            context.SaveChanges();
                            return true;
                }
            return false;
        }

        private double courseByExam(int ExamID)
        {

            
                Exam ss = context.Exams.First(s => s.ID == ExamID);
                if (ss != null)
                    return ss.Course_ID;

            return 0.0;

        }

        //private int serialByCourse(int CourseID)
        //{
        //    using (Entities context = new Entities())
        //    {
        //        foreach (var s in context.Student_Courses)
        //            if (s.course_id == CourseID)
        //                return Convert.ToInt32(s.course_serial);
        //    }
        //    return 0;
        //}

        //private bool checkEmptyExam(string StudID, int ExamID)
        //{
        //    using (Entities context = new Entities())
        //    {
        //        foreach (var s in context.Student_Courses)
        //            if (s.stud_Id == StudID)
        //            {
        //                switch (returnDueIn(ExamID))
        //                {
        //                    case 1:
        //                        if (s.Exam1_ID == null)
        //                            return true;
        //                        break;
        //                    case 2:
        //                        if (s.Exam2_ID == null)
        //                            return true;
        //                        break;
        //                    case 3:
        //                        if (s.Exam3_ID == null)
        //                            return true;
        //                        break;
        //                }
        //                break;
        //            }
                        
        //    }
        //    return false;
        //}
        private int returnDueIn(int ExamID)
        {           
                Exam ss = context.Exams.First(s => s.ID == ExamID);
                if (ss != null)
                    return Convert.ToInt32(ss.Due_in);
           return 0;
        }

    }
}
