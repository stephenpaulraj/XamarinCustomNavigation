﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CustomNavigation.Models
{
    public enum MenuItemType
    {
        Home,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
