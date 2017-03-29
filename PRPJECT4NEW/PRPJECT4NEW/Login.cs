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
        private string connetionString = null;
        private SqlConnection sqlcon;


        public Login()
        {
            InitializeComponent();
            this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            this.sqlcon = new SqlConnection(connetionString);
            this.sqlcon.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // SqlConnection sqlcon = new SqlConnection(@"Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            // sqlcon.Open();
//            try
 //           {
                SqlCommand cmd = new SqlCommand("select * from person where ID='" + txtuser.Text + "' and Password='" + txtpassword.Text + "'", sqlcon);
                SqlDataReader dr = cmd.ExecuteReader();
               
                if (dr.Read() == true)
                {
                    // MessageBox.Show("Login Successful");
                    if (dr[6].ToString() == "Student")
                    {
                        //MessageBox.Show("Login student");
                        this.Hide();
                        Form1 Connect = new Form1();
                        Connect.Show();
                    }
                    else if (dr[6].ToString() == "Exam_Section")
                    {
                        //MessageBox.Show("Login Exam_Section");
                        this.Hide();
                        Exams_Section.Menu Connect = new Exams_Section.Menu();
                        Connect.Show();
                    }
                    else if (dr[6].ToString() == "Tech_Team")
                    {
                        // MessageBox.Show("Login Tech_Team");
                        this.Hide();
                        Tech_Team.Menu Connect = new Tech_Team.Menu();
                        Connect.Show();
                    }
                    else
                    {
                        // MessageBox.Show("Login Dean_of_Faculty");
                        this.Hide();
                        Dean_of_Faculty.Menu Connect = new Dean_of_Faculty.Menu();
                        Connect.Show();
                    }
                }
                else
                {
                MessageBox.Show("error");
                txtpassword.Clear();
                txtuser.Clear();
                cmd = null;
                
                
            }
               
 //           }
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Exception");
            //}
        }

// button quit
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuser_Click(object sender, EventArgs e)
        {
            txtuser.Text = "";
        }

        private void txtpassword_Click(object sender, EventArgs e)
        {
            txtpassword.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //if (this.sqlcon==true)
            // {
            this.sqlcon.Close();
            //}
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
