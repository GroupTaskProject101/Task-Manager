using Personal_Task_Manager.Data;
using Personal_Task_Manager.Managers;
using System.Windows;

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

        private void AddTask_Click(object sender, RoutedEventArgs e)
        {
            if (AssignGroupCB.SelectedIndex == -1)
            {
                if (SelectDateDD.SelectedDate != null)
                {
                    TaskManager.CreateTask(TaskNameTb.Text, DescriptionTb.Text, "", EndTimeTb.Text, AMRb.IsChecked, SelectDateDD.SelectedDate.Value.ToShortDateString());
                }
                else
                {
                    TaskManager.CreateTask(TaskNameTb.Text, DescriptionTb.Text, "", EndTimeTb.Text, AMRb.IsChecked, "");
                }               
            }
            else
            {
                if (SelectDateDD.SelectedDate != null)
                {
                    TaskManager.CreateTask(TaskNameTb.Text, DescriptionTb.Text, AssignGroupCB.SelectedValue.ToString(), EndTimeTb.Text, AMRb.IsChecked, SelectDateDD.SelectedDate.Value.ToShortDateString());
                }
                else
                {
                    TaskManager.CreateTask(TaskNameTb.Text, DescriptionTb.Text, AssignGroupCB.SelectedValue.ToString(), EndTimeTb.Text, AMRb.IsChecked, "");
                }                 
            }
            this.Close();
        }
    }
}
