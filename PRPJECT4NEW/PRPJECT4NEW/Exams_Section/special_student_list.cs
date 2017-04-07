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
    public partial class special_student_list : Form
    {
        public special_student_list()
        {
            InitializeComponent();


        }

        private void special_student_list_Load(object sender, EventArgs e)
        {
            RefreshTB();
        }

        private void Type_of_easements_label_Click(object sender, EventArgs e)
        {

        }

        private void Type_of_easements_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        protected void RefreshTB()
        {
            using (MazalEntities context = new MazalEntities())
            {
                var allRows = context.students.ToList();
                Sview.DataSource = allRows;
                
            }

        }
    }
}
