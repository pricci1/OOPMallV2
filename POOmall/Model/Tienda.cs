using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOmall.Model
{
    public class Tienda
    {
        public string Nombre { get; }
        public int Piso { get; }
        public int CantidadEmpleados { get; }
        public int Area { get; }
        public int PrecioMin { get; }
        public int PrecioMax { get; }
        public Settings.Categoria Categoria { get; }

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

        public void CalcularCantidadClientes()
        {
            int cmax = (int)(CantidadClientesHoy + Area *
                                         Math.Max(100 - (PrecioMax * 0.5 + PrecioMin * 0.5), 0) * 0.001 *
                                         CantidadEmpleados);
            CantidadClientesHoy = Settings.GetRandomInt(0, cmax);

        }

        public void CalcularGanacia()
        {
            int ventaPromedio = Settings.GetRandomInt(PrecioMin, PrecioMax);
            int costoArriendo = Area * Settings.PrecioArriendo;
            GananciaTienda = ventaPromedio * CantidadClientesHoy - CantidadEmpleados * Settings.SueldoEmpreados - costoArriendo;
        }
    }
}
