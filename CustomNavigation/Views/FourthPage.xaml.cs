using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace CustomNavigation.Views
{
    public partial class FourthPage : ContentPage
    {
        public FourthPage()
        {
            InitializeComponent();
        }
        void Logout(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
            var login = new LoginPage();
            Application.Current.MainPage = new CustomNavigationPage(login);
        }
    }
}
