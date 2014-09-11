using atripeira.ViewModels;
using Microsoft.Phone.Controls;
using System.Windows.Navigation;

namespace atripeira
{

    public partial class Historia : PhoneApplicationPage
    {

        private tripasViewModel TripasViewModel = new tripasViewModel();
                
        public Historia()
        {
            InitializeComponent();
            
            DataContext = TripasViewModel;
            TripasViewModel.LoadData();
            
            //txthistoria.Text = TripasViewModel.Items[0].LineOne;
        }

        //protected override void OnNavigatedTo(NavigationEventArgs e)
        //{
        //    if (!TripasViewModel.IsDataLoaded)
        //    {
        //        TripasViewModel.LoadData();
        //    }
            
        //}
    }
}