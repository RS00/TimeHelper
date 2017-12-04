using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TimeHelper.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NoteDetail : ContentPage
    {
        String Name;
        String Description;
        DateTime CreationDate;

        public NoteDetail(String name, DateTime created, String desc)
        {
            InitializeComponent();
            Name = name;
            NameLabel.Text = Name;
            CreationDate = created;
            CreateLabel.Text = CreationDate.ToString();
            Description = desc;
            DescriptionLabel.Text = Description;
        }
    }
}