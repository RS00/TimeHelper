using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeHelper
{
    abstract class Builder
    {
        public abstract void BuildNameAndDate(String name, DateTime creationTime, DateTime deadlineTime);
        public abstract void BuildPriority(Int32 priority);
        public abstract void BuildAdditionalInfo(String description);
        public abstract TimeHelper.Task GetTask();
    }
}
