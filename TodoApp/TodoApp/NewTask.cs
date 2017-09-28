using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TodoApp
{
    class NewTask
    {
        private string[] text;
        private string path;

        public NewTask()
        {
            path = @"./datastore.txt";
        }

        public NewTask(string[] text, string path)
        {
            this.text = text;
            this.path = path;
        }

        public void AddNewTask()
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("Feed the monkey");          
            }
        }
    }
}