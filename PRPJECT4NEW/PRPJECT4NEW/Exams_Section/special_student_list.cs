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

    public partial class special_student_list : Form
    {
        public special_student_list()
        {
            InitializeComponent();
            using (Entities context = new Entities())
            {
                //special_student_list_Load(this, EventArgs.Empty);
                var allRowes = context.students.ToList();
               // Sview.DataSource = allRowes;
                // RefreshTB(context);
            }
            Type_of_easements_comboBox.Items.Add("All Students");
            Type_of_easements_comboBox.Items.Add("Extra Time");
            Type_of_easements_comboBox.Items.Add("Formula Sheet");
            Type_of_easements_comboBox.Items.Add("Laptop");

           
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
            Sview.ColumnHeadersDefaultCellStyle.BackColor = Utility.menuColor;
            Sview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

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
                Sview.Rows.Add(s.ID, s.Department, s.Year, s.Average, s.ExtraTime,s.Laptop,s.FormulaSheet);
            }
            Sview.Refresh();
        }



        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            //SqlCommand cm = new SqlCommand("SELECT ID FROM tblstudents WHERE ExtraTime = 'True' OR Laptop = 'True' OR FormulaSheets = 'True'");
            //SqlDataReader dr = cm.ExecuteReader();
            //while (dr.Read()) {
            //    Sview.DataSource = dr;
            //}
            Entities context = new Entities();

            //special_student_list_Load(this, EventArgs.Empty);
            if (Type_of_easements_comboBox.Text == "Extra Time")
            {
                Sview.Rows.Clear();
                foreach (student s in context.students)
                {
                    if(s.ExtraTime==true)
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
            else
            {
                Sview.Rows.Clear();
                RefreshTB(context);
            }

        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            
        }

        private void Sview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
