using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PRPJECT4NEW.Classes;
using PRPJECT4NEW.Secretary;
using System.Data.SqlClient;
using PRPJECT4NEW.Forms;

namespace UnitTestProject
{
    [TestClass]
    public class SecretaryCheck
    {
        private SqlConnection sqlcon;
        Secretary s = new Secretary("123456789");
        AddStudent a1 = new AddStudent();

        [TestMethod]
        public void AVGCheckTrue()
        {
            int[] grades = { 1, 2, 3, 4 };
            int size = 4;
            Assert.AreEqual(s.AVG(grades, size), 2.5);
        }

        [TestMethod]
        public void AVGCheckFalse()
        {
            int[] grades = { 1, 2, 3, 4 };
            int size = 4;
            Assert.AreNotEqual(s.AVG(grades, size), 2);
        }

        [TestMethod]
        public void CheckBoolTrue()
        {
            bool flag = true;
            Assert.IsTrue(s.checkIfTrue(flag));
        }

        [TestMethod]
        public void CheckBoolFalse()
        {
            bool flag = false;
            Assert.IsFalse(s.checkIfTrue(flag));
        }

        [TestMethod]
        public void selectSemesterFalse()
        {
            bool flag = false;
            if (a1.semester("1") == 2) flag = true;
            Assert.IsFalse(flag);
        }

        [TestMethod]
        public void selectSemesterTrue()
        {
            bool flag = false;
            if (a1.semester("1") == 1) flag = true;
            Assert.IsTrue(flag);
        }

        [TestMethod]
        public void checkStudentTrue()
        {
            Assert.IsTrue(s.checkForStudent("321201121"));
        }

        [TestMethod]
        public void checkStudentFalse()
        {
            Assert.IsFalse(s.checkForStudent("999999999"));
        }

        [TestMethod]
        public void checkTeacherFalse()
        {
            Assert.IsFalse(s.checkForTeacher("999949999"));
        }

        [TestMethod]
        public void checkTeacherTrue()
        {
            Assert.IsTrue(s.checkForTeacher("203396809"));
        }
    }
}
