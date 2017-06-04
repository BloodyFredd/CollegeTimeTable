namespace FB_Analyze
{
    using System;
    using System.Data;
    using System.Windows.Forms;
    using Facebook;
    using Facebook.MiniJSON;
    using System.Collections.Generic;
    using System.Data.SqlClient;

    using PRPJECT4NEW;
    using PRPJECT4NEW.Forms;
    using PRPJECT4NEW.Admin;
    using PRPJECT4NEW.Dean_of_Faculty;
    using PRPJECT4NEW.Exams_Section;
    using PRPJECT4NEW.Lecturer;
    using PRPJECT4NEW.Secretary;
    using PRPJECT4NEW.Teaching_Assistant;
    using PRPJECT4NEW.Tech_Team;
    using PRPJECT4NEW.Student;
    using System.Linq;

    public partial class FB_Analyze : Form
    {
        private const string AppId = "239010066477815";
        private const string ExtendedPermissions= "public_profile,user_friends,email";
        private string _accessToken;
        FacebookClient fbClient = new FacebookClient();


        public FB_Analyze()
        {
            InitializeComponent();
            var fbLoginDialog = new FB_LoginDialog(AppId, ExtendedPermissions);
            fbLoginDialog.ShowDialog();

            DisplayAppropriateMessage(fbLoginDialog.FacebookOAuthResult);
        }

        private void btnFacebookLogin_Click(object sender, EventArgs e)
        {
            var fbLoginDialog = new FB_LoginDialog(AppId, ExtendedPermissions);
            fbLoginDialog.ShowDialog();

            DisplayAppropriateMessage(fbLoginDialog.FacebookOAuthResult);
        }

        private void DisplayAppropriateMessage(FacebookOAuthResult facebookOAuthResult)
        {

            if (facebookOAuthResult != null)
            {
                if (facebookOAuthResult.IsSuccess)
                {
                    _accessToken = facebookOAuthResult.AccessToken;
                    var fb = new FacebookClient(facebookOAuthResult.AccessToken);

                    var result = fb.Get("me", new { fields = new[] { "first_name", "last_name", "name", "gender", "id", "age_range" } });
                    var cl = fb;
                    dynamic result1 = fb.Get("me?fields=id,name,email");
                    string _currentEmail = result1.email;
                    //NewUser.EmaillF=_currentEmail;
                    // MessageBox.Show(_currentEmail);
                    // MessageBox.Show(result1.name);
                    // MessageBox.Show(result1.id);
                    // SqlConnection sqlcon=null;
                    // General.ConnectToSql(sqlcon);
                    string connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
                    SqlConnection sqlcon = new SqlConnection(connetionString);
                    sqlcon.Open();
                    SqlCommand cmd = new SqlCommand("select * from person where Email='" + _currentEmail + "'", sqlcon);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read() == true)
                    {
                        string ID = string.Copy(dr[0].ToString());
                        using (Entities context = new Entities())
                        {
                            if (context.Person.Any(p => p.ID == ID ))
                                Utility.User = context.Person.SingleOrDefault(p => p.ID == ID);

                            switch (Utility.User.Permission)
                            {
                                case "Student":
                                    PRPJECT4NEW.Student.Menu Student_Connect = new PRPJECT4NEW.Student.Menu();
                                    Student_Connect.Student_Name.Text = "      " + Utility.User.F_name + " " + Utility.User.L_name;
                                    Student_Connect.ShowDialog();
                                    break;
                                case "Exam_Section":
                                    PRPJECT4NEW.Exams_Section.Menu Exam_Connect = new PRPJECT4NEW.Exams_Section.Menu();
                                    Exam_Connect.Student_Name.Text = "      " + Utility.User.F_name + " " + Utility.User.L_name;
                                    Exam_Connect.ShowDialog();
                                    break;
                                case "Tech_Team":
                                    PRPJECT4NEW.Tech_Team.Menu Tech_Connect = new PRPJECT4NEW.Tech_Team.Menu();
                                    Tech_Connect.Student_Name.Text = "      " + Utility.User.F_name + " " + Utility.User.L_name;
                                    Tech_Connect.ShowDialog();
                                    break;
                                case "Dean_of_Faculty":
                                    PRPJECT4NEW.Dean_of_Faculty.Menu Dean_Connect = new PRPJECT4NEW.Dean_of_Faculty.Menu();
                                    Dean_Connect.Student_Name.Text = "      " + Utility.User.F_name + " " + Utility.User.L_name;
                                    Dean_Connect.ShowDialog();
                                    break;
                                case "Admin":
                                    PRPJECT4NEW.Admin.Menu Connect = new PRPJECT4NEW.Admin.Menu();
                                    Connect.Admin_name.Text = "      " + Utility.User.F_name + " " + Utility.User.L_name;
                                    Connect.ShowDialog();
                                    break;
                                case "Lecturer":
                                    PRPJECT4NEW.Lecturer.Menu Connect1 = new PRPJECT4NEW.Lecturer.Menu();
                                    Connect1.Lecturer_Name.Text = "      " + Utility.User.F_name + " " + Utility.User.L_name;
                                    Connect1.ShowDialog();
                                    break;
                                case "Teaching_Assistant":
                                    PRPJECT4NEW.Teaching_Assistant.Menu Connect2 = new PRPJECT4NEW.Teaching_Assistant.Menu();
                                    Connect2.Teaching_Assistant_Name.Text = "      " + Utility.User.F_name + " " + Utility.User.L_name;
                                    Connect2.ShowDialog();
                                    break;
                                case "Secretary":
                                    PRPJECT4NEW.Secretary.Menu Connect3 = new PRPJECT4NEW.Secretary.Menu();
                                    Connect3.Secretary_Name.Text = "      " + Utility.User.F_name + " " + Utility.User.L_name;
                                    Connect3.ShowDialog();
                                    break;
                                default:
                                    Console.WriteLine("Wrong User Permission - Check your Database");
                                    break;
                            }
                        }
                             
                                var dict = Json.Deserialize(result.ToString()) as Dictionary<string, object>;
                        string id = dict["id"].ToString();
                        string name = dict["name"].ToString();
                        string Lname = dict["first_name"].ToString();
                        string Fname = dict["last_name"].ToString();
                        string gender = dict["gender"].ToString();


                        btnLogout.Visible = true;

                    }
                    else
                    {
                        MessageBox.Show(facebookOAuthResult.ErrorDescription);
                    }
                    this.btnLogoutClick();
                }
            }
        }

        private void ConnectToSql(SqlConnection sqlConnection, object sqlcon)
        {
            throw new NotImplementedException();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var webBrowser = new WebBrowser();
            var fb = new FacebookClient();
            var logouUrl = fb.GetLogoutUrl(new { access_token = _accessToken, next = "https://www.facebook.com/connect/login_success.html" });
            webBrowser.Navigate(logouUrl);
            btnLogout.Visible = false;
        }
        private void btnLogoutClick()
        {
            var webBrowser = new WebBrowser();
            var fb = new FacebookClient();
            var logouUrl = fb.GetLogoutUrl(new { access_token = _accessToken, next = "https://www.facebook.com/connect/login_success.html" });
            webBrowser.Navigate(logouUrl);
            btnLogout.Visible = false;
        }

    }
}
