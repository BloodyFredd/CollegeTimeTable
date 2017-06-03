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
    public partial class Supervisor_List : Form
    {
        public Supervisor_List()
        {
            InitializeComponent();
            Superviser_List_Load();
        }

        private void Exams_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Superviser_List_Load()
        {

            //Create Columns
            Superviser_Grid.Columns.Add("ID", "ID");
            Superviser_Grid.Columns.Add("First_Name", "First Name");
            Superviser_Grid.Columns.Add("Last_Name", "Last Name");
            Superviser_Grid.Columns.Add("Email", "Email");
            Superviser_Grid.Columns.Add("Phone", "Phone Number");

            //Paint headers
            Superviser_Grid.EnableHeadersVisualStyles = false;
            //Conferences_Grid.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            Superviser_Grid.GridColor = Utility.HeaderBackColor;
            Superviser_Grid.ColumnHeadersDefaultCellStyle.BackColor = Utility.HeaderBackColor;
            Superviser_Grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            Superviser_Grid.AutoResizeColumns();

            Superviser_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            Superviser_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            using (Entities context = new Entities())
            {
                Superviser_Grid.Rows.Clear();
                foreach (Person p in context.People)
                {
                    if(p.Permission == "Supervisor")
                        Superviser_Grid.Rows.Add(p.ID,p.F_name,p.L_name,p.Email,p.Telephone);
                }
                Superviser_Grid.Refresh();
            }
        }
    }
}
