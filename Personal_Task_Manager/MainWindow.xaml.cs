using System;
using System.Windows;
using Personal_Task_Manager.Data;
using System.Windows.Threading;
using System.Globalization;
using System.Windows.Forms;
using Personal_Task_Manager.Managers;
using System.IO;

namespace Personal_Task_Manager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeClock();
            InitializeTimingLoop();

            TaskManager aTaskManager = new TaskManager();
            TextManager aTextManager = new TextManager();
            JsonManager aJsonManager = new JsonManager();
            CSVManager aCSVManager = new CSVManager();
            GroupManager aGroupManager = new GroupManager();

            FileData fileData = new FileData();
            TaskData aTaskData = new TaskData();

            DataContext = aTaskData;
            TaskList.DataContext = TaskData.GetTaskData();
            ProgressSP.DataContext = TaskData.Count;
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

        void timer_Tick(object sender, EventArgs e)
        {
            //TotalTaskTB.Text = TaskData.count.ToString(); 
        }


        //**********************File Menu**********************
        private void MenuOpen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuExit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }


        //**********************Help Menu**********************
        private void MenuVersionInformation_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuHelpfulLinks_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuDocumentation_Click(object sender, RoutedEventArgs e)
        {

        }


        //**********************View Menu**********************
        private void MenuMultipletaskWindow_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuEditTaskWindow_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuGroupWindow_Click(object sender, RoutedEventArgs e)
        {

        }


        //**********************Edit Menu**********************
        private void MenuEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuDelete_Click(object sender, RoutedEventArgs e)
        {

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
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {

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
    }
}
