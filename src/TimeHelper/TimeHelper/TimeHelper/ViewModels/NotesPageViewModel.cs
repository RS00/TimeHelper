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
    class NotesPageViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Model.Model> Items { get; set; }


        public NotesPageViewModel()
        {
            Items = new ObservableCollection<Model.Model>();
            List<TimeHelper.Note> noteList = Model.Model.NoteList.ListOfNotes;
            for (int i = 0; i < noteList.Count; i++)
            {
                Note item = noteList[i];
                Items.Add(new Model.Model() { Name = item.Name, Description = item.Description, CreateDate = item.CreationTime});
            }
        }

        public void AddNote(String name, String description)
        {
            Model.Model.NoteList.AddNote(name, description);
            Model.Model model = new Model.Model();
            model.Name = name;
            model.CreateDate = DateTime.Now;
            model.Description = description;
            Items.Add(model);
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
