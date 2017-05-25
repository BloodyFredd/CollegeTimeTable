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

    public partial class FB_Analyze : Form
    {
        private const string AppId = "239010066477815";
        private const string ExtendedPermissions= "public_profile,user_friends,email";
        private string _accessToken;
        FacebookClient fbClient = new FacebookClient();


        public FB_Analyze()
        {
            InitializeComponent();
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
                    MessageBox.Show(_currentEmail);
                    MessageBox.Show(result1.name);
                    MessageBox.Show(result1.id);
                   // SqlConnection sqlcon=null;
                   // General.ConnectToSql(sqlcon);
                    string connetionString = "Data Source = whitesnow.database.windows.net; Initial Catalog = Mazal; Integrated Security = False; User ID = Grimm; Password = #!7Dwarfs; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
                    SqlConnection sqlcon = new SqlConnection(connetionString);
                    sqlcon.Open();
                    SqlCommand cmd = new SqlCommand("select * from person where Email='" + _currentEmail + "'", sqlcon);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read() == true)
                    {
                        PRPJECT4NEW.Forms.UserID.ID = string.Copy(dr[0].ToString());
                        if (dr[6].ToString() == "Admin")
                        {
                            this.Hide();
                            PRPJECT4NEW.Admin.Menu Connect = new PRPJECT4NEW.Admin.Menu();
                            Connect.Show();
                            Connect.Admin_name.Text = "      " + dr[1].ToString() + " " + dr[2].ToString();
                        }
                        else if (dr[6].ToString() == "Lecturer")
                        {
                            this.Hide();
                            PRPJECT4NEW.Lecturer.Menu Connect = new PRPJECT4NEW.Lecturer.Menu();
                            Connect.Show();
                            Connect.Lecturer_Name.Text = "      " + dr[1].ToString() + " " + dr[2].ToString();
                        }
                        else if (dr[6].ToString() == "Teaching_Assistant")
                        {
                            this.Hide();
                            PRPJECT4NEW.Teaching_Assistant.Menu Connect = new PRPJECT4NEW.Teaching_Assistant.Menu();
                            Connect.Show();
                            Connect.Teaching_Assistant_Name.Text = "      " + dr[1].ToString() + " " + dr[2].ToString();
                        }
                        else if (dr[6].ToString() == "Secretary")
                        {
                           // this.Hide();
                            PRPJECT4NEW.Secretary.Menu Connect = new PRPJECT4NEW.Secretary.Menu();
                            Connect.Show();
                            Connect.Secretary_Name.Text = "      " + dr[1].ToString() + " " + dr[2].ToString();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password ");
                        cmd = null;


                    }
                    var dict = Json.Deserialize(result.ToString()) as Dictionary<string, object>;
                    string id = dict["id"].ToString();
                    string name = dict["name"].ToString();
                    string Lname = dict["first_name"].ToString();
                    string Fname = dict["last_name"].ToString();
                    string gender = dict["gender"].ToString();
                    MessageBox.Show(name);
                    MessageBox.Show(Lname);
                    MessageBox.Show(Fname);
                    MessageBox.Show(gender);
                    MessageBox.Show(id);


                    btnLogout.Visible = true;
                }
                else
                {
                    MessageBox.Show(facebookOAuthResult.ErrorDescription);
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

    }
}
