using System.Linq;
using System.Runtime.InteropServices;

namespace Todo_List
{
    internal class Program
    {
        private static string[] _tasks = [];

        static void Main(string[] args)
        {
            Console.WriteLine("This is a todo list");
            while (true)
            {
                Console.ResetColor();
                Console.WriteLine("\nHere are your choices");
                Console.WriteLine("1. Add new tasks");
                Console.WriteLine("2. Print all tasks");
                Console.WriteLine("3. delete tasks");
                Console.WriteLine("4. Mark a task done");
                Console.Write("\nEnter your choice: ");
                var todoListInput = Console.ReadLine();

                switch (todoListInput)
                {
                    case "1":
                        addTask();
                        break;
                    case "2":
                        printTask();
                        break;
                    case "3":
                        deleteTask();
                        break;
                    case "4":
                        markTask();
                        break;


                };
                Console.ReadLine();
            }
        }
        static void addTask()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Enter your task: ");
            Console.ResetColor();
            var task = Console.ReadLine();

            if (!string.IsNullOrEmpty(task))
            {
                _tasks = [task];
            }
            else
            {
                Console.WriteLine("Du skal skrive noget");
            }
        }
        public static string printTask()
        {
            int number = +1;
            Console.Clear();
            Console.WriteLine("Task List:");
            var listofTasks = string.Join(",", _tasks);
            Console.WriteLine(number + "." + listofTasks);
            Console.ReadLine();
            return listofTasks;
        }
        public static string deleteTask()
        {
            var listofTasks = Console.ReadLine();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("What task do you need to remove: ");
            Console.ResetColor();
            var taskToRemove = Console.ReadLine();

            if (_tasks.Contains(taskToRemove))
            {
                _tasks = _tasks.Where(task => task != taskToRemove).ToArray();
                Console.WriteLine("You have removed a task");
            }


            if (string.IsNullOrEmpty(listofTasks))
            { Console.WriteLine("You have removed an task"); }

            else
            {
                Console.WriteLine("You did not remove a task from the list");
            }

            Console.ReadLine();
            return "";
        }
        static string markTask()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Enter your task to mark done: ");
            Console.ResetColor();
            var task = Console.ReadLine();

            if (!string.IsNullOrEmpty(task))
            {
                var taskToRemove = Console.ReadLine();
                _tasks = _tasks.Where(task => task != taskToRemove).ToArray();
                _tasks = new string[] { task + " is done!" };
                Console.BackgroundColor = ConsoleColor.White;

            }
            else
            {
                Console.WriteLine("Du skal skrive noget");
            }

            return "";

        }
    }
}
