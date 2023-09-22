using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elviajaresunplacer
{
    internal class Automovil : VehiculosConCambios
    {
        int cantidadPasajeros;

        public Automovil(short cantidadDeRuedas, short cantidadDePuertas, Colores color, short cantidadMarchas, int cantidadPasajeros) : base(cantidadDeRuedas, cantidadDePuertas, color, cantidadMarchas)
        {
            CantidadPasajeros = cantidadPasajeros;
        }

        public int CantidadPasajeros { get => cantidadPasajeros; set => cantidadPasajeros = value; }
        
        public void MostrarAuto()
        {
            Console.WriteLine("AUTOMOVIL");
            StringBuilder sb = MostrarVehiculoTerrestre();
            sb.AppendLine($"cantidad de marchas.. {CantidadMarchas}");
            sb.AppendLine($"cantidad de pasajeros {CantidadPasajeros}");
            Console.WriteLine(sb.ToString());
            
        }
        /*Automovil tendrá los atributos: 
        cantidadRuedas : short, 
        cantidadPuertas : short, 
        color : Colores, 
        cantidadMarchas : short, 
        cantidadPasajeros : int.*/

    }
}
