using libreriaParaJugador;
using System;

namespace trabajoEnClases
{
    class Program
    {
        static void Main(string[] args)
        {
            Personaje jugador = new Personaje("Celeste", "NTVG");
            jugador.MostrarPersonajes();
        }
    }
}
