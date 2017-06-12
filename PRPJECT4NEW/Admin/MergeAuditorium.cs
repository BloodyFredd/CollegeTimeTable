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

namespace PRPJECT4NEW.Admin
{
    public partial class MergeAuditorium : Form
    {
        private string connetionString = null;
        private SqlConnection sqlcon;

        public MergeAuditorium()
        {
            InitializeComponent();
        }

        private void Available_Classes_Click(object sender, EventArgs e)
        {

        }

        public bool checkChoice(string value1, string value2)
        {
            if (value1.Equals("") && !value2.Equals(""))
                return true;
            return false;
        }

        private void Merge_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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

                //Paint headers
                Lecture.EnableHeadersVisualStyles = false;
                Lecture.GridColor = Utility.HeaderBackColor;
                Lecture.ColumnHeadersDefaultCellStyle.BackColor = Utility.HeaderBackColor;
                Lecture.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                Lecture.AutoResizeColumns();
                Lecture.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                Lecture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;


                bsource.DataSource = dbdataset;
                Lecture.DataSource = bsource;
                sda.Update(dbdataset);

                int i = 0;
                for (int j = 0; j <= 9; j++)
                {
                    paintCells2(i);
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                toolStripComboBox1.Text = "";
                toolStripComboBox2.Text = "";
            }
        }

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

        private void My_Lectures_Click(object sender, EventArgs e)
        {
            string str = null;


            try
            {
                this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
                this.sqlcon = new SqlConnection(connetionString);
                SqlCommand cmd = new SqlCommand("select * from Classes_SM1 where date='" + "1990-01-01" + "'", sqlcon);
                SqlCommand cmd0 = new SqlCommand("select * from Classes_SM1 where date='" + "1990-01-01" + "'", sqlcon);
                if (checkChoice(toolStripComboBox1.Text, toolStripComboBox2.Text))

                {
                    str = toolStripComboBox2.Text;
                    cmd = new SqlCommand("UPDATE Classes_SM1 SET Capacity= 20 where class_Id='" + "a101" + "'AND date='" + str + "'", sqlcon);
                    cmd0 = new SqlCommand("UPDATE Classes_SM1 SET Capacity= 0 where class_Id='" + "a102" + "' AND date='" + str + "'", sqlcon);

                    Lecture.Visible = true;

                    SqlCommand cmd1 = new SqlCommand("update Classes_SM1 set [08-09]=1 where Class_Id ='" + "a102" + "' AND date = '" + toolStripComboBox2.Text + "'", sqlcon);
                    SqlCommand cmd2 = new SqlCommand("update Classes_SM1 set [09-10]=1 where Class_Id ='" + "a102" + "' AND date = '" + toolStripComboBox2.Text + "'", sqlcon);
                    SqlCommand cmd3 = new SqlCommand("update Classes_SM1 set [10-11]=1 where Class_Id ='" + "a102" + "'  AND date = '" + toolStripComboBox2.Text + "'", sqlcon);
                    SqlCommand cmd4 = new SqlCommand("update Classes_SM1 set [11-12]=1 where Class_Id ='" + "a102" + "'  AND date = '" + toolStripComboBox2.Text + "'", sqlcon);
                    SqlCommand cmd5 = new SqlCommand("update Classes_SM1 set [12-13]=1 where Class_Id ='" + "a102" + "'  AND date = '" + toolStripComboBox2.Text + "'", sqlcon);
                    SqlCommand cmd6 = new SqlCommand("update Classes_SM1 set [13-14]=1 where Class_Id ='" + "a102" + "'  AND date = '" + toolStripComboBox2.Text + "'", sqlcon);
                    SqlCommand cmd7 = new SqlCommand("update Classes_SM1 set [14-15]=1 where Class_Id ='" + "a102" + "'  AND date = '" + toolStripComboBox2.Text + "'", sqlcon);
                    SqlCommand cmd8 = new SqlCommand("update Classes_SM1 set [15-16]=1 where Class_Id ='" + "a102" + "'  AND date = '" + toolStripComboBox2.Text + "'", sqlcon);
                    SqlCommand cmd9 = new SqlCommand("update Classes_SM1 set [16-17]=1 where Class_Id ='" + "a102" + "'  AND date = '" + toolStripComboBox2.Text + "'", sqlcon);
                    SqlCommand cmd10 = new SqlCommand("update Classes_SM1 set [17-18]=1 where Class_Id ='" + "a102" + "'  AND date = '" + toolStripComboBox2.Text + "'", sqlcon);
                    SqlCommand cmd11 = new SqlCommand("update Classes_SM1 set [18-19]=1 where Class_Id ='" + "a102" + "'  AND date = '" + toolStripComboBox2.Text + "'", sqlcon);
                    SqlCommand cmd12 = new SqlCommand("update Classes_SM1 set [19-20]=1 where Class_Id ='" + "a102" + "'  AND date = '" + toolStripComboBox2.Text + "'", sqlcon);
                    SqlCommand cmd13 = new SqlCommand("update Classes_SM1 set [20-21]=1 where Class_Id ='" + "a102" + "'  AND date = '" + toolStripComboBox2.Text + "'", sqlcon);

                    SqlDataAdapter sda0 = new SqlDataAdapter();
                    sda0.SelectCommand = cmd1;
                    SqlDataAdapter sda2 = new SqlDataAdapter();
                    sda2.SelectCommand = cmd2;
                    SqlDataAdapter sda3 = new SqlDataAdapter();
                    sda3.SelectCommand = cmd3;
                    SqlDataAdapter sda4 = new SqlDataAdapter();
                    sda4.SelectCommand = cmd4;
                    SqlDataAdapter sda5 = new SqlDataAdapter();
                    sda5.SelectCommand = cmd5;
                    SqlDataAdapter sda6 = new SqlDataAdapter();
                    sda6.SelectCommand = cmd6;
                    SqlDataAdapter sda7 = new SqlDataAdapter();
                    sda7.SelectCommand = cmd7;
                    SqlDataAdapter sda8 = new SqlDataAdapter();
                    sda8.SelectCommand = cmd8;
                    SqlDataAdapter sda9 = new SqlDataAdapter();
                    sda9.SelectCommand = cmd9;
                    SqlDataAdapter sda10 = new SqlDataAdapter();
                    sda10.SelectCommand = cmd10;
                    SqlDataAdapter sda11 = new SqlDataAdapter();
                    sda11.SelectCommand = cmd11;
                    SqlDataAdapter sda12 = new SqlDataAdapter();
                    sda12.SelectCommand = cmd12;
                    SqlDataAdapter sda13 = new SqlDataAdapter();
                    sda13.SelectCommand = cmd13;
                    DataTable dbdataset0 = new DataTable();

                    sda0.Fill(dbdataset0);
                    sda2.Fill(dbdataset0);
                    sda3.Fill(dbdataset0);
                    sda4.Fill(dbdataset0);
                    sda5.Fill(dbdataset0);
                    sda6.Fill(dbdataset0);
                    sda7.Fill(dbdataset0);
                    sda8.Fill(dbdataset0);
                    sda9.Fill(dbdataset0);
                    sda10.Fill(dbdataset0);
                    sda11.Fill(dbdataset0);
                    sda12.Fill(dbdataset0);
                    sda13.Fill(dbdataset0);
                    BindingSource bsource1 = new BindingSource();
                    bsource1.DataSource = dbdataset0;

                    sda0.Update(dbdataset0);
                    sda2.Update(dbdataset0);
                    sda3.Update(dbdataset0);
                    sda4.Update(dbdataset0);
                    sda5.Update(dbdataset0);
                    sda6.Update(dbdataset0);
                    sda7.Update(dbdataset0);
                    sda8.Update(dbdataset0);
                    sda9.Update(dbdataset0);
                    sda10.Update(dbdataset0);
                    sda11.Update(dbdataset0);
                    sda12.Update(dbdataset0);
                    sda13.Update(dbdataset0);
                }
                else if (checkChoice(toolStripComboBox2.Text, toolStripComboBox1.Text))
                {
                    str = toolStripComboBox1.Text;
                    cmd = new SqlCommand("UPDATE Classes_SM2 SET Capacity= 20 where class_Id='" + "a101" + "'AND date='" + str + "'", sqlcon);
                    cmd0 = new SqlCommand("UPDATE Classes_SM2 SET Capacity= 0 where class_Id='" + "a102" + "' AND date='" + str + "'", sqlcon);
                    Lecture.Visible = true;

                    SqlCommand cmd1 = new SqlCommand("update Classes_SM2 set [08-09]=1 where Class_Id ='" + "a102" + "' AND date = '" + toolStripComboBox1.Text + "'", sqlcon);
                    SqlCommand cmd2 = new SqlCommand("update Classes_SM2 set [09-10]=1 where Class_Id ='" + "a102" + "' AND date = '" + toolStripComboBox1.Text + "'", sqlcon);
                    SqlCommand cmd3 = new SqlCommand("update Classes_SM2 set [10-11]=1 where Class_Id ='" + "a102" + "'  AND date = '" + toolStripComboBox1.Text + "'", sqlcon);
                    SqlCommand cmd4 = new SqlCommand("update Classes_SM2 set [11-12]=1 where Class_Id ='" + "a102" + "'  AND date = '" + toolStripComboBox1.Text + "'", sqlcon);
                    SqlCommand cmd5 = new SqlCommand("update Classes_SM2 set [12-13]=1 where Class_Id ='" + "a102" + "'  AND date = '" + toolStripComboBox1.Text + "'", sqlcon);
                    SqlCommand cmd6 = new SqlCommand("update Classes_SM2 set [13-14]=1  where Class_Id ='" + "a102" + "'  AND date = '" + toolStripComboBox1.Text + "'", sqlcon);
                    SqlCommand cmd7 = new SqlCommand("update Classes_SM2 set [14-15]=1 where Class_Id ='" + "a102" + "'  AND date = '" + toolStripComboBox1.Text + "'", sqlcon);
                    SqlCommand cmd8 = new SqlCommand("update Classes_SM2 set [15-16]=1 where Class_Id ='" + "a102" + "'  AND date = '" + toolStripComboBox1.Text + "'", sqlcon);
                    SqlCommand cmd9 = new SqlCommand("update Classes_SM2 set [16-17]=1 where Class_Id ='" + "a102" + "'  AND date = '" + toolStripComboBox1.Text + "'", sqlcon);
                    SqlCommand cmd10 = new SqlCommand("update Classes_SM2 set [17-18]=1where Class_Id ='" + "a102" + "'  AND date = '" + toolStripComboBox1.Text + "'", sqlcon);
                    SqlCommand cmd11 = new SqlCommand("update Classes_SM2 set [18-19]=1 where Class_Id ='" + "a102" + "'  AND date = '" + toolStripComboBox1.Text + "'", sqlcon);
                    SqlCommand cmd12 = new SqlCommand("update Classes_SM2 set [19-20]=1 where Class_Id ='" + "a102" + "'  AND date = '" + toolStripComboBox1.Text + "'", sqlcon);
                    SqlCommand cmd13 = new SqlCommand("update Classes_SM2 set [20-21]=1where Class_Id ='" + "a102" + "'  AND date = '" + toolStripComboBox1.Text + "'", sqlcon);

                    SqlDataAdapter sda0 = new SqlDataAdapter();
                    sda0.SelectCommand = cmd1;
                    SqlDataAdapter sda2 = new SqlDataAdapter();
                    sda2.SelectCommand = cmd2;
                    SqlDataAdapter sda3 = new SqlDataAdapter();
                    sda3.SelectCommand = cmd3;
                    SqlDataAdapter sda4 = new SqlDataAdapter();
                    sda4.SelectCommand = cmd4;
                    SqlDataAdapter sda5 = new SqlDataAdapter();
                    sda5.SelectCommand = cmd5;
                    SqlDataAdapter sda6 = new SqlDataAdapter();
                    sda6.SelectCommand = cmd6;
                    SqlDataAdapter sda7 = new SqlDataAdapter();
                    sda7.SelectCommand = cmd7;
                    SqlDataAdapter sda8 = new SqlDataAdapter();
                    sda8.SelectCommand = cmd8;
                    SqlDataAdapter sda9 = new SqlDataAdapter();
                    sda9.SelectCommand = cmd9;
                    SqlDataAdapter sda10 = new SqlDataAdapter();
                    sda10.SelectCommand = cmd10;
                    SqlDataAdapter sda11 = new SqlDataAdapter();
                    sda11.SelectCommand = cmd11;
                    SqlDataAdapter sda12 = new SqlDataAdapter();
                    sda12.SelectCommand = cmd12;
                    SqlDataAdapter sda13 = new SqlDataAdapter();
                    sda13.SelectCommand = cmd13;
                    DataTable dbdataset0 = new DataTable();

                    sda0.Fill(dbdataset0);
                    sda2.Fill(dbdataset0);
                    sda3.Fill(dbdataset0);
                    sda4.Fill(dbdataset0);
                    sda5.Fill(dbdataset0);
                    sda6.Fill(dbdataset0);
                    sda7.Fill(dbdataset0);
                    sda8.Fill(dbdataset0);
                    sda9.Fill(dbdataset0);
                    sda10.Fill(dbdataset0);
                    sda11.Fill(dbdataset0);
                    sda12.Fill(dbdataset0);
                    sda13.Fill(dbdataset0);
                    BindingSource bsource1 = new BindingSource();
                    bsource1.DataSource = dbdataset0;

                    sda0.Update(dbdataset0);
                    sda2.Update(dbdataset0);
                    sda3.Update(dbdataset0);
                    sda4.Update(dbdataset0);
                    sda5.Update(dbdataset0);
                    sda6.Update(dbdataset0);
                    sda7.Update(dbdataset0);
                    sda8.Update(dbdataset0);
                    sda9.Update(dbdataset0);
                    sda10.Update(dbdataset0);
                    sda11.Update(dbdataset0);
                    sda12.Update(dbdataset0);
                    sda13.Update(dbdataset0);
                }
                else
                {
                    throw new ArgumentException("Error selecting dates,try again!");
                }

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                SqlDataAdapter sda1 = new SqlDataAdapter();
                sda1.SelectCommand = cmd0;
                DataTable dbdataset1 = new DataTable();
                sda1.Fill(dbdataset1);
                BindingSource bsource = new BindingSource();

                //Paint headers
                Lecture.EnableHeadersVisualStyles = false;
                Lecture.GridColor = Utility.HeaderBackColor;
                Lecture.ColumnHeadersDefaultCellStyle.BackColor = Utility.HeaderBackColor;
                Lecture.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                Lecture.AutoResizeColumns();
                Lecture.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                Lecture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;


                bsource.DataSource = dbdataset;
                Lecture.DataSource = bsource;
                sda.Update(dbdataset);
                sda1.Update(dbdataset);
            }
            catch (Exception ex)
            {
                this.Close();
                MessageBox.Show(ex.Message);
                MergeAuditorium form2 = new MergeAuditorium();
                form2.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
