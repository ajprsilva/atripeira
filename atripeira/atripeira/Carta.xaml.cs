using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using atripeira.ViewModels;

namespace atripeira
{
    public partial class Carta : PhoneApplicationPage
    {
        private cartaViewModel cartaViewModel1 = new cartaViewModel();
        public Carta()
        {
            InitializeComponent();
            string parameter = string.Empty;

            DataContext = cartaViewModel1;

            if (NavigationContext.QueryString.TryGetValue("parameter", out parameter))
            {
                cartaViewModel1.LoadData(parameter);
            }
        }

    }
}