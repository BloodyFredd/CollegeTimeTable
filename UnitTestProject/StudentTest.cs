using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PRPJECT4NEW.Student;
using PRPJECT4NEW;

namespace UnitTestProject
{
    [TestClass]
    public class StudentTest
    {
        student mockStudent = new student();

        [TestMethod]
        public void setter1()
        {
            mockStudent.ID = "123456789";
            Assert.IsTrue(mockStudent.ID == "123456789");
        }

        [TestMethod]
        public void setter2()
        {
            mockStudent.Year = 3;
            Assert.IsTrue(mockStudent.Year == 3);
        }

        [TestMethod]
        public void setter3()
        {
            Assert.IsFalse(mockStudent.ID == "123123123");
        }

        [TestMethod]
        public void setter4()
        {
            mockStudent.Average = 85.6;
            Assert.IsFalse(mockStudent.Average == 90);
        }

    }
}
