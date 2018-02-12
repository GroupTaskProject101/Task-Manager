// Application: Personal Task Manager (PTM)
// Author: Zac Henderson, Dominic Goodman, Christopher Woodard
// Purpose: This class is meant to act as the manager(logic layer) and house the logic relavant to the CSV Manager 
// File: CSVManager.cs
// Date: 2/10/2018
//Date, startTime, endTime, "name", "description","group",
//2017/1/27,1400,1500,"sample name", "sample description", "samples",
//2017/1/30,1600,1700,"Lifting", "Working on my gains","exercise",
//2017/1/31,1400,1500,"Work", "Got to make money", "weekly issues",


using Personal_Task_Manager.Data;
using Personal_Task_Manager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }
    }
}