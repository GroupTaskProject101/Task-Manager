// Application: Personal Task Manager (PTM)
// Author: Zac Henderson, Dominic Goodman, Christopher Woodard
// Purpose: This class is meant to act as the manager(logic layer) and house the logic relavant to the File Manager 
// File: FileManager.cs
// Date: 2/10/2018

using Personal_Task_Manager.Data;
using Personal_Task_Manager.Interfaces;
using System;
using System.IO;

namespace Personal_Task_Manager.Managers
{
    public abstract class FileManager : IParsable
    {
        #region Fields
        FileData aFileData = new FileData();
        #endregion

        #region Methods
        /// <summary>
        /// Saves all tasks inside the task collection to the specified output file
        /// </summary>
        /// <param name="aFilePath"></param>
        public static void Save(string aFilePath)
        {
            string fileName = "LastSaveInformation.txt";
            string path = Path.Combine(@"../../Resources/", fileName);

            try
            {
                if (aFilePath != null && aFilePath != "")
                {
                    StreamWriter writer = new StreamWriter(path, false);

                    if (FileData.SaveFileLocation != null && FileData.SaveFileLocation != "")
                    {
                        writer.WriteLine(FileData.SaveFileLocation);
                    }
                    
                    writer.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            
        }

        /// <summary>
        /// Loads the last save location and values
        /// </summary>
        public static string LoadLastSave()
        {
            string line = "";
            string fileName = "LastSaveInformation.txt";

            try
            {
                StreamReader reader = new StreamReader(@"../../Resources/" + fileName);

                line = reader.ReadLine();

                if (line != null || line != "")
                {
                    FileData.LastSaveLocation = line;
                }

                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

            return line;
        }

        /// <summary>
        /// Specifies how to parse a file
        /// </summary>
        /// <returns></returns>
        public abstract void ParseFile();
        #endregion
    }
}
