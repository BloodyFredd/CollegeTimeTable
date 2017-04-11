using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRPJECT4NEW.Student
{
    public partial class Calendar : Form
    {

        string Student_ID;

        public Calendar(string Student_ID)
        {
            this.Student_ID = Student_ID;
            InitializeComponent();
            CreateGridView();
            getData();
        }

        private void getData()
        {
            using (MazalEntities context = new MazalEntities())
            {
                //Select cources of a student without final grade for current year
                var selected =
                    from c in context.Student_Courses where c.student_id == Student_ID && c.final_grade == null
                    from i in context.Course_detail where i.Course_id.ToString() == c.course_id && i.Year == DateTime.Now.Year select i;

                //Place each Course into DataGridView
                foreach (var s in selected)
                {
                    cours course = context.courses.FirstOrDefault(c => c.Course_id == s.Course_id);
                    for (int i = s.Start_time; i < s.End_time; i++)
                    {
                        this.calendarGridView.Rows[i - 8].Cells[s.Day.Trim()].Value = course.Course_name;
                        this.calendarGridView.Rows[i - 8].Cells[s.Day.Trim()].Style.BackColor = Color.AliceBlue;
                    }
                    
                }
            }
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
            for (int i = 8; i <= 23; i++){
                calendarGridView.Rows.Add(i + ":00");
            }

            //Preent Sorting
            foreach (DataGridViewColumn column in calendarGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //Paint headers
            calendarGridView.Columns[0].DefaultCellStyle.BackColor = Constants.menuColor;
            calendarGridView.Columns[0].DefaultCellStyle.ForeColor = Color.White;
            calendarGridView.ColumnHeadersDefaultCellStyle.BackColor = Constants.menuColor;
            calendarGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void calendarGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            if (e.RowIndex < 1 || e.ColumnIndex < 0)
                return;
            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            }
            else
            {
                e.AdvancedBorderStyle.Top = calendarGridView.AdvancedCellBorderStyle.Top;
            }
        }

        bool IsTheSameCellValue(int column, int row)
        {
            DataGridViewCell cell1 = calendarGridView[column, row];
            DataGridViewCell cell2 = calendarGridView[column, row - 1];
            if (cell1.Value == null || cell2.Value == null)
            {
                return false;
            }
            return cell1.Value.ToString() == cell2.Value.ToString();
        }

        private void calendarGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == 0)
                return;
            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                e.Value = "";
                e.FormattingApplied = true;
            }
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            calendarGridView.AutoGenerateColumns = false;
        }
    }
}
