﻿using Microsoft.Office.Interop.Word;
using Personal_Task_Manager.Data;
using Personal_Task_Manager.Managers;
using System;
using System.Globalization;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Threading;

namespace Personal_Task_Manager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {
        public TaskManager aTaskManager = new TaskManager();
        public TextManager aTextManager = new TextManager();
        public JsonManager aJsonManager = new JsonManager();
        public CSVManager aCSVManager = new CSVManager();
        public GroupManager aGroupManager = new GroupManager();
        
        public FileData aFileData = new FileData();
        public TaskData aTaskData = new TaskData();

        public MainWindow()
        {
            InitializeComponent();
            InitializeClock();
            InitializeTimingLoop();

            DataContext = aTaskData;

            TaskList.DataContext = TaskData.aTaskCollection;

            SearchList.DataContext = TaskData.aFoundTaskCollection;
        }

        private void InitializeTimingLoop()
        {
            var timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 1000;
            timer.Start();
        }

        private void InitializeClock()
        {
            DispatcherTimer clock = new DispatcherTimer(new TimeSpan(0, 0, 1),
                DispatcherPriority.Normal, delegate
                {
                    this.currentTime.Text = DateTime.Now.ToString("hh:mm:ss tt", CultureInfo.InvariantCulture);
                }, this.Dispatcher);
        }

        void timer_Tick(object sender, EventArgs e)
        {
            int daily = 0;
            foreach(TaskData nextTask in TaskData.aTaskCollection)
            {
                if(nextTask.EndDate.Date == DateTime.Today)
                {
                    daily++;
                }
            }
            DailyTaskTB.Text = daily.ToString();
            TotalTaskTB.Text = TaskData.aTaskCollection.Count.ToString();
        }

        private void createTaskBtn_Click(object sender, RoutedEventArgs e)
        {
            CreateTaskWindow createTaskWindow = new CreateTaskWindow();

            createTaskWindow.ShowDialog();
        }

        private void createGroupBtn_Click(object sender, RoutedEventArgs e)
        {
            CreateGroupWindow createGroupWindow = new CreateGroupWindow();

            createGroupWindow.ShowDialog();
        }


        //**********************File Menu**********************
        private void MenuOpen_Click(object sender, RoutedEventArgs e)
        {
            try { 
            if (TextRB.IsChecked == true)
            {
                aTextManager.ParseFile();
            }
            else if (JsonRB.IsChecked == true)
            {
                aJsonManager.ParseFile();
            }
            else if (CSVRB.IsChecked == true)
            {
                aCSVManager.ParseFile();
            }
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Invalid save file, try changing default location or creating a new one.", "ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuSave_Click(object sender, RoutedEventArgs e)
        {
            if(TextRB.IsChecked ==true)
            {
                aTextManager.Save();
            }
            else if(JsonRB.IsChecked == true)
            {
                aJsonManager.Save();
            }
            else if(CSVRB.IsChecked == true)
            {
                aCSVManager.Save();
            }
        }

        private void MenuExit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }


        //**********************Help Menu**********************
        private void MenuDocumentation_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Word.Application ap = new Microsoft.Office.Interop.Word.Application();
            Document document = ap.Documents.Open((System.IO.Path.GetFullPath(@"..\..\Resources\") + "WK3_ User_Guide_Grp7_v2.docx"));
        }


        //**********************View Menu**********************
        private void MenuGroupWindow_Click(object sender, RoutedEventArgs e)
        {
            CreateGroupWindow createGroupWindow = new CreateGroupWindow();

            createGroupWindow.ShowDialog();
        }


        //**********************Edit Menu**********************
        private void MenuDelete_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = TaskList.SelectedItem != null? TaskList.SelectedItem: (SearchList.SelectedItem != null ? SearchList.SelectedItem : null);
            try
            {
                if (selectedItem != null)
                {
                    TaskData.aTaskCollection.Remove((TaskData)selectedItem);
                    TaskData.aFoundTaskCollection.Remove((TaskData)selectedItem);
                }
            }
            catch
            {
                //Ignore a failed delete
            }
        }

        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            FileData.SaveFileLocation = SavePath.Text != "" ? SavePath.Text : "C:/";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SavePath.Text = FileManager.LoadLastSave();       

            if (FileData.LastSaveLocation != "")
            {
                SavePath.Text = FileData.LastSaveLocation;
            }
            if (FileData.LastSaveLocation.EndsWith(".txt"))
            {
                TextRB.IsChecked = true;
            }
            else if (FileData.LastSaveLocation.EndsWith(".json"))
            {
                JsonRB.IsChecked = true;
            }
            else if (FileData.LastSaveLocation.EndsWith(".csv"))
            {
                CSVRB.IsChecked = true;
            }
        }     

        private void Window_Closed(object sender, EventArgs e)
        {
            FileManager.Save(SavePath.Text);
        }

        private void Browse_Click(object sender, RoutedEventArgs e)
        {
            string temp = SavePath.Text;

            OpenFileDialog aFileDialog = new OpenFileDialog();

            aFileDialog.InitialDirectory = @"C:\";
            aFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            aFileDialog.FilterIndex = 2;
            aFileDialog.RestoreDirectory = true;

            aFileDialog.ShowDialog();

            if (aFileDialog.FileName != "" && aFileDialog.FileName != null)
            {
                string path = aFileDialog.FileName;
                SavePath.Text = path;
            }
            else
            {
                SavePath.Text = temp;
            }
        }

        private void JsonRB_Checked(object sender, RoutedEventArgs e)
        {
            FileData.FileFormat = "Json";
        }

        private void CSVRB_Checked(object sender, RoutedEventArgs e)
        {
            FileData.FileFormat = "CSV";
        }

        private void TextRB_Checked(object sender, RoutedEventArgs e)
        {
            FileData.FileFormat = "Text";
        }

        private void SearchElement_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            setButtonVisibility();
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            if (SearchElement.Text != String.Empty)
            {
                aTaskManager.SearchTasks(SearchElement.Text, CategoryCB.Text);
            }
        }

        private void setButtonVisibility()
        {
            if (SearchElement.IsInitialized)
            {
                if (SearchElement.Text != String.Empty)
                {
                    SearchBtn.IsEnabled = true;
                }
                else
                {
                    SearchBtn.IsEnabled = false;
                }
            }          
        }


    }
}
