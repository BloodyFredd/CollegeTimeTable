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
using System.IO;
using CsvHelper;

namespace PRPJECT4NEW.Exams_Section
{

    public partial class special_student_list : Form
    {
        public special_student_list()
        {
            InitializeComponent();
            using (Entities context = new Entities())
            {  
                var allRowes = context.students.ToList();
            }
            Type_of_easements_comboBox.Items.Add("All Students");
            Type_of_easements_comboBox.Items.Add("Extra Time");
            Type_of_easements_comboBox.Items.Add("Formula Sheet");
            Type_of_easements_comboBox.Items.Add("Laptop");
            Type_of_easements_comboBox.Items.Add("Whithout any easments");
           
        }

        private void special_student_list_Load(object sender, EventArgs e)
        {
            //Create Columns
            Sview.Columns.Add("ID", "Student ID");
            Sview.Columns.Add("Department", "Department");
            Sview.Columns.Add("Year", "Year");
            Sview.Columns.Add("Average", "Average");
            Sview.Columns.Add("ExtraTime", "Extra Time");
            Sview.Columns.Add("Laptop", "Laptop");
            Sview.Columns.Add("FormulaSheet", "Formula Sheet ");

            //Paint headers
            Sview.EnableHeadersVisualStyles = false;
            Sview.GridColor = Utility.HeaderBackColor;
            Sview.ColumnHeadersDefaultCellStyle.BackColor = Utility.HeaderBackColor;
            Sview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            Sview.AutoResizeColumns();

            Sview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            Sview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

        }

        private void Type_of_easements_label_Click(object sender, EventArgs e)
        {

        }

        private void Type_of_easements_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // SqlDataSourceEnumerator dr=new SqlNotificationRequest



        }
        protected void RefreshTB(Entities context)
        {
            Sview.Rows.Clear();
            foreach (student s in context.students)
            {
                 Sview.Rows.Add(s.ID, s.Department, s.Year, s.Average, s.ExtraTime, s.Laptop, s.FormulaSheet);
            }
            Sview.Refresh();
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            Entities context = new Entities();

            if (Type_of_easements_comboBox.Text == "Extra Time")
            {
                Sview.Rows.Clear();
                foreach (student s in context.students)
                {
                    if (s.ExtraTime == true)
                        Sview.Rows.Add(s.ID, s.Department, s.Year, s.Average, s.ExtraTime, s.Laptop, s.FormulaSheet);   
                }
            }
            else if (Type_of_easements_comboBox.Text == "Laptop")
            {
                Sview.Rows.Clear();
                foreach (student s in context.students)
                {
                    if (s.Laptop == true)
                        Sview.Rows.Add(s.ID, s.Department, s.Year, s.Average, s.ExtraTime, s.Laptop, s.FormulaSheet);
                }
            }
            else if (Type_of_easements_comboBox.Text == "Formula Sheet")
            {
                Sview.Rows.Clear();
                foreach (student s in context.students)
                {
                    if (s.FormulaSheet == true)
                        Sview.Rows.Add(s.ID, s.Department, s.Year, s.Average, s.ExtraTime, s.Laptop, s.FormulaSheet);
                }
            }
            else if(Type_of_easements_comboBox.Text == "Whithout any easments")
            {
                Sview.Rows.Clear();
                foreach (student s in context.students)
                {
                    if (s.Laptop == false && s.FormulaSheet == false && s.ExtraTime == false)
                        Sview.Rows.Add(s.ID, s.Department, s.Year, s.Average, s.ExtraTime, s.Laptop, s.FormulaSheet);
                }
            }
            else
            {
                Sview.Rows.Clear();
                RefreshTB(context);
            }
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            //SAVE FILE
            using (Entities context = new Entities())
            {
                var allRowes = context.students.ToList();

                using (SaveFileDialog sdf = new SaveFileDialog() { Filter = "Csv|*.csv", ValidateNames = true })
                {
                    if (sdf.ShowDialog() == DialogResult.OK)
                    {
                        using (var sw = new StreamWriter(sdf.FileName))
                        {
                            var writer = new CsvWriter(sw);
                            writer.WriteHeader(typeof(student));
                            foreach (var s in context.students)
                            {
                               if (s.ExtraTime==true)
                                { 
                                    writer.WriteRecord(s);
                                }
                            }
                        }
                        MessageBox.Show("Saved", "mes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void dataSet1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SAVE FILE
            using (Entities context = new Entities())
            {
                var allRowes = context.students.ToList();

                using (SaveFileDialog sdf = new SaveFileDialog() { Filter = "Csv|*.csv", ValidateNames = true })
                {
                    if (sdf.ShowDialog() == DialogResult.OK)
                    {
                        using (var sw = new StreamWriter(sdf.FileName))
                        {
                            var writer = new CsvWriter(sw);
                            writer.WriteHeader(typeof(student));
                            foreach (var s in context.students)
                            {
                                if (s.Laptop == true)
                                {
                                    writer.WriteRecord(s);
                                }
                            }
                        }
                        MessageBox.Show("Saved", "mes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void save3_button_Click(object sender, EventArgs e)
        {
            //SAVE FILE
            using (Entities context = new Entities())
            {
                var allRowes = context.students.ToList();

                using (SaveFileDialog sdf = new SaveFileDialog() { Filter = "Csv|*.csv", ValidateNames = true })
                {
                    if (sdf.ShowDialog() == DialogResult.OK)
                    {
                        using (var sw = new StreamWriter(sdf.FileName))
                        {
                            var writer = new CsvWriter(sw);
                            writer.WriteHeader(typeof(student));
                            foreach (var s in context.students)
                            {
                                if (s.FormulaSheet == true)
                                {
                                    writer.WriteRecord(s);
                                }
                            }
                        }
                        MessageBox.Show("Saved", "mes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void Sview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void save_regular_stu_btn_Click(object sender, EventArgs e)
        {
            //SAVE FILE
            using (Entities context = new Entities())
            {
                var allRowes = context.students.ToList();

                using (SaveFileDialog sdf = new SaveFileDialog() { Filter = "Csv|*.csv", ValidateNames = true })
                {
                    if (sdf.ShowDialog() == DialogResult.OK)
                    {
                        using (var sw = new StreamWriter(sdf.FileName))
                        {
                            var writer = new CsvWriter(sw);
                            writer.WriteHeader(typeof(student));
                            foreach (var s in context.students)
                            {
                                if (s.Laptop == false &&s.FormulaSheet==false &&s.ExtraTime==false)
                                {
                                    writer.WriteRecord(s);
                                }
                            }
                        }
                        MessageBox.Show("Saved", "mes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}

