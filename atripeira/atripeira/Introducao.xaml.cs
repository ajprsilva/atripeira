using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Threading;

namespace atripeira
{
    public partial class Introducao : PhoneApplicationPage
    {
        private DispatcherTimer showWindowTimer;
        public Introducao()
        {
            InitializeComponent();
            showWindowTimer = new DispatcherTimer();
            showWindowTimer.Interval = TimeSpan.FromMilliseconds(2000);
            showWindowTimer.Tick += showWindowTimer_Tick;
            showWindowTimer.Start();
        }

        void showWindowTimer_Tick(object sender, EventArgs e)
        {
            showWindowTimer.Stop();
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }
    }
}