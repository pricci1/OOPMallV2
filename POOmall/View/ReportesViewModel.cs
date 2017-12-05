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
        public ReportesViewModel()
        {
            GenerarCommand = new RelayCommand(OnGenerar, CanGenerar);
        }

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
                NotifyPropertyChanged("ReporteTiendaSeleccionadaDiaSeleccionado");
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
                NotifyPropertyChanged("ReportesSelectedDia");
            }
        }

        //private ObservableCollection<Reporte> _reportesSelectedDia;
        public ObservableCollection<Reporte> ReportesSelectedDia
        {
            //https://stackoverflow.com/a/3559830
            //get => (ObservableCollection<Reporte>) Reportes.Where(r => r.Dia == SelectedDia);
            get => new ObservableCollection<Reporte>(Reportes.Any(r => r.Dia == SelectedDia)? Reportes.Where(r => r.Dia == SelectedDia):new ObservableCollection<Reporte>());
            //set => Settings.Reportes = value;
        }

        public Reporte ReporteTiendaSeleccionadaDiaSeleccionado
        {
            //get => ReportesSelectedDia.Where(reporte => reporte.Tienda == SelectedTienda).First();
            get => ReportesSelectedDia.Any(reporte => reporte.Tienda == SelectedTienda) ? ReportesSelectedDia.First(reporte => reporte.Tienda == SelectedTienda) :new Reporte(SelectedTienda,SelectedDia,0,0);
        }

        public ReporteAcomulado ReporteAcomulado { get => GetReporteAcomulado(); }

        public ReporteAcomulado GetReporteAcomulado()
        {
            if (Reportes.Count>0)
            {
                return new ReporteAcomulado((int)Reportes.Average(r => r.CantidadClientes), (int)Reportes.Average(r => r.Ganancia), Reportes.OrderBy(r => r.Ganancia).First().Tienda, 100, Reportes.OrderByDescending(r => r.Ganancia).First().Tienda, 0, Reportes.OrderBy(r => r.CantidadClientes).First().Tienda, Reportes.OrderByDescending(r => r.CantidadClientes).First().Tienda);
            }
            return new ReporteAcomulado(0,0,new Tienda("",1,0,0,1,10,Settings.Categoria.Ferreteria), 0, new Tienda("", 1, 0, 0, 1, 10, Settings.Categoria.Ferreteria), 0, new Tienda("", 1, 0, 0, 1, 10, Settings.Categoria.Ferreteria), new Tienda("", 1, 0, 0, 1, 10, Settings.Categoria.Ferreteria));
        }

        public RelayCommand GenerarCommand { get; }
        private bool CanGenerar()
        {

            return true;
        }

        private void OnGenerar()
        {
            NotifyPropertyChanged("ReporteAcomulado");

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
