using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRPJECT4NEW.Student
{
    public partial class Requests : Form
    {
        public student studentUsr;
        List<student_request> requests = new List<student_request>();


        public Requests(student _studentUsr)
        {
            InitializeComponent();
            studentUsr = _studentUsr;
            fillDataGridView();
            getRequests();
            insertRequestsToGrid();
        }


        //Get all messages intended to student
        private void getRequests()
        {
            using (Entities context = new Entities())
            {
                var selected =
                    from r in context.student_request where r.ID == studentUsr.ID
                    select r;
                requests = selected.ToList();
            } 
        }

        private void fillDataGridView()
        {
            //Create headers
            requestsGridView.Columns.Add("Subject", "Subject");
            requestsGridView.Columns.Add("Message", "Message");
            requestsGridView.Columns.Add("Status", "Status");

            //Paint headers
            requestsGridView.ColumnHeadersDefaultCellStyle.BackColor = Utility.HeaderBackColor;
            requestsGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            requestsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            requestsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            foreach (DataGridViewColumn column in requestsGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        //Insert request to grid
        private void insertRequestsToGrid()
        {
            foreach (student_request request in requests)
            {
                requestsGridView.Rows.Add(request.Subject, request.Message, request.Status);
            }
        }


        //Send request
        private void sendRequestBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(subjectTextBox.Text))
            {
                MessageBox.Show("Empty subject field", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else if (string.IsNullOrWhiteSpace(messageTextBox.Text))
            {
                MessageBox.Show("Empty Message", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else
            {
                using (Entities context = new Entities())
                {
                    student_request newRequest = new student_request
                    {
                        ID = studentUsr.ID,
                        Subject = subjectTextBox.Text,
                        Message = messageTextBox.Text,
                        Status = "Pending"
                    };
                    context.student_request.Add(newRequest);
                    context.SaveChanges();
                }

                //Reload data grid view 
                requestsGridView.Rows.Clear();
                requestsGridView.Refresh();
                getRequests();
                insertRequestsToGrid();
            }
        }
    }
}
