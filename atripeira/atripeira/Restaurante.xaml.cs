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
using Microsoft.Phone.Maps.Services;
using Microsoft.Phone.Maps.Controls;
using System.Device.Location;
using Microsoft.Phone.Maps.Toolkit;

namespace atripeira
{
    public partial class Restaurante : PhoneApplicationPage
    {
        private MainViewModel ViewModel1 = new MainViewModel();
        private cartaViewModel cartaViewModel1 = new cartaViewModel();

        public Restaurante()
        {
            InitializeComponent();
            DataContext = cartaViewModel1;
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

                cartaViewModel1.LoadData(Int32.Parse(parameter));
                mapa("Avenida dos aliados, Porto, Portugal");
            }
        }

        private async void mapa(string local) {
            try
            {

                IEnumerable<MapLocation> mapLocations;
                MapLocation mapLocation;
                GeocodeQuery gq = new GeocodeQuery();
                gq.SearchTerm = local;
                gq.GeoCoordinate = new GeoCoordinate(0, 0);

                mapLocations = (List<MapLocation>)await gq.GetMapLocationsAsync();
                mapLocation = mapLocations.FirstOrDefault();
                gq.QueryAsync();

                if (mapLocation != null)
                {
                    LocationRectangle locationRectangle;
                    Pushpin pushpin = (Pushpin)this.FindName("RouteDirectionsPushPin");
                    var Latitude = mapLocation.GeoCoordinate.Latitude;
                    var Longitude = mapLocation.GeoCoordinate.Longitude;

                    locationRectangle = LocationRectangle.CreateBoundingRectangle(mapLocation.GeoCoordinate);

                    this.Map.SetView(locationRectangle, new Thickness(20, 20, 20, 20));
                    pushpin.GeoCoordinate = new GeoCoordinate(Latitude, Longitude);
                    pushpin.Visibility = Visibility.Visible;
                }
            }
            catch (Exception ex)
            {

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

        private void Pivot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch ((sender as Pivot).SelectedIndex)
            {
                case 0:
                    this.ApplicationBar = this.Resources["resta"] as ApplicationBar;
                    break;
                case 1:
                    this.ApplicationBar = this.Resources["resta2"] as ApplicationBar;
                    break;
                case 2:
                    this.ApplicationBar = this.Resources["resta3"] as ApplicationBar;
                    break;
                default:
                    break;
            }
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Comentário inserido com sucesso!");
        }
    }

    
}