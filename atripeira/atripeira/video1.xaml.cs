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
    public partial class video1 : PhoneApplicationPage
    {
        private videoViewModel TripasViewModel = new videoViewModel();
        public video1()
        {
            InitializeComponent();
            DataContext = TripasViewModel;
            TripasViewModel.LoadData();
        }
    }
}