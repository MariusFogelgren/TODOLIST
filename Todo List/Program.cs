using System.Runtime.InteropServices;

namespace Todo_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a todo list");
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
                    Console.WriteLine();
                    break;
                case "2":
                    Console.WriteLine();
                    break;
                case "3":
                    Console.WriteLine();
                    break;
                case "4":
                    Console.WriteLine();
                    break;

            };

            


        }
        class TodoListCase 
        {
            
        }
    }
}
