using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRPJECT4NEW.Tech_Team
{
    public partial class Available_Classes : Form
    {
        public Available_Classes()
        {
            InitializeComponent();
            date_cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            type_cmb.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void Available_Classes_Load(object sender, EventArgs e)
        {
            using (Entities db = new Entities())
            {
                //Create Columns
                dataGridView.Columns.Add("Date", "Date");
                dataGridView.Columns.Add("Day", "Day in week");
                dataGridView.Columns.Add("Name", "Class name");
                dataGridView.Columns.Add("Type", "Type");
                dataGridView.Columns.Add("Capacity", "Capacity");
                dataGridView.Columns.Add("0809", "08-09");
                dataGridView.Columns.Add("0910", "09-10");
                dataGridView.Columns.Add("1011", "10-11");
                dataGridView.Columns.Add("1112", "11-12");
                dataGridView.Columns.Add("1213", "12-13");
                dataGridView.Columns.Add("1314", "13-14");
                dataGridView.Columns.Add("1415", "14-15");
                dataGridView.Columns.Add("1516", "15-16");
                dataGridView.Columns.Add("1617", "16-17");
                dataGridView.Columns.Add("1718", "17-18");
                dataGridView.Columns.Add("1819", "18-19");
                dataGridView.Columns.Add("1920", "19-20");
                dataGridView.Columns.Add("2021", "20-21");

                //paint
                //Paint headers
                dataGridView.EnableHeadersVisualStyles = false;
                dataGridView.GridColor = Utility.HeaderBackColor;
                dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Utility.HeaderBackColor;
                dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridView.AutoResizeColumns();

                dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;


                dataGridView.Columns[0].Width = 70;
                dataGridView.Columns[1].Width = 80;



                dataGridView.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
                dataGridView.Hide();

                addDatesToDate_cmb();
                addTypesToType_cmb();
            }
        }
        private void paintCells1(int i, Classes_SM1 s)
        {
            for (int j = 5; j < 18; j++)
                dataGridView.Rows[i].Cells[j].Style.BackColor = Color.Red;
            if (s.C08_09.Value == 0)
                dataGridView.Rows[i].Cells[5].Style.BackColor = Color.LawnGreen;
            if (s.C09_10.Value == 0)
                dataGridView.Rows[i].Cells[6].Style.BackColor = Color.LawnGreen;
            if (s.C10_11.Value == 0)
                dataGridView.Rows[i].Cells[7].Style.BackColor = Color.LawnGreen;
            if (s.C11_12.Value == 0)
                dataGridView.Rows[i].Cells[8].Style.BackColor = Color.LawnGreen;
            if (s.C12_13.Value == 0)
                dataGridView.Rows[i].Cells[9].Style.BackColor = Color.LawnGreen;
            if (s.C13_14.Value == 0)
                dataGridView.Rows[i].Cells[10].Style.BackColor = Color.LawnGreen;
            if (s.C14_15.Value == 0)
                dataGridView.Rows[i].Cells[11].Style.BackColor = Color.LawnGreen;
            if (s.C15_16.Value == 0)
                dataGridView.Rows[i].Cells[12].Style.BackColor = Color.LawnGreen;
            if (s.C16_17.Value == 0)
                dataGridView.Rows[i].Cells[13].Style.BackColor = Color.LawnGreen;
            if (s.C17_18.Value == 0)
                dataGridView.Rows[i].Cells[14].Style.BackColor = Color.LawnGreen;
            if (s.C18_19.Value == 0)
                dataGridView.Rows[i].Cells[15].Style.BackColor = Color.LawnGreen;
            if (s.C19_20.Value == 0)
                dataGridView.Rows[i].Cells[16].Style.BackColor = Color.LawnGreen;
            if (s.C20_21.Value == 0)
                dataGridView.Rows[i].Cells[17].Style.BackColor = Color.LawnGreen;
            i++;
        }
        private void paintCells2(int i, Classes_SM2 s)
        {
            for (int j = 5; j < 18; j++)
                dataGridView.Rows[i].Cells[j].Style.BackColor = Color.Red;
            if (s.C08_09.Value == 0)
                dataGridView.Rows[i].Cells[5].Style.BackColor = Color.LawnGreen;
            if (s.C09_10.Value == 0)
                dataGridView.Rows[i].Cells[6].Style.BackColor = Color.LawnGreen;
            if (s.C10_11.Value == 0)
                dataGridView.Rows[i].Cells[7].Style.BackColor = Color.LawnGreen;
            if (s.C11_12.Value == 0)
                dataGridView.Rows[i].Cells[8].Style.BackColor = Color.LawnGreen;
            if (s.C12_13.Value == 0)
                dataGridView.Rows[i].Cells[9].Style.BackColor = Color.LawnGreen;
            if (s.C13_14.Value == 0)
                dataGridView.Rows[i].Cells[10].Style.BackColor = Color.LawnGreen;
            if (s.C14_15.Value == 0)
                dataGridView.Rows[i].Cells[11].Style.BackColor = Color.LawnGreen;
            if (s.C15_16.Value == 0)
                dataGridView.Rows[i].Cells[12].Style.BackColor = Color.LawnGreen;
            if (s.C16_17.Value == 0)
                dataGridView.Rows[i].Cells[13].Style.BackColor = Color.LawnGreen;
            if (s.C17_18.Value == 0)
                dataGridView.Rows[i].Cells[14].Style.BackColor = Color.LawnGreen;
            if (s.C18_19.Value == 0)
                dataGridView.Rows[i].Cells[15].Style.BackColor = Color.LawnGreen;
            if (s.C19_20.Value == 0)
                dataGridView.Rows[i].Cells[16].Style.BackColor = Color.LawnGreen;
            if (s.C20_21.Value == 0)
                dataGridView.Rows[i].Cells[17].Style.BackColor = Color.LawnGreen;
            i++;
        }
        //add dates to date combo box
        private void addDatesToDate_cmb()
        {
            DateTime today = new DateTime(2017,03,12);
            DateTime endDay = new DateTime(2017, 06, 30);
            while (today <= endDay)
            {
                
                if(today.DayOfWeek.ToString()!="Saturday")
                    date_cmb.Items.Add(today.ToShortDateString());
                today = today.AddDays(1);
            }
        }

        //add types to type combo box
        private void addTypesToType_cmb()
        {
            type_cmb.Items.Add("normal");
            type_cmb.Items.Add("lab");
            type_cmb.Items.Add("auditorium");
            type_cmb.Items.Add("all");
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            if (date_cmb.Text.ToString() == "")
            {
                MessageBox.Show("Please select date");
                return;
            }
            using (Entities db = new Entities())
            {
                int i = 0;
                String type = type_cmb.Text.ToString();
                if (type == "all")
                    type = "";
                if (System.DateTime.Now.Month > 0 && System.DateTime.Now.Month < 7)
                    foreach (Classes_SM2 s in db.Classes_SM2)
                    {
                        if(s.date.Length==10)
                        {
                            if (s.date.ToString().Substring(6, 4) == date_cmb.Text.Substring(6, 4) && //year
                                s.date.ToString().Substring(0, 2) == date_cmb.Text.Substring(3, 2) && //month
                                s.date.ToString().Substring(3, 2) == date_cmb.Text.Substring(0, 2) && //days
                            s.Type.ToString().Contains(type))
                            {
                                dataGridView.Rows.Add(s.date.ToString(), s.day.ToString(), s.Class_Id.ToString(), s.Type.ToString(),
                                s.Capacity.ToString());
                                paintCells2(i, s);
                                i++;
                            }
                        }
                    }
            }
            dataGridView.Show();
        }
        //save to file
        private void save_btn_Click(object sender, EventArgs e)
        {
            //SAVE FILE
           
            using (SaveFileDialog save = new SaveFileDialog() { Filter = "Csv|*.csv", ValidateNames = true })
                {
                    
                    if (save.ShowDialog() == DialogResult.OK)
                    {

                    var csv = new StringBuilder();
                    Classes_SM2 req = new Classes_SM2();
                    
                    using (var sw = new StreamWriter(save.FileName))
                    {
                        var writer = new CsvWriter(sw);
                        writer.WriteHeader(typeof(Classes_SM2));
                        for (int i = 0; i < dataGridView.RowCount-1; i++)
                        {
                            req.date = dataGridView.Rows[i].Cells[0].Value.ToString() ;
                            req.day = dataGridView.Rows[i].Cells[1].Value.ToString();
                            req.Class_Id = dataGridView.Rows[i].Cells[2].Value.ToString();
                            req.Type = dataGridView.Rows[i].Cells[3].Value.ToString();
                            req.Capacity = Convert.ToInt32( dataGridView.Rows[i].Cells[4].Value);
                            if (dataGridView.Rows[i].Cells[5].Style.BackColor == Color.LawnGreen)
                                req.C08_09 = 0;
                            if (dataGridView.Rows[i].Cells[6].Style.BackColor == Color.LawnGreen)
                                req.C09_10 = 0;
                            if (dataGridView.Rows[i].Cells[7].Style.BackColor == Color.LawnGreen)
                                req.C10_11 = 0;
                            if (dataGridView.Rows[i].Cells[8].Style.BackColor == Color.LawnGreen)
                                req.C11_12 = 0;
                            if (dataGridView.Rows[i].Cells[9].Style.BackColor == Color.LawnGreen)
                                req.C12_13 = 0;
                            if (dataGridView.Rows[i].Cells[10].Style.BackColor == Color.LawnGreen)
                                req.C13_14 = 0;
                            if (dataGridView.Rows[i].Cells[11].Style.BackColor == Color.LawnGreen)
                                req.C14_15 = 0;
                            if (dataGridView.Rows[i].Cells[12].Style.BackColor == Color.LawnGreen)
                                req.C15_16 = 0;
                            if (dataGridView.Rows[i].Cells[13].Style.BackColor == Color.LawnGreen)
                                req.C16_17 = 0;
                            if (dataGridView.Rows[i].Cells[14].Style.BackColor == Color.LawnGreen)
                                req.C17_18 = 0;
                            if (dataGridView.Rows[i].Cells[15].Style.BackColor == Color.LawnGreen)
                                req.C18_19 = 0;
                            if (dataGridView.Rows[i].Cells[16].Style.BackColor == Color.LawnGreen)
                                req.C19_20 = 0;
                            if (dataGridView.Rows[i].Cells[17].Style.BackColor == Color.LawnGreen)
                                req.C20_21 = 0;
                            writer.WriteRecord(req);
                        }
                            

                    }
                    
                        MessageBox.Show("Saved", "mes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    
}
