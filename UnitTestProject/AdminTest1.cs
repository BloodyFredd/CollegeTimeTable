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
    public class AdminTest1
    {


        Admin a1 = new Admin();
        SignStudent s1 = new SignStudent();
        MergeAuditorium m1 = new MergeAuditorium();
        string value1 = "1001";
        string value2 = "1002";
        string serial = "1001";

        //checkss if the values are the same
        [TestMethod]
        public void checkForSameSerial()
        {
            Assert.IsTrue(s1.CheckCourse(serial, value1));
        }

        //checkss if the values are different
        [TestMethod]
        public void checkForDifferentSerial()
        {
            Assert.IsFalse(s1.CheckCourse(value2, value1));
        }

        //checkss if the values are equal
        [TestMethod]
        public void checkForEqual()
        {
            Assert.IsTrue(m1.checkChoice("", value1));
        }

        [TestMethod]
        public void DisplayStuff()
        {
            Assert.IsNotNull(a1.SelectStuff());
        }

        [TestMethod]
        public void DisplayClassesBYDate()
        {
            Assert.IsNull(a1.classesByDate("03/40/2018"));
        }


        [TestMethod]
        public void DisplayClassesBYDateTrue()
        {
            Assert.IsNotNull(a1.classesByDate("03/13/2017"));
        }

        [TestMethod]
        public void TestMethodLecture()
        {
            Assert.IsNotNull(a1.FindLecturer("204892749"));
        }
        [TestMethod]
        public void TestMethodLecture2()
        {
            Assert.IsNull(a1.FindLecturer("333333333"));
        }
    }
}
