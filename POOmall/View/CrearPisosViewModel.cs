using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using POOmall.Model;

namespace POOmall.View
{
    public class CrearPisosViewModel : INotifyPropertyChanged
    {
        public int CuentaPisos { get; set; }

        

        public CrearPisosViewModel()
        {
            AddTiendaCommand = new RelayCommand(OnAddTienda, CanAddTienda);
            AddPisoCommand = new RelayCommand(OnAddPiso, CanAddPiso);
            AreaLastPiso = 1500;
            CuentaPisos = 1;
            SliderAreaPisoValue = 1500;
        }

        
        
        public ObservableCollection<Piso> Pisos
        {
            get => Settings.Pisos;
            set => Settings.Pisos = value;
        }

        public ObservableCollection<Tienda> Tiendas
        {
            get => Settings.Tiendas;
            set => Settings.Tiendas = value;
        }

        //public Piso SelectedPiso;
        private Piso _selectedPiso;
        public Piso SelectedPiso
        {
            get => _selectedPiso;
            set
            {
                _selectedPiso = value;
                AddTiendaCommand.RaiseCanExecuteChanged();
                NotifyPropertyChanged("SelectedPiso");
            }
        }

        private int _areaLastPiso;
        private int _sliderAreaPisoValue;

        public int SliderAreaPisoValue
        {
            get => _sliderAreaPisoValue;
            set
            {
                _sliderAreaPisoValue = value;
                NotifyPropertyChanged("SliderAreaPisoValue");
            }
        }
        public int AreaLastPiso
        {
            get => _areaLastPiso;
            set
            {
                _areaLastPiso = value; 
                NotifyPropertyChanged("AreaLastPiso");
            }
        }


        #region AddPiso
        public RelayCommand AddPisoCommand { get; }

        private bool CanAddPiso()
        {
            return true;
        }

        private void OnAddPiso()
        {
            Pisos.Add(new Piso(CuentaPisos++,SliderAreaPisoValue));
            AreaLastPiso = Pisos.Last().Area;
            
        }

        #endregion


        #region AddTienda
        //private 

        public RelayCommand AddTiendaCommand { get; private set; }

        private bool CanAddTienda()
        {
            return SelectedPiso != null;
        }

        private void OnAddTienda()
        {
            Tiendas.Add(new Tienda("Test", SelectedPiso.Numero,12,100,1,10,Settings.Categoria.Ferreteria));
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
