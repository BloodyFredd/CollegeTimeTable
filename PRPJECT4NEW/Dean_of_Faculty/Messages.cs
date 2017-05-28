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
    public partial class Messages : Form
    {
        public Messages()
        {
            InitializeComponent();
            Intended_to_combo.Items.Add("All_students");
            //Intended_to_combo.Items.Add("Tech_Team");
           
            //Intended_to_combo.Items.Add("Approved")
        }

        private void Messages_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns.Add("Intended to", "Intended_to");
            dataGridView1.Columns.Add("Subject", "Subject");
            dataGridView1.Columns.Add("Message", "Message");
            //dataGridView1.Columns.Add("Status", "Status");
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
            dataGridView1.Columns.Insert(dataGridView1.Columns.Count, column);
            //Paint headers
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Utility.HeaderBackColor;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Utility.HeaderBackColor;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.AutoResizeColumns();

            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            using (Entities db = new Entities())
            {
                foreach (DF_requests s in db.DF_requests)
                {

                    if (s.Intended_to.ToString().Contains("All_students"))
                        dataGridView1.Rows.Add(s.Date.ToShortDateString(), s.Intended_to, s.Subject, s.Message);//,s.Status);
                }
            }
        }

        private void Delete_Message_btn_Click(object sender, EventArgs e)
        {
            List<string> DF_requests = new List<string>();
            int checkBoxColumn = dataGridView1.Columns.Count - 1;

            //List marked scholarships
            foreach (DataGridViewRow rw in this.dataGridView1.Rows)
            {
                if (rw.Cells[checkBoxColumn].Value != null && Convert.ToBoolean(rw.Cells[checkBoxColumn].Value) == true)
                    DF_requests.Add(rw.Cells[2].Value.ToString());
            }

            using (Entities context = new Entities())
            {
                //Delete each marked scholarship
                foreach (string i in DF_requests)
                {
                    DF_requests msg = context.DF_requests.FirstOrDefault(s => s.Subject == i);
                    context.DF_requests.Remove(msg);
                }

                //Save changes and reload grid
                context.SaveChanges();
                reloadDataGridView(context);
            }
            dataGridView1.Refresh();
        }
        private void reloadDataGridView(Entities context)
        {
            dataGridView1.Rows.Clear();
            foreach (DF_requests s in context.DF_requests)
            {
                if (s.Intended_to.ToString().Contains("All_students"))
                    dataGridView1.Rows.Add(s.Date, s.Intended_to, s.Subject, s.Message);//,s.Status);
            }
            dataGridView1.Refresh();
        }

        private void Add_New_Message_btn_Click(object sender, EventArgs e)
        {
            using (Entities context = new Entities())
            {
                DF_requests msg = new DF_requests
                {
                    Date=DateTime.Today,
                    Intended_to = Intended_to_combo.Text,
                    Subject = Subject_textbox.Text,
                    Message = Message_textbox.Text,
                    Status="Open"
                };

                context.DF_requests.Add(msg);
                context.SaveChanges();

                reloadDataGridView(context);
            }
            
        }
    }
}
