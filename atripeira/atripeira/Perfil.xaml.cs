using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Maps.Services;
using Microsoft.Phone.Maps.Controls;
using System.Device.Location;
using Microsoft.Phone.Maps.Toolkit;
using atripeira.ViewModels;

namespace atripeira
{
    public partial class Perfil : PhoneApplicationPage
    {

        private MainViewModel ViewModel1 = new MainViewModel();
        public Perfil()
        {
            InitializeComponent();
            DataContext = ViewModel1;
            
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
           string parameter = string.Empty;

            if (NavigationContext.QueryString.TryGetValue("parameter", out parameter))
            {
               await ViewModel1.LoadDataRestaurante(parameter);
            }
        }
    }
}