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
        int TogMove;
        int MValX;
        int MValY;

        public Login()
        {
            InitializeComponent();
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
            this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            this.sqlcon = new SqlConnection(connetionString);
            this.sqlcon.Open();
            SqlCommand cmd = new SqlCommand("select * from person where ID='" + txtuser.Text + "' and Password='" + txtpassword.Text + "'", sqlcon);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {

                // MessageBox.Show("Login Successful");
                if (dr[6].ToString() == "Student")
                {
                    //MessageBox.ShowDialog("Login student");
                    this.Hide();
                    string Student_ID = dr[0].ToString();
                    Student.Menu Connect = new Student.Menu(Student_ID);
                    // Connect.ShowDialog();
                    Connect.Student_Name.Text = "      " + dr[1].ToString() + " " + dr[2].ToString();
                    Connect.ShowDialog();
                    //after logout
                    this.Show();
                    this.sqlcon.Close();
                    txtuser.Text = "User Name";
                    txtpassword.Text = "Password";
                    txtpassword.UseSystemPasswordChar = false;
                    Center(this);
                }
                else if (dr[6].ToString() == "Exam_Section")
                {
                    //MessageBox.Show("Login Exam_Section");
                    this.Hide();
                    Exams_Section.Menu Connect = new Exams_Section.Menu();
                    // Connect.ShowDialog();
                    Connect.Student_Name.Text = "      " + dr[1].ToString() + " " + dr[2].ToString();
                    Connect.ShowDialog();
                    //after logout
                    this.Show();
                    this.sqlcon.Close();
                    txtuser.Text = "User Name";
                    txtpassword.Text = "Password";
                    txtpassword.UseSystemPasswordChar = false;
                    Center(this);
                }
                else if (dr[6].ToString() == "Tech_Team")
                {
                    // MessageBox.Show("Login Tech_Team");
                    this.Hide();
                    Tech_Team.Menu Connect = new Tech_Team.Menu();
                    // Connect.ShowDialog();
                    Connect.Student_Name.Text = "      " + dr[1].ToString() + " " + dr[2].ToString();
                    Connect.ShowDialog();
                    //after logout
                    this.Show();
                    this.sqlcon.Close();
                    txtuser.Text = "User Name";
                    txtpassword.Text = "Password";
                    txtpassword.UseSystemPasswordChar = false;
                    Center(this);
                }
                else if (dr[6].ToString() == "Dean_of_Faculty")
                {
                    // MessageBox.Show("Login Dean_of_Faculty");
                    this.Hide();
                    Dean_of_Faculty.Menu Connect = new Dean_of_Faculty.Menu();
                    // Connect.ShowDialog();
                    Connect.Student_Name.Text = "      " + dr[1].ToString() + " " + dr[2].ToString();
                    Connect.ShowDialog();
                    //after logout
                    this.Show();
                    this.sqlcon.Close();
                    txtuser.Text = "User Name";
                    txtpassword.Text = "Password";
                    txtpassword.UseSystemPasswordChar = false;
                    Center(this);
                }
                else
                {
                    MessageBox.Show("The user is not have permisions in your branch ");
                    this.sqlcon.Close();
                    txtuser.Text = "User Name";
                    txtpassword.Text = "Password";
                    txtpassword.UseSystemPasswordChar = false;
                }

            }
            else
            {
                MessageBox.Show("Invalid Username or Password ");
                this.sqlcon.Close();
                txtuser.Text = "User Name";
                txtpassword.Text = "Password";
                txtpassword.UseSystemPasswordChar = false;
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
            Application.Exit();
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

        private void txtuser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtpassword.Focus();
        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, (EventArgs)e);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }
        private void Center(Form form)
        {
            form.Location = new Point((Screen.PrimaryScreen.Bounds.Size.Width / 2) - (form.Size.Width / 2), (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (form.Size.Height / 2));
        }
    }
}
