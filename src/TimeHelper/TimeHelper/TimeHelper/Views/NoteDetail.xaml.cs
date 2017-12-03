using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        DateTime DeadlineDate;

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