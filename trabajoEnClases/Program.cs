using entidades;
using System;
using System.Collections.Generic;

namespace trabajoEnClases
{
    class Program
    {
        static int cantidad = 2;
        static void Main(string[] args)
        {
            Personaje jugador = new Personaje();
            List<Personaje> ListaDeJugadores = new List<Personaje>();
            string[] Nombres = { "Celeste", "Gonzalo", "Fabio", "Alex", "Fede" };
            string[] Apodos = { "Ntvg", "Sotaski", "Soto", "Juampy", "kiko" };
            for(int i = 0; i < cantidad; i++)
            {
                jugador = new Personaje(Nombres[new Random().Next(0, 4)], Apodos[new Random().Next(0, 4)], i+1);
                ListaDeJugadores.Add(jugador);
                jugador.MostrarPersonajes();
            }
            
        }
    }
}
