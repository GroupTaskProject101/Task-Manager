// Application: Personal Task Manager (PTM)
// Author: Zac Henderson, Dominic Goodman, Christopher Woodard
// Purpose: This class is meant to act as the manager(logic layer) and house the logic relavant to the Text Manager 
// File: TextManager.cs
// Date: 2/10/2018
//Input file format
//1/1/0001 12:00:00 AM,Enter Task Name,Enter Task Description, $
//1/1/0001 12:00:00 AM,qweqweq,Enter Task Description, $


using Personal_Task_Manager.Data;
using Personal_Task_Manager.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Personal_Task_Manager.Managers
{
    public class TextManager : FileManager, IParsable
    {
        #region Fields
        private List<TaskData> taskCollection = new List<TaskData>();
        private string endOfLine;
        private string[] fields;
        #endregion

        #region Properties
        public List<TaskData> TaskCollection { get => taskCollection; }
        public string[] Fields { get => fields; set => fields = value; }
        public string EndOfLine { get => endOfLine; set => endOfLine = value; }
        #endregion

        /// <summary>
        /// Specifies how to parse a text file
        /// </summary>
        public override void ParseFile()
        {
            try
            {
                string fileName = FileManager.LoadLastSave();

                StreamReader reader = File.OpenText(fileName);
                string line = "";

                while ((line = reader.ReadLine()) != null)
                {
                    string[] items = line.Split('$').Select(p => p.Trim()).Where(p => !string.IsNullOrWhiteSpace(p)).ToArray();

                    foreach (string item in items)
                    {
                        string[] tempItems = item.Split(',');
                        string[] time =  tempItems[0].Split(' ');
                        TaskManager.CreateTask(tempItems[1], tempItems[2], tempItems[3],time[1].Substring(0, time[1].LastIndexOf(':')) , time[2].Equals("AM")?true:false, time[0],bool.Parse(tempItems[4]));
                    }
                }
                reader.Close();
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
                if (FileData.SaveFileLocation != null && FileData.SaveFileLocation != ""  )
                {
                    if(!FileData.SaveFileLocation.EndsWith(".txt"))
                    {
                            File.Delete(FileData.SaveFileLocation);
                            FileData.SaveFileLocation = FileData.SaveFileLocation.Substring(0, FileData.SaveFileLocation.LastIndexOf('.')) + ".txt";
                            Save(FileData.SaveFileLocation);
                    }
                    StreamWriter writer = new StreamWriter(FileData.SaveFileLocation, false);
                    foreach(TaskData nextTask in TaskData.aTaskCollection)
                    {
                        string nextLine = nextTask.EndDate.ToString() + "," + nextTask.Name + "," + nextTask.Description + "," + nextTask.Group+","+ nextTask.Completed + " $";
                        writer.WriteLine(nextLine);
                    }
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