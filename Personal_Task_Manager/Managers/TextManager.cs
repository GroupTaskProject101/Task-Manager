﻿// Application: Personal Task Manager (PTM)
// Author: Zac Henderson, Dominic Goodman, Christopher Woodard
// Purpose: This class is meant to act as the manager(logic layer) and house the logic relavant to the Text Manager 
// File: TextManager.cs
// Date: 2/10/2018
//Input file format
//#Fields: Date,startTime,endTime,name,description,group
//#End of line character: $
//2017/1/27,1400,1500,sample name,sample description,samples $
//2017/1/30,1600,1700,Lifting,Working on my gains,exercise $
//2017/1/31,1400,1500,Work,Got to make money,weekly issues $

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
                        TaskManager.CreateTask(tempItems[1], tempItems[2], tempItems[3],time[1].Substring(0, time[1].LastIndexOf(':')) +" "+time[2] , false, time[0]);
                    }
                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
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
                        string nextLine = nextTask.EndDate.ToString() + "," + nextTask.Name + "," + nextTask.Description + "," + nextTask.Group + " $";
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