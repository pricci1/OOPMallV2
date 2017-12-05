using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOmall.Model
{
    public class Tienda
    {
        public string Nombre { get; set; }
        public int Piso { get; set; }
        public int CantidadEmpleados { get; set; }
        public int Area { get; set; }
        public int PrecioMin { get; set; }
        public int PrecioMax { get; set; }
        public Settings.Categoria Categoria { get; set; }

        public int CantidadClientesHoy;

        public int GananciaTienda;

        public Tienda(string nombre, int piso, int cantidadEmpleados, int area, int precioMin, int precioMax, Settings.Categoria categoria)
        {
            // Pasados
            Nombre = nombre;
            Piso = piso;
            CantidadEmpleados = cantidadEmpleados;
            Area = area;
            PrecioMin = precioMin;
            PrecioMax = precioMax;
            Categoria = categoria;

            // Otros
            CantidadClientesHoy = 0;
            GananciaTienda = 0;
        }

        public int CalcularCantidadClientes()
        {
            int cmax = (int)(CantidadClientesHoy + Area *
                                         Math.Max(100 - (PrecioMax * 0.5 + PrecioMin * 0.5), 0) * 0.001 *
                                         CantidadEmpleados);
            CantidadClientesHoy = Settings.GetRandomInt(0, cmax);
            return CantidadClientesHoy;

        }

        public int CalcularGanacia()
        {
            int ventaPromedio = Settings.GetRandomInt(PrecioMin, PrecioMax);
            int costoArriendo = Area * Settings.PrecioArriendo;
            GananciaTienda = ventaPromedio * CantidadClientesHoy - CantidadEmpleados * Settings.SueldoEmpreados - costoArriendo;
            return GananciaTienda;
        }
    }
}
