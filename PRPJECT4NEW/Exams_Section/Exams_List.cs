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
    public partial class Exams_List : Form
    {
        public Exams_List()
        {
            InitializeComponent();
            Exams_List_Load();
        }

        private void Exams_List_Load()
        {

            //Create Columns
            Exams_Grid.Columns.Add("ID", "ID");
            Exams_Grid.Columns.Add("Course_Name", "Course Name");
            Exams_Grid.Columns.Add("Start_Time", "Start Time");
            Exams_Grid.Columns.Add("End_Time", "End Time");
            Exams_Grid.Columns.Add("Class", "Class");
            Exams_Grid.Columns.Add("Superviser1_ID", "First Superviser ID");
            Exams_Grid.Columns.Add("Superviser2_ID", "Second Superviser ID");
            Exams_Grid.Columns.Add("Students_Enrolled", "Students Enrolled");
            Exams_Grid.Columns.Add("Date", "Date");

            //Paint headers
            Exams_Grid.EnableHeadersVisualStyles = false;
            //Conferences_Grid.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
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
                    Exams_Grid.Rows.Add(s.ID, getCourseName(s.Course_ID), s.Start_Time + ":00", s.End_Time + ":00", s.Class, s.Superviser1_ID, s.Superviser2_ID, s.Student_Enrolled, s.Date.ToShortDateString());
                }

                //Conferences_Grid.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
                //Conferences_Grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;
                Exams_Grid.Refresh();
            }
            //Exams_Grid.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

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


    }
}
