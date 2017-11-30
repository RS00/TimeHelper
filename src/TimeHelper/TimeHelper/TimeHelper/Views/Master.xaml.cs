using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TimeHelper.Model;
using TimeHelper.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TimeHelper.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : ContentPage
    {
        public ListView ListView;

        public Master()
        {
            InitializeComponent();

            BindingContext = new MasterViewModel();
            ListView = MenuItemsListView;
        }
    }
}