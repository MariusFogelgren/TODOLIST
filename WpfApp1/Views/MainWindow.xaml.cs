using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
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
                Status = "not done",
                Date = DateTime.Now,

            };

            taskList.Add(newTask);
        }

        private void deleteTask (object sender, RoutedEventArgs e)
        {
            
        }

        private void markTask(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
        }

        private void lvDataBinding_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
