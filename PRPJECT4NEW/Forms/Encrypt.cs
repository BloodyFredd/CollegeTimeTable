using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Configuration;
using System.Data.SqlClient;


namespace PRPJECT4NEW.Forms
{
    public partial class Encrypt : Form
    {
        SqlConnection sqlcon = null;
        public Encrypt()
        {
            InitializeComponent();
        }

        public bool ConvertPass(string value)
        {
            sqlcon = General.ConnectToSql();
            SqlCommand cmd = new SqlCommand("select * from person ", sqlcon);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                string PassTemp = string.Copy(dr[5].ToString());
                dr.Close();
                PassTemp = base64Encode(PassTemp);
                MessageBox.Show(PassTemp);
                string connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
                this.sqlcon = new SqlConnection(connetionString);
                SqlCommand cmd2 = new SqlCommand("UPDATE person SET password='" + PassTemp + "'", sqlcon);

                //dr.Close();
                // SqlDataAdapter sda = new SqlDataAdapter();
                //sda.SelectCommand = cmd2;
                // DataTable dbdataset = new DataTable();
                // sda.Fill(dbdataset);
                // SqlDataAdapter sda1 = new SqlDataAdapter();
                //sda1.SelectCommand = cmd1;
                // DataTable dbdataset1 = new DataTable();
                //  sda1.Fill(dbdataset1);
                //  BindingSource bsource = new BindingSource();

                // bsource.DataSource = dbdataset;
                // Lecture.DataSource = bsource;
                //sda.Update(dbdataset);
                // sda1.Update(dbdataset);
                return true;

            }

            return false;

        }
        public bool ConvertPass2(string value)
        {
            sqlcon = General.ConnectToSql();
            SqlCommand cmd = new SqlCommand("select * from person where Email='vas123@plus.mazal.com' and Password='123'", sqlcon);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
               string PassTemp= string.Copy(dr[5].ToString());
                dr.Close();
                PassTemp = base64Encode(PassTemp);
                MessageBox.Show(PassTemp);
                string connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
                this.sqlcon = new SqlConnection(connetionString);
                SqlCommand cmd2 = new SqlCommand("UPDATE person SET password='" + PassTemp + "' where Email='vas123@plus.mazal.com' ", sqlcon);

                //dr.Close();
               // SqlDataAdapter sda = new SqlDataAdapter();
                //sda.SelectCommand = cmd2;
               // DataTable dbdataset = new DataTable();
               // sda.Fill(dbdataset);
               // SqlDataAdapter sda1 = new SqlDataAdapter();
                //sda1.SelectCommand = cmd1;
               // DataTable dbdataset1 = new DataTable();
              //  sda1.Fill(dbdataset1);
              //  BindingSource bsource = new BindingSource();

               // bsource.DataSource = dbdataset;
               // Lecture.DataSource = bsource;
                //sda.Update(dbdataset);
               // sda1.Update(dbdataset);
                return true;

            }

            return false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter your Password", "Messege", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            textBox2.Text = base64Encode(textBox1.Text);
            ConvertPass(textBox1.Text);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please enter your Password", "Messege", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            textBox3.Text = base64Decode2(textBox2.Text);

        }

        public string base64Encode(string data)
        {
            try
            {
                byte[] encData_byte = new byte[data.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(data);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception e)
            {
                throw new Exception("Error in base64Encode" + e.Message);
            }
        }
        public string base64Decode2(string sData)
        {
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            System.Text.Decoder utf8Decode = encoder.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(sData);
            int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            string result = new String(decoded_char);
            return result;
        }
    }
}
