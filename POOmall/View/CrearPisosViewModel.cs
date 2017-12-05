using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POOmall.Model;

namespace POOmall.View
{
    public class CrearPisosViewModel
    {
        public CrearPisosViewModel()
        {
            AddTiendaCommand = new RelayCommand(OnAddTienda, CanAddTienda);
            AddPisoCommand = new RelayCommand(OnAddPiso, CanAddPiso);
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
            }
        }

        public string NumeroPisoSeleccionado => $"Piso: {SelectedPiso.Numero}";

        #region AddPiso
        public RelayCommand AddPisoCommand { get; }

        private bool CanAddPiso()
        {
            return true;
        }

        private void OnAddPiso()
        {
            Pisos.Add(new Piso(1,1000));
        }

        #endregion


        #region AddTienda
        public RelayCommand AddTiendaCommand { get; private set; }

        private bool CanAddTienda()
        {
            return SelectedPiso != null;
        }

        private void OnAddTienda()
        {
            Tiendas.Add(new Tienda("Test", 12,12,100,1,10,Settings.Categoria.Ferreteria));
        }
        #endregion

    }
}
