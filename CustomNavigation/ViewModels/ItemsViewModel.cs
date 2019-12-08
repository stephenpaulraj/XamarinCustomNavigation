using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using CustomNavigation.Models;
using CustomNavigation.Views;

namespace CustomNavigation.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        public ObservableCollection<MenuItems> MenuItems { get; set; }
        public ItemsViewModel()
        {
            MenuItems = new ObservableCollection<MenuItems>(new[]
                {

                    new MenuItems { Id = 1, Title = "Home", TargetType = typeof(MainPage)},
                    new MenuItems { Id = 2, Title = "First Page", TargetType = typeof(FirstPage) },
                    new MenuItems { Id = 3, Title = "Second Page", TargetType = typeof(SecondPage) },
                    new MenuItems { Id = 4, Title = "Third Page", TargetType = typeof(ThirdPage) },
                    new MenuItems { Id = 5, Title = "Fourth Page", TargetType = typeof(FourthPage) },
                    new MenuItems { Id = 6, Title = "Logout", TargetType = typeof(LoginPage) },
                });
        }
    }
}