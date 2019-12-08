using System;
using CustomNavigation.Views;

namespace CustomNavigation.Models
{
    public class MenuItems
    {
        public MenuItems()
        {
            Title = "flooop";
            TargetType = typeof(MainPage);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}
