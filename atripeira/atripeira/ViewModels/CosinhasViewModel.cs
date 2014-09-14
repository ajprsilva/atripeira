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
    public class CosinhasViewModel : INotifyPropertyChanged
    {

        private MobileServiceCollection<Cosinha, Cosinha> items;
        private IMobileServiceTable<Cosinha> todoTable = App.MobileService.GetTable<Cosinha>();

        public CosinhasViewModel()
        {
            this.Items = new ObservableCollection<CosinhaViewModel>();
        }

        /// <summary>
        /// A collection for ItemViewModel objects.
        /// </summary>
        public ObservableCollection<CosinhaViewModel> Items { get; private set; }

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

            Deployment.Current.Dispatcher.BeginInvoke(() =>
            {
                foreach (Cosinha resta in items)
                {
                    this.Items.Add(new CosinhaViewModel() { idRest=resta.idRest, data=resta.data });
                }
            });



            this.IsDataLoaded = true;
        }

        public async Task<Cosinha> LoadDataCosinha(string id)
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