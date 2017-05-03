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


namespace BranchA_MazalPlus.Secretary
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
            Reports REPOR = new Reports();
            REPOR.Show();

            // // SqlConnection sqlcon = new SqlConnection(@"Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            // // sqlcon.Open();
            // //            try
            // //           {
            // this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            // this.sqlcon = new SqlConnection(connetionString);
            // this.sqlcon.Open();
            // //SqlCommand cmd = new SqlCommand("select * from person where ID='" + txtuser.Text + "' and Password='" + txtpassword.Text + "'", sqlcon);
            // SqlCommand cmd = new SqlCommand("select * from person ", sqlcon);
            // //if can read the table 
            // SqlDataReader dr = cmd.ExecuteReader();
            // //if (dr.Read() == true)
            // //{
            //     // MessageBox.Show("Login Successful");
            //    // if (dr[6].ToString() == "Student")
            //    // {
            //         SqlDataAdapter sda = new SqlDataAdapter();
            //         sda.SelectCommand = cmd;
            //         DataTable dbdataset = new DataTable();
            //         sda.Fill(dbdataset);
            //         BindingSource bsource = new BindingSource();

            //         bsource.DataSource = dbdataset;
            //         StudentsReport.DataSource = bsource;
            //         sda.Update(dbdataset);
            //   //  }
            //// }
        }


        private void Exams_Assignment_Button_Click(object sender, EventArgs e)
        {
            AddStudent form2 = new AddStudent();
            form2.Show();
        }

        private void Supervisors_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Assign a student for all year ");
        }

        private void Supervisors_List_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Access to a schedule of a student");
        }

        private void Available_Classes_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modify courses of a student");
            
        }

        private void Special_Stud_Button_Click(object sender, EventArgs e)
        {
            Modifay_2_classes modifay = new Modifay_2_classes();
            modifay.Show();
        }

        private void Supervisor_Tut_Button_Click(object sender, EventArgs e)
        {
            Course_And_Prev modifay = new Course_And_Prev();
            modifay.Show();
        }

        private void Special_Exams_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Temporary button");
        }

        private void Logout_Click(object sender, EventArgs e)
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
