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
    public partial class Messages : Form
    {

        List<DF_requests> messages = new List<DF_requests>();

        public student studentUsr;

        public Messages(student _studentUsr)
        {
            InitializeComponent();
            studentUsr = _studentUsr;
            fillDataGridView();
            using (Entities context = new Entities())
            {
                messages = getMessages(context);
            }

            insertMessageToGrid();
        }

        //Get all messages intended to student
        private List<DF_requests> getMessages(Entities context)
        {
            var selected =
                from rdf in context.DF_requests where rdf.Intended_to == "All_students"
                select rdf;

            return selected.ToList();
        }

        private void fillDataGridView()
        {
            //Create headers
            messagesGridView.Columns.Add("Subject", "Subject");
            messagesGridView.Columns.Add("Date", "Date");

            // Button column
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            messagesGridView.Columns.Add(btn);
            btn.HeaderText = "Read";
            btn.Text = "Read";
            btn.Name = "Button";
            btn.UseColumnTextForButtonValue = true;

            //Paint headers
            messagesGridView.ColumnHeadersDefaultCellStyle.BackColor = Utility.HeaderBackColor;
            messagesGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            messagesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            messagesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
   
        }

        //Insert message to grid
        private void insertMessageToGrid()
        {
            foreach (DF_requests message in messages)
            {
                messagesGridView.Rows.Add(message.Subject, message.Date.ToLongDateString() );
            }
        }

        //Show message on row click
        private void messagesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            messagesGridView.ClearSelection();
            messageTextBox.Text = messages[e.RowIndex].Message;
        }


    }
}
