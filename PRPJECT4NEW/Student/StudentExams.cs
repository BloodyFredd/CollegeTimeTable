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
    public partial class StudentExams : Form
    {
        List<Exam> exams = new List<Exam>();
        List<Student_Courses> courses = new List<Student_Courses>();
        List<cours> courseDetails = new List<cours>();

        public student studentUsr;

        public StudentExams(student _studentUsr)
        {
            InitializeComponent();
            studentUsr = _studentUsr;
            createDataGridView();

            using (Entities context = new Entities())
            {
                getExams(context);
                getCourseDeatails(context);
            }

            insertExamsToGrid();
        }

        private void createDataGridView()
        {
            //Create headers
            examGridView.Columns.Add("Course", "Course");
            examGridView.Columns.Add("Date", "Date");
            examGridView.Columns.Add("Time", "Time");
            examGridView.Columns.Add("Class", "Class");

            //Paint headers
            examGridView.ColumnHeadersDefaultCellStyle.BackColor = Utility.HeaderBackColor;
            examGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            examGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            examGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            foreach (DataGridViewColumn column in examGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }

        //Get all Exams intended to student
        private void getExams(Entities context)
        {
            var selected =
                from sc in context.Student_Courses where sc.stud_Id == studentUsr.ID && sc.Type == 1
                from ex in context.Exams where ex.Course_ID == sc.course_id
                select ex;

            exams = selected.ToList();
        }

        //Get Courses deatails
        private void getCourseDeatails(Entities context)
        {
            var selected =
                from c in context.courses where c.Year <= studentUsr.Year
                select c;

            courseDetails = selected.ToList();
        }



        //Insert  Exams to grid
        private void insertExamsToGrid()
        {
            foreach (Exam e in exams)
            {
                string courseName = courseDetails.First(course => course.Course_id == e.Course_ID).Course_name.ToString();
                examGridView.Rows.Add(courseName, e.Date, e.Start_Time + "-" + e.End_Time, e.Class);
            }
        }



    }
}
