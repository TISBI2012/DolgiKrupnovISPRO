using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Cinema.Models;


namespace Cinema
{
    public partial class App : Application
    {
        public static Practic2Entities DB = new Practic2Entities();
    
        public static User LoggedUser { get; internal set; }
    }
}
