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

namespace PRPJECT4NEW.Student
{
    public partial class Exams : Form
    {
        List<student_request> specialExams = new List<student_request>();
        List<Student_Courses> courses = new List<Student_Courses>();
        List<cours> courseDetails = new List<cours>();

        public student studentUsr;

        public Exams(student _studentUsr)
        {
            InitializeComponent();
            studentUsr = _studentUsr;
            fillDataGridView();
            using (Entities context = new Entities())
            {
                specialExams = getSpecialExams(context);
                courses = getCourses(context);
                courseDetails = getCourseDeatails(context);
            }

            fillComboBox();
            insertExamsToGrid();
        }

        //Fill comboBox with courses
        private void fillComboBox()
        {
            examsComboBox.Items.Clear();
            examsComboBox.ResetText();

            var selected = 
                from c in courses 
                from cd in courseDetails where c.course_id == cd.Course_id
                select cd.Course_name;

            foreach (var course in selected)
            {
                Debug.WriteLine(course);
            }

            foreach (cours course in courseDetails)
            {
                if (!examsComboBox.Items.Contains(course.Course_name)) examsComboBox.Items.Add(course.Course_name);
                //  if (!examsComboBox.Items.Contains(course.Course_name) && !selected.Contains(course.Course_name)) examsComboBox.Items.Add(course.Course_name);
            }
        }

        //Get all Special Exams intended to student
        private List<student_request> getSpecialExams(Entities context)
        {
            var selected =
                from e in context.student_request where e.ID == studentUsr.ID && e.Subject == "Special Exam"
                select e;

            return selected.ToList();
        }


        //Get all Courses intended to student
        private List<Student_Courses> getCourses(Entities context)
        {
            var selected =
                from sc in context.Student_Courses where sc.stud_Id == studentUsr.ID 
                select sc;

            return selected.ToList();
        }

        //Get Courses deatails
        private List<cours> getCourseDeatails(Entities context)
        {
            var selected =
                from sc in courses
                from c in context.courses where c.Course_id == sc.course_id
                select c;

            return selected.ToList();
        }


        private void fillDataGridView()
        {
            //Create headers
            specialExamGridView.Columns.Add("Course", "Course");
            specialExamGridView.Columns.Add("Serial", "Serial");
            specialExamGridView.Columns.Add("Status", "Status");

            //Paint headers
            specialExamGridView.ColumnHeadersDefaultCellStyle.BackColor = Utility.HeaderBackColor;
            specialExamGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            specialExamGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            specialExamGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            foreach (DataGridViewColumn column in specialExamGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }

        //Insert Specia Exams to grid
        private void insertExamsToGrid()
        {
            foreach (student_request request in specialExams)
            {
                string courseName = courseDetails.First(course => course.Course_id == request.Course_ID).Course_name.ToString();
                specialExamGridView.Rows.Add(courseName, request.Course_ID, request.Status);
            }
        }


        public student_request newRequest()
        {
            int courseID = courseDetails.First(c => examsComboBox.Text == c.Course_name).Course_id;

            student_request request = new student_request
            {
                ID = studentUsr.ID,
                Subject = "Special Exam",
                Message = reasonTextBox.Text,
                Status = "Pending",
                Course_ID = courseID
            };

            return request;
        }

        //Send Special exam request
        private void sendRequestBtn_Click(object sender, EventArgs e)
        {
            using (Entities context = new Entities())
            {
                context.student_request.Add(newRequest());
                context.SaveChanges();
                specialExams = getSpecialExams(context);
            }

            //Reload data grid view 
            specialExamGridView.Rows.Clear();
            specialExamGridView.Refresh();
            insertExamsToGrid();
            fillComboBox();
        }

    }
}
