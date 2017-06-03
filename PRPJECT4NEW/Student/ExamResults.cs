using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace PRPJECT4NEW.Student
{
    public partial class ExamResults : Form
    {
        List<Student_Courses> studentLectures = new List<Student_Courses>();
        List<cours> studentCourses = new List<cours>();
        List<Student_Courses> choosenCourses = new List<Student_Courses>();

        public student studentUsr;

        public ExamResults(student _studentUsr)
        {
            InitializeComponent();
            studentUsr = _studentUsr;
            fillDataGridView();
            using (Entities context = new Entities())
            {
                studentLectures = getStudentLectures(context);
                studentCourses = getStudentCourses(context);
            }
        }

        private void courseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedYear = Int32.Parse(courseComboBox.Text);

            var selected =
                from c in studentCourses
                from sl in studentLectures where sl.course_id == c.Course_id && c.Year == selectedYear
                select sl;

            choosenCourses = selected.ToList();

            ExamResultDataGridView.Rows.Clear();
            ExamResultDataGridView.Refresh();

            insertCourseExamResults();
        }


        private void fillDataGridView()
        {
            //Create headers
            ExamResultDataGridView.Columns.Add("Course", "Course");
            ExamResultDataGridView.Columns.Add("ID", "ID");
            ExamResultDataGridView.Columns.Add("Nakaz", "Nakaz");
            ExamResultDataGridView.Columns.Add("Quiz_1", "Quiz 1");
            ExamResultDataGridView.Columns.Add("Quiz_2", "Quiz 2");
            ExamResultDataGridView.Columns.Add("Grade_A", "Grade A");
            ExamResultDataGridView.Columns.Add("Grade_B", "Grade B");
            ExamResultDataGridView.Columns.Add("Grade_C", "Grade C");
            ExamResultDataGridView.Columns.Add("Final_Grade", "Final Grade");

            //Print Sorting
            foreach (DataGridViewColumn column in ExamResultDataGridView.Columns)
            {
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //Paint headers
            ExamResultDataGridView.Columns[0].DefaultCellStyle.BackColor = Utility.HeaderBackColor;
            ExamResultDataGridView.Columns[0].DefaultCellStyle.ForeColor = Color.White;
            ExamResultDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Utility.HeaderBackColor;
            ExamResultDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            ExamResultDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ExamResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }

        private void insertCourseExamResults()
        {
            foreach (Student_Courses i in choosenCourses)
            {
                Debug.WriteLine(i.course_id);
                cours tempCourse = studentCourses.First(course => course.Course_id == i.course_id);
                string courseName = tempCourse.Course_name;
                string Nakaz = tempCourse.Nakaz.ToString();

                ExamResultDataGridView.Rows.Add(courseName, i.course_id, Nakaz, i.quiz1, i.quiz2, i.grade_a, i.grade_b, i.grade_c, i.final_grade);
            }
        }

        //Get all student lectures with grades
        private List<Student_Courses> getStudentLectures(Entities context)
        {
            var selected =
                from sc in context.Student_Courses where (studentUsr.ID == sc.stud_Id && sc.Type == 1)
                select sc;
     
            Debug.WriteLine(selected.Count());

            return selected.ToList();
        }

        //Get student courses
        private List<cours> getStudentCourses(Entities context)
        {
            var selected =
                from sl in studentLectures
                from c in context.courses where c.Course_id == sl.course_id
                select c;

            //Inser year only Once
            foreach (cours c in selected)
            {
                if (!courseComboBox.Items.Contains(c.Year)) courseComboBox.Items.Add(c.Year);
            }
            return selected.ToList();
        }

    }
}
