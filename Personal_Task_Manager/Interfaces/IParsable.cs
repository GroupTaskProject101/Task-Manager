// Application: Personal Task Manager (PTM)
// Author: Zac Henderson, Dominic Goodman, Christopher Woodard
// Purpose: This interface is used to ensure the parsing method is defined in any class parsing in data
// File: IParsable.cs
// Date: 2/10/2018

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Task_Manager.Interfaces
{
    interface IParsable
    {
        //This function should specify how to parse the file format being used
        string ParseFile();
    }
}