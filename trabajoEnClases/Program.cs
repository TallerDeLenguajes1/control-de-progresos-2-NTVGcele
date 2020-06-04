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
            Personaje jugador;
            List<Personaje> ListaDeJugadores = new List<Personaje>();
            string[] Nombres = { "Celeste", "Gonzalo", "Fabio", "Alex", "Fede" };
            string[] Apodos = { "Ntvg", "Sotaski", "Soto", "Juampy", "kiko" };
            for(int i = 0; i < cantidad; i++)
            {
                jugador = new Personaje(Nombres[new Random().Next(0, 4)], Apodos[new Random().Next(0, 4)], i+1);
                ListaDeJugadores.Add(jugador);
                jugador.MostrarPersonajes();
            }
            Combate(ListaDeJugadores);


        }

       static public void Combate(List<Personaje>ListJugadores)
        {
            Personaje personaje1 = ListJugadores[0];
            Personaje personaje2 = ListJugadores[1];
            for(int i = 1; i < 3; i++)
            {
                personaje1.Atacar(personaje2);
                personaje2.Atacar(personaje1);
            }
            if (personaje1.Dat.Salud < personaje2.Dat.Salud)
            {
                Console.Write("\n\n\nJUGADOR GANADOR: ");
                personaje2.MostrarPersonajes();
                ListJugadores.Remove(personaje1);
            }
            else if (personaje1.Dat.Salud > personaje2.Dat.Salud)
            {
                Console.Write("\n\n\nJUGADOR GANADOR: ");
                personaje1.MostrarPersonajes();
                ListJugadores.Remove(personaje2);
            }
            else
            {
                Console.Write("\n\n\nEMPATE!!!");
            }
        }
    }
}
