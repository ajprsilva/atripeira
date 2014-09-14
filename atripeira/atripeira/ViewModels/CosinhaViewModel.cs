using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atripeira.ViewModels
{
    class CosinhaViewModel : INotifyPropertyChanged
    {
        private string _idRest;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string idRest
        {
            get
            {
                return _idRest;
            }
            set
            {
                if (value != _idRest)
                {
                    _idRest = value;
                    NotifyPropertyChanged("idRest");
                }
            }
        }

        private string _data;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string data
        {
            get
            {
                return _data;
            }
            set
            {
                if (value != _data)
                {
                    _data = value;
                    NotifyPropertyChanged("data");
                }
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
