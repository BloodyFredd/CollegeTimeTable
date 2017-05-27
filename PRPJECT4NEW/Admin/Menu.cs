using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRPJECT4NEW.Classes;

namespace PRPJECT4NEW.Admin
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            Buttons_view.Visible = false;

        }

        private void Sign_new_user_button_Click(object sender, EventArgs e)
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


        private void Sign_Student_Course_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sign a new student to a course.");
        }

        private void Failing_Students_Button_Click(object sender, EventArgs e)
        {
            Reports REPOR = new Reports();
            REPOR.Show();
        }

        private void Remove_Student_Button_Click(object sender, EventArgs e)
        {
            RemoveAssistant remove = new RemoveAssistant();
            remove.Show();
        }

        private void Remove_Teaching_Assistant_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Remove teaching assistant");
        }

        private void Exemption_Stud_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exemption students");
        }

        private void Excellent_Students_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Excellent students");
        }

        private void Occupied_Classes_Button_Click(object sender, EventArgs e)
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

        //private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        //{

//        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Merge_Auditorium_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merge Auditorium");
        }

        private void Logout_Button_Click_1(object sender, EventArgs e)
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

        private void Cancel_Lectures_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancel Lectures");
        }

        private void Sign_person_button_Click(object sender, EventArgs e)
        {
            NewUser frm = new NewUser();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.WindowState = FormWindowState.Maximized;
            panel5.Controls.Add(frm);
            panel5.Visible = true;
            frm.Show();

        }

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Remove_student_Click(object sender, EventArgs e)
        {
            RemoveStudent remove = new RemoveStudent();
            remove.Show();
        }

        private void Merge_Auditorium_button_Click_1(object sender, EventArgs e)
        {
            MergeAuditorium form2 = new MergeAuditorium();
            form2.Show();
        }

        private void Reports_button_Click(object sender, EventArgs e)
        {
            Reports frm = new Reports();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.WindowState = FormWindowState.Maximized;
            panel5.Controls.Add(frm);
            panel5.Visible = true;
            frm.Show();
        }

        private void Remove_Teaching_Assistant_Button_Click_1(object sender, EventArgs e)
        {
            RemoveAssistant remove = new RemoveAssistant();
            remove.Show();
        }

        private void Cancel_Lectures_Click_1(object sender, EventArgs e)
        {
            CancelLectures form2 = new CancelLectures();
            form2.Show();
        }
        private void Sign_student_course_Click(object sender, EventArgs e)
        {
            SignStudent form2 = new SignStudent();
            form2.Show();
        }

        private void Exemption_Student_Button_Click(object sender, EventArgs e)
        {
            StudentExemption form2 = new StudentExemption();
            form2.Show();
        }
    }
}
