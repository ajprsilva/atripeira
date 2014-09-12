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

namespace atripeira
{
    public partial class Videos : PhoneApplicationPage
    {
        public Videos()
        {
            InitializeComponent();
        }

        public async void playYoutube(){

            
            await YouTube.PlayWithPageDeactivationAsync("LSj4OlGV4x0", true, YouTubeQuality.Quality480P);
            
            
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            playYoutube();
        }
    }
}