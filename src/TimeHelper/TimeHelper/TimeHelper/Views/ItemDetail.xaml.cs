using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TimeHelper.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetail : ContentPage
    {
        String Name;
        String Description;
        DateTime CreationDate;
        DateTime DeadlineDate;
        public ItemDetail(String name, DateTime deadline, DateTime created, String desc)
        {
            InitializeComponent();
            Name = name;
            NameLabel.Text = Name;
            DeadlineDate = deadline;
            DeadlineLabel.Text = DeadlineDate.ToString();
            CreationDate = created;
            CreatedLabel.Text = CreationDate.ToString();
            Description = desc;
            if (Description == null)
                DescriptionInfoLabel.IsVisible = false;
            else
                DescriptionLabel.Text = Description;
        }
    }
}