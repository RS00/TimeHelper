using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeHelper
{
    class Note
    {
        public String Name { get; }
        public String Description { get; }
        public DateTime CreationTime { get; }

        public Note(String name, String description)
        {
            this.Name = Name;
            this.Description = description;
            this.CreationTime = DateTime.Now;
        }
    }
}
