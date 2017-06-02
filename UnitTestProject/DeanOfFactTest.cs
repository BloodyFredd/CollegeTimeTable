using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PRPJECT4NEW.Dean_of_Faculty;
using PRPJECT4NEW;

namespace UnitTestProject
{

    [TestClass]
    public class DeanOfFactTest
    {
        Tech_support T1 = new Tech_support();
        Messages M1 = new Messages();
        Student_special_Exam S = new Student_special_Exam("205774094",1001,"Approved");
        Stu_Request SS = new Stu_Request();
        List<string> stu_list = new List<string>();
        


        [TestMethod]
        public void newrequset()
        {
            Assert.IsNotNull(T1.newrequset());

        }
        [TestMethod]
        public void newrequset1()
        {
            Assert.IsInstanceOfType(T1.newrequset(), typeof(DF_requests));

        }
        [TestMethod]
        [ExpectedException(typeof(Exception),
   "exeption throwen")]
        public void TestreloadData()
        {
            using (Entities db = new Entities())
            {
                Assert.IsTrue(T1.reloadDataGridView(db));
            }
        }

        [TestMethod]
        public void newrequsettotal()
        {
            Assert.IsNotNull(M1.newrequsettoall());

        }
        [TestMethod]
        public void newrequsettotal1()
        {
            Assert.IsInstanceOfType(M1.newrequsettoall(), typeof(DF_requests));

        }
        [TestMethod]
        [ExpectedException(typeof(Exception),
  "exeption throwen")]
        public void TestreloadDataMessage()
        {
            using (Entities db = new Entities())
            {
                Assert.IsTrue(M1.reloadDataGridView(db));

            }
        }


        [TestMethod]
        public void constructor_exam()
        {
            Assert.IsNotNull(S);
        }
        [TestMethod]
        public void setter_Exam()
        {
            S.ID = "123456789";
            Assert.IsTrue(S.ID == "123456789");
        }
        [TestMethod]
        public void setter_Exam2()
        {
            Assert.IsFalse(S.ID == "123123123");
        }
        [TestMethod]
        public void setter_Exam3()
        {
            S.ID = "1111";
            Assert.IsFalse(S.Course_Serial == 1111);
        }
        [TestMethod]
        public void setter_Exam4()
        {
            Assert.IsFalse(S.Course_Serial == 123123123);
        }
        public void setter_Exam5()
        {
            S.Status = "Approved";
            Assert.IsFalse(S.Status == "Approved");
        }
        [TestMethod]
        public void setter_Exam6()
        {
            Assert.IsFalse(S.Status == "Open");
        }
        //[TestMethod]
        //public void isDenied()
        //{
        //    stu_list.Add("20202020");
        //    Assert.IsFalse(SS.isDenied(stu_list));
        //}
        //[TestMethod]
        //public void TestMethod2()
        //{

        //}
        //[TestMethod]
        //public void TestMethod2()
        //{

        //[TestMethod]
        //public void TestMethod2()
        //{

        //}
        //}
    }
}
