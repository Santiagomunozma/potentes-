using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackjackConDados
{
    internal class Program
    {
        private static Random random = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al juego de Blackjack con dados!");
            Console.WriteLine("¿Cuántos jugadores (excluyendo la máquina) van a jugar?");

            // Numero de jugadores
            int numJugadores = int.Parse(Console.ReadLine()); // "2" -> 2

            // Lista de jugadores
            List<Jugador> jugadores = new List<Jugador>();

            // Llenamos la lista
            for (int i = 0; i < numJugadores; i++)
            {
                Console.WriteLine($"Ingrese el nombre del jugador {i + 1}:");
                string nombre = Console.ReadLine();
                jugadores.Add(new Jugador(nombre));
            }

            jugadores.Add(new Jugador("Máquina", esMaquina: true));

            bool hayJugadoresActivos = true;

            while (hayJugadoresActivos)
            {
                Console.WriteLine("\n--- Nueva ronda ---");

                foreach (var jugador in jugadores.Where(j => j.EstaActivo))
                {
                    jugador.LanzarDados(random);
                }

                foreach (var jugador in jugadores.Where(j => j.EstaActivo))
                {
                    if (jugador.Puntaje >= 21)
                    {
                        jugador.Desactivar();
                        continue;
                    }

                    if (jugador.EsMaquina)
                    {
                        if (jugador.Puntaje <= 16)
                        {
                            Console.WriteLine($"{jugador.Nombre} decide continuar.");
                        }
                        else
                        {
                            jugador.Plantarse();
                        }
                    }
                    else
                    {
                        jugador.Plantarse();
                    }
                }

                hayJugadoresActivos = jugadores.Any(j => j.EstaActivo);
            }

            Console.WriteLine("\n--- Resultados finales ---");
            foreach (var jugador in jugadores)
            {
                jugador.MostrarPuntaje();
            }

            Jugador ganador = DeterminarGanador(jugadores);

            if (ganador != null)
            {
                Console.WriteLine($"\nEl ganador es {ganador.Nombre} con un puntaje de {ganador.Puntaje}!");
            }
            else
            {
                Console.WriteLine("\nNo hay ganador.");
            }
        }


        static Jugador DeterminarGanador(List<Jugador> jugadores)
        {
            Jugador ganador = null;
            int mejorPuntaje = 0;

            foreach (var jugador in jugadores)
            {
                if (jugador.Puntaje <= 21 && jugador.Puntaje > mejorPuntaje)
                {
                    mejorPuntaje = jugador.Puntaje;
                    ganador = jugador;
                }
            }

            return ganador;
        }
    }

    class Jugador
    {
        // Atributos
        public string Nombre { get; }
        public int Puntaje { get; private set; }
        public bool EstaActivo { get; private set; }
        public bool EsMaquina { get; }

        // Constructor
        public Jugador(string nombre, bool esMaquina = false)
        {
            Nombre = nombre;
            Puntaje = 0;
            EsMaquina = esMaquina;
            EstaActivo = true;
        }

        private int GenerarNumero(Random random)
        {
            return random.Next(1, 7);
        }

        public void MostrarPuntaje()
        {
            Console.WriteLine($"{Nombre}: {Puntaje}");
        }

        public void Plantarse()
        {
            Console.WriteLine($"\n{Nombre}, ¿desea 'pedir' (seguir lanzando) o 'plantarse'?");
            string respuesta = Console.ReadLine().ToLower();
            if (respuesta != "pedir")
            {
                Desactivar();
            }
        }

        // Métodos
        public void LanzarDados(Random random)
        {
            int dado1 = GenerarNumero(random);
            int dado2 = GenerarNumero(random);
            Puntaje += dado1 + dado2;

            Console.WriteLine($"{Nombre} lanzó {dado1} y {dado2}. Puntaje actual: {Puntaje}");
        }

        public void Desactivar()
        {
            EstaActivo = false;
        }
    }
}