using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeHelper
{
    abstract class Builder
    {
        public abstract void BuildNameAndDate();
        public abstract void BuildPriority();
        public abstract void BuildAdditionalInfo();
        public abstract TimeHelper.Task GetTask();
    }
}
