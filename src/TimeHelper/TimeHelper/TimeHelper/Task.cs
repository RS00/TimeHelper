using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeHelper
{
    class Task
    {
        String Name { get; set; }
        DateTime DeadLineDate { get; set; }
        DateTime CreationDate;
        Int32 Priorty;
        DateTime Time;
        String FilePath;
        String Description;
        Boolean IsOverdue;

        Task(String name, DateTime creationTime, DateTime deadlineTime)
        {
            this.Name = name;
            this.CreationDate = creationTime;
            this.DeadLineDate = deadlineTime;
        }
    }
}
