using System;
using TimeHelper.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TimeHelper.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotesPage : ContentPage
    {
        public NotesPage()
        {
            InitializeComponent();
            BindingContext = new NotesPageViewModel();
            NotesList.ItemSelected += NotesPage_ItemSelected;
        }

        private void NotesPage_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Model.Model;
            if (item == null)
                return;
            NoteDetail page = new NoteDetail(item.Name, item.CreateDate, item.Description);
            page.Title = "Note Info";
            Navigation.PushAsync(page);
            NotesList.SelectedItem = null;
        }

        private void AddNoteButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreateNotePage());
        }
    }
}