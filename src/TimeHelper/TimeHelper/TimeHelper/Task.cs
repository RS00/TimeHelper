using System;
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
            Name = name;
            CreationDate = creationTime;
            DeadLineDate = deadlineTime;
        }
    }
}
