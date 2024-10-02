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

        //private void addTask_Click(object sender, RoutedEventArgs e)
        //{
            
        //}

        private void deleteTask(object sender, RoutedEventArgs e)
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
        private void DescriptionBox(object sender, RoutedEventArgs e)
        {
            //popup.IsOpen = true;
            //var selectedTask = lvDataBinding.SelectedItem as Task;
            //if (selectedTask != null)
            //{

            //}

        }


        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            var descriptionText = descriptionBox.Text;
            var selectedTask = lvDataBinding.SelectedItem as Task;

            if (selectedTask != null)
            {
                selectedTask.Description = descriptionText;

            }
        }


        private void saveTask_Click(object sender, RoutedEventArgs e)
        {
            var selectedTask = lvDataBinding.SelectedItem as Task;

            var title = textBoxTask.Text;

            var newTask = new WpfApp1.Task()
            {
                Title = title,
                Status = Status.NotDone,
                Date = DateTime.Now,

            };

            taskList.Add(newTask);
            textBoxTask.Clear();

            if (selectedTask != null)
            {
                if (!string.IsNullOrEmpty(descriptionBox.Text))
                {
                    var foundTask = taskList.FirstOrDefault(x => x == selectedTask);

                    if (foundTask != null)
                    {
                        foundTask.Description = descriptionBox.Text;
                    } 
                    else 
                    {
                        taskList.Add(new Task{});
                    }
                }

                // 1. Tjek at felter er udfyldt
                // 2. TJek efter titel
                // 3. Find evt eksisterende objekt i liste
                // 4. Hvis ikke, lav ny
                // 5. Muliggør kun udfyldelse af titel, eller titel/beskrivelse
                // 99. Når man har klikket på eksisterende task, udfyld felter med værdier, muliggør at disse kan rettes og gemmes.
            }

        }

        private static void descriptionBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            var selectedTask = lvDataBinding.SelectedItem as Task;
        }
    }    
} 
