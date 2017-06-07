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

namespace PRPJECT4NEW.Secretary
{
    public partial class StudentDetails : Form
    {
        private string connetionString = null;
        private SqlConnection sqlcon;

        public StudentDetails()
        {
            InitializeComponent();
        }

        private void StudentDetails_Load(object sender, EventArgs e)
        {

        }

        private void Search_Click_1(object sender, EventArgs e)
        {
            this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            this.sqlcon = new SqlConnection(connetionString);
            SqlCommand cmd = new SqlCommand("select ID,F_name,L_name,Telephone,Email from person where ID='" + IDbutton.Text + "'", sqlcon);
            StudentInfo.Visible = true;
            try
            {
                
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                //Paint headers
                StudentInfo.EnableHeadersVisualStyles = false;
                StudentInfo.GridColor = Utility.HeaderBackColor;
                StudentInfo.ColumnHeadersDefaultCellStyle.BackColor = Utility.HeaderBackColor;
                StudentInfo.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                StudentInfo.AutoResizeColumns();
                StudentInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                StudentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;


                bsource.DataSource = dbdataset;
                StudentInfo.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            this.sqlcon = new SqlConnection(connetionString);
            SqlCommand cmd = new SqlCommand("UPDATE person SET [F_Name] = '"+Fname.Text+ "',[L_Name] = '" + Lname.Text + "',[Telephone] = '" + Phone.Text + "' WHERE [ID] = '" + IDbutton.Text + "'", sqlcon);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;
                StudentInfo.DataSource = bsource;
                sda.Update(dbdataset);
                MessageBox.Show("Changed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Search_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click_1(object sender, EventArgs e)
        {

        }
    }
}
