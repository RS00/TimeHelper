using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeHelper
{
    class BulderWithPriority : Builder
    {
        private TimeHelper.Task Task;
        public override void BuildAdditionalInfo()
        {
           
        }

        public override void BuildNameAndDate()
        {
            throw new NotImplementedException();
        }

        public override void BuildPriority()
        {
            throw new NotImplementedException();
        }

        public override Task GetTask()
        {
            throw new NotImplementedException();
        }
    }
}
