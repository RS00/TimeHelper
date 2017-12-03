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
    public partial class CreateNotePage : ContentPage
    {
        public CreateNotePage()
        {
            InitializeComponent();
            BindingContext = new ItemsPageViewModel();
        }

        private void OK_Clicked(object sender, EventArgs e)
        {
            int size = Navigation.NavigationStack.Count;
            Page p = Navigation.NavigationStack.ElementAt(size - 2);
            ((NotesPageViewModel)p.BindingContext).AddNote(NoteName.Text, NoteDescription.Text);
            Navigation.PopAsync();
        }
    }
}