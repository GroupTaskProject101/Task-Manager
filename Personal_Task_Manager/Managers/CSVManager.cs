// Application: Personal Task Manager (PTM)
// Author: Zac Henderson, Dominic Goodman, Christopher Woodard
// Purpose: This class is meant to act as the manager(logic layer) and house the logic relavant to the CSV Manager 
// File: CSVManager.cs
// Date: 2/10/2018
//Date, startTime, endTime, "name", "description","group"
//2017/1/27,1400,1500,"sample name", "sample description", "samples"
//2017/1/30,1600,1700,"Lifting", "Working on my gains","exercise"
//2017/1/31,1400,1500,"Work", "Got to make money", "weekly issues"


using CsvHelper;
using Personal_Task_Manager.Data;
using Personal_Task_Manager.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Task_Manager.Managers
{
    public class CSVManager : FileManager, IParsable
    {

        private List<TaskData> taskCollection = new List<TaskData>();

        public List<TaskData> TaskCollection { get => taskCollection; set => taskCollection = value; }

        /// <summary>
        /// Specifies how to parse a CSV file
        /// </summary>
        /// <returns></returns>
        public override void ParseFile()
        {
            CsvReader csv = new CsvReader(File.OpenText("C:\\Users\\Dominic\\Desktop\\testFile.csv"));
            csv.Read();
            csv.ReadHeader();
            while (csv.Read())
            { 
                TaskData nextTask = new TaskData();
                nextTask.Name = csv.GetField<string>("name");
                nextTask.Group=csv.GetField<string>("description");
                nextTask.Description=csv.GetField<string>("group");
                nextTask.StartTime = csv.GetField<string>("startTime");
                taskCollection.Add(nextTask);
            }
        }
    }
}