using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRPJECT4NEW.Dean_of_Faculty
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            Buttons_view.Visible = false;

        }

        private void Students_Requests_Button_Click(object sender, EventArgs e)
        {

            Calendar frm = new Calendar("Matan", 123456);
            frm.TopLevel = false;
            //frm.FormBorderStyle = FormBorderStyle.None;
            //frm.WindowState = FormWindowState.Maximized;
            Buttons_view.Controls.Add(frm);
            Buttons_view.Visible = true;
            frm.Show();

        }


        private void Important_messages_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Important messages");
        }

        private void Scholarships_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Scholarships");
        }

        private void Technical_Support_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Technical Support");
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
