using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BranchA_MazalPlus;
using System.Windows;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        NewUser f1 = new NewUser();
        String ID = "123456789";
        String NAME = "newName";
        String TELEPHONE = "0525252852";
        String USERNAME = "UserNAME";

        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(f1.checkString(NAME, "name"));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(f1.checkString(USERNAME, "username"));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(f1.checkString(TELEPHONE, "telephone"));
        }
        //[TestMethod]
        //public void TestMethod4()
        //{
        //    Assert.IsFalse(f1.checkString(ID, "ID"));
        //}
    }
}
