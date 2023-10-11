using System;
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
        public AuthorizationWindow()
        {
            InitializeComponent();

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
        private void KaptchaCheckBtn_Click(object sender, RoutedEventArgs e)
        {
            switch (KaptchaNum)
            {
                case 1:
                    {
                        if (KaptchaTb.Text != "27ab")
                        {
                            KaptchaCheckBtn.IsEnabled = false;
                            int time = 5;
                            DispatcherTimer Timer;
                            Timer = new DispatcherTimer();
                            Timer.Interval = new TimeSpan(0, 0, 1);
                            Timer.Tick += Timer_Tick;
                            Timer.Start();
                            void Timer_Tick(object test, EventArgs a)
                            {
                                if (time > 0)
                                {
                                    time--;
                                }
                                else
                                {
                                    Timer.Stop();
                                    KaptchaCheckBtn.IsEnabled = true;
                                }
                            }
                        }
                    }
                    break;

                case 2:
                    {
                        if (KaptchaTb.Text != "zr71")
                        {
                            KaptchaCheckBtn.IsEnabled = false;
                            int time = 5;
                            DispatcherTimer Timer;
                            Timer = new DispatcherTimer();
                            Timer.Interval = new TimeSpan(0, 0, 1);
                            Timer.Tick += Timer_Tick;
                            Timer.Start();
                            void Timer_Tick(object test, EventArgs a)
                            {
                                if (time > 0)
                                {
                                    time--;
                                }
                                else
                                {
                                    Timer.Stop();
                                    KaptchaCheckBtn.IsEnabled = true;
                                }
                            }
                        }
                    }
                    break;
            }
        }
    }
}
