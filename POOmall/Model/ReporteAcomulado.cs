using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOmall.Model
{
    public class ReporteAcomulado
    {
        public int ClientesPromedio { get; set; }
        public int GananciaPromedio { get; set; }
        public Tienda TiendaMayorGanancia { get; set; }
        public int GananciaTiendaMayor { get; set; }
        public Tienda TiendaMenorGanancia { get; set; }
        public int GananciaTiendaMenor { get; set; }
        public Tienda TiendaMenorClientes { get; set; }
        public Tienda TiendaMayorClientes { get; set; }

        public ReporteAcomulado(int clientesPromedio,int gananciaPromedio, Tienda tiendaMayorGanancia, int gananciaTiendaMayor, Tienda tiendaMenorGanancia, int gananciaTiendaMenor, Tienda tiendaMenorClientes, Tienda tiendaMayorClientes)
        {
            ClientesPromedio = clientesPromedio;
            GananciaPromedio = gananciaPromedio;
            TiendaMayorGanancia = tiendaMayorGanancia;
            GananciaTiendaMayor = gananciaTiendaMayor;
            TiendaMenorGanancia = tiendaMenorGanancia;
            GananciaTiendaMenor = gananciaTiendaMenor;
            TiendaMenorClientes = tiendaMenorClientes;
            TiendaMayorClientes = tiendaMayorClientes;
        }
    }
}
