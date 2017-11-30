using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TimeHelper.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPageMaster : ContentPage
    {
        public ListView ListView;

        public MainPageMaster()
        {
            InitializeComponent();

            BindingContext = new DetailPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class DetailPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<ItemsPageItem> MenuItems { get; set; }

            public DetailPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<ItemsPageItem>(new[]
                {
                    new ItemsPageItem { Id = 0, Title = "Список задач" },
                    new ItemsPageItem { Id = 1, Title = "Список заметок" },
                });
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
}