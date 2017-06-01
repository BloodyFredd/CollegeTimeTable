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

        //checkss if the values are the same
        [TestMethod]
        public void checkForEqual()
        {
            Assert.IsTrue(m1.checkChoice("", value1));
        }

        
    }
}
