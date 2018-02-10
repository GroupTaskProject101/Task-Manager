// Application: Personal Task Manager (PTM)
// Author: Zac Henderson, Dominic Goodman, Christopher Woodard
// Purpose: This class is meant to act as the data layer and house the data relavant to the File Manager 
// File: FileData.cs
// Date: 2/10/2018

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Task_Manager.Data
{
    public class FileData : INotifyPropertyChanged
    {
        #region Fields
        private string saveFileLocation;
        private string lastSaveLocation;
        private string fileFormat;
        #endregion


        #region Properties
        public string SaveFileLocation
        {
            get
            {
                return saveFileLocation;
            }
            set
            {
                saveFileLocation = value;
                OnPropertyChanged();
            }
        }

        public string LastSaveLocation
        {
            get
            {
                return lastSaveLocation;
            }
            set
            {
                lastSaveLocation = value;
                OnPropertyChanged();
            }
        }

        public string FileFormat
        {
            get
            {
                return fileFormat;
            }
            set
            {
                fileFormat = value;
                OnPropertyChanged();
            }
        }
        #endregion


        #region Methods
        /// <summary>
        /// Static method to be used with setting default value placeholders
        /// </summary>
        /// <returns></returns>
        public static FileData GetFileData()
        {
            var aFileData = new FileData()
            {
                SaveFileLocation = "C:/",
                LastSaveLocation = "C:/",
                FileFormat = "Text"
            };
            return aFileData;
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
