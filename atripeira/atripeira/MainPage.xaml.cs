using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using atripeira.Resources;
using atripeira.ViewModels;
using System.ComponentModel;

namespace atripeira
{
    public partial class MainPage : PhoneApplicationPage
    {
        private static CosinhasViewModel viewModel2 = new CosinhasViewModel();
        private static MainViewModel viewModel = new MainViewModel();
        private BackgroundWorker bw = new BackgroundWorker();

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            DataContext = viewModel;

            bw.DoWork += bw_DoWork;
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.RunWorkerAsync();

        }

        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progress.Visibility = Visibility.Collapsed;
        }

        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                viewModel.LoadData();
            }
            catch (Exception ex)
            {

            }
        }

        private void TextBlock_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Historia.xaml", UriKind.Relative));
        }

        private void TextBlock_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Ingredientes.xaml", UriKind.Relative));
        }

        private void TextBlock_Tap_2(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Receita.xaml", UriKind.Relative));
        }

        private void TextBlock_Tap_3(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Video1.xaml", UriKind.Relative));
        }

        private void PhoneApplicationPage_BackKeyPress(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Terminate();
        }

        private void Pivot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch ((sender as Pivot).SelectedIndex)
            {
                case 0:
                    this.ApplicationBar = this.Resources["resta2"] as ApplicationBar;
                    break;
                case 1:
                    this.ApplicationBar = this.Resources["resta"] as ApplicationBar;
                    break;
                default:
                    break;
            }
        }

        private void lst_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var sd = (LongListSelector)sender;
            var temp = (ItemViewModel)sd.SelectedItem;

            if (temp != null)
                NavigationService.Navigate(new Uri("/Restaurante.xaml?parameter=" + temp.ID, UriKind.Relative));
        }

        private void ApplicationBarMenuItem_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/AreaReservada.xaml", UriKind.Relative));
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            viewModel= new MainViewModel();

            DataContext = null;
            DataContext = viewModel;
            try
            {
                viewModel.LoadData();
            }
            catch (Exception ex)
            {

            }
        }


        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}