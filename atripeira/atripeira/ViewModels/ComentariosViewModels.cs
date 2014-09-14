using System;
using System.ComponentModel;

namespace atripeira.ViewModels
{
    public class ComentariosViewModels : INotifyPropertyChanged
    {
        private string _Nome;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string Nome
        {
            get
            {
                return _Nome;
            }
            set
            {
                if (value != _Nome)
                {
                    _Nome = value;
                    NotifyPropertyChanged("Nome");
                }
            }
        }

        private string _Pais;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string Pais
        {
            get
            {
                return _Pais;
            }
            set
            {
                if (value != _Pais)
                {
                    _Pais = value;
                    NotifyPropertyChanged("Morada");
                }
            }
        }

        private string _Comentario;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string Comentario
        {
            get
            {
                return _Comentario;
            }
            set
            {
                if (value != _Comentario)
                {
                    _Comentario = value;
                    NotifyPropertyChanged("Capacidade");
                }
            }
        }

        private string _iDrest;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string iDRest
        {
            get
            {
                return _iDrest;
            }
            set
            {
                if (value != _iDrest)
                {
                    _iDrest = value;
                    NotifyPropertyChanged("Contacto");
                }
            }
        }

        private string _ID;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (value != _ID)
                {
                    _ID = value;
                    NotifyPropertyChanged("ID");
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