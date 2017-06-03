using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRPJECT4NEW.Lecturer
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            panel5.Visible = false;

        }

        private void Exams_report_button_Click(object sender, EventArgs e)
        {
            Reports form2 = new Reports();
            form2.TopLevel = false;
            form2.FormBorderStyle = FormBorderStyle.None;
            form2.WindowState = FormWindowState.Maximized;
            panel5.Controls.Add(form2);
            panel5.Visible = true;
            form2.Show();
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
            modifay_grade modifay_grade = new modifay_grade();
            modifay_grade.Show();
        }

        private void Available_Classes_Button_Click(object sender, EventArgs e)
        {
            ExtraLecture lec = new ExtraLecture();

            lec.TopLevel = false;
            lec.FormBorderStyle = FormBorderStyle.None;
            lec.WindowState = FormWindowState.Maximized;
            panel5.Controls.Add(lec);
            panel5.Visible = true;

            lec.Show();
        }

        private void Special_Stud_Button_Click(object sender, EventArgs e)
        {
            bonus_10_points fac = new bonus_10_points();
            fac.Show();
        }

        private void Supervisor_Tut_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Supervisor Tutorial");
        }

        private void Special_Exams_Button_Click(object sender, EventArgs e)
        {
            ReceptionHours rec = new ReceptionHours();
            rec.Show();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
           
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

        private void AddNewLecture_Click(object sender, EventArgs e)
        {
            AddLecture lec = new AddLecture();
            lec.Show();
        }

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Have a good day!");
            // close application
            this.Close();
        }
    }
}
