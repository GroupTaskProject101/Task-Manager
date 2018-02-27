// Application: Personal Task Manager (PTM)
// Author: Zac Henderson, Dominic Goodman, Christopher Woodard
// Purpose: This class is meant to act as the data layer and house the data relavant to the File Manager 
// File: FileData.cs
// Date: 2/10/2018

using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Personal_Task_Manager.Data
{
    public class FileData : INotifyPropertyChanged
    {
        #region Fields
        private static string saveFileLocation;
        private static string lastSaveLocation;
        private static string fileFormat;
        #endregion


        #region Properties
        public static string SaveFileLocation
        {
            get
            {
                return saveFileLocation;
            }
            set
            {
                saveFileLocation = value;
            }
        }

        public static string LastSaveLocation
        {
            get
            {
                return lastSaveLocation;
            }
            set
            {
                lastSaveLocation = value;
            }
        }

        public static string FileFormat
        {
            get
            {
                return fileFormat;
            }
            set
            {
                fileFormat = value;
            }
        }
        #endregion


        #region Methods
        
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
