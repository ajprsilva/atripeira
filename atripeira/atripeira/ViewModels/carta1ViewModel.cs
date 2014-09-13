using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atripeira.ViewModels
{
    public class carta1ViewModel : INotifyPropertyChanged
    {

        private string _id;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string iD
        {
            get
            {
                return _id;
            }
            set
            {
                if (value != _id)
                {
                    _id= value;
                    NotifyPropertyChanged("id");
                }
            }
        }

        private string _nome;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value != _nome)
                {
                    _nome = value;
                    NotifyPropertyChanged("Nome");
                }
            }
        }

        private string _descricao;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string Descricao
        {
            get
            {
                return _descricao;
            }
            set
            {
                if (value != _descricao)
                {
                    _descricao = value;
                    NotifyPropertyChanged("Descricao");
                }
            }
        }

        private string _preco;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string Preco
        {
            get
            {
                return _preco;
            }
            set
            {
                if (value != _preco)
                {
                    _preco = value;
                    NotifyPropertyChanged("Preco");
                }
            }
        }

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


