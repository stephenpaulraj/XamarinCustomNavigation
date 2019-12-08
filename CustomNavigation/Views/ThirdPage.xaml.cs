using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CustomNavigation.Views
{
    public partial class ThirdPage : ContentPage
    {
        public ThirdPage()
        {
            InitializeComponent();
        }
        public void FourthPage(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new FourthPage());
        }
    }
}
