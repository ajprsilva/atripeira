using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MyToolkit.Multimedia;
using MyToolkit.Networking;
using atripeira.ViewModels;

namespace atripeira
{
    public partial class Videos : PhoneApplicationPage
    {
        private videoViewModel TripasViewModel = new videoViewModel();

        public Videos()
        {
            InitializeComponent();
            DataContext = TripasViewModel;
            TripasViewModel.LoadData();
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            
        }

        private async void ListBox_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var sd = (ListBox)sender;
            var temp = (ItemViewModel)sd.SelectedItem;

            await YouTube.PlayWithPageDeactivationAsync(temp.ID, true, YouTubeQuality.Quality480P);

            GC.Collect();
        }

        private async void ListBox_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var sd = (ListBox)sender;
            var temp = (ItemViewModel)sd.SelectedItem;

            await YouTube.PlayWithPageDeactivationAsync(temp.ID, true, YouTubeQuality.Quality480P);

            GC.Collect();
        }
    }
}