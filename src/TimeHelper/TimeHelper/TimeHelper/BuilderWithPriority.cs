using System;

namespace TimeHelper
{
    class BuilderWithPriority : Builder
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

        public override void BuildPriority(Int32 priority)
        {
            Task.Priority = priority;
        }

        public override Task GetTask()
        {
            return Task;
        }
    }
}
