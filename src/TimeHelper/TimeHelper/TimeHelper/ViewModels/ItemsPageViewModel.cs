using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TimeHelper.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TimeHelper.Views;

namespace TimeHelper.ViewModels
{
    class ItemsPageViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Model.Model> Items { get; set; }

      
        public ItemsPageViewModel()
        {
            Items = new ObservableCollection<Model.Model>();
            List<TimeHelper.Task> taskList = Model.Model.TaskList.ListOfTasks;
            for (int i = 0; i < taskList.Count; i++)
            {
                Task t = taskList[i];
                Items.Add(new Model.Model { Name = t.Name, Date = t.DeadLineDate.ToString(), Priority = t.Priority });
            }
        }

        public void AddTask(String name, Int32 priority, DateTime deadline, String description)
        {
            Model.Model.TaskList.AddTask(name, deadline, description, priority);
            Items.Add(new Model.Model { Name = name, Date = deadline.ToString(), Priority = priority});
        }

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
