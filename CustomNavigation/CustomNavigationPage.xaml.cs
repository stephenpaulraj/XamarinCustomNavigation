using System;
using System.Collections.Generic;
using CustomNavigation.Views;
using Xamarin.Forms;

namespace CustomNavigation
{
    public partial class CustomNavigationPage : NavigationPage
    {
        public CustomNavigationPage(Page startPage) : base(startPage)
        {
            InitializeComponent();
        }

        public CustomNavigationPage():base()
        {
            InitializeComponent();
        }
        public bool IgnoreLayoutChange { get; set; } = false;

        protected override void OnSizeAllocated(double width, double height)
        {
            if (!IgnoreLayoutChange)
                base.OnSizeAllocated(width, height);
        }
    }
}
