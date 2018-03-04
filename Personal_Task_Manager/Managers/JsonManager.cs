// Application: Personal Task Manager (PTM)
// Author: Zac Henderson, Dominic Goodman, Christopher Woodard
// Purpose: This class is meant to act as the manager(logic layer) and house the logic relavant to the Json Manager 
// File: JsonManager.cs
// Date: 2/10/2018

using Newtonsoft.Json;
using Personal_Task_Manager.Data;
using Personal_Task_Manager.Interfaces;
using System.Collections.Generic;
using System.IO;

namespace Personal_Task_Manager.Managers
{
    public class JsonManager : FileManager, IParsable
    {
        /// <summary>
        /// Specifies how to parse a Json file
        /// </summary>
        /// <returns></returns>
        public override void ParseFile()
        {
            
        }
    }
}
