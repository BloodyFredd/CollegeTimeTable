using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PRPJECT4NEW.Classes;

namespace UnitTestProject
{
 
    [TestClass]
    public class PersonTest
    {
        PersonStuff p1 = new PersonStuff();
        string f_name = "newName";
        string l_name = "newlname";
        string email = "temp@gmail.com";
        string password = "fred123";
        string TELEPHONE = "0525252852";


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
