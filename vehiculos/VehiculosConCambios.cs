using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elviajaresunplacer
{
    internal class VehiculosConCambios : VehiculoTerrestre
    {
        short cantidadMarchas;

        public VehiculosConCambios(short cantidadDeRuedas, short cantidadDePuertas, Colores color, short cantidadMarchas) : base(cantidadDeRuedas, cantidadDePuertas, color)
        {
            CantidadMarchas = cantidadMarchas;
        }

        public short CantidadMarchas { get => cantidadMarchas; set => cantidadMarchas = value; }




    }
}
