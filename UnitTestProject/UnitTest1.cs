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
    public class UnitTest1
    {
        PersonStuff p1 = new PersonStuff();
        NewUser f1 = new NewUser();
        General G1 = new General();
        SqlConnection sqlcon = null;

        string f_name = "newName";
        string l_name = "newlname";
        string TELEPHONE = "0525252852";
        string USERNAME = "UserNAME";
        string email = "temp@gmail.com";
        string password = "fred123";

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

        [TestMethod]
        public void TestMethodPerson1()
        {
            Assert.IsTrue(p1.setEmail(email));
        }

        [TestMethod]
        public void TestMethodPerson2()
        {
            Assert.IsTrue(p1.setFname(f_name));
        }

        [TestMethod]
        public void TestMethodPerson3()
        {
            Assert.IsTrue(p1.setLname(l_name));
        }

        [TestMethod]
        public void TestMethodPerson4()
        {
            Assert.IsTrue(p1.setPassword(password));
        }
        //#1
        [TestMethod]
        public void TestMethodPerson5()
        {
            Assert.IsTrue(p1.setPermission("Student"));
        }
        //#2
        [TestMethod]
        public void TestMethodPerson6()
        {
            Assert.IsTrue(p1.setPermission("Lecturer"));
        }

        //#3
        [TestMethod]
        public void TestMethodPerson7()
        {
            Assert.IsFalse(p1.setPermission("abu"));
        }

        [TestMethod]
        public void TestMethodPerson8()
        {
            Assert.IsTrue(p1.setPhone(TELEPHONE));
        }
    }
}

