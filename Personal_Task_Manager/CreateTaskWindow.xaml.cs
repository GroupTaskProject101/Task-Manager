using Personal_Task_Manager.Data;
using Personal_Task_Manager.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Personal_Task_Manager
{
    /// <summary>
    /// Interaction logic for Create_Task_Window.xaml
    /// </summary>
    public partial class CreateTaskWindow : Window
    {
        private TaskManager aTaskManager = new TaskManager();

        public CreateTaskWindow()
        {
            InitializeComponent();

            AssignGroupCB.ItemsSource = GroupData.aGroupCollection;
        }

        private void loadTaskFileBtn_Click_1(object sender, RoutedEventArgs e)
        {
            MultipleTaskWindow aMultipleTaskWindow = new MultipleTaskWindow();

            aMultipleTaskWindow.ShowDialog();
        }

        private void AddTaskBtn_Click(object sender, RoutedEventArgs e)
        {
            aTaskManager.CreateTask(TaskNameTb.Text, DescriptionTb.Text, AssignGroupCB.SelectedValue.ToString());

            this.Close();
        }
    }
}
