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
        private ObservableCollection<Model.Model> ModelItems;
        public ObservableCollection<Model.Model> Items
        {
            get
            {
                return ModelItems;
            }
            set
            {
                ModelItems = value;
                OnPropertyChanged("Items");
            }
        }
        public ItemsPageViewModel()
        {
            Items = new ObservableCollection<Model.Model>();
            List<TimeHelper.Task> taskList = Model.Model.TaskList.ListOfTasks;
            for (int i = 0; i < taskList.Count; i++)
            {
                Task t = taskList[i];
                Items.Add(new Model.Model() { Name = t.Name, DeadlineDate = t.DeadLineDate, Priority = t.Priority, CreateDate = t.CreationDate.Date, Description = t.Description});
            }
            
        }

        public void AddTask(String name, Int32 priority, DateTime deadline, String description)
        {
            if (priority == -1 )
            {
                Model.Model.TaskList.AddTask(name, deadline, description);
            }
            else
            {
                Model.Model.TaskList.AddTask(name, deadline, description, priority);
            }
            Task last = Model.Model.TaskList.ListOfTasks.Last();
            Items.Add(new Model.Model() { Name = last.Name, DeadlineDate = last.DeadLineDate, Priority = last.Priority, CreateDate = last.CreationDate, Description = last.Description});
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
