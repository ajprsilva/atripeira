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
using atripeira.DataModels;

namespace atripeira
{
    public partial class Restaurante : PhoneApplicationPage
    {
        private MainViewModel ViewModel1 = new MainViewModel();

        public Restaurante()
        {
            InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            string parameter = string.Empty;
            
            if (NavigationContext.QueryString.TryGetValue("parameter", out parameter))
            {
                var rest = await ViewModel1.LoadDataRestaurante(parameter);
                txtNome.Text = rest.nome;
                txtMorada.Text = rest.morada;
                RatingControl6.Value = Double.Parse(rest.Pontuacao);
                ratingNum.Text = rest.Pontuacao;
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