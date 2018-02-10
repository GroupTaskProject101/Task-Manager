// Application: Personal Task Manager (PTM)
// Author: Zac Henderson, Dominic Goodman, Christopher Woodard
// Purpose: This interface is used to ensure the transfer method is defined in any class transfering data to and from groups
// File: ITransferable.cs
// Date: 2/10/2018

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Task_Manager.Interfaces
{
    interface ITransferable
    {
        //This function should specify how to transfer the group to a file
        void Transfer(string aGroup, string aFilePath);
    }
}