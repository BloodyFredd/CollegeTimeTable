using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CsvHelper;
using System.Data.SqlClient;
namespace PRPJECT4NEW.Tech_Team
{
    public partial class DF_requestForm : Form
    {
        public DF_requestForm()
        {
            InitializeComponent();
        }
        public void reloadGrid()
        {
            dataGridView.Rows.Clear();
            using (Entities db = new Entities())
            {
                foreach (DF_requests s in db.DF_requests)
                    dataGridView.Rows.Add(s.Date.ToShortDateString(), s.Intended_to, s.Subject, s.Message, s.Status);
            }
            dataGridView.Refresh();
        }
        public void reload()
        {
            using (Entities db = new Entities())
            {
                foreach (DF_requests s in db.DF_requests)
                {
                    dataGridView.Rows.Add(s.Date.ToShortDateString(), s.Intended_to, s.Subject, s.Message, s.Status);
                }
               
            }
        }

        private void DF_requestForm_Load(object sender, EventArgs e)
        {
            using (Entities db = new Entities())
            {
                var allRowes = db.DF_requests.ToList();
                //Create Columns
                dataGridView.Columns.Add("Date", "Date");
                dataGridView.Columns.Add("Intended to", "Intended_to");
                dataGridView.Columns.Add("Subject", "Subject");
                dataGridView.Columns.Add("Message", "Message");
                dataGridView.Columns.Add("Status", "Status");

                // Button column
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                dataGridView.Columns.Add(btn);
                btn.HeaderText = "Update status";
                btn.Text = "update";
                btn.Name = "btn";
                btn.UseColumnTextForButtonValue = true;


                //Paint headers
                dataGridView.EnableHeadersVisualStyles = false;
                dataGridView.GridColor = Utility.HeaderBackColor;
                dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Utility.HeaderBackColor;
                dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridView.AutoResizeColumns();

                dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

                foreach (DF_requests s in db.DF_requests)
                    {
                            
                            dataGridView.Rows.Add(s.Date.ToShortDateString(), s.Intended_to, s.Subject, s.Message, s.Status);
                     }
                dataGridView.AutoResizeColumns();
                dataGridView.Columns[0].Width = 70;
                dataGridView.Columns[1].Width = 90;
                dataGridView.Columns[4].Width = 50;
                dataGridView.Columns[5].Width = 50;
                dataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
                dataGridView.Refresh();
            }
            
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            //SAVE FILE
           
            using (SaveFileDialog save = new SaveFileDialog() { Filter = "Csv|*.csv", ValidateNames = true })
                {
                    
                    if (save.ShowDialog() == DialogResult.OK)
                    {

                    var csv = new StringBuilder();
                    DF_requests req = new DF_requests();
                    

                    string v1 = "Date";
                    string v2 = "Intendet to";
                    string v3 = "Subject";
                    string v4 = "Message";
                    string v5 = "Status";
                    var newLine = string.Format("{0},{1},{2},{3},{4}", v1, v2, v3, v4, v5);
                    //ner.Date = Convert.ToDateTime(v1);
                    
                    using (var sw = new StreamWriter(save.FileName))
                    {
                        var writer = new CsvWriter(sw);
                        writer.WriteHeader(typeof(DF_requests));
                        for (int i = 0; i < dataGridView.RowCount; i++)
                        {
                            req.Date = Convert.ToDateTime(dataGridView.Rows[i].Cells[0].Value);
                            req.Intended_to = dataGridView.Rows[i].Cells[1].Value.ToString();
                            req.Subject = dataGridView.Rows[i].Cells[2].Value.ToString();
                            req.Message = dataGridView.Rows[i].Cells[3].Value.ToString();
                            req.Status = dataGridView.Rows[i].Cells[4].Value.ToString();
                            writer.WriteRecord(req);
                        }
                            

                    }
                    
                        MessageBox.Show("Saved", "mes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                
                using (Entities db = new Entities())
                {
                    string intendedTo = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string subject = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                    
                    
                    DF_requests df_request = db.DF_requests.FirstOrDefault(s => s.Intended_to == intendedTo && s.Subject == subject);
                    
                    df_request.Status = "Close";

                    db.SaveChanges();
                    MessageBox.Show("data updated");
                    reloadGrid();
                }
            }
        }
    }
}
