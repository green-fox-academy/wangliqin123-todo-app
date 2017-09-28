using System;

namespace TodoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Welcome();

            TaskList taskList = new TaskList();

            //if (args == null)
            //{
            //    return;
            //}
            if (args[0] == "-l")
            {
                taskList.ReadFile();
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
