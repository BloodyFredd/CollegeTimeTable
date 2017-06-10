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
    public partial class UpdateCalendar : Form
    {
        List<int> courseList = new List<int>();
        List<cours> openCourses = new List<cours>();
        List<Lecture_Course> enrolledLectures = new List<Lecture_Course>();
        List<Lecture_Course> openLectures = new List<Lecture_Course>();
        List<Lecture_Course> selectedCourse = new List<Lecture_Course>();
        List<Lecture_Course> choosen = new List<Lecture_Course>();
        bool lectureOverlapp = false;
        bool practiceOverlap = false;
        bool labOverlap = false;

        public UpdateCalendar()
        {
            InitializeComponent();
            CreateGridView();
            reloadData();
            fillGridView(enrolledLectures, Color.Gray);
        }

        private void CreateGridView()
        {
            //Create headers
            calendarGridView.Columns.Add("Time", "");
            calendarGridView.Columns.Add("Sunday", "Sunday");
            calendarGridView.Columns.Add("Monday", "Monday");
            calendarGridView.Columns.Add("Tuesday", "Tuesday");
            calendarGridView.Columns.Add("Wednesday", "Wednesday");
            calendarGridView.Columns.Add("Thursday", "Thursday");
            calendarGridView.Columns.Add("Friday", "Friday");

            courseGridView.Columns.Add("Title", "");
            courseGridView.Columns.Add("Fact", "");

            lectureGridView.Columns.Add("Title", "");
            lectureGridView.Columns.Add("Fact", "");

            //Course Grid View Rows 
            courseGridView.Rows.Add("Course ID:");
            courseGridView.Rows.Add("Nakaz:");
            courseGridView.Rows.Add("Year:");
            courseGridView.Rows.Add("Semester:");
            courseGridView.Rows.Add("Blocking Course:");

            //Lecture Grid View Rows
            lectureGridView.Rows.Add("Course Serial:");
            lectureGridView.Rows.Add("Type:");
            lectureGridView.Rows.Add("Teacher:");
            lectureGridView.Rows.Add("Time:");


            clearDataGridView();
        }

        //Get slected course information and place it into DataGridView and ListBox
        private void courseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected =
                from oc in openCourses where oc.Course_name == courseComboBox.Text
                from sl in openLectures where sl.Course_ID == oc.Course_id
                select sl;

            selectedCourse = selected.ToList();

            SignBtn.Enabled = true;
            if ( enrolledLectures.Any(item => selectedCourse.Contains(item))) UnsignBtn.Enabled = true;
            else UnsignBtn.Enabled = false;

            choosen.Clear();
            fillListBoxes();

            clearDataGridView();
            fillInfoGridView();
            fillGridView(enrolledLectures.Except(selectedCourse).ToList(), Color.Gray);
        }

        //Place each Course into DataGridView
        private void fillGridView(List<Lecture_Course> courses, Color fillColor)
        {
            foreach (var s in courses)
            {
                cours course = openCourses.FirstOrDefault(c => c.Course_id == s.Course_ID);

                string overlappingCourse = "";
                for (int i = s.Start_time; i < s.End_time; i++)
                {
                    string column = s.Date.Trim();
                    int row = i - 8;

                    calendarGridView.Rows[row].Cells[column].Style.ForeColor = Color.White; //Font Color

                    //Check overlapping courses
                    overlappingCourse = checkForOverlappingCourse(s, i);

                    if (overlappingCourse != "")
                    {
                        calendarGridView.Rows[row].Cells[column].Style.BackColor = Color.Red; //Paint overlapping cell
                        calendarGridView.Rows[row].Cells[column].Value = overlappingCourse + "/" + course.Course_name.Trim();   //Print data to cell
                    }
                    else
                    {
                        //Print name only in first row
                        calendarGridView.Rows[row].Cells[column].Style.BackColor = fillColor; //Paint cell
                        if (i - s.Start_time <= 0) calendarGridView.Rows[row].Cells[column].Value = course.Course_name.Trim();   //Print data to cell
                        else calendarGridView.Rows[row].Cells[column].Value = "";
                    }                            
                } 
            } 
        }

        //Get name of overlapping Course. Returns "" if don't exists
        private string checkForOverlappingCourse(Lecture_Course check, int time)
        {
            string overlappingCourse = "";
            foreach (Lecture_Course course in enrolledLectures)
            {
                if ((course.Date == check.Date) && !enrolledLectures.Contains(check))
                {
                    if (time >= course.Start_time && time < course.End_time)
                    {
                        overlappingCourse = (openCourses.First(c => c.Course_id == course.Course_ID)).Course_name.Trim();
                        //Debug.WriteLine(course.Date + ": " + course.Start_time + " " + course.End_time + " : " + time + " " + overlappingCourse);
                        switch (check.Course_type)
                        {
                            case 1:
                                lectureOverlapp = true;
                                break;
                            case 2:
                                practiceOverlap = true;
                                break;
                            case 3:
                                labOverlap = true;
                                break;
                            default:
                                Debug.WriteLine("No such Course Type! Check Data Base!");
                                break;
                        }
                        return overlappingCourse;
                    }
                } 
            }
            switch (check.Course_type)
            {
                case 1:
                    lectureOverlapp = false;
                    break;
                case 2:
                    practiceOverlap = false;
                    break;
                case 3:
                    labOverlap = false;
                    break;
                default:
                    Debug.WriteLine("No such Course Type! Check Data Base!");
                    break;
            }
            return overlappingCourse;
        }

        private void fillListBoxes()
        {
            lecturesListBox.Items.Clear();
            practicesListBox.Items.Clear();
            labsListBox.Items.Clear();

            foreach (Lecture_Course lecture in selectedCourse)
            {
                switch (lecture.Course_type)
                {
                    case 1:
                        lecturesListBox.Items.Add(lecture.Course_Serial);
                        break;
                    case 2:
                        practicesListBox.Items.Add(lecture.Course_Serial);
                        break;
                    case 3:
                        labsListBox.Items.Add(lecture.Course_Serial);
                        break;
                    default:
                        Debug.WriteLine("No such Course Type! Check Data Base!");
                        break;
                }
            }
        }

        private void reloadData()
        {
            using (Entities context = new Entities())
            {
                getOpenCourses(context);
                getEnrolledLectures(context);
                getOpenLectures(context);
            }
        }

        private void getOpenCourses(Entities context)
        {
            //Select open courses to student
            var selected =
              (from s in context.students where s.ID == Utility.User.ID.ToString()                                     //Find Student 
               from sc in context.Student_Courses where sc.final_grade > 55 && sc.stud_Id == s.ID && sc.Type == 1      //Passed Courses
               from c in context.courses where c.Year <= s.Year && c.Semester == Utility.semester && (c.Blocking_Cource == null || c.Blocking_Cource == sc.course_id) //Get all relevant courses
               select c).Distinct();

            //Place each Course into List
            foreach (var s in selected)
            {
                courseComboBox.Items.Add(s.Course_name);
            }
            openCourses = selected.ToList();
        }

        private void getEnrolledLectures(Entities context)
        {
            //Select cources of a student without final grade for current year
            var selected =
                from c in context.Student_Courses where c.stud_Id == Utility.User.ID.ToString() && c.final_grade == null
                from i in context.Lecture_Course where i.Course_ID == c.course_id
                select i;

            enrolledLectures = selected.ToList();
        }

        private void getOpenLectures(Entities context)
        {
            //Select Lectures of a student without final grade for current year
            var selected =
                from oc in openCourses
                from ol in context.Lecture_Course where ol.Course_ID == oc.Course_id
                select ol;

            openLectures = selected.ToList();
        }

        private void clearDataGridView()
        {
            calendarGridView.Rows.Clear();
            lectureGridView.Rows.Clear();

            //Calendar Grid View
            for (int i = 8; i <= 23; i++)
            {
                calendarGridView.Rows.Add(i + ":00");
            }

            //Preent Sorting
            foreach (DataGridViewColumn column in calendarGridView.Columns)
            {
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //Calendar Grid View Paint headers
            calendarGridView.Columns[0].DefaultCellStyle.BackColor = Utility.HeaderBackColor;
            calendarGridView.Columns[0].DefaultCellStyle.ForeColor = Color.White;
            calendarGridView.ColumnHeadersDefaultCellStyle.BackColor = Utility.HeaderBackColor;
            calendarGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            //Course Grid View Paint headers
            courseGridView.Columns[0].DefaultCellStyle.BackColor = Utility.HeaderBackColor;
            courseGridView.Columns[0].DefaultCellStyle.ForeColor = Color.White;
            courseGridView.ColumnHeadersDefaultCellStyle.BackColor = Utility.HeaderBackColor;
            courseGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            //Lecture Grid View Paint headers
            lectureGridView.Columns[0].DefaultCellStyle.BackColor = Utility.HeaderBackColor;
            lectureGridView.Columns[0].DefaultCellStyle.ForeColor = Color.White;
            lectureGridView.ColumnHeadersDefaultCellStyle.BackColor = Utility.HeaderBackColor;
            lectureGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            calendarGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            calendarGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            foreach (DataGridViewRow row in calendarGridView.Rows)
            {
                row.Height = 25;
            }

            calendarGridView.Refresh();
            courseGridView.Refresh();
            lectureGridView.Refresh();
        }

        //Get Choosen lecture from ListBox
        private void lecturesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine(lecturesListBox.SelectedIndex);
            int lecture = Int32.Parse(lecturesListBox.Items[lecturesListBox.SelectedIndex].ToString());
            refreshChoosen(lecture, 1);
        }

        //Get Choosen practice from ListBox
        private void practicesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int practice = Int32.Parse(practicesListBox.Items[practicesListBox.SelectedIndex].ToString());
            refreshChoosen(practice, 2);
        }

        //Get Choosen lab from ListBox
        private void labsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int lab = Int32.Parse(labsListBox.Items[labsListBox.SelectedIndex].ToString());
            refreshChoosen(lab, 3);
        }

        //Refresh and display choosen courses in Data grid view
        private void refreshChoosen(int course_Serial, int course_type)
        {
            //Remove previously choosen course
            foreach (Lecture_Course lc in choosen.ToList())
            {
                if (lc.Course_type == course_type)
                {
                    choosen.Remove(lc);
                    clearDataGridView();
                }
            }

            choosen.Add(openLectures.First(c => c.Course_Serial == course_Serial && c.Course_type == course_type));


           // fillCourseGridView(course_Serial, course_type);
            fillGridView(enrolledLectures.Except(selectedCourse).ToList(), Color.Gray);
            fillGridView(choosen, Color.Blue);
        }

        private void SignBtn_Click(object sender, EventArgs e)
        {
            //Check if necessary items selected
            if (lecturesListBox.Items.Count > 0 && lecturesListBox.SelectedIndex == -1 || 
                practicesListBox.Items.Count > 0 && practicesListBox.SelectedIndex == -1 ||
                labsListBox.Items.Count > 0 && labsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Unable to Sign. Select at least one Lecture, Practice, Lab (if available)", "Wrong selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (lectureOverlapp || practiceOverlap || labOverlap)
            {
                MessageBox.Show("Overlapping courses!", "Wrong selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

      
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to sign to " + courseComboBox.Text.Trim() + "?", "Sign", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                using (Entities context = new Entities())
                {
                    //Delete previous if existed 
                    foreach (Lecture_Course c in selectedCourse)
                    {
                        Student_Courses course = context.Student_Courses.FirstOrDefault(x => x.course_id == c.Course_ID && x.stud_Id == Utility.User.ID);
                        if (course != null) context.Student_Courses.Remove(course);
                    }
                    //Sign to new one
                    foreach (Lecture_Course lc in choosen)
                    {
                        Student_Courses sc = new Student_Courses
                        {
                            stud_Id = Utility.User.ID, course_id = lc.Course_ID,
                            grade_a = null, grade_b = null, grade_c = null, quiz1 = null, quiz2 = null,
                            final_grade = null, Type = lc.Course_type, course_serial = lc.Course_Serial,
                            Exam1_ID = null, Exam2_ID = null, Exam3_ID = null
                        };
                        context.Student_Courses.Add(sc);
                    }
                    context.SaveChanges();
                }
                MessageBox.Show("You signed to " + courseComboBox.Text.Trim() + "!");
                clearAll();
            }
        }

        private void UnsignBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to unsign from " + courseComboBox.Text.Trim() + "?", "Unsign", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                using (Entities context = new Entities())
                {
                    foreach (Lecture_Course c in selectedCourse)
                    {
                        Debug.WriteLine(c.Course_ID);
                        Student_Courses course = context.Student_Courses.FirstOrDefault(x => x.course_id == c.Course_ID && x.stud_Id == Utility.User.ID && c.Course_type == x.Type);
                        context.Student_Courses.Remove(course); 
                    }
                    context.SaveChanges();
                }
                MessageBox.Show("You unsigned from " + courseComboBox.Text.Trim() + "!");
                clearAll();
            }
        }

        private void clearAll()
        {
            courseComboBox.Items.Clear();
            lecturesListBox.Items.Clear();
            practicesListBox.Items.Clear();
            labsListBox.Items.Clear();
            reloadData();
            fillGridView(enrolledLectures, Color.Gray);
        }

        private void fillInfoGridView()
        {
            cours selected =
                (from sc in selectedCourse
                from oc in openCourses where oc.Course_id == sc.Course_ID
                select oc).FirstOrDefault();

            courseGridView.Rows[0].Cells["Fact"].Value = selected.Course_id;
            courseGridView.Rows[1].Cells["Fact"].Value = selected.Nakaz;
            courseGridView.Rows[2].Cells["Fact"].Value = selected.Year;
            courseGridView.Rows[3].Cells["Fact"].Value = selected.Semester;
            courseGridView.Rows[4].Cells["Fact"].Value = selected.Blocking_Cource;
        }

        private void fillCourseGridView(int course_Serial, int course_type)
        {
            Lecture_Course selected =
            (from sc in selectedCourse
             from oc in openCourses where oc.Course_id == sc.Course_ID
             from ol in openLectures where ol.Course_ID == oc.Course_id && ol.Course_Serial == course_Serial && ol.Course_type == course_type
            select ol).FirstOrDefault();

            string type = "";
          //  string teacher = .First(c => c.Course_Serial == course_Serial && c.Course_type == course_type))

            switch (course_type) {
                case 1:
                    type = "Lecture";
                    break;
                case 2:
                    type = "Practice";
                    break;
                case 3:
                    type = "Lab";
                    break;
                default:
                    Debug.WriteLine("Wrong course_type parameter check Data Base");
                    break;
            }

            lectureGridView.Rows[0].Cells["Fact"].Value = course_Serial;
            lectureGridView.Rows[1].Cells["Fact"].Value = type;
            // lectureGridView.Rows[2].Cells["Fact"].Value = selected.Year;
            lectureGridView.Rows[3].Cells["Fact"].Value = selected.Date + " " + selected.Start_time + " - " + selected.End_time;
         
        }
    }
}
