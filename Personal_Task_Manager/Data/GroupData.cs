// Application: Personal Task Manager (PTM)
// Author: Zac Henderson, Dominic Goodman, Christopher Woodard
// Purpose: This class is meant to act as the data layer and house the data relavant to the Group Manager 
// File: GroupData.cs
// Date: 2/10/2018

using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Personal_Task_Manager.Data
{
    public class GroupData : INotifyPropertyChanged
    {
        #region Fields
        private string name;
        private string description;
        private int taskCount;
        private Guid groupGuid;
        public static ObservableCollection<GroupData> aGroupCollection = new ObservableCollection<GroupData>();
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

        public Guid GroupGuid
        {
            get
            {
                return groupGuid;
            }
            set
            {
                groupGuid = value;
                OnPropertyChanged();
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
        #endregion


        #region Constructors
        public GroupData()
        {
            groupGuid = Guid.NewGuid();
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
