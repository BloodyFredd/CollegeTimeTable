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
    public partial class Special_Test : Form
    {
        public Special_Test()
        {
            InitializeComponent();
            using (Entities context = new Entities())
            {
                
                var allRowes = context.students.ToList();
                studentspecialExamBindingSource.IsReadOnly.ToString();



            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        //protected void RefreshTB(Entities context)
        //{
        //    //dataGridView1.Rows.Clear();
        //    foreach (var s in context.Student_special_Exam)
        //    {
        //        dataGridView1.Rows.Add(s.ID,s.Course_Serial,s.Date,s.Status);
        //    }
        //    dataGridView1.Refresh();
        //}

        private void button1_Click(object sender, EventArgs e)
        {

        }
        // shoe just the students with approved request of special exam
        private void Special_Test_Load(object sender, EventArgs e)
        {
            using (Entities context = new Entities())
            {
                foreach (var s in context.Student_special_Exam)
                {
                    if(s.Status==true)
                    {
                        // studentspecialExamBindingSource.DataSource = context.Student_special_Exam.ToList();
                        studentspecialExamBindingSource.DataSource =s;
                    }
                }

            }
        }
    }
}
