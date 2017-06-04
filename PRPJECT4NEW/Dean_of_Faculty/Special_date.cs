//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace PRPJECT4NEW.Dean_of_Faculty
//{
//    public partial class Special_date : Form
//    {
//        public Special_date()
//        {
//            InitializeComponent();
//            special_date_combobox.Items.Add("Open");
//            special_date_combobox.Items.Add("Postponed");
//            special_date_combobox.Items.Add("Approved");
//            special_date_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
//        }

//        private void Special_date_Load(object sender, EventArgs e)
//        {
//            dataGridView1.Columns.Add("ID", "Student ID");
//            dataGridView1.Columns.Add("Course_Serial", "Course_Serial");
//            dataGridView1.Columns.Add("Course_Name", "Course_Name");
//            dataGridView1.Columns.Add("Date", "Date");
//            dataGridView1.Columns.Add("Status", "Status");

//            //Paint headers
//            dataGridView1.EnableHeadersVisualStyles = false;
//            dataGridView1.GridColor = Utility.HeaderBackColor;
//            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Utility.HeaderBackColor;
//            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
//            dataGridView1.AutoResizeColumns();

//            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
//            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

//            using (Entities context = new Entities())
//            {
//                foreach (var s in context.Student_special_Exam)
//               {

//                    studentspecialExamBindingSource.DataSource = s;

//                    foreach (var v in context.courses)
//                    {
//                        if (s.Course_Serial.ToString().Contains(v.Course_id.ToString()))
//                        {
//                            dataGridView1.Rows.Add(s.ID, s.Course_Serial, v.Course_name, s.Date,s.Status);
//                        }
//                    }

//                }

//            }
//        }

//        private void special_date_combobox_SelectedIndexChanged(object sender, EventArgs e)
//        {

//            using (Entities context = new Entities())
//            {
//                dataGridView1.Rows.Clear();
//                foreach (var s in context.Student_special_Exam)
//                {
//                    foreach (var v in context.courses)
//                    {
//                        if (s.Course_Serial.ToString().Contains(v.Course_id.ToString()))
//                        {
//                            if (special_date_combobox.Text == "Open")
//                            {
//                                if (s.Status == "Open")
//                                {
//                                    studentspecialExamBindingSource.DataSource = s;
//                                    dataGridView1.Rows.Add(s.ID, s.Course_Serial, v.Course_name, s.Date, s.Status);
//                                }
//                            }
//                            else if (special_date_combobox.Text == "Postponed")
//                            {
//                                if (s.Status == "Denied")
//                                {
//                                    studentspecialExamBindingSource.DataSource = s;
//                                    dataGridView1.Rows.Add(s.ID, s.Course_Serial, v.Course_name, s.Date, s.Status);
//                                }
//                            }
//                            else
//                            {
//                                if (s.Status == "Approved")
//                                {
//                                    studentspecialExamBindingSource.DataSource = s;
//                                    dataGridView1.Rows.Add(s.ID, s.Course_Serial, v.Course_name, s.Date, s.Status);
//                                }
//                            }
//                            break;
//                        }
//                    }
//                }
//            }

//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRPJECT4NEW.Dean_of_Faculty
{
    public partial class Special_date : Form
    {
        public Special_date()
        {
            InitializeComponent();
            special_date_combobox.Items.Add("Pending");
            special_date_combobox.Items.Add("Postponed");
            special_date_combobox.Items.Add("Approved");
            special_date_combobox.Items.Add("All");
        }

        private void Special_date_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("ID", "Student ID");
            dataGridView1.Columns.Add("Course_Name", "Course_Name");
            dataGridView1.Columns.Add("Status", "Status");

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
                foreach (student_request s in context.student_request)
                {

                    dataGridView1.Rows.Add(s.ID, s.Course_ID, s.Status);



                }

            }
        }

        private void special_date_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (Entities context = new Entities())
            {
                dataGridView1.Rows.Clear();
                foreach (student_request s in context.student_request)
                {

                    if (special_date_combobox.Text == "Pending")
                    {
                        if (s.Status == "Pending")
                        {
                            dataGridView1.Rows.Add(s.ID, s.Course_ID, s.Status);
                        }
                    }
                    else if (special_date_combobox.Text == "Postponed")
                    {
                        if (s.Status == "Denied")
                        {
                            dataGridView1.Rows.Add(s.ID, s.Course_ID, s.Status);
                        }
                    }
                    else if (special_date_combobox.Text == "All")
                    {
                        if (s.Status == "All")
                        {
                            dataGridView1.Rows.Add(s.ID, s.Course_ID, s.Status);
                        }
                    }
                    else
                    {
                        if (s.Status == "Approved")
                        {
                            dataGridView1.Rows.Add(s.ID, s.Course_ID, s.Status);
                        }
                    }
                }
            }
        }
    }
}