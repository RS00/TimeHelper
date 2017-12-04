using System;

namespace TimeHelper
{
    class Note
    {
        public String Name { get; }
        public String Description { get; }
        public DateTime CreationTime { get; }

        public Note(String name, String description)
        {
            Name = name;
            Description = description;
            CreationTime = DateTime.Now;
        }
    }
}
