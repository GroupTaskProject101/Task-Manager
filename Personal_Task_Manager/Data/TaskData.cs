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
        private bool completed;
        private bool isChecked;

        private DateTime startDate;
        private DateTime endDate;
        private Guid taskGuid;
        
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

        public bool IsChecked
        {
            get
            {
                return isChecked;
            }
            set
            {
                isChecked = value;
                OnPropertyChanged();
            }
        }
        #endregion


        #region Constructors
        public TaskData()
        {
            TaskGUID = Guid.NewGuid();
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
