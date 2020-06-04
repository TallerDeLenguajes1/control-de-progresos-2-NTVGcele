using System;

namespace entidades
{
        public enum Tipo
        {
            Humano,
            Animal,
            Aliens,
        }


   public class Personaje
   {
        private Caracteristicas caract;
        private Datos dat;
        private int id;

        public Personaje()
        {
        }

        public Personaje(string nombre, string apodo, int _Id )
        {
            Caract = new Caracteristicas();
            Dat = new Datos(nombre, apodo);
            Id = _Id;
        }

        public Caracteristicas Caract { get => caract; set => caract = value; }
        public Datos Dat { get => dat; set => dat = value; }
        public int Id { get => id; set => id = value; }

        public void MostrarPersonajes()
        {
            Console.Write("\n_______________________________");
            Console.Write("\n\nDatos del Jugador " + Id + ": ");
            Console.Write("\nTipo de jugador: " + Dat.TipoJugador);
            Console.Write("\nNombre: " + Dat.Nombre);
            Console.Write("\nApodo: : " + Dat.Apodo);
            Console.Write("\nFecha de Nacimiento: " + Dat.FechaNacimiento);
            Console.Write("\nEdad: " + Dat.Edad);
            Console.Write("\nSalud: " + Dat.Salud);

            Console.Write("\n\nCaracteristicas: ");
            Console.Write("\nVelocidad: " + Caract.Velocidad);
            Console.Write("\nDestreza: " + Caract.Destreza);
            Console.Write("\nFuerza: " + Caract.Fuerza);
            Console.Write("\nNivel: " + Caract.Nivel);
            Console.Write("\nArmadura: " + Caract.Armadura);

            
    }
   }

   public class Caracteristicas
   {
            private int velocidad;// 1-10
            private int destreza;// 1-5
            private int fuerza;// 1-10
            private int nivel;// 1-10
            private int armadura; // 1-10
            public Random rnd = new Random();
            public Caracteristicas()
            {
                Velocidad = rnd.Next(1, 10);
                Destreza = rnd.Next(1, 5);
                Fuerza = rnd.Next(1, 10);
                Nivel = rnd.Next(1, 10);
                Armadura = rnd.Next(1, 10);
            }

            public int Velocidad { get => velocidad; set => velocidad = value; }
            public int Destreza { get => destreza; set => destreza = value; }
            public int Fuerza { get => fuerza; set => fuerza = value; }
            public int Nivel { get => nivel; set => nivel = value; }
            public int Armadura { get => armadura; set => armadura = value; }
   }
   public class Datos
   {
            private Tipo tipoJugador;
            private string nombre;
            private string apodo;
            private DateTime fechaNacimiento;
            private int edad; //0-300
            private int salud; //100

        public Random rnd = new Random();
        public Datos(string nombre, string apodo)
        {
            Nombre = nombre;
            Apodo = apodo;
            FechaNacimiento = new DateTime(rnd.Next(1800, 2020), rnd.Next(1, 12), rnd.Next(1, 30));
            Edad = rnd.Next(1, 300);
            Salud = rnd.Next(0, 100);
            TipoJugador = (Tipo)rnd.Next(0, 3);
        }

        public Datos()
        {
        }

        public string Nombre { get => nombre; set => nombre = value; }
            public string Apodo { get => apodo; set => apodo = value; }
            public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
            public int Edad { get => edad; set => edad = value; }
            public int Salud { get => salud; set => salud = value; }
            internal Tipo TipoJugador { get => tipoJugador; set => tipoJugador = value; }
    }

}
