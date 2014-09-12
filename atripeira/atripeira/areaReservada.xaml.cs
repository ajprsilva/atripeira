using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace atripeira
{
    public partial class areaReservada : PhoneApplicationPage
    {
        public areaReservada()
        {
            InitializeComponent();
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Manutencao.xaml", UriKind.Relative));
        }
    }
}