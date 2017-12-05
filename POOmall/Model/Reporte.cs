﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOmall.Model
{
    public class Reporte
    {
        public Tienda Tienda { get; }
        public int Dia { get; }
        public int CantidadClientes { get; }
        public int Ganancia { get; }

        public Reporte(Tienda tienda, int dia, int cantidadClientes, int ganancia)
        {
            Tienda = tienda;
            Dia = dia;
            CantidadClientes = cantidadClientes;
            Ganancia = ganancia;
        }

        
    }
}