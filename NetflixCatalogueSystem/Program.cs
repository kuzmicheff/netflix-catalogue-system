﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace NetflixCatalogueSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.launchMenu();
        }
    }
}
