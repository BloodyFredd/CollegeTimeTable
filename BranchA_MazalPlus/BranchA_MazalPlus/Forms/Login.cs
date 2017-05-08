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
using System.Text.RegularExpressions;
// new updates ver 1, once more


namespace BranchA_MazalPlus
{
    public partial class Login : Form
    {
        public static string ID;//{ get; set; }
        private string connetionString = null;
        private SqlConnection sqlcon;
        // System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(BranchA_MazalPlus.Properties.Resources.mazalmazal);

        public Login()
        {
            InitializeComponent();
           
           // player.SoundLocation = "mazalmazal.wav";
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
            player.Play();
            this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            this.sqlcon = new SqlConnection(connetionString);
            this.sqlcon.Open();
            //SqlCommand cmd = new SqlCommand("select * from person where ID='" + txtuser.Text + "' and Password='" + txtpassword.Text + "'", sqlcon);
            txtuser.Text = txtuser.Text + "@plus.mazal.com";
            SqlCommand cmd = new SqlCommand("select * from person where Email='" + txtuser.Text + "' and Password='" + txtpassword.Text + "'", sqlcon);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                Forms.UserID.ID = string.Copy(dr[0].ToString());
                if (dr[6].ToString() == "Admin")
                {
                    this.Hide();
                    Admin.Menu Connect = new Admin.Menu();
                    Connect.Show();
                    Connect.Admin_name.Text = "      " + dr[1].ToString() + " " + dr[2].ToString();
                }
                else if (dr[6].ToString() == "Lecturer")
                {
                    this.Hide();
                    Lecturer.Menu Connect = new Lecturer.Menu();
                    Connect.Show();
                    Connect.Lecturer_Name.Text = "      " + dr[1].ToString() + " " + dr[2].ToString();
                }
                else if (dr[6].ToString() == "Teaching_Assistant")
                {
                    this.Hide();
                    Teaching_Assistant.Menu Connect = new Teaching_Assistant.Menu();
                    Connect.Show();
                    Connect.Teaching_Assistant_Name.Text = "      " + dr[1].ToString() + " " + dr[2].ToString();
                }
                else if (dr[6].ToString() == "Secretary")
                {
                    this.Hide();
                    Secretary.Menu Connect = new Secretary.Menu();
                    Connect.Show();
                    Connect.Secretary_Name.Text = "      " + dr[1].ToString() + " " + dr[2].ToString();
                }

            }
            else
            {
                MessageBox.Show("Invalid Username or Password ");
                this.sqlcon.Close();
                txtpassword.Clear();
                txtuser.Clear();
                cmd = null;


            }
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
            txtpassword.UseSystemPasswordChar = true;
            txtpassword.Text = "";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // close application
            System.Windows.Forms.Application.Exit();
            //this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
