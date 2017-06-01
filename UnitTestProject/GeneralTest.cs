using PRPJECT4NEW.Admin;
using PRPJECT4NEW;
using System.Data.SqlClient;
using PRPJECT4NEW.Forms;
using PRPJECT4NEW.Classes;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class GeneralTest
    {
        NewUser f1 = new NewUser();
        General G1 = new General();
        SqlConnection sqlcon = null;
        string USERNAME = "UserNAME";
        string TELEPHONE = "0525252852";
        string f_name = "newName";




        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(f1.checkString(f_name, "name"));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(f1.checkString(USERNAME, "username"));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(f1.checkString(TELEPHONE, "telephone"));
        }
        [TestMethod]
        public void TestMethod4()
        {
            this.sqlcon = General.ConnectToSql();
            Assert.IsNotNull(sqlcon);
        }

       
    }
}

