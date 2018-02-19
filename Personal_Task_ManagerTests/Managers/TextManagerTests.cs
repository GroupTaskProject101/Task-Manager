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
        public void ParseFileTest()
        {
            TextManager manager = new TextManager();
            manager.ParseFile();
            foreach (TaskData next in manager.TaskCollection)
            {
                Console.WriteLine(next.Name);
                Console.WriteLine(next.Group);
                Console.WriteLine(next.EndTime);
                Console.WriteLine(next.StartTime);
                Console.WriteLine(next.Description);
            }
        }
    }
}