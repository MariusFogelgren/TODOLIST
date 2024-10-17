using System;
using System.Collections.ObjectModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using TodolistWPF;

using System.Configuration;
using Task = WpfApp1.Task;
using System.Threading.Tasks;
using WpfApp1;


namespace TodolistWPF
{

    public partial class MainWindow : Window
    {
        private ObservableCollection<Task> taskList = new ObservableCollection<Task>();


        public MainWindow()
        {
            InitializeComponent();

            // 1. find tasklist.txt
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var filePath = Path.Combine(docPath, "tasklist.txt");

            // 2. læs indhold linie for linie
            var openFile = File.OpenRead(filePath);
            //var linier =  

            // 3. for hver linie, separer med komma, og lav nyt Task objekt med værdier (taskListString.Split(',') ==== giver dig et array, hvor hvert item i array kan puttes i Task objektet) LinierIfilen.Split(',')
            //foreach (var linie in linier)
            //{
            //var linieX
            //}
            // 4. indsæt disse i din taskList på linie 24








            lvDataBinding.ItemsSource = taskList;
        }

        private void SaveDataToFile()
        {
            //using (StreamWriter writer = new StreamWriter(filePath))
            //{


            //    //foreach (var task in taskList)
            //    //{
            //    //    writer.WriteLine($"Title: {task.Title}");
            //    //    writer.WriteLine($"Status: {task.Status}");
            //    //    writer.WriteLine($"Date: {task.Date}");
            //    //    writer.WriteLine($"Description: {task.Description}");

            //    //}
            //}

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var filePath = Path.Combine(docPath, "tasklist.txt");

            using (StreamWriter outputFile = new StreamWriter(filePath, true))
            {
                foreach (var task in taskList)
                {
                    outputFile.WriteLine($"{task.Title},{task.Description},{task.Status},{task.Date}");
                    //outputFile.WriteLine($"Status: {task.Status}");
                    //outputFile.WriteLine($"Date: {task.Date}");
                    //outputFile.WriteLine($"Description: {task.Description}");
                }
            }
            SavedBox.Text = "Data saved to " + docPath;
        }

        private void SaveToFileBtn(object sender, RoutedEventArgs e)
        {
            //string filepath = "tasklist.txt";

            //SaveDataToFile(filepath);
            SaveDataToFile();

        }

        private void saveTask_Click(object sender, RoutedEventArgs e)
        {
            var selectedTask = lvDataBinding.SelectedItem as Task;

            if (selectedTask != null)
            {
                var foundTask = taskList.FirstOrDefault(x => x == selectedTask);

                if (foundTask != null)
                {
                    foundTask.Title = textBoxTask.Text;
                    foundTask.Description = descriptionBox.Text;
                    lvDataBinding.Items.Refresh();
                }
                else
                {

                }
            }
            else
            {
                var title = textBoxTask.Text;
                var Description = descriptionBox.Text;
                var newTask = new Task()
                {
                    Title = title,
                    Status = Status.NotDone,
                    Date = DateTime.Now,
                    Description = Description,

                };
                taskList.Add(newTask);
                textBoxTask.Clear();
                descriptionBox.Clear();
            }
        }

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

        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var selectedTask = lvDataBinding.SelectedItem as Task;
            var editTask = new Task();

        }

        private void descriptionBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void lvDataBinding_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedTask = lvDataBinding.SelectedItem as Task;
            var newTask = new Task();

            if (selectedTask != null)
            {
                textBoxTask.Text = selectedTask.Title;
                descriptionBox.Text = selectedTask.Description;

            }


            // 1. udfyld title textbox med ovenstående title: X
            // 2. udfyld description textbox med ovenstående description: X
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}