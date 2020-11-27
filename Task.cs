using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPrototype
{
    public class Task : ICloneable<Task>
    {
        public string Content { get; set; }

        public Task(string content)
        {
            Content = content;
        }

        public Task Clone()
        {
            return new Task(Content);
        }
    }
}
