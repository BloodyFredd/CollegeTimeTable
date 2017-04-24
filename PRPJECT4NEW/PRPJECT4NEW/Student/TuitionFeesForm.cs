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
    public partial class TuitionFeesForm : Form
    {
        string Student_ID;
        float approximatedFee = 0;

        public TuitionFeesForm(string ID)
        {
            Student_ID = ID;
            InitializeComponent();
            createGridView();
            getData();
        }

        private void createGridView()
        {
            //Create columns
            tuitionGridView.Columns.Add("courseID", "Course ID");
            tuitionGridView.Columns.Add("courseName", "Course Name");
            tuitionGridView.Columns.Add("nakaz", "Nakaz");
            tuitionGridView.Columns.Add("price", "Price");

            //Paint Headers
            tuitionGridView.ColumnHeadersDefaultCellStyle.BackColor = Constants.menuColor;
            tuitionGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void getData()
        {
            using (MazalEntities context = new MazalEntities())
            {
                //Select cources of a student without final grade 
                var selected =
                    from c in context.Student_Courses where c.stud_Id == Student_ID && c.final_grade == null
                    from i in context.courses where i.Course_id == c.course_id select i;

                foreach (var s in selected)
                {
                    float coursePrice = (float)s.Nakaz * Constants.feePerNakaz;
                    tuitionGridView.Rows.Add(s.Course_id, s.Course_name, s.Nakaz, coursePrice);
                    approximatedFee += coursePrice; //Calculate aproximated Tuition Fee
                }
            }

            totalFeeLabel.Text = "Approximate total tuition Fee for this semester: " + approximatedFee + " NIS";
        }
    }
}
