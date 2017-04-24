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
    public partial class ScholarshipForm : Form
    {
        public ScholarshipForm(String User, int Password)
        {
            InitializeComponent();

            //Create & Load DataGridView
            using (MazalEntities context = new MazalEntities())
            {
                CreateGridView();
                reloadDataGridView(context);
            }
        }

        private void delScholarshipBtn_Click(object sender, EventArgs e)
        {
            List<string> checkedScholarships = new List<string>();
            int checkBoxColumn = scholarshipGridView.Columns.Count - 1;

            //List marked scholarships
            foreach (DataGridViewRow rw in this.scholarshipGridView.Rows)
            {
                if (rw.Cells[checkBoxColumn].Value != null && Convert.ToBoolean(rw.Cells[checkBoxColumn].Value) == true)
                    checkedScholarships.Add(rw.Cells[0].Value.ToString());          
            }

            using (MazalEntities context = new MazalEntities())
            {
                //Delete each marked scholarship
                foreach (string i in checkedScholarships)
                {
                    Scholarship scholarship = context.Scholarships.FirstOrDefault(s => s.Scholership_Name == i);
                    context.Scholarships.Remove(scholarship);
                }

                //Save changes and reload grid
                context.SaveChanges();
                reloadDataGridView(context);
            }

       
            scholarshipGridView.Refresh();
        }

        private void CreateGridView()
        {
            //Create Columns
            scholarshipGridView.Columns.Add("Scholarship_Name", "Scholarship Name");
            scholarshipGridView.Columns.Add("Grant_Amount", "Grant Amount (NIS)");
            scholarshipGridView.Columns.Add("Intended_For", "Intended For");
            scholarshipGridView.Columns.Add("Duration(years)", "Duration (Years)");
            scholarshipGridView.Columns.Add("Volunteer_hours", "Volunteer Hours");

            //Create check box column
            DataGridViewCheckBoxColumn column = new DataGridViewCheckBoxColumn();
            {
                column.HeaderText = "Check";
                column.Name = "check";
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                column.FlatStyle = FlatStyle.Standard;
                column.ThreeState = false;
                column.IndeterminateValue = false;
                column.CellTemplate = new DataGridViewCheckBoxCell();
            }
            //Paint headers
            scholarshipGridView.Columns.Insert(scholarshipGridView.Columns.Count, column);
            scholarshipGridView.ColumnHeadersDefaultCellStyle.BackColor = Utility.menuColor;
            scholarshipGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void newScholarshipBtn_Click(object sender, EventArgs e)
        {
            using (MazalEntities context = new MazalEntities())
            {
                Scholarship nachshon = new Scholarship
                {
                    Scholership_ID = "SomeID",
                    Grant_Amount_shekel_ = Convert.ToInt32(grantNumeric.Value),
                    Scholership_Name = nameTextBox.Text,
                    Intended_for = forTextBox.Text,
                    Duration_years_ = Convert.ToInt32(durationNumeric.Value),
                    Volunteer_hours = Convert.ToInt32(hoursNumeric.Value)
                };

                context.Scholarships.Add(nachshon);
                context.SaveChanges();

                reloadDataGridView(context);
            }
        }

        private void reloadDataGridView(MazalEntities context)
        {
            scholarshipGridView.Rows.Clear();
            foreach (Scholarship s in context.Scholarships)
            {
                scholarshipGridView.Rows.Add(s.Scholership_Name, s.Grant_Amount_shekel_, s.Intended_for, s.Duration_years_, s.Volunteer_hours);
            }
            scholarshipGridView.Refresh();
        }
    }
}
