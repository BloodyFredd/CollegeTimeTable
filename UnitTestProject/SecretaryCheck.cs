using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PRPJECT4NEW.Classes;

namespace UnitTestProject
{
    [TestClass]
    public class SecretaryCheck
    {
        Secretary s = new Secretary("123456789");
        
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
        

    }
}
