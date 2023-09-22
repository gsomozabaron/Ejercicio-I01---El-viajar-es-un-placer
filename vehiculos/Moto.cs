using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elviajaresunplacer
{
    internal class Moto : VehiculoTerrestre
    {
        private short cilindrada;

        public Moto(short cantidadDeRuedas, short cantidadDePuertas, Colores color, short cilindrada) : base(cantidadDeRuedas, cantidadDePuertas, color)
        {
            Cilindrada = cilindrada;
        }

        public short Cilindrada { get => cilindrada; set => cilindrada = value; }

        public void Mostrarmoto()
        {
            Console.WriteLine("MOTO");
            StringBuilder sb = MostrarVehiculoTerrestre();
            sb.AppendLine($"cilindrada........... {Cilindrada}");
            Console.WriteLine(sb.ToString());
        }
    }
}
