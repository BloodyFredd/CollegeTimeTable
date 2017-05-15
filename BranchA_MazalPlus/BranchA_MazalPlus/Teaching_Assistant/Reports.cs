﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace BranchA_MazalPlus.Teaching_Assistant
{
    public partial class Reports : Form
    {
        private string connetionString = null;
        private SqlConnection sqlcon;
        public Reports()
        {
            InitializeComponent();
        }

        private void Load_table_Click(object sender, EventArgs e)
        {
        }

        private void StudentsReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Load_table_Click_1(object sender, EventArgs e)
        {
            this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            this.sqlcon = new SqlConnection(connetionString);

            SqlCommand cmd = new SqlCommand("declare @results varchar(50) select @results = convert(varchar(50),Course_id) from Teaching_Stuff  WHERE Teaching_Stuff.ID = '" + Forms.UserID.ID + "' SELECT Person.F_name,Person.L_name,Teaching_Stuff.ID,Teaching_Stuff.Course_id,Teaching_Stuff.office,Person.Email FROM Teaching_Stuff JOIN Person on Person.ID=Teaching_Stuff.ID WHERE Course_id  = @results AND Teaching_Stuff.ID  != '" + Forms.UserID.ID + "'", sqlcon);
             
            try
            {

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;
                StudentsReport.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
                Reports form2 = new Reports();
                form2.Show();
            }
            this.sqlcon.Close();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            this.sqlcon = new SqlConnection(connetionString);

            SqlCommand cmd = new SqlCommand("select Course_id from Teaching_Stuff where ID ='" + Forms.UserID.ID + "'", sqlcon);
            this.sqlcon.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            SqlCommand cmd1 = new SqlCommand("select ID from Teaching_Stuff where Course_id ='" + dr[0].ToString() + "'", sqlcon);
            try
            {
                
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd1;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;
                StudentsReport.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
                Reports form2 = new Reports();
                form2.Show();
            }
            this.sqlcon.Close();
            this.Close();
        }

        private void Grades_Button_Click(object sender, EventArgs e)
        {
            this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False; MultipleActiveResultSets=true";
            this.sqlcon = new SqlConnection(connetionString);
            try
            {
                SqlCommand cmd = new SqlCommand("select Student_Courses.stud_Id,Student_Courses.course_id, Student_Courses.grade_a, Student_Courses.grade_b, Student_Courses.grade_c, Student_Courses.quiz1, Student_Courses.quiz2, Student_Courses.final_grade FROM Student_Courses LEFT join Teaching_Stuff on Student_Courses.course_id=Teaching_Stuff.Course_ID where ID='" + Forms.UserID.ID + "' and Type != 1", sqlcon);
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;
                StudentsReport.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
                Reports form2 = new Reports();
                form2.Show();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False; MultipleActiveResultSets=true";
            this.sqlcon = new SqlConnection(connetionString);
            StudentsReport.Visible = true;

            try
            {
                SqlCommand cmd = new SqlCommand("select Student_Courses.stud_Id,Student_Courses.course_id FROM Student_Courses LEFT join Teaching_Stuff on Student_Courses.course_id=Teaching_Stuff.Course_ID where ID='" + Forms.UserID.ID + "' and Type = 1", sqlcon);
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;
                StudentsReport.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
                Reports form2 = new Reports();
                form2.Show();

            }
        }

        private void EmptyClasses_Click(object sender, EventArgs e)
        {
            string str = null;


            try
            {
                this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
                this.sqlcon = new SqlConnection(connetionString);
                SqlCommand cmd = new SqlCommand("select * from Classes_SM1 where date='" + "1990-01-01" + "'", sqlcon);
                if (toolStripComboBox1.Text.Equals("") && !toolStripComboBox2.Text.Equals(""))
                {
                    str = toolStripComboBox2.Text;
                    //MessageBox.Show(str);
                    cmd = new SqlCommand("select * from Classes_SM2 where date='" + str + "'", sqlcon);
                    StudentsReport.Visible = true;
                }
                else if (toolStripComboBox2.Text.Equals("") && !toolStripComboBox1.Text.Equals(""))
                {
                    str = toolStripComboBox1.Text;
                    //MessageBox.Show(str);
                    cmd = new SqlCommand("select * from Classes_SM1 where date='" + str + "'", sqlcon);
                    StudentsReport.Visible = true;
                }
                else
                {
                    throw new ArgumentException("Error selecting dates, try again!");
                }

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;
                StudentsReport.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
                Reports form2 = new Reports();
                form2.Show();
            }
            this.sqlcon.Close();
            this.Close();
        }

        private void My_Lectures_Click(object sender, EventArgs e)
        {
            this.connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            this.sqlcon = new SqlConnection(connetionString);
            SqlCommand cmd = new SqlCommand("select Lecture_Course.Course_ID,Lecture_Course.Course_Serial,courses.Course_Name from Lecture_Course LEFT join courses on Lecture_Course.Course_ID=courses.Course_id where Teacher='" + Forms.UserID.ID + "'", sqlcon);
            StudentsReport.Visible = true;

            try
            {

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dbdataset;
                StudentsReport.DataSource = bsource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
