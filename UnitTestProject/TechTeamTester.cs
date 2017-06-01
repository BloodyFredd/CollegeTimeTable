using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PRPJECT4NEW.Tech_Team; 

namespace UnitTestProject
{
    /// <summary>
    /// Summary description for TechTeamTester
    /// </summary>
    [TestClass]
    public class TechTeamTester
    {
        Available_Classes avalibleClasses = new Available_Classes();
        Classes_with10_stu classesWithCapacity = new Classes_with10_stu();
        Conferences_List conferences = new Conferences_List();
        //function to check if dates added to combobox
        [TestMethod]
        public void TestMethodTech1()
        {

            DateTime d = new DateTime(2017, 7, 1);

            Assert.IsTrue(d == avalibleClasses.addDatesToDate_cmb());
        }
        //function to check if dates added to combobox
        [TestMethod]
        public void TestMethodTech9()
        {

            DateTime d = new DateTime(2017, 7, 2);

            Assert.IsFalse(d == avalibleClasses.addDatesToDate_cmb());
        }
        //check funxtion to add types to cmb
        [TestMethod]
        public void TestMethodTech2()
        {
            Assert.IsTrue(avalibleClasses.addTypesToType_cmb());
        }
        //check if no choose date
        [TestMethod]
        public void TestMethodTech3()
        {
            Assert.IsFalse(avalibleClasses.checkDateCmbText(""));
        }
        //check if choose date
        [TestMethod]
        public void TestMethodTech4()
        {
            Assert.IsTrue(avalibleClasses.checkDateCmbText("Any"));
        }
        //check type of class
        [TestMethod]
        public void TestMethodTech5()
        {
            Assert.IsTrue(avalibleClasses.returnType("Any"));
        }
        //check type of class
        [TestMethod]
        public void TestMethodTech6()
        {
            Assert.IsFalse(avalibleClasses.returnType("all"));
        }
        //check capacity number
        [TestMethod]
        public void TestMethodTech7()
        {
            Assert.IsTrue(classesWithCapacity.addCapacitiesToCap_cmb()== 11);
        }
        //check capacity number
        [TestMethod]
        public void TestMethodTech8()
        {
            Assert.IsFalse(classesWithCapacity.addCapacitiesToCap_cmb() == 9);
        }
        //check save file
        [TestMethod]
        public void TestMethodTech10()
        {
            Assert.IsFalse(conferences.SaveFILE());
        }

    }
}
