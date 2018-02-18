// Application: Personal Task Manager (PTM)
// Author: Zac Henderson, Dominic Goodman, Christopher Woodard
// Purpose: This class is meant to act as the data layer and house the data relavant to the Task Manager 
// File: TaskData.cs
// Date: 2/10/2018

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Task_Manager.Data
{
    public class TaskData : INotifyPropertyChanged
    {
        #region Fields
        private int taskNo;
        private string name;
        private string description;
        private string group;
        private string startTime;
        private string endTime;
        private DateTime currentTime;
        private string endDate;
        private Guid taskGuid;
        // TODO Finish setting up task completion system to keep track of finished tasks
        private List<string> taskCollection;
        #endregion


        #region Properties
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
                OnPropertyChanged();
            }
        }

        public string Group
        {
            get
            {
                return group;
            }
            set
            {
                group = value;
                OnPropertyChanged();
            }
        }

        public string StartTime
        {
            get
            {
                return startTime;
            }
            set
            {
                startTime = value;
                OnPropertyChanged();
            }
        }

        public string EndTime
        {
            get
            {
                return endTime;
            }
            set
            {
                endTime = value;
                OnPropertyChanged();
            }
        }

        public DateTime CurrentTime
        {
            get
            {
                return currentTime;
            }
            set
            {
                currentTime = value;
                OnPropertyChanged();
            }
        }

        public string EndDate
        {
            get
            {
                return endDate;
            }
            set
            {
                endDate = value;
                OnPropertyChanged();
            }
        }

        public Guid TaskGUID
        {
            get
            {
                return taskGuid;
            }
            set
            {
                taskGuid = value;
                OnPropertyChanged();
            }
        }

        // TODO This Collection should be updated to reflect appropriate format for the input values coming from save/load file
        public List<string> TaskCollection
        {
            get
            {
                return taskCollection;
            }
            set
            {
                taskCollection = value;
                OnPropertyChanged();
            }
        }

        public int TaskNo
        {
            get
            {
                return taskNo;
            }
            set
            {
                taskNo = value;
                OnPropertyChanged();
            }
        }
        #endregion


        #region Methods
        /// <summary>
        /// Static method to be used with setting default value placeholders for databinding
        /// </summary>
        /// <returns></returns>
        public static ObservableCollection<TaskData> GetTaskData()
        {
            var aTaskData = new ObservableCollection<TaskData>();

            aTaskData.Add(new TaskData()
            {
                TaskNo = 0,
                Name = "Test0",
                Description = "Take 30 minute practice test for English101",
                Group = "English 101",
                StartTime = "6:00 PM",
                EndTime = "11:30 PM",
                CurrentTime = DateTime.Now,
                EndDate = DateTime.Today.ToShortDateString(),
                TaskGUID = Guid.NewGuid(),
            });
            aTaskData.Add(new TaskData()
            {
                TaskNo = 1,
                Name = "Test1",
                Description = "Take 30 minute practice test for English101",
                Group = "English 101",
                StartTime = "6:00 PM",
                EndTime = "11:30 PM",
                CurrentTime = DateTime.Now,
                EndDate = DateTime.Today.ToShortDateString(),
                TaskGUID = Guid.NewGuid(),
            });
            aTaskData.Add(new TaskData()
            {
                TaskNo = 2,
                Name = "Test2",
                Description = "Take 30 minute practice test for English101",
                Group = "English 101",
                StartTime = "6:00 PM",
                EndTime = "11:30 PM",
                CurrentTime = DateTime.Now,
                EndDate = DateTime.Today.ToShortDateString(),
                TaskGUID = Guid.NewGuid(),
            });
            aTaskData.Add(new TaskData()
            {
                TaskNo = 3,
                Name = "Test3",
                Description = "Take 30 minute practice test for English101",
                Group = "English 101",
                StartTime = "6:00 PM",
                EndTime = "11:30 PM",
                CurrentTime = DateTime.Now,
                EndDate = DateTime.Today.ToShortDateString(),
                TaskGUID = Guid.NewGuid(),
            });
            aTaskData.Add(new TaskData()
            {
                TaskNo = 4,
                Name = "Test4",
                Description = "Take 30 minute practice test for English101",
                Group = "English 101",
                StartTime = "6:00 PM",
                EndTime = "11:30 PM",
                CurrentTime = DateTime.Now,
                EndDate = DateTime.Today.ToShortDateString(),
                TaskGUID = Guid.NewGuid(),
            });
            aTaskData.Add(new TaskData()
            {
                TaskNo = 5,
                Name = "Test5",
                Description = "Take 30 minute practice test for English101",
                Group = "English 101",
                StartTime = "6:00 PM",
                EndTime = "11:30 PM",
                CurrentTime = DateTime.Now,
                EndDate = DateTime.Today.ToShortDateString(),
                TaskGUID = Guid.NewGuid(),
            });
            aTaskData.Add(new TaskData()
            {
                TaskNo = 6,
                Name = "Test6",
                Description = "Take 30 minute practice test for English101",
                Group = "English 101",
                StartTime = "6:00 PM",
                EndTime = "11:30 PM",
                CurrentTime = DateTime.Now,
                EndDate = DateTime.Today.ToShortDateString(),
                TaskGUID = Guid.NewGuid(),
            });
            aTaskData.Add(new TaskData()
            {
                TaskNo = 7,
                Name = "Test7",
                Description = "Take 30 minute practice test for English101",
                Group = "English 101",
                StartTime = "6:00 PM",
                EndTime = "11:30 PM",
                CurrentTime = DateTime.Now,
                EndDate = DateTime.Today.ToShortDateString(),
                TaskGUID = Guid.NewGuid(),
            });
            return aTaskData;
        }
        #endregion


        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion


        #region EvenetHandler
        private void OnPropertyChanged(
            [CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }
        #endregion
    }
}
