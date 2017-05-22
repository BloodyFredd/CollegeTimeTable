using System;
using System.Data.SqlClient;
using System.Linq;
using BranchA_MazalPlus.Forms;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Data;

namespace BranchA_MazalPlus.Classes
{
    class PersonStuff
    {
        private string ID;
        private string Fname;
        private string Lname;
        private string Telephone;
        private string Email;
        private string Password;
        private string Permission;


        public PersonStuff(string id)
        {
            SqlConnection sqlcon = General.ConnectToSql();
            SqlCommand cmd = new SqlCommand("select * from person where ID='"+id+"'", sqlcon);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                ID = dr[0].ToString();
                Fname= dr[1].ToString();
                Lname = dr[2].ToString();
                Telephone = dr[3].ToString();
                Email = dr[4].ToString();
                Password = dr[5].ToString();
                Permission = dr[6].ToString();
            }

        }


        public string getID() { return ID; }
        public bool setID(string value) {
            bool allDigits = value.All(char.IsDigit);
            if (value.Length != 9 || allDigits == false){
                return false;
            }
            ID = value;
            return true;
         }
        public string getFname() { return Fname; }
        public bool setFname(string value)
        {
            foreach (char c in value)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            if (value.Length > 12)
                return false;
            Fname = value;
            return true;
        }
        public string getLname() { return Lname; }
        public bool setLname(string value)
        {
            foreach (char c in value)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            if (value.Length > 12)
                return false;
            Lname = value;
            return true;
        }
        public string getTelephone() { return Telephone; }
        public bool setPhone(string value){
            bool allDigits = value.All(char.IsDigit);
            if (value.Length != 10 || allDigits == false)
                return false;
            Telephone = value;
            return true;
        }
        public string getEmail() { return Email; }
        public bool setEmail(string value)
        {
            bool invalid = false;
            if (String.IsNullOrEmpty(value))
                return false;

            // Use IdnMapping class to convert Unicode domain names.
            try
            {
                value = Regex.Replace(value, @"(@)(.+)$", this.DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

            if (invalid)
                return false;

            // Return true if strIn is in valid e-mail format.
            try
            {
                return Regex.IsMatch(value,
                      @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
        public string getPassword() { return Password; }
        public bool setPassword(string value)
        {
            if (value.Length > 12)
                return false;
            Password = value;
            return true;
        }
        public string getPermission() { return Permission; }
        public bool setPermission(string value)
        { string[] perm = { "Teaching_Assistant", "Secretary", "Admin", "Lecturer", "Student", "Tech_Team", "Dean_of_Faculty", "Exam_Section" };
            foreach (string x in perm) { 
            if (value.Contains(x))
            { Permission = value;
                return true;
            }
           }
            return false;

        }
        public bool updatesql()
        {
            SqlConnection sqlcon = General.ConnectToSql();
            if (sqlcon == null)
            {
                return false;

            }

            
            return true;
        }
        private string DomainMapper(Match match)
        {
            // IdnMapping class with default property values.
            IdnMapping idn = new IdnMapping();

            string domainName = match.Groups[2].Value;
            try
            {
                domainName = idn.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                // invalid = true;
            }

            return match.Groups[1].Value + domainName;
        }
    }
}
