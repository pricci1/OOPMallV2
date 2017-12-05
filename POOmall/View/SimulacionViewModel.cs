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
    public class SimulacionViewModel : INotifyPropertyChanged
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
        public SimulacionViewModel()
        {
            _dia = 0;
            ComenzarCommand = new RelayCommand(OnComenzar, CanComenzar);
        }

        private int _dia;
        public int Dia { get => _dia; set =>_dia = value; }

        public void GenerarReporteDia()
        {
            Dia++;
            NotifyPropertyChanged("Dia");
            foreach (var tienda in Tiendas)
            {
                Reportes.Add(new Reporte(tienda,Dia,tienda.CalcularCantidadClientes(),tienda.CalcularGanacia()));
            }
            NotifyPropertyChanged("Reportes");
        }

        #region Botón Comenzar Simulación

        public RelayCommand ComenzarCommand { get; }
        private bool CanComenzar()
        {
            //return Settings.Tiendas.Count > 0;
            return true;
        }

        private void OnComenzar()
        {
            GenerarReporteDia();
            
        }

        #endregion





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
