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

namespace BranchA_MazalPlus.Lecturer
{
    public partial class Factor : Form
    {
        private string connetionString = null;
        private SqlConnection sqlcon;
        public Factor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
                this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
                this.sqlcon = new SqlConnection(connetionString);

                //try
                //{
                    // select Student_Courses.stud_Id,Student_Courses.course_id FROM Student_Courses LEFT join Teaching_Stuff on Student_Courses.course_id = Teaching_Stuff.Course_ID where ID = '" + Forms.UserID.ID + "'"
                    SqlCommand cmd = new SqlCommand("UPDATE Student_Courses set final_grade=(select Teaching_Stuff.ID and Teaching_Stuff.Course_id,Student_Courses.course_id FROM Teaching_Stuff LEFT join Student_Courses on Student_Courses.course_id=Teaching_Stuff.Course_ID where Teaching_Stuff.ID='" + Forms.UserID.ID + "'", sqlcon);
                    //update m
                    //set m.shoebrandid = sb.shoebrandid
                    //from main_tbl m
                    // join temp_tbl t on m.personalid = t.personalid
                    //join shoebrand sb on t.shoebrand = sb.shoebrand
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = cmd;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bsource = new BindingSource();
                    bsource.DataSource = dbdataset;
                    // StudentsReport.DataSource = bsource;
                    sda.Update(dbdataset);


                }
   
               
                
                
            
            

        private void Factor_Load(object sender, EventArgs e)
        {

        }
    }
}
