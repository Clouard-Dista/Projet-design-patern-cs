﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.sushiMaker.Menu
{
    public interface IMenu
    {
        void DisplayMenu();
        void AddMenu();
        void RemoveMenu();
    }
}