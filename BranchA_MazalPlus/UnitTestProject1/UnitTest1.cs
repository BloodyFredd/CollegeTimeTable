using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BranchA_MazalPlus;
using System.Data.SqlClient;
using System.Windows;
using BranchA_MazalPlus.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        NewUser f1 = new NewUser();
        General G1 = new General();
        SqlConnection sqlcon;

        string ID = "123456789";
        string NAME = "newName";
        string TELEPHONE = "0525252852";
        string USERNAME = "UserNAME";

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
        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsTrue(General.ConnectToSql(sqlcon));
        }


        //[TestMethod]
        //public void TestMethod4()
        //{
        //    Assert.IsFalse(f1.checkString(ID, "ID"));
        //}
    }
}
