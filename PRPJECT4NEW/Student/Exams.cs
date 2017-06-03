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
        List<Student_special_Exam> specialExams = new List<Student_special_Exam>();
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
                from se in specialExams 
                from c in courses where se.Course_Serial == c.course_serial
                from cd in courseDetails where c.course_id == cd.Course_id
                select cd.Course_name;

            foreach (cours course in courseDetails)
            {
                if (!examsComboBox.Items.Contains(course.Course_name) && !selected.Contains(course.Course_name)) examsComboBox.Items.Add(course.Course_name);
            }
        }

        //Get all Specia Exams intended to student
        private List<Student_special_Exam> getSpecialExams(Entities context)
        {
            var selected =
                from e in context.Student_special_Exam where e.ID == studentUsr.ID
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
            specialExamGridView.Columns.Add("Data", "Date");
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
            foreach (Student_special_Exam exam in specialExams)
            {
                double courseID = courses.First(c => c.course_serial == exam.Course_Serial).course_id;
                string courseName = courseDetails.First(course => course.Course_id == courseID).Course_name.ToString();
                // string courseName = courseDetails.First(course => course.Course_id == courses.First(c => c.course_serial == exam.Course_Serial).course_id).Course_name.ToString();
                specialExamGridView.Rows.Add(courseName, exam.Course_Serial ,exam.Date, exam.Status);
            }
        }

        //Send Special exam request
        private void sendRequestBtn_Click(object sender, EventArgs e)
        {
            int courseID = courseDetails.First(c => examsComboBox.Text == c.Course_name).Course_id;
            int courseSerial = courses.First(c => c.course_id == courseID && c.Type == 1).course_serial.Value;

            using (Entities context = new Entities())
            {
                Student_special_Exam newRequest = new Student_special_Exam
                {
                    ID = studentUsr.ID,
                    Course_Serial = courseSerial,
                    Date = null,
                    Status = "Pending"
                };
                context.Student_special_Exam.Add(newRequest);
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
