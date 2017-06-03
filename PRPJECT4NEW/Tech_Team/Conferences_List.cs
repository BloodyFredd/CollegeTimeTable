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

namespace PRPJECT4NEW.Tech_Team
{
    public partial class Conferences_List : Form
    {
        public Conferences_List()
        {
            InitializeComponent();
        }
        public Boolean SaveFILE()
        {
            try
            {
                //SAVE FILE
                using (Entities context = new Entities())
                {
                    var allRowes = context.Conferences.ToList();

                    using (SaveFileDialog sdf = new SaveFileDialog() { Filter = "Csv|*.csv", ValidateNames = true })
                    {
                        if (sdf.ShowDialog() == DialogResult.OK)
                        {
                            using (var sw = new StreamWriter(sdf.FileName))
                            {
                                var writer = new CsvWriter(sw);
                                writer.WriteHeader(typeof(Conference));
                                foreach (var s in context.Conferences)
                                {
                                    writer.WriteRecord(s);
                                }
                            }
                            return true;

                        }
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());

                return false;
            }
            return false;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
          if (SaveFILE())
                MessageBox.Show("Saved", "mes", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Conferences_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Conferences_List_Load(object sender, EventArgs e)
        {

            //Create Columns
            Conferences_Grid.Columns.Add("ID", "ID");
            Conferences_Grid.Columns.Add("Name", "Name");
            Conferences_Grid.Columns.Add("Class", "Class");
            Conferences_Grid.Columns.Add("Date", "Date");
            Conferences_Grid.Columns.Add("Start_Time", "Start Time");
            Conferences_Grid.Columns.Add("End_Time", "End Time");
            Conferences_Grid.Columns.Add("Microphone", "Need's Microphone");
            Conferences_Grid.Columns.Add("Projector", "Need's Projector");

            //Paint headers
            Conferences_Grid.EnableHeadersVisualStyles = false;
            //Conferences_Grid.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            Conferences_Grid.GridColor = Utility.HeaderBackColor;
            Conferences_Grid.ColumnHeadersDefaultCellStyle.BackColor = Utility.HeaderBackColor;
            Conferences_Grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            Conferences_Grid.AutoResizeColumns();

            Conferences_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            Conferences_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            using (Entities context = new Entities())
            {
                Conferences_Grid.Rows.Clear();
                foreach (Conference s in context.Conferences)
                {
                    Conferences_Grid.Rows.Add(s.Id, s.Name, s.Class, s.Date.ToShortDateString(), s.Start_Time, s.End_Time, s.Microphone, s.Projector);
                }
                
                //Conferences_Grid.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
                //Conferences_Grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;
                Conferences_Grid.Refresh();
            }
                
        }
    }
}
