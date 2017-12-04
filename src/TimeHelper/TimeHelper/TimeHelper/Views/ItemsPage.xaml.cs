using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using TimeHelper.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TimeHelper.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemsPage : ContentPage
    {
        private const int SortByName = 0;
        private const int SortByPriority = 1;
        private const int SortByCreationDate = 2;
        private const int SortByDeadline = 3;
        private Int32 SortMode = 0;
        public ItemsPage()
        {
            InitializeComponent();
            BindingContext = new ItemsPageViewModel();
            ItemsList.ItemSelected += ItemsPage_ItemSelected;
        }

        private void ItemsPage_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Model.Model;
            if (item == null)
                return;
            ItemDetail page = new ItemDetail(item.Name, item.DeadlineDate, item.CreateDate, item.Description);
            page.Title = "Task Info";
            Navigation.PushAsync(page);
            ItemsList.SelectedItem = null;
        }

        private void AddTaskButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreateTaskPage());
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Sorter sorter = new Sorter();
            List<Task> taskList;
            switch (SortMode)
            {
                case SortByName:
                    {
                        taskList = sorter.SortByName(ref Model.Model.TaskList);
                        SortMode++;
                        break;
                    }
                case SortByPriority:
                    {
                        taskList = sorter.SortByPriority(ref Model.Model.TaskList);
                        SortMode++;
                        break;
                    }
                case SortByCreationDate:
                    {
                        taskList = sorter.SortCreationDate(ref Model.Model.TaskList);
                        SortMode++;
                        break;
                    }
                case SortByDeadline:
                    {
                        taskList = sorter.SortByDeadline(ref Model.Model.TaskList);
                        SortMode = 0;
                        break;
                    }
                default:
                    {
                        taskList = new List<Task>();
                        break;
                    }
            }
            ObservableCollection<Model.Model> newItems = new ObservableCollection<Model.Model>();
            for (int i = 0; i < taskList.Count; i++)
            {
                Task t = taskList[i];
                newItems.Add(new Model.Model() { Name = t.Name, DeadlineDate = t.DeadLineDate, Priority = t.Priority, CreateDate = t.CreationDate.Date, Description = t.Description });
            }
            ((ItemsPageViewModel)BindingContext).Items = newItems;
        }
    }
}