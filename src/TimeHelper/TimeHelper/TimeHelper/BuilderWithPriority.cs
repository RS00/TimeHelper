using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeHelper
{
    class BuilderWithPriority : Builder
    {
        private TimeHelper.Task Task;
        public override void BuildAdditionalInfo(string description)
        {
            Task.Description = description;
        }

        public override void BuildNameAndDate(String name, DateTime creationTime, DateTime deadlineTime)
        {
            this.Task = new TimeHelper.Task(name, creationTime, deadlineTime);
        }

        public override void BuildPriority(Int32 priority)
        {
            Task.Priority = priority;
        }

        public override Task GetTask()
        {
            return this.Task;
        }
    }
}
