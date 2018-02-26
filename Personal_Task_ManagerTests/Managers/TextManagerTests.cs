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
    public class TextManagerTests
    {
        [TestMethod()]
        public void ParseFile_ReadInName_AddsValueToCollection()
        {
            TextManager manager = new TextManager();

            manager.ParseFile();

            string expectedName = "Reading";
            string actualName = TaskData.aTaskCollection[0].Name;

            Assert.AreEqual(expectedName, actualName);
        }

        
    }
}