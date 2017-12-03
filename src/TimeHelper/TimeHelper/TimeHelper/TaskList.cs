using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TimeHelper
{
    class TaskList
    {
        public List<TimeHelper.Task> ListOfTasks { get; set;  }
        Builder builder;
        public TaskList()
        {
            ListOfTasks = new List<TimeHelper.Task>();
        }


        public void AddTask(String name, DateTime deadline, String description)
        {
            builder = new BuilderWithoutPriority();
            builder.BuildNameAndDate(name, DateTime.Now, deadline);
            builder.BuildPriority(1);
            builder.BuildAdditionalInfo(description);
            TimeHelper.Task task = builder.GetTask();
            ListOfTasks.Add(task);
        }

        public void AddTask(String name, DateTime deadline, String description, Int32 priority)
        {
            builder = new BuilderWithPriority();
            builder.BuildNameAndDate(name, DateTime.Now, deadline);
            builder.BuildPriority(priority);
            builder.BuildAdditionalInfo(description);
            TimeHelper.Task task = builder.GetTask();
            ListOfTasks.Add(task);
        }
    }
}
