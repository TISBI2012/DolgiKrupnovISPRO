using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using AziaFood.Models;

namespace AziaFood
{
    public partial class App : Application
    {
        public static Practic1Entities DB = new Practic1Entities();

        public static User LoggedUser { get; internal set; }
    }
}
