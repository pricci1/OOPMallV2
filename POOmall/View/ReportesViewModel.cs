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
    public class ReportesViewModel : INotifyPropertyChanged
    {

        public ObservableCollection<Reporte> Reportes
        {
            get => Settings.Reportes;
            set => Settings.Reportes = value;
        }
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

        private int _selectedDia;
        public int SelectedDia
        {
            get => _selectedDia;
            set
            {
                _selectedDia = value;
                NotifyPropertyChanged("SelectedDia");
            }
        }

        //private ObservableCollection<Reporte> _reportesSelectedDia;
        public ObservableCollection<Reporte> ResportesSelectedDia
        {
            get => (ObservableCollection<Reporte>) Reportes.Where(r => r.Dia == SelectedDia);
            //set => Settings.Reportes = value;
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
