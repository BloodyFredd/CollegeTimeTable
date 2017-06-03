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
    public partial class Tech_support : Form
    {
        public Tech_support()
        {
            InitializeComponent();
        }
        public DF_requests newrequset()
        {
            using (Entities context = new Entities())
            {
                DF_requests msg = new DF_requests
                {
                    Date = DateTime.Today,
                    Intended_to = "Tech_Team",
                    Subject = subject_txtbox.Text,
                    Message = message_textbox.Text,
                    Status = "Open"
                };
                return msg;
            }
           }
        private void new_Request_btn_Click(object sender, EventArgs e)
        {

            using (Entities context = new Entities())
            {

                context.DF_requests.Add(newrequset());
                context.SaveChanges();

                reloadDataGridView(context);
            }
        }

        private void Tech_support_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns.Add("Intended to", "Intended_to");
            dataGridView1.Columns.Add("Subject", "Subject");
            dataGridView1.Columns.Add("Message", "Message");
            dataGridView1.Columns.Add("Status", "Status");

            //DataGridViewCheckBoxColumn column = new DataGridViewCheckBoxColumn();
            //{
            //    column.HeaderText = "Check";
            //    column.Name = "check";
            //    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //    column.FlatStyle = FlatStyle.Standard;
            //    column.ThreeState = false;
            //    column.IndeterminateValue = false;
            //    column.CellTemplate = new DataGridViewCheckBoxCell();
            //}
            //dataGridView1.Columns.Insert(dataGridView1.Columns.Count, column);

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

                    if (s.Intended_to.ToString().Contains("Tech_Team"))
                        dataGridView1.Rows.Add(s.Date.ToShortDateString(), s.Intended_to, s.Subject, s.Message, s.Status);
                }
            }
        }



        public bool reloadDataGridView(Entities context)
        {
            try
            {

                dataGridView1.Rows.Clear();
                foreach (DF_requests s in context.DF_requests)
                {
                    if (s.Intended_to.ToString().Contains("Tech_Team"))
                    {
                        dataGridView1.Rows.Add(s.Date, s.Intended_to, s.Subject, s.Message, s.Status);
                    }
                }

                dataGridView1.Refresh();
                return true;

            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());

                throw new Exception();
            }



        }
    }
}