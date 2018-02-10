// Application: Personal Task Manager (PTM)
// Author: Zac Henderson, Dominic Goodman, Christopher Woodard
// Purpose: This class is meant to act as the data layer and house the data relavant to the Task Manager 
// File: TaskData.cs
// Date: 2/10/2018

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Task_Manager.Data
{
    public class TaskData
    {
        #region Fields
        private string name;
        private string description;
        private string group;
        private DateTime currentTime;
        private DateTime startTime;
        private DateTime endTime;
        private DateTime endDate;
        private Guid taskGuid;
        // TODO Finish setting up task completion system to keep track of finished tasks
        private Dictionary<Guid, Tuple<string, string, string, bool>> taskCollection;
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
                // TODO 2 way binding
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
                // TODO 2 way binding
            }
        }

        public string Group
        {
            get
            {
                return group;
            }
            set
            {
                group = value;
                // TODO 2 way binding
            }
        }

        public DateTime CurrentTime
        {
            get
            {
                return currentTime;
            }
            set
            {
                currentTime = value;
                /// TODO 2 way binding
            }
        }

        public DateTime StartTime
        {
            get
            {
                return startTime;
            }
            set
            {
                startTime = value;
                // TODO 2 way binding
            }
        }

        public DateTime EndTime
        {
            get
            {
                return endTime;
            }
            set
            {
                endTime = value;
                // TODO 2 way binding
            }
        }

        public DateTime EndDate
        {
            get
            {
                return endDate;
            }
            set
            {
                endDate = value;
                // TODO 2 way binding
            }
        }

        public Guid TaskGUID
        {
            get
            {
                return taskGuid;
            }
            set
            {
                taskGuid = value;
                // TODO 2 way binding
            }
        }

        // TODO This Collection should be updated to reflect appropriate format for the input values coming from save/load file
        public Dictionary<Guid, Tuple<string, string, string, bool>> TaskCollection
        {
            get
            {
                return taskCollection;
            }
            set
            {
                taskCollection = value;
                // TODO 2 way binding
            }
        }
        #endregion
    }
}
