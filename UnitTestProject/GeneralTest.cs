using PRPJECT4NEW.Admin;
using PRPJECT4NEW;
using System.Data.SqlClient;
using PRPJECT4NEW.Forms;
using PRPJECT4NEW.Classes;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using System.Linq;


namespace UnitTestProject
{
    [TestClass]
    public class GeneralTest
    {
        NewUser f1 = new NewUser();
        General G1 = new General();
        SqlConnection sqlcon = null;
        //Encrypt e1 = new Encrypt();
        string USERNAME = "UserNAME";
        string TELEPHONE = "0525252852";
        string f_name = "newName";
        string EncryptTest = "CheckBase64";




        [TestMethod]
        public void TestMethodCheckS1()
        {
            Assert.IsTrue(f1.checkString(f_name, "name"));
        }
        [TestMethod]
        public void TestMethodCheckS2()
        {
            Assert.IsTrue(f1.checkString(USERNAME, "username"));
        }
        [TestMethod]
        public void TestMethodCheckS3()
        {
            Assert.IsTrue(f1.checkString(TELEPHONE, "telephone"));
        }
        [TestMethod]
        public void TestMethodSQL()
        {
            this.sqlcon = General.ConnectToSql();
            Assert.IsNotNull(sqlcon);
        }
        [TestMethod]
        public void TestMethodEncrypt()
        {
            string encrypt = Encrypt.base64Encode(EncryptTest);
            encrypt = Encrypt.base64Decode2(encrypt);
            Assert.IsTrue(encrypt== EncryptTest);
        }
        [TestMethod]
        public void TestMethodEncryptNotNULL()
        {
            string encrypt = Encrypt.base64Encode(EncryptTest);
            Assert.IsNotNull(encrypt);
        }

    }
}

