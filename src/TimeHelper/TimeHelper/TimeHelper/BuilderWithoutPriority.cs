using System;

namespace TimeHelper
{
    class BuilderWithoutPriority : Builder
    {
        private Task Task;
        public override void BuildAdditionalInfo(string description)
        {
            Task.Description = description;
        }

        public override void BuildNameAndDate(String name, DateTime creationTime, DateTime deadlineTime)
        {
            Task = new Task(name, creationTime, deadlineTime);
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
            return Task;
        }
    }
}
