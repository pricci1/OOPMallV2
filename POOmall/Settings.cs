using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POOmall.Model;

namespace POOmall
{
    public static class Settings
    {
        // Configuración Inicial:
        public static int PrecioArriendo { get; set; }
        public static int DineroInicial { get; set; }
        public static int HorasFuncionamiento { get; set; }
        public static int SueldoEmpreados { get; set; }


        // Globales

        public static ObservableCollection<Piso> Pisos = new ObservableCollection<Piso>();
        public static ObservableCollection<Tienda> Tiendas = new ObservableCollection<Tienda>();
        public static ObservableCollection<Reporte> Reportes = new ObservableCollection<Reporte>();

        public enum Categoria
        {
            Ropa,
            Hogar,
            Alimentos,
            Ferreteria,
            Tecnologia,
            ComidaRapida,
            Restaurant,
            Cine,
            Juegos,
            Bowling
        }

        // Funciones
        public static int GetRandomInt(int min, int max)
        {
            Random r = new Random();
            int rInt = r.Next(min, max);
            return rInt;
        }


    }
}
