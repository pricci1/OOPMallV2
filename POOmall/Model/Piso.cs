using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOmall.Model
{
    public class Piso
    {
        public int Numero { get; }
        public int Area { get; }

        public Piso(int numero, int area)
        {
            Numero = numero;
            Area = area;
        }

        public override string ToString()
        {
            return $"Piso número: {Numero}, Área: {Area}";
        }
    }
}
