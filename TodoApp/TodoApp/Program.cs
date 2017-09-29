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

            string[] commands = { "-l", "-a", "-r", "-c" };

            if (args.Length == 0)
            {
                Welcome();
                return;
            }

            if (args[0] == "-l")
            {
                taskList.ReadFile();
            }

            if (args[0] == "-a")
            {
                try
                {
                    newTask.AddNewTask(args[1]);
                }
                catch (Exception)
                {
                    Console.WriteLine("Unable to add: no task provided");
                }   
            }
        }

        public static void Welcome()
        {
            Console.WriteLine("Command Line Todo application\n" +
                              "=============================\n\n " +
                              "Command line arguments:\n -l " +
                                " Lists all the tasks\n -a  " +
                                "Adds a new task\n -r  " +
                                "Removes an task\n -c  " +
                                "Completes an task\n");
        } 
    }
}