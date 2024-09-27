using System.Windows;
using System.Windows.Markup;
using WpfApp1;
using Task = WpfApp1.Task;


namespace WpfApp
{
    public partial class MainWindow : Window
    {
        private List<Task> taskList = new List<Task>();

        public MainWindow()
        {
            InitializeComponent();
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

        private void printTask (object sender, RoutedEventArgs e)
        {

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

       
    }
}
