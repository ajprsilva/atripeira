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
    public partial class Restaurante : PhoneApplicationPage
    {
        public Restaurante()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string parameter = string.Empty;
            if (NavigationContext.QueryString.TryGetValue("parameter", out parameter))
            {
                pivotRestName.Header = parameter;
            }
        }

        public void calcRating(double soma,int numpessoas) {

            double rating;

            rating = soma / numpessoas;
        }
        public void addRating(double higiene, double localizacao, double conforto, double atendimento, double qualidadepreco) {

            double soma;
            soma = (higiene + localizacao + conforto + atendimento + qualidadepreco)/5;
            //adicionar soma a bd
        }
    }

    
}