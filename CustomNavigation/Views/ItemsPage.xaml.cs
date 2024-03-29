﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using CustomNavigation.Models;
using CustomNavigation.Views;
using CustomNavigation.ViewModels;

namespace CustomNavigation.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemsPage : ContentPage
    {
        
        public ItemsPage()
        {
            InitializeComponent();
        }

        public void FirstPage(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new FirstPage());
        }

    }
}