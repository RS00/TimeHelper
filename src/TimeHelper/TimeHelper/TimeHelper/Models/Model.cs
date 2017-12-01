using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeHelper.Views;

namespace TimeHelper.Model
{
    //Main model, contain ItemList and NoteList
    class Model
    {
        public String Name { get; set; }
        public String Date { get; set; }
        public static TimeHelper.TaskList TaskList = new TimeHelper.TaskList();
        public Type TargetType { get; set; }

        public Model()
        {
            TargetType = typeof(ItemDetail);
        }


    }
}