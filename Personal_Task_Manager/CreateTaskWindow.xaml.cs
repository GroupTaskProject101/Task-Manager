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
        public CreateTaskWindow()
        {
            InitializeComponent();
        }

        private void loadTaskFileBtn_Click_1(object sender, RoutedEventArgs e)
        {
            MultipleTaskWindow multipleTaskWindow = new MultipleTaskWindow();

            multipleTaskWindow.ShowDialog();
        }
    }
}
