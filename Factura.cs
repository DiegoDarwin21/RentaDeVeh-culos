using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaDeVehículos
{
    class Factura : Vehiculo // herencia 
    {
        string nombre;
        DateTime fdevo;
        int pagar;

        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime Fdevo { get => fdevo; set => fdevo = value; }
        public int Pagar { get => pagar; set => pagar = value; }
    }
}
