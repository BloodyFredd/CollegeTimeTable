using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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

                foreach (var s in context.courses)
                    Combo_Course_name.Items.Add(s.Course_name);

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
            dataGridView1.Columns.Add("ID", "Student ID");
            dataGridView1.Columns.Add("Course_Serial", "Course_Serial");
            dataGridView1.Columns.Add("Course_Name", "Course_Name");
            dataGridView1.Columns.Add("Date", "Date");

            //Paint headers
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Utility.HeaderBackColor;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Utility.HeaderBackColor;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.AutoResizeColumns();

            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            using (Entities context = new Entities())
            {
                int i = 0;
                foreach (var s in context.Student_special_Exam)
                {
                    if (s.Status == true)
                    {
                        studentspecialExamBindingSource.DataSource = s;

                        foreach (var v in context.courses)
                        {
                            if (s.Course_Serial.ToString().Contains(v.Course_id.ToString()))
                            {
                                dataGridView1.Rows.Add(s.ID, s.Course_Serial, v.Course_name, s.Date);
                            }
                        }
                        i++;
                    }
                }
                dataGridView1.Refresh();
            }
        }

        private void Combo_Course_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (Entities context = new Entities())
            {
                foreach (var s in context.Student_special_Exam)
                {
                    if (Combo_Course_name.Text == null)
                    {
                        if (s.Status == true)
                        {
                            studentspecialExamBindingSource.DataSource = s;
                        }
                    }
                    else
                    {
                        foreach (var v in context.courses)
                        {
                            if (Combo_Course_name.Text == v.Course_name)
                            {
                                dataGridView1.Rows.Clear();
                                dataGridView1.Rows.Add(s.ID, s.Course_Serial, v.Course_name, s.Date);
                            }
                        }
                    }
                }
                dataGridView1.Refresh();
            }
        }
    }
}

