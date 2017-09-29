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
            RemoveTask removeTask = new RemoveTask();
            CheckTask checkTask = new CheckTask();

            string[] commands = { "-l", "-a", "-r", "-c" };
            try
            {
                if (args.Length == 0)
                {
                    Welcome();
                    return;
                }
                if (args[0] == "-c")
                {
                    //taskList.FillFile();
                    checkTask.Checker(args[1]);
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
                if (args[0] == "-r")
                {
                    removeTask.Remover(args[1]);
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Unsupported argument");
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