using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elviajaresunplacer
{
    internal class VehiculoTerrestre
    {
        private short cantidadDeRuedas;
        private short cantidadDePuertas;
        private Colores color;

        public VehiculoTerrestre(short cantidadDeRuedas, short cantidadDePuertas, Colores color)
        {
            this.cantidadDeRuedas = cantidadDeRuedas;
            this.cantidadDePuertas = cantidadDePuertas;
            this.color = color;
        }

        public short CantidadDeRuedas { get => cantidadDeRuedas; set => cantidadDeRuedas = value; }
        public short CantidadDePuertas { get => cantidadDePuertas; set => cantidadDePuertas = value; }
        public Colores Color { get => color; set => color = value; }

        public StringBuilder MostrarVehiculoTerrestre()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"cantidad de ruedas... {CantidadDeRuedas}");
            sb.AppendLine($"cantidad de puertas.. {CantidadDePuertas}");
            sb.AppendLine($"color................ {Color}");
            return sb;
        }
    }
}

