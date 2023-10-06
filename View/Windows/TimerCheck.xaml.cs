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
    /// Interaction logic for TimerCheck.xaml
    /// </summary>
    public partial class TimerCheck : Window
    {
        
        public TimerCheck()
        {
            InitializeComponent();
        }

        

        private void TimerCheckBtn_Click(object sender, RoutedEventArgs e)
        {
            App.Timer();
        }
    }
}
