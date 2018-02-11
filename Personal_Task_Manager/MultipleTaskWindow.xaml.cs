using Personal_Task_Manager.Data;
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
    /// Interaction logic for MultipleTaskWindow.xaml
    /// </summary>
    public partial class MultipleTaskWindow : Window
    {
        public MultipleTaskWindow()
        {
            InitializeComponent();
            dataGrid.ItemsSource = TaskData.GetTaskData();
        }
    }
}
