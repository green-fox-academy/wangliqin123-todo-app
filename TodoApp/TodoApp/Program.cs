using System;

namespace TodoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Welcome();

            TaskList taskList = new TaskList();
            NewTask newTask = new NewTask();

            if (args[0] == "-l")
            {
                taskList.ReadFile();
            }
            if (args[0] == "-a")
            {
                newTask.AddNewTask(args[1]);
            }
            
            string[] commands = { "-l", "-a", "-r", "-c" };

            Console.ReadLine();
        }
        public static void Welcome()
        {
            Console.WriteLine("Command Line Todo application\n=============================\n\nCommand line arguments:\n -l   Lists all the tasks\n -a   Adds a new task\n -r   Removes an task\n -c   Completes an task\n");
        } 
    }
}