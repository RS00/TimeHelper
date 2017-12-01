using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeHelper.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TimeHelper.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemsPage : ContentPage
    {
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
            var page = (Page)Activator.CreateInstance(item.TargetType);

            page.Title = item.Name;
            Navigation.PushAsync(page);

            ItemsList.SelectedItem = null;
        }

        private void AddTaskButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreateTaskPage());
        }
    }
}