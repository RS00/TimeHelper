using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeHelper
{
    class BuilderWithoutPriority : Builder
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

        public override void BuildPriority(int priority)
        {
            DateTime today = DateTime.Now;
            DateTime deadline = Task.DeadLineDate;
            TimeSpan difference = deadline - today;
            Task.Priority = difference.Days >= 5 ? priority : difference.Days <= 0 ? 5 : difference.Days;
            return;
        }

        public override Task GetTask()
        {
            return this.Task;
        }
    }
}
