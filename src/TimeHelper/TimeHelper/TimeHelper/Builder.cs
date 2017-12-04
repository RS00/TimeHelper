using System;

namespace TimeHelper
{
    abstract class Builder
    {
        public abstract void BuildNameAndDate(String name, DateTime creationTime, DateTime deadlineTime);
        public abstract void BuildPriority(Int32 priority);
        public abstract void BuildAdditionalInfo(String description);
        public abstract Task GetTask();
    }
}
