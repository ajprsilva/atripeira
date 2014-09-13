using System;
using System.ComponentModel;

namespace atripeira.ViewModels
{
    public class ItemViewModel : INotifyPropertyChanged
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

        private string _Morada;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string Morada
        {
            get
            {
                return _Morada;
            }
            set
            {
                if (value != _Morada)
                {
                    _Morada = value;
                    NotifyPropertyChanged("Morada");
                }
            }
        }

        private int _Capacidade;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public int Capacidade
        {
            get
            {
                return _Capacidade;
            }
            set
            {
                if (value != _Capacidade)
                {
                    _Capacidade = value;
                    NotifyPropertyChanged("Capacidade");
                }
            }
        }

        private int _Contacto;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public int Contacto
        {
            get
            {
                return _Contacto;
            }
            set
            {
                if (value != _Contacto)
                {
                    _Contacto = value;
                    NotifyPropertyChanged("Contacto");
                }
            }
        }

        private string _Descricao;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string Descricao
        {
            get
            {
                return _Descricao;
            }
            set
            {
                if (value != _Descricao)
                {
                    _Descricao = value;
                    NotifyPropertyChanged("Descricao");
                }
            }
        }

        private double _Pontuacao;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public double Pontuacao
        {
            get
            {
                return _Pontuacao;
            }
            set
            {
                if (value != _Pontuacao)
                {
                    _Pontuacao = value;
                    NotifyPropertyChanged("Pontuacao");
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