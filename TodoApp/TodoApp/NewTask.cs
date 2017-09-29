using System.IO;

namespace TodoApp
{
    class NewTask
    {
        private string[] text;
        private string path;
        private string newTask;

        public NewTask()
        {
            path = @"./datastore.txt";
        }

        public NewTask(string[] text, string path, string newTask)
        {
            this.text = text;
            this.path = path;
            this.newTask = newTask;
        }

        public void AddNewTask(string newTask)
        {
           
             using (StreamWriter writer = new StreamWriter(path))
                 {
                        writer.WriteLine(newTask);
                 }
        }
    }
}