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
        public void ParseFileTest()
        {
            CSVManager manager = new CSVManager();
            manager.ParseFile();
            foreach (TaskData next in manager.TaskCollection)
            {
                Console.WriteLine(next.Name);
                Console.WriteLine(next.Group);
                Console.WriteLine(next.Description);
                Console.WriteLine(next.StartTime);

            }
        }
    }
}