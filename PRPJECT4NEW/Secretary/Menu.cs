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


namespace PRPJECT4NEW.Secretary
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
            AddStudent form2 = new AddStudent();
            form2.TopLevel = false;
            form2.FormBorderStyle = FormBorderStyle.None;
            form2.WindowState = FormWindowState.Maximized;
            panel5.Controls.Add(form2);
            panel5.Visible = true;
            form2.Show();
        }

        private void Supervisors_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Assign a student for all year ");
        }

        private void Supervisors_List_Button_Click(object sender, EventArgs e)
        {
            StudentDetails form2 = new StudentDetails();
            form2.TopLevel = false;
            form2.FormBorderStyle = FormBorderStyle.None;
            form2.WindowState = FormWindowState.Maximized;
            panel5.Controls.Add(form2);
            panel5.Visible = true;
            form2.Show();
        }

        private void Available_Classes_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modify courses of a student");
            
        }

        private void Special_Stud_Button_Click(object sender, EventArgs e)
        {
            Modifay_2_classes form2 = new Modifay_2_classes();
            form2.TopLevel = false;
            form2.FormBorderStyle = FormBorderStyle.None;
            form2.WindowState = FormWindowState.Maximized;
            panel5.Controls.Add(form2);
            panel5.Visible = true;
            form2.Show();
        }

        private void Supervisor_Tut_Button_Click(object sender, EventArgs e)
        {
            Course_And_Prev form2 = new Course_And_Prev();
            form2.TopLevel = false;
            form2.FormBorderStyle = FormBorderStyle.None;
            form2.WindowState = FormWindowState.Maximized;
            panel5.Controls.Add(form2);
            panel5.Visible = true;
            form2.Show();
        }

        private void Special_Exams_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Temporary button");
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Have a good day!");
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


        }



    }
}
