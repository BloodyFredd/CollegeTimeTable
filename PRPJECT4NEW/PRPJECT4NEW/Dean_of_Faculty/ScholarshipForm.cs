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
        public ScholarshipForm()
        {
            InitializeComponent();
        }
        public ScholarshipForm(String User, int Password)
        {
            InitializeComponent();
            MessageBox.Show("           User info\n         ------------\nName: " + User + "\nPassword: " + Password);
            using (MazalEntities context = new MazalEntities())
            {
                var allRows = context.Scholarships.ToList();
                dataGridView1.DataSource = allRows;
                dataGridView1.Refresh();
            }
        }

    }
}
