using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOmall.View
{
    public class ConfiguracionViewModel
    {
        public int PrecioArriendo
        {
            get => Settings.PrecioArriendo;
            set => Settings.PrecioArriendo = value;
        }

        public int DineroInicial
        {
            get => Settings.DineroInicial;
            set => Settings.DineroInicial = value;
        }

        public int HorasFuncionamiento
        {
            get => Settings.HorasFuncionamiento;
            set => Settings.HorasFuncionamiento = value;
        }

        public int SueldoEmpreados
        {
            get => Settings.SueldoEmpreados;
            set => Settings.SueldoEmpreados = value;
        }

        public ConfiguracionViewModel()
        {
            PrecioArriendo = 100;
            DineroInicial = 100;
            HorasFuncionamiento = 12;
            SueldoEmpreados = 10;
        }
    }
}
