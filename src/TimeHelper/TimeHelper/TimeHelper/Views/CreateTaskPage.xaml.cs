using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TimeHelper.ViewModels;
namespace TimeHelper.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateTaskPage : ContentPage
    {
        public CreateTaskPage()
        {
            InitializeComponent();
            BindingContext = new ItemsPageViewModel();
        }

        private void OK_Clicked(object sender, EventArgs e)
        {
            if (TaskName.Text == null)
            {
                TaskName.BackgroundColor = Color.Red;
                return;
            }
            int size = Navigation.NavigationStack.Count;
            Page p = Navigation.NavigationStack.ElementAt(size - 2);
            if (PriorityAuto.BackgroundColor == Color.DarkRed)
            {
                ((ItemsPageViewModel)p.BindingContext).AddTask(TaskName.Text, -1, TaskDeadline.Date, TaskDescription.Text);
                Navigation.PopAsync();
                return;
            }
            int priority = 1;
            if (PriorityButton5.BackgroundColor == Color.DarkRed)
                priority = 5;
            else if (PriorityButton4.BackgroundColor == Color.DarkRed)
                priority = 4;
            else if (PriorityButton3.BackgroundColor == Color.DarkRed)
                priority = 3;
            else if (PriorityButton2.BackgroundColor == Color.DarkRed)
                priority = 2;

            ((ItemsPageViewModel)p.BindingContext).AddTask(TaskName.Text, priority, TaskDeadline.Date, TaskDescription.Text);
            Navigation.PopAsync();
        }

        private void PriorityButton_Clicked(object sender, EventArgs e)
        {
            Button from = (Button)sender;
            if (from == PriorityAuto)
            {
                PriorityAuto.BackgroundColor = Color.DarkRed;
                PriorityButton2.BackgroundColor = Color.DarkGray;
                PriorityButton3.BackgroundColor = Color.DarkGray;
                PriorityButton4.BackgroundColor = Color.DarkGray;
                PriorityButton5.BackgroundColor = Color.DarkGray;
                return;
            }
            PriorityButton2.BackgroundColor = Color.DarkRed;
            PriorityButton3.BackgroundColor = Color.DarkRed;
            PriorityButton4.BackgroundColor = Color.DarkRed;
            PriorityButton5.BackgroundColor = Color.DarkRed;
            if (PriorityButton4 == from)
            {
                PriorityButton5.BackgroundColor = Color.DarkGray;
            }
            else if (PriorityButton3 == from)
            {
                PriorityButton4.BackgroundColor = Color.DarkGray;
                PriorityButton5.BackgroundColor = Color.DarkGray;
            }
            else if (PriorityButton2 == from)
            {
                PriorityButton3.BackgroundColor = Color.DarkGray;
                PriorityButton4.BackgroundColor = Color.DarkGray;
                PriorityButton5.BackgroundColor = Color.DarkGray;
            }
            else if (PriorityButton1 == from)
            {
                PriorityButton2.BackgroundColor = Color.DarkGray;
                PriorityButton3.BackgroundColor = Color.DarkGray;
                PriorityButton4.BackgroundColor = Color.DarkGray;
                PriorityButton5.BackgroundColor = Color.DarkGray;
            }
            PriorityAuto.BackgroundColor = Color.DarkGray;
        }
    }
}