using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CustomNavigation.Views
{
    public partial class FirstPage : ContentPage, INavigationActionBarConfig
    {
        public int BackButtonStyle { get; set; }
        public FirstPage()
        {
            InitializeComponent();
        }
        public FirstPage(int backButtonStyle) : this()
        {
            BackButtonStyle = backButtonStyle;
        }

        public async void SecondPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SecondPage());
        }
    }
}
