using System;
using System.Text;

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PRPJECT4NEW.Classes;
using System.Data.SqlClient;

namespace UnitTestProject
{
    [TestClass]
    public class Teaching_AssistantU
    {
        PRPJECT4NEW.Classes.Teaching_Assistant t1 = new PRPJECT4NEW.Classes.Teaching_Assistant();

        [TestMethod]
        public void TestMethodGrade()
        {
           Assert.IsNotNull(t1.GradeStud("201602117", "100"));
        }
        [TestMethod]
        public void TestMethodGrade2()
        {
            Assert.IsNull(t1.GradeStud("201602117", "600"));
        }
        [TestMethod]
        public void TestMethodGrade3()
        {
            Assert.IsNull(t1.GradeStud("159184963", "100"));
        }

        [TestMethod]
        public void TestMethodLecture()
        {
            Assert.IsNotNull(t1.LectureWith("204892749"));
        }
        [TestMethod]
        public void TestMethodLecture2()
        {
            Assert.IsNull(t1.LectureWith("333333333"));
        }

        [TestMethod]
        public void TestMethodRecepH()
        {
            Assert.IsNotNull(t1.RecepH("03/13/2017"));
        }
        [TestMethod]
        public void TestMethodRecepH2()
        {
            Assert.IsNull(t1.RecepH("03/40/2018"));
        }
        [TestMethod]
        public void TestMethodStuff()
        {
            Assert.IsNotNull(t1.SelectStuff());
        }
        [TestMethod]
        public void TestMethodCheckID()
        {
            Assert.IsTrue(PRPJECT4NEW.Teaching_Assistant.Grade56.checkString("123456789", "ID"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
    "ID should be only digits and with length of 9.")]
        public void TestMethodCheckIDFalse()
        {
            Assert.IsFalse(PRPJECT4NEW.Teaching_Assistant.Grade56.checkString("12345", "ID"));
        }

        [TestMethod]
        public void TestMethodCheckCourse()
        {
            Assert.IsTrue(PRPJECT4NEW.Teaching_Assistant.Grade56.checkString("123", "Course"));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
    "Exception.")]
        public void TestMethodCheckCourseFalse()
        {
            Assert.IsFalse(PRPJECT4NEW.Teaching_Assistant.Grade56.checkString("13", "Course"));
        }
    }
}
