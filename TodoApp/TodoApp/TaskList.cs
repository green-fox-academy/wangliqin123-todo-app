using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TodoApp
{
    class TaskList
    {
        private string[] text;
        private string path;

        public TaskList()
        {
            path = @"./datastore.txt";  
        }

        public TaskList(string[] text, string path)
        {
            this.text = text;
            this.path = path;
        }
   
        public void FillFile()
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("Walk the dog");
                writer.WriteLine("Buy milk");
                writer.WriteLine("Do homework");
            }
        }

        public void ReadFile()
        {
            text = File.ReadAllLines(path);

            if (text.Length == 0)
            {
                Console.WriteLine("No todos for today! :)");
            }
            else
            {
                for (int i = 1; i <= text.Length; i++)
                {
                    Console.WriteLine("{0} - {1}", i, text[i - 1]);
                }
            }        
        }  
    }
}