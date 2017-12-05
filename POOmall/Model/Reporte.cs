using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOmall.Model
{
    public class Reporte
    {
        public Tienda Tienda { get; set; }
        public int Dia { get; set; }
        public int CantidadClientes { get; set; }
        public int Ganancia { get; set; }

        public Reporte(Tienda tienda, int dia, int cantidadClientes, int ganancia)
        {
            Tienda = tienda;
            Dia = dia;
            CantidadClientes = cantidadClientes;
            Ganancia = ganancia;
        }

        public override string ToString()
        {
            return $"Tienda: {Tienda.Nombre} \nDía: {Dia}\nCantidad de clientes recepcionados: {CantidadClientes}\nGanancia de hoy: {Ganancia}";
        }
    }
}
