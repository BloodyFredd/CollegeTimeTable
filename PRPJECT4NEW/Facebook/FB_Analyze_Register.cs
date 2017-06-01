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

    public partial class FB_Analyze_Register : Form
    {
        private const string AppId = "239010066477815";
        private const string ExtendedPermissions= "public_profile,user_friends,email";
        private string _accessToken;
        FacebookClient fbClient = new FacebookClient();
        public string EmailReg, FnameReg, LnameReg;


        public FB_Analyze_Register()
        {
            InitializeComponent();
            var fbLoginDialog = new FB_LoginDialog(AppId, ExtendedPermissions);
            fbLoginDialog.ShowDialog();

            DisplayAppropriateMessage(fbLoginDialog.FacebookOAuthResult);
        }

        //private void btnFacebookLogin_Click(object sender, EventArgs e)
        //{
        //    var fbLoginDialog = new FB_LoginDialog(AppId, ExtendedPermissions);
        //    fbLoginDialog.ShowDialog();

        //    DisplayAppropriateMessage(fbLoginDialog.FacebookOAuthResult);
        //}

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
                    EmailReg = result1.email;
                    var dict = Json.Deserialize(result.ToString()) as Dictionary<string, object>;
                    //string id = dict["id"].ToString();
                   // string name = dict["name"].ToString();
                    FnameReg = dict["first_name"].ToString();
                    LnameReg = dict["last_name"].ToString();
                    //string gender = dict["gender"].ToString();
                    this.btnLogoutL();

                }
                else
                {
                    MessageBox.Show(facebookOAuthResult.ErrorDescription);
                }
            }
        }

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // FB_Analyze_Register
        //    // 
        //    this.ClientSize = new System.Drawing.Size(676, 314);
        //    this.Name = "FB_Analyze_Register";
        //    this.ResumeLayout(false);

        //}

        private void ConnectToSql(SqlConnection sqlConnection, object sqlcon)
        {
            throw new NotImplementedException();
        }


        private void btnLogoutL()
        {
            var webBrowser = new WebBrowser();
            var fb = new FacebookClient();
            var logouUrl = fb.GetLogoutUrl(new { access_token = _accessToken, next = "https://www.facebook.com/connect/login_success.html" });
            webBrowser.Navigate(logouUrl);
        }
    }
}
