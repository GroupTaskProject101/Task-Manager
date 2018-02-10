// Application: Personal Task Manager (PTM)
// Author: Zac Henderson, Dominic Goodman, Christopher Woodard
// Purpose: This class is meant to act as the data layer and house the data relavant to the Group Manager 
// File: GroupData.cs
// Date: 2/10/2018

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Task_Manager.Data
{
    public class GroupData
    {
        #region Fields
        private string name;
        private Guid groupGuid;
        private int taskCount;
        #endregion


        #region Properties
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                //TODO 2 way binding
            }
        }

        public Guid GroupGuid
        {
            get
            {
                return groupGuid;
            }
            set
            {
                groupGuid = value;
                //TODO 2 way binding
            }
        }

        public int TaskCount
        {
            get
            {
                return taskCount;
            }
            set
            {
                taskCount = value;
                //TODO 2 way binding
            }
        }
        #endregion
    }
}
