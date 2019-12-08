using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CustomNavigation.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        public void Login(object sender, EventArgs e)
        {
            var UserName = uname.Text;
            var Password = pass.Text;
            if(UserName==Password && UserName != null && Password != null)
            {
                Application.Current.MainPage.Navigation.PushAsync(new MainPage());
            }
            else
            {
                DisplayAlert("Login", "Enter demo as Username and Password", "Okay");
            }
        }
    }
}
