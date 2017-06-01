using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PRPJECT4NEW.Lecturer;
using PRPJECT4NEW.Classes;

namespace UnitTestProject
{
    /// <summary>
    /// Summary description for LecturerTest
    /// </summary>
    [TestClass]
    public class LecturerTest
    {
        Lecturer lec = new PRPJECT4NEW.Classes.Lecturer();

        public LecturerTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {


            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            modifay_grade modi = new modifay_grade();

        }

        [TestMethod]
        public void date_test()
        {
            Assert.IsFalse(lec.checker_dates_sql());
        }

        [TestMethod]
        public void date_test_of_start_sm1()
        {
            string d = "2016-08-07";
            Assert.IsTrue(lec.report_dates_from_sm1(d));
        }

         [TestMethod]
          public void date_test_of_start_sm1_false()
         {
            string d = "2019 - 08 - 07";
              Assert.IsFalse(lec.report_dates_from_sm1(d));
          }

        [TestMethod]
        public void date_test_of_start_sm2()
        {
            string d = "03/12/2017";
            Assert.IsTrue(lec.report_dates_from_sm2(d));
        }

        [TestMethod]
        public void date_test_of_start_sm2_false()
         {
           string d =  "03 / 12 / 2020";
         Assert.IsFalse(lec.report_dates_from_sm2(d));

        }
    }
}



