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
    public class ComentarioViewModel: INotifyPropertyChanged
    {

        private MobileServiceCollection<Comentario, Comentario> items;
        private IMobileServiceTable<Comentario> todoTable = App.MobileService.GetTable<Comentario>();

        public ComentarioViewModel()
        {
            this.Items = new ObservableCollection<ComentariosViewModels>();
        }

        /// <summary>
        /// A collection for ItemViewModel objects.
        /// </summary>
        public ObservableCollection<ComentariosViewModels> Items { get; private set; }

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
        public async void LoadData(string id)
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

           foreach (Comentario resta in items)
                {
                    if(resta.idRest==id)
                        this.Items.Add(new ComentariosViewModels() { Nome = resta.nome, iDRest= resta.idRest, ID = resta.Id, Pais = resta.pais, Comentario=resta.comentario });
                }

            

            this.IsDataLoaded = true;
        }

        public async void insertData(Comentario com) {
            try
            {
                await todoTable.InsertAsync(com);
            }
            catch (Exception ex)
            {
                
                throw;
            }
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