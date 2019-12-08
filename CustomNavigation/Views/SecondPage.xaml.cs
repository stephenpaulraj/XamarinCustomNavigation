using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace CustomNavigation.Views
{
    public partial class SecondPage : ContentPage, INavigationActionBarConfig
    {
        public int BackButtonStyle { get; set; }
        public SecondPage()
        {
            InitializeComponent();
        }

        public SecondPage(int backButtonStyle) : this()
        {
            Debug.WriteLine(backButtonStyle);
            BackButtonStyle = backButtonStyle; // see INavigationActionBarConfig for possible values
        }

        public void ThirdPage(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new ThirdPage());
        }
    }
}
