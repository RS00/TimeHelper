using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace TimeHelper.ViewModels
{
    class NotesPageViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Model.Model> Items { get; set; }

        public NotesPageViewModel()
        {
            Items = new ObservableCollection<Model.Model>();
            List<Note> noteList = Model.Model.NoteList.ListOfNotes;
            for (int i = 0; i < noteList.Count; i++)
            {
                Note item = noteList[i];
                Items.Add(new Model.Model() { Name = item.Name, Description = item.Description, CreateDate = item.CreationTime});
            }
        }

        public void AddNote(String name, String description)
        {
            Model.Model.NoteList.AddNote(name, description);
            Note last = Model.Model.NoteList.ListOfNotes.Last();
            Items.Add(new Model.Model() { Name = last.Name, Description = last.Description, CreateDate = last.CreationTime });
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
