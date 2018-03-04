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
    public class GroupManager
    {
        #region Fields
        GroupData aGroupData = new GroupData();
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
    }
}
