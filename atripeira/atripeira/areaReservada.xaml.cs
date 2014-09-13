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

        private void Pivot_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            switch ((sender as Pivot).SelectedIndex)
                        {
                            case 0:
                                this.ApplicationBar = this.Resources["login"] as ApplicationBar;
                                break;
                            case 1:
                                this.ApplicationBar = this.Resources["registo"] as ApplicationBar;
                                break;
                            default:
                                break;
                        }
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Manutencao.xaml?parameter="+"1", UriKind.Relative));
        }

        private void ApplicationBarIconButton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Registo efectuado com sucesso");
        }
    }
}