using elviajaresunplacer;

namespace elviajaresunplacer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Camion nuevoCamion = new Camion(6, 2, Colores.rojo, 5, 1500);
            Moto nuevaMoto = new Moto(2, 0, Colores.azul,500);
            Automovil nuevoAutomovil = new Automovil(4, 2, Colores.negro, 6, 4);

            nuevoCamion.MostrarCamion();
            nuevaMoto.Mostrarmoto();
            nuevoAutomovil.MostrarAuto();
        }
    }
}