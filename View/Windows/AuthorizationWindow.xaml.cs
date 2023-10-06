﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Demo_Afonichev.View.Windows
{
    /// <summary>
    /// Interaction logic for AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        int KaptchaNum;
        private int time = 10;
        private DispatcherTimer Timer;
        public AuthorizationWindow()
        {
            InitializeComponent();

            Timer = new DispatcherTimer();
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Tick += Timer_Tick;

            Random rand = new Random();
            int da = rand.Next(0, 2);
            if (da == 1)
            {
                Kaptcha.Source = new BitmapImage(new Uri("/Resources/Капча1.jpg", UriKind.Relative));
                KaptchaNum = 1;
            }
            else
            {
                Kaptcha.Source = new BitmapImage(new Uri("/Resources/Капча2.jpg", UriKind.Relative));
                KaptchaNum = 2;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(time>0)
            {
                time--;
            }
            else
            {
                KaptchaCheckBtn.IsEnabled = true;
            }
            
        }

        private void KaptchaCheckBtn_Click(object sender, RoutedEventArgs e)
        {
            if (KaptchaNum == 1)
            {
                if (KaptchaTb.Text != "27ab")
                {
                    KaptchaCheckBtn.IsEnabled = false;
                    Timer.Start();
                }
            }
        }
    }
}