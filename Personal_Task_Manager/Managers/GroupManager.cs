// Application: Personal Task Manager (PTM)
// Author: Zac Henderson, Dominic Goodman, Christopher Woodard
// Purpose: This class is meant to act as the manager(logic layer) and house the logic relavant to the Group Manager 
// File: GroupManager.cs
// Date: 2/10/2018

using Personal_Task_Manager.Data;
using Personal_Task_Manager.Interfaces;
using System;

namespace Personal_Task_Manager.Managers
{
    public class GroupManager : ITransferable
    {
        #region Fields
        GroupData aGroupData = new GroupData();
        #endregion


        #region Constructors
        #endregion


        #region Setters
        /// <summary>
        /// Sets the name of the group
        /// </summary>
        /// <param name="aName"></param>
        public void SetName(string aName) => aGroupData.Name = aName;

        /// <summary>
        /// Sets the Guid of the group
        /// </summary>
        /// <param name="aGroupGuid"></param>
        public void SetGroupGuid(Guid aGroupGuid) => aGroupData.GroupGuid = aGroupGuid;

        /// <summary>
        /// Sets the task count of the group
        /// </summary>
        /// <param name="aTaskCount"></param>
        public void SetTaskCount(int aTaskCount) => aGroupData.TaskCount = aTaskCount;
        #endregion


        #region Getters
        /// <summary>
        /// Returns name of the group
        /// </summary>
        /// <returns>string</returns>
        public string GetName() => aGroupData.Name;

        /// <summary>
        /// Returns the group Guid
        /// </summary>
        /// <returns>Guid</returns>
        public Guid GetGroupGuid() => aGroupData.GroupGuid;

        /// <summary>
        /// Returns the task count of the group
        /// </summary>
        /// <returns>int</returns>
        public int GetTaskCount() => aGroupData.TaskCount;
        #endregion


        #region Methods
        /// <summary>
        /// Takes a selected group and transfers it to another save file for other users to import
        /// </summary>
        /// <param name="aGroup"></param>
        /// <param name="aOutputPath"></param>
        public void TransferGroup(string aGroup, string aOutputPath)
        {
            // TODO Implement Transfer Logic
        }

        /// <summary>
        /// Adds a task to the specified group and returns true if successful or false otherwise
        /// </summary>
        /// <param name="aGroup"></param>
        /// <returns>bool</returns>
        public bool AddTaskTogroup(string aGroup)
        {
            // TODO Implement Adding Group logic

            return true;
        }

        /// <summary>
        /// Removes the specified task from the specified group
        /// </summary>
        /// <param name="aTask"></param>
        /// <param name="aGroup"></param>
        /// <returns>bool</returns>
        public bool RemoveTaskFromGroup(string aTask, string aGroup)
        {
            // TODO Implement Remove task from group logic

            return true;
        }

        /// <summary>
        /// Progress bar displaying overall completion of tasks inside specified group
        /// </summary>
        /// <param name="aGroup"></param>
        /// <returns></returns>
        public int ProgressOfGroup(string aGroup)
        {
            // TODO Implement Progress bar displaying overall completion of tasks inside specified group

            return 0;
        }

        /// <summary>
        /// Defines how to transfer a group to a file
        /// </summary>
        /// <param name="aGroup"></param>
        /// <param name="aFilePath"></param>
        public void Transfer(string aGroup, string aFilePath)
        {
            // TODO Implement Transfer group to file logic
            throw new NotImplementedException();
        }
        #endregion
    }
}
