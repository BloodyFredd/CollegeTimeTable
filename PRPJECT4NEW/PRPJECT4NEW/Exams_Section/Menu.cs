using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRPJECT4NEW.Exams_Section
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

        // present list of student with Ease of study
        private void Special_Stud_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Special Students");
            special_student_list frm = new special_student_list();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.WindowState = FormWindowState.Maximized;
            Buttons_view.Controls.Add(frm);
            Buttons_view.Visible = true;
            frm.Show();

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
            Application.Exit();
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

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
