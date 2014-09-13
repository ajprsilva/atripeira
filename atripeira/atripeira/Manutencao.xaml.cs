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
    public partial class Manutencao : PhoneApplicationPage
    {
        public Manutencao()
        {
            InitializeComponent();
        }

        string parameter = string.Empty;

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (NavigationContext.QueryString.TryGetValue("parameter", out parameter))
            {
                
            }

        }
        private void Border_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Tripas.xaml", UriKind.Relative));
        }

        private void Border_Tap1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Perfil.xaml", UriKind.Relative));
        }

        private void Border_Tap2(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Carta.xaml?parameter="+parameter, UriKind.Relative));
        }

        private void Border_Tap3(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Fotos.xaml", UriKind.Relative));
        }

        
    }
}