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
        public static int check;
        public static void Timer(object da)
        {
           
            int time = 10;
            DispatcherTimer Timer;
            Timer = new DispatcherTimer();
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Tick += Timer_Tick;
            Timer.Start();
            void Timer_Tick(object sender, EventArgs e)
            {
                if (time > 0)
                {
                    check = 0;
                    time--;
                }
                else
                {
                    Timer.Stop();
                    check = 1;
                }
            }
        }
    }
}
