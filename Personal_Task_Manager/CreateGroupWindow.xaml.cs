using Personal_Task_Manager.Data;
using System.Windows;
using System;

namespace Personal_Task_Manager
{
    /// <summary>
    /// Interaction logic for CreateGroupWindow.xaml
    /// </summary>
    public partial class CreateGroupWindow : Window
    {
        /// <summary>
        /// Constructor for Create Group Window
        /// </summary>
        public CreateGroupWindow()
        {
            InitializeComponent();
        }

        private void AddGroupBtn_Click(object sender, RoutedEventArgs e)
        {
            GroupData aGroupData = new GroupData();

            aGroupData.Name = GroupNameTb.Text;
            aGroupData.Description = GroupDescriptionTb.Text;
            aGroupData.GroupGuid = Guid.NewGuid();
            aGroupData.TaskCount = aGroupData.TaskCount++;

            if (GroupNameTb.Text != "")
            {
                GroupData.aGroupCollection.Add(aGroupData);
            }

            this.Close();
        }
    }
}
