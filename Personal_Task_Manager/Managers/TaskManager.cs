// Application: Personal Task Manager (PTM)
// Author: Zac Henderson, Dominic Goodman, Christopher Woodard
// Purpose: This class is meant to act as the manager(logic layer) and house the logic relavant to the Task Manager 
// File: TaskManager.cs
// Date: 2/10/2018

using Personal_Task_Manager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Task_Manager.Managers
{
    public class TaskManager
    {
        #region Fields/Properties
        TaskData aTaskData = new TaskData();
        #endregion


        #region Contructors

        #endregion


        #region Setters
        /// <summary>
        /// Sets the name of the Task with the supplied value
        /// </summary>
        /// <param name="aName"></param>
        public void SetName(string aName) => aTaskData.Name = aName;

        /// <summary>
        /// Sets the current time
        /// </summary>
        /// <param name="aTime"></param>
        public void SetCurrentTime(DateTime aTime) => aTaskData.CurrentTime = aTime;

        /// <summary>
        /// Sets the starting time to be used by the task
        /// </summary>
        /// <param name="aTime"></param>
        public void SetStartTime(DateTime aTime) => aTaskData.StartTime = aTime;

        /// <summary>
        /// Sets the ending time to be used by the task
        /// </summary>
        /// <param name="aTime"></param>
        public void SetEndTime(DateTime aTime) => aTaskData.EndTime = aTime;

        /// <summary>
        /// Sets the ending date to be used by the task
        /// </summary>
        /// <param name="aDate"></param>
        public void SetEndDate(DateTime aDate) => aTaskData.EndDate = aDate;

        /// <summary>
        /// Sets the description of the task
        /// </summary>
        /// <param name="aDescription"></param>
        public void SetDescription(string aDescription) => aTaskData.Description = aDescription;

        /// <summary>
        /// Sets the group that the tasks will fall under
        /// </summary>
        /// <param name="aGroup"></param>
        public void SetGroup(string aGroup) => aTaskData.Group = aGroup;
        #endregion


        #region Getters
        /// <summary>
        /// Returns the name of task
        /// </summary>
        /// <returns>string</returns>
        public string GetName() => aTaskData.Name;

        /// <summary>
        /// Returns the group that the tasks will fall under
        /// </summary>
        /// <returns>string</returns>
        public string GetGroup() => aTaskData.Group;

        /// <summary>
        /// Returns the description of the task
        /// </summary>
        /// <returns>string</returns>
        public string GetDescription() => aTaskData.Description;

        /// <summary>
        /// Returns the current time
        /// </summary>
        /// <returns>DateTime</returns>
        public DateTime GetCurrentTime() => aTaskData.CurrentTime;

        /// <summary>
        /// Returns the starting time of the task
        /// </summary>
        /// <returns>DateTime</returns>
        public DateTime GetStartTime() => aTaskData.StartTime;

        /// <summary>
        /// Returns the ending time of the task
        /// </summary>
        /// <returns>DateTime</returns>
        public DateTime GetEndTime() => aTaskData.EndTime;

        /// <summary>
        /// Returns the ending date of the task
        /// </summary>
        /// <returns>DateTime</returns>
        public DateTime GetEndDate() => aTaskData.EndDate;
        #endregion


        #region Methods
        /// <summary>
        /// Creates a new Task which will be added to the task collection
        /// </summary>
        public void CreateTask()
        {
            // TODO Implement Creation of Task
        }

        /// <summary>
        /// Deletes a selected task from the task collection
        /// </summary>
        /// <param name="aTask"></param>
        public void DeleteTask(string aTask)
        {
            // TODO Implement Deletion of task
        }

        /// <summary>
        /// Sorts the task collection
        /// </summary>
        public void SortTasks()
        {
            // TODO Implement the sorting algorithm
        }

        /// <summary>
        /// Searches for the specified task name in the task collection
        /// </summary>
        /// <param name="aName"></param>
        public void SearchTasks(string aName)
        {
            // TODO Implement the searching algorithm
        }

        /// <summary>
        /// Sets the task to the completed status
        /// </summary>
        /// <param name="aName"></param>
        public void CompleteTask(string aName)
        {
            // TODO Implement setting of completion flag
        }

        /// <summary>
        /// Generates and returns a GUID
        /// </summary>
        /// <returns>GUID</returns>
        public Guid CreateGUID()
        {
            Guid temp = new Guid();

            // TODO Implement Guid creation system

            return temp;
        }
        #endregion
    }
}
