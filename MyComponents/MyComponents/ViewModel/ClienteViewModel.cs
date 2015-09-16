using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MyComponents.Model;
using Xamarin.Forms;

namespace MyComponents.ViewModel
{
    public class ClienteViewModel : INotifyPropertyChanged
    {

        public ICommand CommandSave { get; set; }

        private List<string> _sexos;

        public List<string> Sexos
        {
            get { return _sexos; }
            set { _sexos = value; NotifyPropertyChanged("Sexos"); }
        }

        private ClienteModel _currentModel;

        public ClienteModel CurrentModel
        {
            get { return _currentModel; }
            set { _currentModel = value; NotifyPropertyChanged("CurrentModel"); }
        }


        public ClienteViewModel()
        {
            Sexos = new List<string>();
            Sexos.Add("FEMININO");
            Sexos.Add("MASCULINO");

            CurrentModel = new ClienteModel();
            CommandSave = new Command(Save);
        }


        public void Save()
        {

            DisplaySave = string.Format("Cliente {0} salvo com sucesso!", CurrentModel.Nome);
            CurrentModel = new ClienteModel();

        }

        private string _displaySave;

        public string DisplaySave
        {
            get { return _displaySave; }
            set { _displaySave = value; NotifyPropertyChanged("DisplaySave"); }
        }



        #region Notificacao
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                (PropertyChanged).Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
