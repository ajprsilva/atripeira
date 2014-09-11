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
    public partial class Receita : PhoneApplicationPage
    {
       private tripasViewModel TripasViewModel = new tripasViewModel();

       public Receita()
        {
            InitializeComponent();
            DataContext = TripasViewModel;
            TripasViewModel.LoadData();
        }
    }
}