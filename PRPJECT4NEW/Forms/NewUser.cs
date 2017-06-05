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
using Facebook;
using PRPJECT4NEW.Forms;

namespace PRPJECT4NEW
{
    public partial class NewUser : Form
    {
        private string connetionString = null;
        private SqlConnection sqlcon;
        public static string  FnameF,LnameF, EmaillF;



        public NewUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
                this.sqlcon = new SqlConnection(connetionString);
                this.sqlcon.Open();
                checkString(this.ID.Text, "ID");
                checkString(this.Fname.Text, "name");
                checkString(this.Lname.Text, "name");
                checkString(this.Phone.Text, "telephone");
                if (!this.Email.Text.Contains("@"))
                {
                    checkString(this.Email.Text, "username");
                    this.Email.Text = this.Email.Text + "@plus.mazal.com";
                }
                string Encod = Forms.Encrypt.base64Encode(this.ID.Text);
                MessageBox.Show(Encod);
                string query = "INSERT INTO person (ID,F_name,L_name,Telephone,Email,Password,Permission) VALUES('" + this.ID.Text + "','" + this.Fname.Text + "','" + this.Lname.Text + "','" + this.Phone.Text + "','" + this.Email.Text + "','" + Encod + "','" + this.perm1.Text + "')  ; ";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                SqlDataReader dr = cmd.ExecuteReader();

                if (this.perm1.Text == "Student")
                {
                    this.sqlcon.Close();
                    this.sqlcon = new SqlConnection(connetionString);
                    this.sqlcon.Open();
                    string query1 = "INSERT INTO students (ID,Department,Year,Average,ExtraTime,Laptop,FormulaSheet) VALUES('" + this.ID.Text + "', 'Computer Science', 1, 0, 0, 0, 0)  ; ";

                    SqlCommand cmd1 = new SqlCommand(query1, sqlcon);
                    SqlDataReader dr1 = cmd1.ExecuteReader();
                    dr1.Close();
                }
                SendMail Send = new SendMail();
                Send.Send(this.Email.Text, "Welcome to MazalPlus", "We're glad you joined us,<br />Your username is:" + this.ID.Text + "<br />Password: " + this.ID.Text);
                MessageBox.Show("Saved");
                this.sqlcon.Close();
                this.Close();

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
                this.sqlcon.Close();
                this.Close();
            }
        }


        public bool checkString(string str, string check)
        {
            if (check == "ID")
            {
                bool allDigits = str.All(char.IsDigit);
                if (str.Length != 9 || allDigits == false)
                {
                    throw new ArgumentException("ID should be only digits and with length of 9.");
                }
                SqlCommand cmd = new SqlCommand("select * from person where ID='" + this.ID.Text + "'", sqlcon);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                    throw new ArgumentException("There exists such an ID.");
                this.sqlcon.Close();
                this.sqlcon = new SqlConnection(connetionString);
                this.sqlcon.Open();
                dr.Close();
                return true;
            }

            if (check == "name")
            {
                foreach (char c in str)
                {
                    if (!Char.IsLetter(c))
                        throw new ArgumentException("Name should be only alphabetical letters.");
                }
                if(str.Length > 12)
                    throw new ArgumentException("Name should be shorter than the length of 12.");
                return true;
            }

            if (check == "telephone")
            {
                bool allDigits = str.All(char.IsDigit);
                if (str.Length != 10 || allDigits == false)
                    throw new ArgumentException("Telephone should be only digits and with length of 10.");
                return true;
            }

            if (check == "username")
            {
                foreach (char c in str)
                {
                    if (!Char.IsLetterOrDigit(c) && c != '_')
                        throw new ArgumentException("User name should be only numbers or digits or underscore.");
                }
                return true;
            }
            return false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mazalDataSet.person' table. You can move, or remove it, as needed.
           // this.personTableAdapter.Fill(this.mazalDataSet.person);

        }



        private void Lname_TextChanged(object sender, EventArgs e)
        {

        }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void perm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Permission_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void facebook_btnLogin_Click(object sender, EventArgs e)
        {
            FB_Analyze.FB_Analyze_Register facebook = new FB_Analyze.FB_Analyze_Register();
            //facebook.Show();
            this.Email.Text = facebook.EmailReg;
            this.Lname.Text = facebook.LnameReg;
            this.Fname.Text = facebook.FnameReg;



        }


    }
}
