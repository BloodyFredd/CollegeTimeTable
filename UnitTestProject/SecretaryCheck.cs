using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PRPJECT4NEW.Classes;
using PRPJECT4NEW.Secretary;

namespace UnitTestProject
{
    [TestClass]
    public class SecretaryCheck
    {
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
    }
}
