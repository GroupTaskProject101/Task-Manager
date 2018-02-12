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
            foreach (string next in manager.Fields)
            { 
                Console.WriteLine(next);
            }
            Console.WriteLine(manager.EndOfLine);
            foreach (TaskData next in manager.TaskCollection)
            {
                Console.WriteLine(next.Name);
            }
        }
    }
}