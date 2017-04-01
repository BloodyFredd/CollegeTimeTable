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
            this.mazalDataSet.person.AddpersonRow(this.mazalDataSet.person.NewpersonRow());
            personBindingSource.MoveLast();
            personBindingSource.EndEdit();
            personTableAdapter.Update(this.mazalDataSet.person);
            MessageBox.Show("daniel");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mazalDataSet.person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.mazalDataSet.person);
            this.personBindingSource.DataSource = this.mazalDataSet.person;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
