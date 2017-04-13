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
            //this.personTableAdapter.Fill(this.mazalDataSet.person);
            this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            this.Email.Text = this.Email.Text + "@plus.mazal.com";
            string query = "INSERT INTO person (ID,F_name,L_name,Telephone,Email,Password,Permission) VALUES('" + this.ID.Text + "','" + this.Fname.Text + "','" + this.Lname.Text + "','"+this.Phone.Text + "','"+this.Email.Text+"','"+ this.ID.Text +"','"+this.perm1.Text+"')  ; " ;
           this.sqlcon = new SqlConnection(connetionString);
            this.sqlcon.Open();
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            SqlDataReader dr = cmd.ExecuteReader();
            MessageBox.Show("Saved");
            this.Close();
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
