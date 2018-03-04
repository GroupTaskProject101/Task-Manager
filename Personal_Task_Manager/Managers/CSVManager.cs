// Application: Personal Task Manager (PTM)
// Author: Zac Henderson, Dominic Goodman, Christopher Woodard
// Purpose: This class is meant to act as the manager(logic layer) and house the logic relavant to the CSV Manager 
// File: CSVManager.cs
// Date: 2/10/2018


using CsvHelper;
using Personal_Task_Manager.Data;
using Personal_Task_Manager.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace Personal_Task_Manager.Managers
{
    public class CSVManager : FileManager, IParsable
    {
        /// <summary>
        /// Specifies how to parse a CSV file
        /// </summary>
        /// <returns></returns>
        public override void ParseFile()
        {

            try
            {
                StreamReader reader = File.OpenText(FileManager.LoadLastSave());
                CsvReader csv = new CsvReader(reader);
                IEnumerable<TaskData> tasks = csv.GetRecords<TaskData>();

                foreach (TaskData nextTask in tasks)
                {
                    TaskData.aTaskCollection.Add(nextTask);
                }
            }
            catch (Exception e)
            {
                throw e;

            }
        }
        public void Save()
        {
            try
            {
                if (FileData.SaveFileLocation != null && FileData.SaveFileLocation != "")
                {
                    if (!FileData.SaveFileLocation.EndsWith(".csv"))
                    {
                        File.Delete(FileData.SaveFileLocation);
                        FileData.SaveFileLocation = FileData.SaveFileLocation.Substring(0, FileData.SaveFileLocation.LastIndexOf('.')) + ".csv";
                        Save(FileData.SaveFileLocation);
                    }
                    StreamWriter writer = new StreamWriter(FileData.SaveFileLocation, false);
                    CsvWriter csv = new CsvWriter(writer);
                    csv.WriteRecords(TaskData.aTaskCollection);
                    writer.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}