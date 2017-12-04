using System;
using System.Collections.Generic;

namespace TimeHelper
{
    class TaskList
    {
        public List<Task> ListOfTasks { get; set;  }
        Builder builder;
        public TaskList()
        {
            ListOfTasks = new List<Task>();
        }

        public void AddTask(String name, DateTime deadline, String description, Int32 priority = 1)
        {
            builder = new BuilderWithPriority();
            builder.BuildNameAndDate(name, DateTime.Now, deadline);
            builder.BuildPriority(priority);
            builder.BuildAdditionalInfo(description);
            Task task = builder.GetTask();
            ListOfTasks.Add(task);
        }
    }
}
