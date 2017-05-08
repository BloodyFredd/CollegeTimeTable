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

namespace BranchA_MazalPlus
{
    public partial class NewUser : Form
    {
        private string connetionString = null;
        private SqlConnection sqlcon;


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
                checkString(this.Email.Text, "username");
                this.Email.Text = this.Email.Text + "@plus.mazal.com";
                string query = "INSERT INTO person (ID,F_name,L_name,Telephone,Email,Password,Permission) VALUES('" + this.ID.Text + "','" + this.Fname.Text + "','" + this.Lname.Text + "','" + this.Phone.Text + "','" + this.Email.Text + "','" + this.ID.Text + "','" + this.perm1.Text + "')  ; ";
                SqlCommand cmd = new SqlCommand(query, sqlcon);
                SqlDataReader dr = cmd.ExecuteReader();
                if(this.perm1.Text == "Teaching_Assistant" || this.perm1.Text == "Lecturer")
                {
                    this.sqlcon.Close();
                    this.sqlcon = new SqlConnection(connetionString);
                    this.sqlcon.Open();
                    //string query1 = "INSERT INTO Teaching_Stuff (ID,Course_id,Office,Reception_day,Reception_startTime,Reception_endTime) VALUES('" + this.ID.Text + "', 0,'" + DBNull.Value + "','" + DBNull.Value + "','" + DBNull.Value + "','" + DBNull.Value + "')  ; ";
                    string query1 = "INSERT INTO Teaching_Stuff (ID,Course_id) VALUES('" + this.ID.Text + "', 0)  ; ";

                    SqlCommand cmd1 = new SqlCommand(query1, sqlcon);
                    SqlDataReader dr1 = cmd1.ExecuteReader();
                }
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

        private void checkString(string str, string check)
        {
            if (check == "ID")
            {
                bool allDigits = str.All(char.IsDigit);
                if (str.Length != 9 || allDigits == false)
                    throw new ArgumentException("ID should be only digits and with length of 9.");
                SqlCommand cmd = new SqlCommand("select * from person where ID='" + this.ID.Text + "'", sqlcon);
                SqlDataReader dr = cmd.ExecuteReader();                
                if (dr.Read() == true)
                    throw new ArgumentException("There exists such an ID.");
                this.sqlcon.Close();
                this.sqlcon = new SqlConnection(connetionString);
                this.sqlcon.Open();
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
            }

            if(check == "telephone")
            {
                bool allDigits = str.All(char.IsDigit);
                if (str.Length != 10 || allDigits == false)
                    throw new ArgumentException("Telephone should be only digits and with length of 10.");
            }

            if(check == "username")
            {
                foreach (char c in str)
                {
                    if (!Char.IsLetterOrDigit(c) && c != '_')
                        throw new ArgumentException("User name should be only numbers or digits or underscore.");
                }
            }
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
    }
}
