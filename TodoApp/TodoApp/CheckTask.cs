using System.Collections.Generic;
using System.IO;

namespace TodoApp
{
    class CheckTask
    {
        private string[] text;
        private string path;
        private string doneTask;

        public CheckTask()
        {
            path = @"./datastore.txt";
        }

        public CheckTask(string[] text, string path, string doneTask)
        {
            this.text = text;
            this.path = path;
            this.doneTask = doneTask;
        }

        public void Checker(string doneTask)
        {
            int done = int.Parse(doneTask);

            List<string> lines = new List<string>(File.ReadAllLines(path));

            for (int i = 0; i <= lines.Count; i++)
            {
                if (i == done - 1)
                {
                    string temp = lines[i];
                    lines[i] = "[X] " + temp;
                    File.WriteAllLines(path, lines);
                }
                else
                {
                    string tempSecond = lines[i];
                    lines[i] = "[ ] " + tempSecond;
                    File.WriteAllLines(path, lines);
                }  
            }
        } 
    }
}