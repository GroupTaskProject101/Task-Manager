// Application: Personal Task Manager (PTM)
// Author: Zac Henderson, Dominic Goodman, Christopher Woodard
// Purpose: This class is meant to act as the manager(logic layer) and house the logic relavant to the File Manager 
// File: FileManager.cs
// Date: 2/10/2018

using Personal_Task_Manager.Data;
using Personal_Task_Manager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Task_Manager.Managers
{
    public abstract class FileManager : IParsable
    {
        #region Fields
        FileData aFileData = new FileData();
        #endregion


        #region Constructors
        #endregion


        #region Setters
        #endregion


        #region Getters
        #endregion


        #region Methods
        /// <summary>
        /// Saves all tasks inside the task collection to the specified output file
        /// </summary>
        /// <param name="aFilePath"></param>
        public void Save(string aFilePath)
        {
            // TODO Implement save file logic
        }

        /// <summary>
        /// Loads in tasks from the specified file location
        /// </summary>
        /// <param name="aFilePath"></param>
        public void Load(string aFilePath)
        {
            // TODO Implement load file logic
        }

        /// <summary>
        /// Specifies how to parse a file
        /// </summary>
        /// <returns></returns>
        public abstract void ParseFile();
        #endregion
    }
}
