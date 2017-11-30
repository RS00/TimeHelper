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
    class MasterViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Model.MasterModel> MenuItems { get; set; }

        public MasterViewModel()
        {
            MenuItems = new ObservableCollection<Model.MasterModel>(new[]
            {
                    new Model.MasterModel { Id = 0, Title = "Список задач" },
                    new Model.MasterModel { Id = 1, Title = "Список заметок" },
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
