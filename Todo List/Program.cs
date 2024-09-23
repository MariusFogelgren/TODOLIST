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
                        Console.WriteLine();
                        break;
                    case "4":
                        Console.WriteLine();
                        break;

                };
                Console.ReadLine();
            }
        }

        static void addTask()
        {
            Console.Clear();
            Console.Write("Enter your task: ");
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
            Console.Clear();
            Console.WriteLine("Task List:");
            var listofTasks = string.Join(",", _tasks);
            Console.WriteLine(listofTasks);
            Console.ReadLine();
            return listofTasks;
        }

         static  deleteTask()
        {

        }

        //static markTask()
        //{ 
        //}
    }
}
