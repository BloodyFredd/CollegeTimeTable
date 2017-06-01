using System;
using System.Text;

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PRPJECT4NEW.Teaching_Assistant;

namespace UnitTestProject
{
    [TestClass]
    public class Teaching_Assistant
    {
        public Teaching_Assistant()
        {

        }




        [TestMethod]
        public void TestMethodCheckID()
        {
            Assert.IsTrue(Grade56.checkString("123456789", "ID"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
    "ID should be only digits and with length of 9.")]
        public void TestMethodCheckIDFalse()
        {
            Assert.IsFalse(Grade56.checkString("12345", "ID"));
        }

        [TestMethod]
        public void TestMethodCheckCourse()
        {
            Assert.IsTrue(Grade56.checkString("123", "Course"));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
    "Exception.")]
        public void TestMethodCheckCourseFalse()
        {
            Assert.IsFalse(Grade56.checkString("13", "Course"));
        }
    }
}
