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

namespace BranchA_MazalPlus.Teaching_Assistant
{
    public partial class ReceptionHours : Form
    {
        private string connetionString = null;
        private SqlConnection sqlcon;
        public ReceptionHours()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            this.sqlcon = new SqlConnection(connetionString);
            try
            {
                SqlCommand cmd = new SqlCommand("update Classes_SM1 set [08-09]=[08-09] + 1 and [09-10]=[09-10] + 1 and [10-11]=[10-11] + 1 and [11-12]=[11-12] + 1 and [12-13]=[12-13] + 1 and [13-14]=[13-14] + 1 and [14-15]=[14-15] + 1 and [15-16]=[15-16] + 1 and [16-17]=[16-17] + 1 and [17-18]=[17-18] + 1 and [18-19]=[18-19] + 1 and [19-20]=[19-20] + 1 and [20-21]=[20-21] + 1 where Class_Id ='" + Office_Button.Text + "'", sqlcon);
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;
                sda.Update(dbdataset);
            }
            //catch (SqlException ex)
            //{
            //    this.Close();
            //    MessageBox.Show("Error selecting class id, try again!");
            //    ReceptionHours form2 = new ReceptionHours();
            //    form2.Show();
            //}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Added succesfully.");
            this.Close();
            this.sqlcon.Close();
        }
    }
}
