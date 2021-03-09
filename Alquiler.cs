using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaDeVehículos
{
    class Alquiler
    {
        string nit;
        string placa;
        DateTime falquiler;
        DateTime fdevo;
        int recorrido;

        public string Nit { get => nit; set => nit = value; }
        public string Placa { get => placa; set => placa = value; }
        public DateTime Falquiler { get => falquiler; set => falquiler = value; }
        public DateTime Fdevo { get => fdevo; set => fdevo = value; }
        public int Recorrido { get => recorrido; set => recorrido = value; }
    }
}
