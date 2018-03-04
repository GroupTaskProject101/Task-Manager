// Application: Personal Task Manager (PTM)
// Author: Zac Henderson, Dominic Goodman, Christopher Woodard
// Purpose: This class is meant to act as the manager(logic layer) and house the logic relavant to the CSV Manager 
// File: CSVManager.cs
// Date: 2/10/2018


using CsvHelper;
using Personal_Task_Manager.Data;
using Personal_Task_Manager.Interfaces;
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
            
        }
    }
}