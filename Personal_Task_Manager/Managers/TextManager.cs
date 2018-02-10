// Application: Personal Task Manager (PTM)
// Author: Zac Henderson, Dominic Goodman, Christopher Woodard
// Purpose: This class is meant to act as the manager(logic layer) and house the logic relavant to the Text Manager 
// File: TextManager.cs
// Date: 2/10/2018

using Personal_Task_Manager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Task_Manager.Managers
{
    public class TextManager : FileManager, IParsable
    {
        /// <summary>
        /// Specifies how to parse a text file
        /// </summary>
        /// <returns></returns>
        public override string ParseFile()
        {
            // TODO Implement logic to parse Text File
            throw new NotImplementedException();
        }
    }
}
