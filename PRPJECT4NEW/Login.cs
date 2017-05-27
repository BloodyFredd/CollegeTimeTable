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
using System.Media;
using PRPJECT4NEW.Forms;

namespace PRPJECT4NEW
{
    
    public partial class Login : Form
    {
         System.Media.SoundPlayer player = new System.Media.SoundPlayer(PRPJECT4NEW.Properties.Resources.mazalRing);//music


        int TogMove;
        int MValX;
        int MValY;



        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UserID = txtuser.Text; //Comparison works only after conversion
            string EncryptPass;
            //Connect to data base
            using (Entities context = new Entities())
            {
               
                //Try to connect to database
                try
                {
                    //Chech ID + Password existance
                    EncryptPass = Encrypt.base64Encode(txtpassword.Text);
                   // MessageBox.Show(EncryptPass);
                    if (context.Person.Any(p => p.ID == UserID && p.Password == EncryptPass))
                    {
                        Utility.User = context.Person.SingleOrDefault(p => p.ID == UserID);
                        this.Hide();
                        LoadMenu();

                        //After logout....
                        this.Show();
                        txtuser.Text = "User Name";
                        txtpassword.Text = "Password";
                        txtpassword.UseSystemPasswordChar = false;
                        Center(this);
                    }
                    else
                    {   //Can't find ID + Password
                        MessageBox.Show("Invalid Username or Password ");
                        txtuser.Text = "User Name";
                        txtpassword.Text = "Password";
                        txtpassword.UseSystemPasswordChar = false;
                    }
                }
                catch(System.Data.Entity.Core.EntityException)
                {
                    MessageBox.Show("Can't connect to Database: Try to reconnect");
                }
            }
        }

        private void LoadMenu()
        {
           // player.Play();//music

            switch (Utility.User.Permission)
            {
                case "Student":
                    Student.Menu Student_Connect = new Student.Menu();
                    Student_Connect.Student_Name.Text = "      " + Utility.User.F_name + " " + Utility.User.L_name;
                    Student_Connect.ShowDialog();
                    break;
                case "Exam_Section":
                    Exams_Section.Menu Exam_Connect = new Exams_Section.Menu();
                    Exam_Connect.Student_Name.Text = "      " + Utility.User.F_name + " " + Utility.User.L_name;
                    Exam_Connect.ShowDialog();
                    break;
                case "Tech_Team":
                    Tech_Team.Menu Tech_Connect = new Tech_Team.Menu();
                    Tech_Connect.Student_Name.Text = "      " + Utility.User.F_name + " " + Utility.User.L_name;
                    Tech_Connect.ShowDialog();
                    break;
                case "Dean_of_Faculty":
                    Dean_of_Faculty.Menu Dean_Connect = new Dean_of_Faculty.Menu();
                    Dean_Connect.Student_Name.Text = "      " + Utility.User.F_name + " " + Utility.User.L_name;
                    Dean_Connect.ShowDialog();
                    break;
                case "Admin":
                    Admin.Menu Connect = new Admin.Menu();
                    Connect.Admin_name.Text = "      " + Utility.User.F_name + " " + Utility.User.L_name;
                    Connect.ShowDialog();
                    break;
                case "Lecturer":
                    Lecturer.Menu Connect1 = new Lecturer.Menu();
                    Connect1.Lecturer_Name.Text = "      " + Utility.User.F_name + " " + Utility.User.L_name;
                    Connect1.ShowDialog();
                    break;
                case "Teaching_Assistant":
                    Teaching_Assistant.Menu Connect2 = new Teaching_Assistant.Menu();
                    Connect2.Teaching_Assistant_Name.Text = "      " + Utility.User.F_name + " " + Utility.User.L_name;
                    Connect2.ShowDialog();
                    break;
                case "Secretary":
                    Secretary.Menu Connect3 = new Secretary.Menu();
                    Connect3.Secretary_Name.Text = "      " + Utility.User.F_name + " " + Utility.User.L_name;
                    Connect3.ShowDialog();
                    break;
                default:
                    Console.WriteLine("Wrong User Permission - Check your Database");
                    break;
            }

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void facebook_btnLogin_Click(object sender, EventArgs e)
        {
            //Encrypt.ConvertPass();
           FB_Analyze.FB_Analyze facebook = new FB_Analyze.FB_Analyze();
           facebook.Show();
        }


    }
}
