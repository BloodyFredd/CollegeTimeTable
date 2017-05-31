using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PRPJECT4NEW.Teaching_Assistant
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
            Reports frm = new Reports();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.WindowState = FormWindowState.Maximized;
            panel5.Controls.Add(frm);
            panel5.Visible = true;
            frm.Show();

        }


        private void Exams_Assignment_Button_Click(object sender, EventArgs e)
        {
            Grade56 grade = new Grade56();
            grade.Show();
        }

        private void Supervisors_Button_Click(object sender, EventArgs e)
        {
            Zero zero = new Zero();
            zero.Show();
        }

        private void Supervisors_List_Button_Click(object sender, EventArgs e)
        {
            ReceptionHours rec = new ReceptionHours();
            rec.Show();
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
            MessageBox.Show("Move to login panel");
            this.Close();
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

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            AddLabExercises rec = new AddLabExercises();
            rec.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Have a good day!");
            // close application
            this.Close();
        }
    }
}
