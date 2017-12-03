using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeHelper.Views;
using Xamarin.Forms;

namespace TimeHelper.Model
{
    //Main model, contain ItemList and NoteList
    class Model 
    {
        public String Name { get; set; }
        public DateTime DeadlineDate { get; set; }
        public DateTime CreateDate { get; set; }
        public Int32 Priority { get; set; }
        public static TimeHelper.TaskList TaskList = new TimeHelper.TaskList();
        public static TimeHelper.NoteList NoteList = new TimeHelper.NoteList();
        public Type TargetType { get; set; }
        public String Description { get; set; }

        public Color Color1
        {
            get
            {
                return Color.DarkRed;
            }
        }

        public Color Color2
        {
            get
            {
                return Priority < 2 ? Color.White : Color.DarkRed;
            }
        }

        public Color Color3
        {
            get
            {
                return Priority < 3 ? Color.White : Color.DarkRed;
            }
        }

        public Color Color4
        {
            get
            {
                return Priority < 4 ? Color.White : Color.DarkRed;
            }
        }

        public Color Color5
        {
            get
            {
                return Priority < 5 ? Color.White : Color.DarkRed;
            }
        }
        public Model()
        {
        }

    }
}