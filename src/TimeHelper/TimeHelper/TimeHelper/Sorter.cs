using System.Collections.Generic;
using System.Linq;

namespace TimeHelper
{
    class Sorter
    {
        public List<Task> SortByName(ref TaskList list)
        {
            list.ListOfTasks = list.ListOfTasks.OrderBy(i => i.Name).ToList();
            return list.ListOfTasks;
        }

        public List<Task> SortByDeadline(ref TaskList list)
        {
            list.ListOfTasks = list.ListOfTasks.OrderBy(i => i.DeadLineDate).ToList();
            return list.ListOfTasks;
        }

        public List<Task> SortCreationDate(ref TaskList list)
        {
            list.ListOfTasks = list.ListOfTasks.OrderBy(i => i.CreationDate).ToList();
            return list.ListOfTasks;
        }

        public List<Task> SortByPriority(ref TaskList list)
        {
            list.ListOfTasks = list.ListOfTasks.OrderBy(i => i.Priority).ToList();
            return list.ListOfTasks;
        }
    }
}
