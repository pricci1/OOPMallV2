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
        public ObservableCollection<Piso> Pisos
        {
            get => Settings.Pisos;
            set => Settings.Pisos = value;
        }

    }
}
