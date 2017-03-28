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

namespace PRPJECT4NEW
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("select * from person where ID='" + txtuser.Text + "' and Password='" + txtpassword.Text + "'", sqlcon);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                MessageBox.Show("Login Successful");
            }
            else
            {
                MessageBox.Show("Invalid Credentials, Please Re-Enter");
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bye bye");
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
