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
    public class FileManagerTests
    {
        [TestMethod()]
        public void SaveTest()
        {
            FileData.SaveFileLocation = @"../../Resources/testtext.txt";
            FileManager.Save(" ");
            Assert.AreEqual(FileData.SaveFileLocation, FileManager.LoadLastSave());
        }

        [TestMethod()]
        public void LoadLastSaveTest()
        {
            String expected = @"../../Resources/testtext.txt";
            Assert.AreEqual(expected, FileManager.LoadLastSave());
        }
    }
}