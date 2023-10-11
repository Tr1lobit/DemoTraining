using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using Demo_Afonichev.Model;

namespace Demo_Afonichev
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static DemoDb_AfonichevEntities context = new DemoDb_AfonichevEntities();


    }
}
