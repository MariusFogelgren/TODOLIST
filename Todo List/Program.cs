namespace Todo_List
{
    internal class Program
    {
        private static string[] _tasks = [];

        static void Main(string[] args)
        {
            int number = 1;



            Console.WriteLine("This is a todo list");
            while (true)
            {
                Console.Clear();
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("This is a todo list");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nHere are your choices");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(number + ". Add new tasks");
                Console.WriteLine(number + 1 + ". Print all tasks");
                Console.WriteLine(number + 2 + ". delete tasks");
                Console.WriteLine(number + 3 + ". Mark a task done");
                Console.Write("\nEnter your choice: ");
                Console.ResetColor();
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
                Console.WriteLine("Du skal skrive noget | You need to write somehing");
            }
        }

        public static string printTask()
        {
            int number = +1;
            Console.Clear();
            Console.WriteLine("Task List:");
            var listofTasks = string.Join(",", _tasks);
            Console.WriteLine(number + "." + listofTasks + "| not done");
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
            // Contains tjekker indholdet
            if (_tasks.Contains(taskToRemove))
            {
                //Denne vil beholde alle andre task undtagen den brugeren vik beholde. ToArray laver imputtet om til en array liste
                // = _tasks gør så alt hvad brugeren gør bliver gemt inde i varen
                _tasks = _tasks.Where(task => task != taskToRemove).ToArray();
                Console.WriteLine("You have removed a task");
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
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
                _tasks = new string[] { task + " | done" };
            }
            else
            {
                Console.WriteLine("Du skal skrive noget | You need to write something");
            }
            return "";
        }
    }
}
