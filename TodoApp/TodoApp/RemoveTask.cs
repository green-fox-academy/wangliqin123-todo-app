using System.Collections.Generic;
using System.IO;

namespace TodoApp
{
    class RemoveTask
    {   
        private string path;
        private string line;

        public RemoveTask()
        {
            path = @"./datastore.txt";
        }

        public RemoveTask(string path, string line)
        {      
            this.path = path;
            this.line = line;
        }

        public void Remover(string line)
        {
            List<string> lines = new List<string>(File.ReadAllLines(path));
            lines.RemoveAt(int.Parse(line) - 1);
            File.WriteAllLines(path, lines);   
        }
    }
}