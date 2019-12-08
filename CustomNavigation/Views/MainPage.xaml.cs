using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


using CustomNavigation.Models;

namespace CustomNavigation.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MenuItems;
            if (item == null)
                return;
            //Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
            Application.Current.MainPage.Navigation.PushAsync((Page)Activator.CreateInstance(item.TargetType));
            IsPresented = false;
            MasterPage.ListView.SelectedItem = null;
        }
    }
}