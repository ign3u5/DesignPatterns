using System;
using System.Collections.Generic;
using System.Linq;

namespace SingletonPrototype
{
    public class BacklogItem : ICloneable<BacklogItem>
    {
        private readonly int _identifier;
        private readonly List<Task> _tasks;

        public BacklogItem(int identifier)
        {
            _identifier = identifier;
            _tasks = new List<Task>();
        }

        public void AddTask(string taskContent)
        {
            _tasks.Add(new Task(taskContent));
        }

        public Task FirstTask()
        {
            return _tasks.First();
        }

        private void AddTask(Task taskContent)
        {
            _tasks.Add(taskContent);
        }

        public override string ToString()
        {
            var returnValue = _identifier.ToString();

            _tasks.ForEach(t => returnValue += $"\nTask: {t.Content}.");

            return returnValue;
        }

        public BacklogItem Clone()
        {
            var newBacklogItem = new BacklogItem(_identifier);

            _tasks.ForEach(t => newBacklogItem.AddTask(t.Clone()));
           
            return newBacklogItem;
        }
    }
}
