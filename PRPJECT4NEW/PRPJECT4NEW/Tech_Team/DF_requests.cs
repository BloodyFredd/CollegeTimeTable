using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRPJECT4NEW.Tech_Team
{
    public partial class DF_requests : Form
    {
        public DF_requests()
        {
            InitializeComponent();
        }
        public DF_requests(String User)
        {
            InitializeComponent();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (MazalEntities context = new MazalEntities())
            {
                Scholarship nachshon = new Scholarship
                {
                    Scholership_ID = "4",
                    Grant_Amount_shekel_ = 10000,
                    Scholership_Name = "Nachshon",
                    Intended_for = "Any",
                    Duration_years_ = 1,
                    Volunteer_hours = 150
                };

                context.Scholarships.Add(nachshon);
                context.SaveChanges();
            }
        }

        private void Select_Click(object sender, EventArgs e)
        {
            using (MazalEntities context = new MazalEntities())
            {
                Scholarship scholarship = context.Scholarships.FirstOrDefault(s => s.Scholership_Name == "Hachvana");
                MessageBox.Show(scholarship.Grant_Amount_shekel_.ToString());
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            using (MazalEntities context = new MazalEntities())
            {
                Scholarship scholarship = context.Scholarships.FirstOrDefault(s => s.Scholership_Name == "Perach");
                scholarship.Volunteer_hours++;
                context.SaveChanges();
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            using (MazalEntities context = new MazalEntities())
            {
                Scholarship scholarship = context.Scholarships.FirstOrDefault(s => s.Scholership_Name == "Nachshon");
                context.Scholarships.Remove(scholarship);
                context.SaveChanges();
            }

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            using (MazalEntities context = new MazalEntities())
            {
                //var allRows = context.Scholarships.ToList();
                var allRows = context.DF_requests.ToList();
                dataGridView1.DataSource = allRows;
                dataGridView1.Refresh();
            }
                
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
