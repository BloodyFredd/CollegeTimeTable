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

        SignStudent f1 = new SignStudent();
        string value1 = "1001";
        string value2 = "1002";
        string serial = "1001";

        //checkss if the values are the same
        [TestMethod]
        public void checkForSameSerial()
        {
            Assert.IsTrue(f1.CheckCourse(serial, value1));
        }

        //checkss if the values are different
        [TestMethod]
        public void checkForDifferentSerial()
        {
            Assert.IsTrue(f1.CheckCourse(value2, value1));
        }
    }
}
