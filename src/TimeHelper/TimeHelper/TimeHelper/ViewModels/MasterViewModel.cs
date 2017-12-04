using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
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
                    new Model.MasterModel(typeof(ItemsPage)) { Id = 0, Title = "Task list" },
                    new Model.MasterModel(typeof(NotesPage)) { Id = 1, Title = "Note list" },
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
