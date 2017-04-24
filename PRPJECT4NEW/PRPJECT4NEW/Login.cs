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
        
        int TogMove;
        int MValX;
        int MValY;

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double UserID = Convert.ToDouble(txtuser.Text); //Comparison works only after conversion

            //Connect to data base
            using (MazalEntities context = new MazalEntities())
            {
               
                //Try to connect to database
                try
                {
                    //Chech ID + Password existance
                    if (context.People.Any(p => p.ID == UserID && p.Password == txtpassword.Text))
                    {
                        Utility.User = context.People.SingleOrDefault(p => p.ID == UserID);
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
                catch(System.Data.Entity.Core.EntityException exception)
                {
                    MessageBox.Show("Can't connect to Database: " + exception.ToString());
                }
            }
        }

        private void LoadMenu()
        {    
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
    }
}
