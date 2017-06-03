using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRPJECT4NEW.Student
{
    public partial class Menu : Form
    {
        public student studentUsr;

        public Menu()
        {

            InitializeComponent();
            Buttons_view.Visible = false;

            //Connect to data base and get student info
            using (Entities context = new Entities())
            {
                //Try to connect to database
                //TODO check if no student with person id exists
                try
                {
                    studentUsr = context.students.SingleOrDefault(s => s.ID == Utility.User.ID);
                }
                catch (System.Data.Entity.Core.EntityException)
                {
                    MessageBox.Show("Can't connect to Database: Try to reconnect");
                }
            }
        }

        private void Celender_Click(object sender, EventArgs e)
        {
            Student.Calendar frm = new Student.Calendar();
            frm.TopLevel = false;
            //frm.FormBorderStyle = FormBorderStyle.None;
            //frm.WindowState = FormWindowState.Maximized;
            Buttons_view.Controls.Add(frm);
            Buttons_view.Visible = true;
            frm.Show();

        }


        private void Update_Calendar_Button_Click(object sender, EventArgs e)
        {
            Student.UpdateCalendar frm = new Student.UpdateCalendar();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.WindowState = FormWindowState.Maximized;
            Buttons_view.Controls.Add(frm);
            Buttons_view.Visible = true;
            frm.Show();
        }

        private void Messages_Button_Click(object sender, EventArgs e)
        {
            Student.Messages frm = new Student.Messages(studentUsr);
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.WindowState = FormWindowState.Maximized;
            Buttons_view.Controls.Add(frm);
            Buttons_view.Visible = true;
            frm.Show();
        }

        private void Exams_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exams calendar");
        }

        private void Holidays_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Holidays calendar");
        }
    
        private void Fees_Button_Click(object sender, EventArgs e)
        {
            TuitionFeesForm frm = new TuitionFeesForm();
            frm.TopLevel = false;
            Buttons_view.Controls.Add(frm);
            Buttons_view.Visible = true;
            frm.Show();
        }

        private void Requests_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Requests panel");
        }

        private void Exam_Res_Button_Click(object sender, EventArgs e)
        {
            Student.ExamResults frm = new Student.ExamResults(studentUsr);
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.WindowState = FormWindowState.Maximized;
            Buttons_view.Controls.Add(frm);
            Buttons_view.Visible = true;
            frm.Show();
        }

        private void Alerts_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alerts!");
        }

        private void Logout_Click(object sender, EventArgs e)
        {
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
            this.Close();
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
