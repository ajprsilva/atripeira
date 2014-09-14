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
            var sd = (LongListSelector)sender;
            var temp = (ItemViewModel)sd.SelectedItem;

            await YouTube.PlayWithPageDeactivationAsync(temp.ID, true, YouTubeQuality.Quality480P);

            GC.Collect();
        }

        private async void temo_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var sd = (ListBox)sender;
            var temp = (ItemViewModel)sd.SelectedItem;

            await YouTube.PlayWithPageDeactivationAsync("gi3rc9Pv2IA", true, YouTubeQuality.Quality480P);

            GC.Collect();
        }

        private async void TextBlock_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            await YouTube.PlayWithPageDeactivationAsync("WvDveq5O3jU", true, YouTubeQuality.Quality480P);

            GC.Collect();
        }

        private void ItemsControl_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

        }

        private async void LongListSelector_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var sd = (LongListSelector)sender;
            var temp = (ItemViewModel)sd.SelectedItem;

            await YouTube.PlayWithPageDeactivationAsync(temp.ID, true, YouTubeQuality.Quality480P);

            GC.Collect();
        }

        private async void LongListSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var sd = (LongListSelector)sender;
            var temp = (ItemViewModel)sd.SelectedItem;

            await YouTube.PlayWithPageDeactivationAsync(temp.ID, true, YouTubeQuality.Quality480P);

            GC.Collect();
        }

        private async void StackPanel_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            //var sd = (StackPanel)sender;
            //var temp = (ItemViewModel)sd.SelectedItem;

            await YouTube.PlayWithPageDeactivationAsync(TripasViewModel.Items[0].ID, true, YouTubeQuality.Quality480P);

            GC.Collect();
        }

        private async void StackPanel_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            await YouTube.PlayWithPageDeactivationAsync(TripasViewModel.Items2[0].ID, true, YouTubeQuality.Quality480P);

            GC.Collect();
        }

        
    }
}