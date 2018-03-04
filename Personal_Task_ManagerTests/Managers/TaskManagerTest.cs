using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Personal_Task_Manager.Managers;
using Personal_Task_Manager.Data;

namespace Personal_Task_ManagerTests.Managers
{
    /// <summary>
    /// Summary description for TaskManagerTest
    /// </summary>
    [TestClass]
    public class TaskManagerTest
    {
        public TaskManagerTest()
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
        public void CreateTask_CreatingTask_AddsValueToCollection()
        {
            TaskManager aTaskManager = new TaskManager();
            TaskData aTaskData = new TaskData();

            string expectedName = "Joe";

            aTaskData.Name = expectedName;
            TaskData.aTaskCollection.Add(aTaskData);

            string actualName = TaskData.aTaskCollection[0].Name;

            Assert.AreEqual<string>(expectedName, actualName);
        }

        [TestMethod]
        public void SearchTask_SearchForATask_AddValueToCollection()
        {
            TaskManager taskManager = new TaskManager();
            TaskData taskData = new TaskData();

            taskData.Name = "Joe";
            TaskData.aTaskCollection.Add(taskData);

            string expected = "Joe";
            taskManager.SearchTasks(expected, "Name");
            string actual = TaskData.aFoundTaskCollection[0].Name;
            

            

            Assert.AreEqual(expected, actual);
        }
    }
}
