using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using atripeira.Resources;
using Microsoft.WindowsAzure.MobileServices;
using atripeira.DataModels;

namespace atripeira.ViewModels
{
    public class cartaViewModel: INotifyPropertyChanged
    {
        private MobileServiceCollection<carta, carta> items;
        private IMobileServiceTable<carta> todoTable = App.MobileService.GetTable<carta>();

        public cartaViewModel()
        {
            this.Items = new ObservableCollection<carta1ViewModel>();
        }

        /// <summary>
        /// A collection for ItemViewModel objects.
        /// </summary>
        public ObservableCollection<carta1ViewModel> Items { get; private set; }

        private string _sampleProperty = "Sample Runtime Property Value";
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding
        /// </summary>
        /// <returns></returns>
        public string SampleProperty
        {
            get
            {
                return _sampleProperty;
            }
            set
            {
                if (value != _sampleProperty)
                {
                    _sampleProperty = value;
                    NotifyPropertyChanged("SampleProperty");
                }
            }
        }

        /// <summary>
        /// Sample property that returns a localized string
        /// </summary>
        public string LocalizedSampleProperty
        {
            get
            {
                return AppResources.SampleProperty;
            }
        }

        public bool IsDataLoaded
        {
            get;
            private set;
        }

        /// <summary>
        /// Creates and adds a few ItemViewModel objects into the Items collection.
        /// </summary>
        public async void LoadData()
        {
            try
            {
                items = await todoTable.CreateQuery().ToCollectionAsync();
            }
            catch (Exception ex) {
                string st = ex.Message.ToString();
            }            
            
            // Sample data; replace with real data
            this.Items.Add(new carta1ViewModel() {  });
            this.IsDataLoaded = true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}