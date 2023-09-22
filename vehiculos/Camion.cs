using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elviajaresunplacer
{
    internal class Camion : VehiculosConCambios
    {
        int pesoCarga;

        public Camion(short cantidadDeRuedas, short cantidadDePuertas, Colores color, short cantidadMarchas, int pesoCarga) : base(cantidadDeRuedas, cantidadDePuertas, color, cantidadMarchas)
        {
            PesoCarga = pesoCarga;
        }

        public int PesoCarga { get => pesoCarga; set => pesoCarga = value; }

        public void MostrarCamion()
        {
            Console.WriteLine("CAMION");
            StringBuilder sb = MostrarVehiculoTerrestre();
            sb.AppendLine($"cantidad de marchas.. {CantidadMarchas}");
            sb.AppendLine($"peso de carga........ {PesoCarga}");
            Console.WriteLine(sb.ToString());



        }
    }
}
