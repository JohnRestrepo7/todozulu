using System;

namespace todozulu.Common.Models
{
    public class Todo
    {
        public DateTime createdTime { get; set; }
        public string TaskDescription { get; set; }

        public bool IsCompleted { get; set; }
    }
}
