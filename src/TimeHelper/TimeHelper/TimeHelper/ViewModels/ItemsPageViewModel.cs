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
           Items = new ObservableCollection<Model.Model>(new[]
            {
                    new Model.Model{ Name = "123" },
                    new Model.Model {Name = "55536mj "},
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
