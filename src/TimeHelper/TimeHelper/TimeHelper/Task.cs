using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace TimeHelper
{
    [Table("Tasks")]
    class Task
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public Int32 Id { get; set; }
        public String Name { get; }
        public DateTime DeadLineDate { get; set; }
        public DateTime CreationDate { get; set; }
        Int32 TaskPriority;
        public String FilePath { get; set; }
        public String Description { get; set; }
        public Boolean IsOverdue { get; set; }

        public Int32 Priority
        {
            get
            {
                return TaskPriority;
            }

            set
            {
                if (value < 1 || value > 5)
                    return;
                else
                    TaskPriority = value;
            }
        }
        public Task()
        {
        }

        public Task(String name, DateTime creationTime, DateTime deadlineTime)
        {
            this.Name = name;
            this.CreationDate = creationTime;
            this.DeadLineDate = deadlineTime;
        }
    }
}
