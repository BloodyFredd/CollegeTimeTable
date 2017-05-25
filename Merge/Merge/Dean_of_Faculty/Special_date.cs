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
            special_date_combobox.Items.Add("Open");
            special_date_combobox.Items.Add("Postponed");
            special_date_combobox.Items.Add("Approved");
            
        }

        private void Special_date_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("ID", "Student ID");
            dataGridView1.Columns.Add("Course_Serial", "Course_Serial");
            dataGridView1.Columns.Add("Course_Name", "Course_Name");
            dataGridView1.Columns.Add("Date", "Date");
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
                foreach (var s in context.Student_special_Exam)
               {
                   
                    studentspecialExamBindingSource.DataSource = s;

                    foreach (var v in context.courses)
                    {
                        if (s.Course_Serial.ToString().Contains(v.Course_id.ToString()))
                        {
                            dataGridView1.Rows.Add(s.ID, s.Course_Serial, v.Course_name, s.Date,s.Status);
                        }
                    }
                    
                }

            }
        }

        private void special_date_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            using (Entities context = new Entities())
            {
                dataGridView1.Rows.Clear();
                foreach (var s in context.Student_special_Exam)
                {
                    foreach (var v in context.courses)
                    {
                        if (s.Course_Serial.ToString().Contains(v.Course_id.ToString()))
                        {
                            if (special_date_combobox.Text == "Open")
                            {
                                if (s.Status == null)
                                {
                                    studentspecialExamBindingSource.DataSource = s;
                                    dataGridView1.Rows.Add(s.ID, s.Course_Serial, v.Course_name, s.Date, s.Status);
                                }
                            }
                            else if (special_date_combobox.Text == "Postponed")
                            {
                                if (s.Status == false)
                                {
                                    studentspecialExamBindingSource.DataSource = s;
                                    dataGridView1.Rows.Add(s.ID, s.Course_Serial, v.Course_name, s.Date, s.Status);
                                }
                            }
                            else
                            {
                                if (s.Status == true)
                                {
                                    studentspecialExamBindingSource.DataSource = s;
                                    dataGridView1.Rows.Add(s.ID, s.Course_Serial, v.Course_name, s.Date, s.Status);
                                }
                            }
                            break;
                        }
                    }
                }
            }
            
        }
    }
}
