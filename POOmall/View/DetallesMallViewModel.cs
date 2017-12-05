using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POOmall.Model;

namespace POOmall.View
{
    public class DetallesMallViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Tienda> Tiendas
        {
            get => Settings.Tiendas;
            set => Settings.Tiendas = value;
        }

        private Tienda _selectedTienda;

        public Tienda SelectedTienda
        {
            get => _selectedTienda;
            set
            {
                _selectedTienda = value;
                NotifyPropertyChanged("SelectedTienda");
            }
        }






        #region Implementación INotify...
        // https://stackoverflow.com/a/8316100
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

    }
}
