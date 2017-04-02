using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BranchA_MazalPlus.Admin
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            Buttons_view.Visible = false;

        }

        private void Exams_report_button_Click(object sender, EventArgs e)
        {
            NewUser Connect = new NewUser();
            Connect.Show();
            //Calendar frm = new Calendar("Matan", 123456);
            //frm.TopLevel = false;
            ////frm.FormBorderStyle = FormBorderStyle.None;
            ////frm.WindowState = FormWindowState.Maximized;
            //Buttons_view.Controls.Add(frm);
            //Buttons_view.Visible = true;
            //frm.Show();

        }


        private void Exams_Assignment_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exams Assignment");
        }

        private void Supervisors_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Supervisors Assignment");
        }

        private void Supervisors_List_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Supervisors List");
        }

        private void Available_Classes_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Available Classes");
        }

        private void Special_Stud_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Special Students");
        }

        private void Supervisor_Tut_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Supervisor Tutorial");
        }

        private void Special_Exams_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Special Exams");
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            //MessageBox.Show("Move to login panel");
            //this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


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


        private void panel5_Paint(object sender, PaintEventArgs e)
        {

            //Calendar frm = new Calendar();
            //frm.TopLevel = false;
            //frm.FormBorderStyle = FormBorderStyle.None;
            //frm.WindowState = FormWindowState.Maximized;
            //Buttons_view.Controls.Add(frm);
            //frm.Show();

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Have a good day!");
            // hide main form
            this.Hide();

            // show other form
            Login form2 = new Login();
            form2.Show();

            // close application
            this.Close();
        }
    }
}
