using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PRPJECT4NEW.Lecturer
{
    public partial class ExtraLecture : Form
    {
            private string connetionString = null;
            private SqlConnection sqlcon;
            public ExtraLecture()
        {
            InitializeComponent();
        }

        private void Lecture_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }



        private void Available_Classes_Click(object sender, EventArgs e)
        {
            string str = null;


            try
            {
                this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
                this.sqlcon = new SqlConnection(connetionString);
                SqlCommand cmd = new SqlCommand("select * from Classes_SM1 where date='" + "1990-01-01" + "'", sqlcon);
                if (toolStripComboBox1.Text.Equals("") && !toolStripComboBox2.Text.Equals(""))

                {
                    str = toolStripComboBox2.Text;
                    //MessageBox.Show(str);
                    cmd = new SqlCommand("select * from Classes_SM1 where date='" + str + "'", sqlcon);
                    Lecture.Visible = true;
                }
                else if (toolStripComboBox2.Text.Equals("") && !toolStripComboBox1.Text.Equals(""))
                {
                    str = toolStripComboBox1.Text;
                    //MessageBox.Show(str);
                    cmd = new SqlCommand("select * from Classes_SM2 where date='" + str + "'", sqlcon);
                    Lecture.Visible = true;
                }
                else
                {
                    throw new ArgumentException("Error selecting dates,try again!");
                }

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;
                Lecture.DataSource = bsource;
                sda.Update(dbdataset);

                Lecture.EnableHeadersVisualStyles = false;
                Lecture.GridColor = Utility.HeaderBackColor;
                Lecture.ColumnHeadersDefaultCellStyle.BackColor = Utility.HeaderBackColor;
                Lecture.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                Lecture.AutoResizeColumns();
                Lecture.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                Lecture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

                // this design loop for chart
                int i = 0;
                for (int j = 0; j <= 9; j++)
                {
                    // the def of this function located below
                    paintCells2(i);
                    i++;
                }

                foreach (DataGridViewRow row in Lecture.Rows)
                {
                    row.Height = 45;
                }
            }
            catch (Exception ex)
            {
                this.Close();
                MessageBox.Show(ex.Message);
                ExtraLecture form2 = new ExtraLecture();
                form2.Show();
            }
        }


        //TODO:: there is a problem accessing the values in the sql 
        private void NewLec_Click(object sender, EventArgs e)
        {
            string str = null;

            try
            { 
                this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
                this.sqlcon = new SqlConnection(connetionString);
            
           
                if (toolStripComboBox1.Text.Equals("") && !toolStripComboBox2.Text.Equals(""))

                {
                    str = toolStripComboBox2.Text;
                    SqlCommand cmd = new SqlCommand("UPDATE Classes_SM1 SET [" + Hour.Text + "] = 1 WHERE [date] = '" + str + "' AND [Class_Id] = '" + Class.Text + "'", sqlcon);
                    MessageBox.Show("Changed!");
                    Lecture.Visible = true;


                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = cmd;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    Lecture.DataSource = bsource;
                    sda.Update(dbdataset);
                }
                else if (toolStripComboBox2.Text.Equals("") && !toolStripComboBox1.Text.Equals(""))
                {
                    str = toolStripComboBox1.Text;
                    SqlCommand cmd = new SqlCommand("UPDATE Classes_SM2 SET [" + Hour.Text + "] = 1 WHERE [date] = '" + str + "' AND [Class_Id] = '" + Class.Text + "'", sqlcon);
                    MessageBox.Show("Changed!");
                    Lecture.Visible = true;


                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = cmd;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();

                    bsource.DataSource = dbdataset;
                    Lecture.DataSource = bsource;
                    sda.Update(dbdataset);
                }
                else
                {
                    throw new ArgumentException("Error selecting dates,try again!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
                ExtraLecture form2 = new ExtraLecture();
                form2.Show();
            }

}

        // function paint the chart according to 0 or 1
        private void paintCells2(int i)
        {
            for (int j = 5; j < 18; j++)
            {
                if (Convert.ToInt32(Lecture.Rows[i].Cells[j].Value) == 1)
                {
                    Lecture.Rows[i].Cells[j].Style.BackColor = Color.Red;
                    Lecture.Rows[i].Cells[j].Style.ForeColor = Color.Red;
                }

                else
                {
                    Lecture.Rows[i].Cells[j].Style.BackColor = Color.LawnGreen;
                    Lecture.Rows[i].Cells[j].Style.ForeColor = Color.LawnGreen;
                }


            }

        }

        private void NewLecture_Load(object sender, EventArgs e)
        {
            
        }

        private void Hour_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
