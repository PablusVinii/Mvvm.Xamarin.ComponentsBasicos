using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyComponents.Model
{
    public class ClienteModel : INotifyPropertyChanged
    {

        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set
            {
                _nome = value; NotifyPropertyChanged("Nome");
            }
        }

        private DateTime _dtNascimento;

        public DateTime DtNascimento
        {
            get { return _dtNascimento; }
            set
            {
                _dtNascimento = value;  NotifyPropertyChanged("DtNascimento");
            }
        }

        private bool _ativo;

        public bool Ativo
        {
            get { return _ativo; }
            set
            {
                _ativo = value; NotifyPropertyChanged("Ativo");
            }
        }

        private int _idSexo;

        public int IdSexo
        {
            get { return _idSexo; }
            set
            {
                _idSexo = value; NotifyPropertyChanged("IdSexo");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                (PropertyChanged).Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
