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
            FileData.SaveFileLocation = @"../../Resources/testcsv.csv";
            manager.ParseFile();

            string expectedName = "Test";
            string actualName = TaskData.aTaskCollection[0].Name;

            Assert.AreEqual(expectedName, actualName);
        }
    }
}