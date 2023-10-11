using Demo_Afonichev.Model;
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
        int FailCheck = 0;
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
            bool kaptchaCheck = false;
            int id;

            try
            {
                id = Convert.ToInt32(IdTb.Text);
            }
            catch
            {
                id = 0;
            }

            Member member = App.context.Member.FirstOrDefault(p => PasswordPb.Password == p.Password && id == p.Id);

            switch (KaptchaNum)
            {
                case 1:
                    {
                        if (KaptchaTb.Text != "27ab")
                        {
                            FailCheck++;
                            MessageBox.Show("Неверный ID или пароль");
                        }
                        else
                        {
                            kaptchaCheck = true;
                        }
                    }
                    break;

                case 2:
                    {
                        if (KaptchaTb.Text != "zr71")
                        {
                            FailCheck++;
                            MessageBox.Show("Неверный ID или пароль");

                        }
                        else
                        {
                            kaptchaCheck = true;
                        }
                    }
                    break;
            }

            if (member != null && kaptchaCheck)
            {
                switch (member.RoleId)
                {
                    case 1:
                        {
                            MemberWindow memberWindow = new MemberWindow();
                            memberWindow.Show();
                        }
                        break;
                    case 2:
                        {
                            ModeratorWindow moderatorWindow = new ModeratorWindow();
                            moderatorWindow.Show();
                        }
                        break;
                    case 3:
                        {
                            OrganizatorWindow organizatorWindow = new OrganizatorWindow();
                            organizatorWindow.Show();
                        }
                        break;
                    case 4:
                        {
                            JuriWindow juriWindow = new JuriWindow();
                            juriWindow.Show();
                        }
                        break;
                }
            }
            else if (FailCheck == 3)
            {
                KaptchaCheckBtn.IsEnabled = false;
                int time = 5;
                DispatcherTimer Timer;
                Timer = new DispatcherTimer { Interval = new TimeSpan(0, 0, 1) };
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
                        FailCheck = 0;
                    }
                }
            }


        }
    }
}
