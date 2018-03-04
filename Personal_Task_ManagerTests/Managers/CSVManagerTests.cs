using Microsoft.VisualStudio.TestTools.UnitTesting;
using Personal_Task_Manager.Data;
using Personal_Task_Manager.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Task_Manager.Managers.Tests
{
    [TestClass()]
    public class CSVManagerTests
    {
        [TestMethod()]
        public void ParseFile_ReadInName_AddsValueToCollection()
        {
            CSVManager manager = new CSVManager();
            TaskManager.CreateTask("TestTask");
            FileData.SaveFileLocation = @"../../Resources/testcsv.csv";
            manager.ParseFile();

            string expectedName = "TestTask";
            string actualName = TaskData.aTaskCollection[0].Name;

            Assert.AreEqual(expectedName, actualName);
        }
    }
}