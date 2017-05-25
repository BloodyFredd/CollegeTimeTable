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

namespace BranchA_MazalPlus.Admin
{
    public partial class RemoveAssistant : Form
    {
        private string connetionString = null;
        private SqlConnection sqlcon;
        public RemoveAssistant()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = null;
            try {
                this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
                this.sqlcon = new SqlConnection(connetionString);
                this.sqlcon.Open();
                str = "Teaching_Assistant";
                SqlCommand command = new SqlCommand("DELETE FROM person WHERE ID = '" + this.IDbutton.Text + "'AND Permission = '" + str + "'", sqlcon);
                int dr = command.ExecuteNonQuery();
                if(dr == 1)
                {
                    MessageBox.Show("Deleted!");
                    this.sqlcon.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No such id exists!");
                    this.sqlcon.Close();
                    this.Close();
                }
                
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
        }

        private void Id_Click(object sender, EventArgs e)
        {

        }

        private void RemoveAssistant_Load(object sender, EventArgs e)
        {

        }
    }
}
