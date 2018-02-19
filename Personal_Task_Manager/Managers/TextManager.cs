// Application: Personal Task Manager (PTM)
// Author: Zac Henderson, Dominic Goodman, Christopher Woodard
// Purpose: This class is meant to act as the manager(logic layer) and house the logic relavant to the Text Manager 
// File: TextManager.cs
// Date: 2/10/2018
//Input file format
//#Fields: Date, startTime, endTime, "name", "description","group"
//#End of line character: $
//2017/1/27,1400,1500,"sample name", "sample description", "samples" $
//2017/1/30,1600,1700,"Lifting", "Working on my gains","exercise" $
//2017/1/31,1400,1500,"Work", "Got to make money", "weekly issues" $

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
            StreamReader reader = File.OpenText("C:\\Users\\Dominic\\Desktop\\testFile.txt");
            string nextLine;

            while ((nextLine = reader.ReadLine()).StartsWith("#"))
            {
                if (nextLine.StartsWith("#Fields"))
                {
                    nextLine = nextLine.Substring(nextLine.IndexOf(":")+1);
                    nextLine = nextLine.Replace(" ", "");
                    nextLine = nextLine.Replace("\"", "");
                    Fields = nextLine.Split(',');

                }
                else
                {
                    if(nextLine.StartsWith("#End of line character:"))
                    {
                        nextLine = nextLine.Substring(nextLine.IndexOf(":") + 1);
                        nextLine = nextLine.Replace(" ", "");
                        EndOfLine = nextLine;
                    }
                }
            }

            do
            {
                TaskData nextTask = new TaskData();
                string[] values = new string[fields.Length];

                for(int i = 0; i < values.Length;i++)
                {
                    nextLine = nextLine.Trim();
                    string nextSection = "";
                    if (nextLine.Contains(","))
                    {
                         nextSection = nextLine.Substring(0, nextLine.IndexOf(','));
                    } else
                    {
                         nextSection = nextLine.Substring(0, nextLine.IndexOf(endOfLine));
                    }

                    if (nextSection.StartsWith("\""))
                    {
                        while(!nextSection.EndsWith("\","))
                        {
                            nextSection += nextLine.Substring(0, nextLine.IndexOf(','));
                        }
                    }
                    nextLine = nextLine.Substring(nextLine.IndexOf(','));
                    values[i] = nextSection;
                }


                if (values.Length != fields.Length)
                {
                    //temporary
                    throw new NotImplementedException();
                }
                for (int i = 0; i < values.Length; i++)
                {
                    switch (fields[i])
                    {
                        case "Date":
                            //needs more information
                            break;
                        case "startTime":
                            nextTask.StartTime = values[i];
                            break;
                        case "endTime":
                            nextTask.EndTime = values[i];
                            break;
                        case "name":
                            nextTask.Name = values[i];
                            break;
                        case "description":
                            nextTask.Description = values[i];
                            break;
                        case "group":
                            nextTask.Group = values[i];
                            break;
                        default:
                            //temporary
                            throw new NotImplementedException();
                    }
                }
                taskCollection.Add(nextTask);
            } while ((nextLine = reader.ReadLine()) != null);

            reader.Close();
        }
    }
}
