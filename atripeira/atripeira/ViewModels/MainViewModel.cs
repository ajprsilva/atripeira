using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using atripeira.Resources;
using Microsoft.WindowsAzure.MobileServices;
using atripeira.DataModels;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Windows;

namespace atripeira.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {

        private MobileServiceCollection<restaurante, restaurante> items;
        private IMobileServiceTable<restaurante> todoTable = App.MobileService.GetTable<restaurante>();

        public MainViewModel()
        {
            this.Items = new ObservableCollection<ItemViewModel>();
        }

        /// <summary>
        /// A collection for ItemViewModel objects.
        /// </summary>
        public ObservableCollection<ItemViewModel> Items { get; private set; }

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
            // Sample data; replace with real data

            try
            {
                items = await todoTable.CreateQuery().ToCollectionAsync();
            }
            catch (Exception ex)
            {
                string st = ex.Message.ToString();
            }

            Deployment.Current.Dispatcher.BeginInvoke(()=>{
                foreach (restaurante resta in items) {
                    this.Items.Add(new ItemViewModel() { LineOne = resta.nome, LineTwo = Double.Parse(resta.Pontuacao.Replace('.',',')), LineThree = resta.Id });
                }
            });

            

            this.IsDataLoaded = true;
        }

        public async Task<restaurante> LoadDataRestaurante(string id)
        {
            try
            {
                items = await todoTable.Where(todoItem => todoItem.Id == id).ToCollectionAsync();
            }
            catch (Exception ex)
            {
                string st = ex.Message.ToString();
            }

            return items[0];
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