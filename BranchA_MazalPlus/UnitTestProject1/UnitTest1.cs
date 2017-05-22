using Microsoft.VisualStudio.TestTools.UnitTesting;
using BranchA_MazalPlus;
using System.Data.SqlClient;
using BranchA_MazalPlus.Forms;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        NewUser f1 = new NewUser();
        General G1 = new General();
        SqlConnection sqlcon=null;

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
            this.sqlcon = General.ConnectToSql();
            Assert.IsNotNull(sqlcon);
        }

    }
}
