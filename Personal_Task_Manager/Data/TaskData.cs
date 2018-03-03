// Application: Personal Task Manager (PTM)
// Author: Zac Henderson, Dominic Goodman, Christopher Woodard
// Purpose: This class is meant to act as the data layer and house the data relavant to the Task Manager 
// File: TaskData.cs
// Date: 2/10/2018

using Personal_Task_Manager.Managers;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Personal_Task_Manager.Data
{
    public class TaskData : INotifyPropertyChanged
    {
        #region Fields
        private static int count = 0;
        private int taskNo;
        private string name;
        private string description;
        private string group;
        private DateTime startDate;
        private DateTime endDate;
        private Guid taskGuid;
        private bool completed;
        public static ObservableCollection<TaskData> aCompletedTaskGroup = new ObservableCollection<TaskData>();
        public static ObservableCollection<TaskData> aTaskCollection = new ObservableCollection<TaskData>();
        public static ObservableCollection<TaskData> aFoundTaskCollection = new ObservableCollection<TaskData>();

        public GroupData aGroupData = new GroupData();
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
                OnPropertyChanged();
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
                OnPropertyChanged();
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
                OnPropertyChanged();
            }
        }

        public DateTime StartDate
        {
            get
            {
                return startDate;
            }
            set
            {
                startDate = value;
                OnPropertyChanged();
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
                OnPropertyChanged();
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
                OnPropertyChanged();
            }
        }

        public int TaskNo
        {
            get
            {
                return taskNo;
            }
            set
            {
                taskNo = value;
                OnPropertyChanged();
            }
        }

        public bool Completed
        {
            get
            {
                return completed;
            }
            set
            {
                completed = value;
                OnPropertyChanged();
            }
        }

        public static int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }
        #endregion


        #region Methods
        /// <summary>
        /// Static method to be used with setting default value placeholders for databinding
        /// </summary>
        /// <returns></returns>
        public static ObservableCollection<TaskData> GetTaskData()
        {
            TextManager aTextManager = new TextManager();
            //TODO Add logic to actually determine if there is a savefile path.
            aTextManager.ParseFile();

            return aTaskCollection;
        }
        #endregion


        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion


        #region EvenetHandler
        private void OnPropertyChanged(
            [CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }
        #endregion
    }
}
