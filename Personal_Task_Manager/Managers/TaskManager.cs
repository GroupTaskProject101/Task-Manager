// Application: Personal Task Manager (PTM)
// Author: Zac Henderson, Dominic Goodman, Christopher Woodard
// Purpose: This class is meant to act as the manager(logic layer) and house the logic relavant to the Task Manager 
// File: TaskManager.cs
// Date: 2/10/2018

using Personal_Task_Manager.Data;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Personal_Task_Manager.Managers
{
    public class TaskManager
    {
        #region Fields/Properties
        TaskData aTaskData = new TaskData();
        GroupData aGroupData = new GroupData();
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
        /// Sets the starting time to be used by the task
        /// </summary>

        /// <param name="aDate"></param>
        public void SetStartDate(DateTime aDate) => aTaskData.StartDate = aDate;

        /// <summary>
        /// Sets the ending time to be used by the task
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
        public void SetGroup(string aGroup) => aGroupData.Name = aGroup;
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
        public string GetGroup() => aGroupData.Name;

        /// <summary>
        /// Returns the description of the task
        /// </summary>
        /// <returns>string</returns>
        public string GetDescription() => aTaskData.Description;

        /// <summary>
        /// Returns the starting time of the task
        /// </summary>
        /// <returns>DateTime</returns>
        public DateTime GetStartTime() => aTaskData.StartDate;

        /// <summary>
        /// Returns the ending time of the task
        /// </summary>
        /// <returns>DateTime</returns>
        public DateTime GetEndTime() => aTaskData.EndDate;
        #endregion


        #region Methods
        /// <summary>
        /// Creates a new Task which will be added to the task collection
        /// </summary>
        public void CreateTask(string aName, string aDescription = "", string aGroup = "" )
        {
            if (aName != string.Empty)
            {
                TaskData aNewTask = new TaskData();

                aNewTask.Name = aName;
                aNewTask.IsChecked = false;
                aNewTask.Description = aDescription;
                aNewTask.Group = aGroup;
                aNewTask.TaskNo = TaskData.Count++;
                aNewTask.Group = aGroupData.Name = aGroup;
                aGroupData.TaskCount++;

                TaskData.aTaskCollection.Add(aNewTask);
                GroupData.aGroupCollection.Add(aGroupData);
            }         
        }

        /// <summary>
        /// Deletes a selected task from the task collection
        /// </summary>
        /// <param name="aTask"></param>
        public void DeleteTask(TaskData aTask)
        {
            if (aTask != null)
            {
                TaskData.aTaskCollection.Remove(aTask);
            }  
        }

        /// <summary>
        /// Searches for the specified task name in the task collection
        /// </summary>
        /// <param name="aName"></param>
        public  void SearchTasks(string aName,string aField)
        {
            HashSet<TaskData> tasksFound = new HashSet<TaskData>();
            Regex exp = new Regex(aName);
            TaskData.aFoundTaskCollection.Clear();

            if (aField.Equals("All Categories"))
            {
                foreach (TaskData nextTask in TaskData.aTaskCollection)
                {
                    if (exp.IsMatch(nextTask.Description) || exp.IsMatch(nextTask.Name) || exp.IsMatch(nextTask.Group))
                    {
                        tasksFound.Add(nextTask);
                    }
                }
            }
            else
            {
                foreach (TaskData nextTask in TaskData.aTaskCollection)
                {
                    switch (aField)
                    {
                        case "Name":
                            if (exp.IsMatch(nextTask.Name))
                            {
                                tasksFound.Add(nextTask);
                            }
                            break;
                        case "Description":
                            if (exp.IsMatch(nextTask.Description))
                            {
                                tasksFound.Add(nextTask);
                            }
                            break;
                        case "Group":
                            if (exp.IsMatch(nextTask.Group))
                            {
                                tasksFound.Add(nextTask);
                            }
                            break;
                    }
                }
            }

            foreach (TaskData nextTask in tasksFound)
            {
                TaskData.aFoundTaskCollection.Add(nextTask);
            }

        }

        public TaskData SearchTasks(Guid aGUID)
        {
            foreach (TaskData nextTask in TaskData.aTaskCollection)
            {
                if (nextTask.TaskGUID.Equals(aGUID))
                {
                    return nextTask;
                }
            }
            return null;
        }


        /// <summary>
        /// Sets the task to the completed status
        /// </summary>
        /// <param name="aTaskData"></param>
        public void CompleteTask(TaskData aTaskData)
        {

            aTaskData.Completed = false;

            TaskData.aCompletedTaskGroup.Add(aTaskData);
        }

        /// <summary>
        /// Generates and returns a GUID
        /// </summary>

        /// <returns></returns>
        public Guid CreateGUID()
        {

            Guid temp = Guid.NewGuid();

            return temp;
        }
        #endregion
    }
}
