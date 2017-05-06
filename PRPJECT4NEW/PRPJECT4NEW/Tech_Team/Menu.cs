using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRPJECT4NEW.Tech_Team
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            Buttons_view.Visible = false;

        }

        private void Available_Classes_button_Click(object sender, EventArgs e)
        {

            //Calendar frm = new Calendar("Matan", 123456);
            //frm.TopLevel = false;
            ////frm.FormBorderStyle = FormBorderStyle.None;
            ////frm.WindowState = FormWindowState.Maximized;
            //Buttons_view.Controls.Add(frm);
            //Buttons_view.Visible = true;
            //frm.Show();

        }


        private void classes_with_more_than_10_students_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("classes_with_more_than_10_students");
        }

        private void Recorded_lectures_display_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Recorded_lectures_display");
        }

        private void list_of_conferences_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("list of conferences in college in this week");
        }

        private void special_request_from_DF_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Requests from DF(Dean of Faculty)");

            DF_requestForm frm = new DF_requestForm();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.WindowState = FormWindowState.Maximized;
            Buttons_view.Controls.Add(frm);
            Buttons_view.Visible = true;
            frm.Show();
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


    }
}
