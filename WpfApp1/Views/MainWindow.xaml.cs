using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using WpfApp1;
using Task = WpfApp1.Task;


namespace WpfApp
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<Task> taskList = new ObservableCollection<Task>();

        public MainWindow()
        {
            InitializeComponent();
            lvDataBinding.ItemsSource = taskList;
        }

        private void addTask_Click (object sender, RoutedEventArgs e)
        {
            var test = textBoxTask.Text;

            var newTask = new WpfApp1.Task() 
            { 
                Title = test, 
                Status = Status.NotDone,
                Date = DateTime.Now,

            };

            taskList.Add(newTask);
        }

        private void deleteTask (object sender, RoutedEventArgs e)
        {
            var selectedTask = lvDataBinding.SelectedItem as Task;

            if (selectedTask != null)
            {
                taskList.Remove(selectedTask);
            }

        }

        private void markTask(object sender, RoutedEventArgs e)
        {
            var selectedTask = lvDataBinding.SelectedItem as Task;
            

            if (selectedTask != null)
            {
                var foundTask = taskList.FirstOrDefault(x => x == selectedTask);

                if (foundTask != null)
                {
                    foundTask.Status = Status.Done;
                }               
            }

            lvDataBinding.Items.Refresh();
        }
        private void descriptionBox(object sender, RoutedEventArgs e)
        {
            popup.IsOpen = true;
            var selectedTask = lvDataBinding.SelectedItem as Task;
            if (selectedTask != null)
            {
                
            }

        }


        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            var selectedTask = lvDataBinding.SelectedItem as Task;
            popup.IsOpen = true;
        }
    }
}
