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
    public partial class Requests : Form
    {
        public student studentUsr;
        List<student_request> requests = new List<student_request>();
        List<student_request> specialExams = new List<student_request>();
        List<Student_Courses> courses = new List<Student_Courses>();
        List<cours> courseDetails = new List<cours>();

        public Requests(student _studentUsr)
        {
            InitializeComponent();
            studentUsr = _studentUsr;
            fillDataGridView();
            getRequests();
            insertRequestsToGrid();

            studentUsr = _studentUsr;
            fillExamDataGridView();

            using (Entities context = new Entities())
            {
                specialExams = getSpecialExams(context);
                courses = getCourses(context);
                courseDetails = getCourseDeatails(context);
            }

            fillComboBox();
            insertExamsToGrid();
        }


        //Get all messages intended to student
        private void getRequests()
        {
            using (Entities context = new Entities())
            {
                var selected =
                    from r in context.student_request where r.ID == studentUsr.ID
                    select r;
                requests = selected.ToList();
            } 
        }

        private void fillDataGridView()
        {
            //Create headers
            requestsGridView.Columns.Add("Subject", "Subject");
            requestsGridView.Columns.Add("Message", "Message");
            requestsGridView.Columns.Add("Status", "Status");

            //Paint headers
            requestsGridView.ColumnHeadersDefaultCellStyle.BackColor = Utility.HeaderBackColor;
            requestsGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            requestsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            requestsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            foreach (DataGridViewColumn column in requestsGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        //Insert request to grid
        private void insertRequestsToGrid()
        {
            foreach (student_request request in requests)
            {
                requestsGridView.Rows.Add(request.Subject, request.Message, request.Status);
            }
        }

        public student_request newRequest()
        {
            student_request newRequest = new student_request
            {
                ID = studentUsr.ID,
                Subject = subjectTextBox.Text,
                Message = messageTextBox.Text,
                Status = "Pending"
            };

            return newRequest;
        }

        //Send request
        private void sendRequestBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(subjectTextBox.Text))
            {
                MessageBox.Show("Empty subject field", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else if (string.IsNullOrWhiteSpace(messageTextBox.Text))
            {
                MessageBox.Show("Empty Message", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else
            {
                using (Entities context = new Entities())
                {
                    context.student_request.Add(newRequest());
                    context.SaveChanges();
                }

                //Reload data grid view 
                requestsGridView.Rows.Clear();
                requestsGridView.Refresh();
                getRequests();
                insertRequestsToGrid();
            }
        }



        //Fill comboBox with courses
        private void fillComboBox()
        {
            examsComboBox.Items.Clear();
            examsComboBox.ResetText();

            var selected =
                from c in courses
                from cd in courseDetails
                where c.course_id == cd.Course_id
                select cd.Course_name;

            foreach (var course in selected)
            {
                if (!examsComboBox.Items.Contains(course)) examsComboBox.Items.Add(course);
            }

        }

        //Get all Special Exams intended to student
        private List<student_request> getSpecialExams(Entities context)
        {
            var selected =
                from e in context.student_request
                where e.ID == studentUsr.ID && e.Subject == "Special Exam"
                select e;

            return selected.ToList();
        }


        //Get all Courses intended to student
        private List<Student_Courses> getCourses(Entities context)
        {
            var selected =
                from sc in context.Student_Courses
                where sc.stud_Id == studentUsr.ID
                select sc;

            return selected.ToList();
        }

        //Get Courses deatails
        private List<cours> getCourseDeatails(Entities context)
        {
            var selected =
                from c in context.courses
                where c.Year <= studentUsr.Year
                select c;

            return selected.ToList();
        }


        private void fillExamDataGridView()
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


        public student_request newExamRequest()
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
        private void sendExamRequestBtn_Click(object sender, EventArgs e)
        {
            using (Entities context = new Entities())
            {
                context.student_request.Add(newExamRequest());
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
