using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Juego
    {
        private static Random random = new Random();
        private List<Jugador> jugadores;

        public void IniciarJuego()
        {
            Console.WriteLine("Bienvenido al juego de Blackjack con dados!");
            InicializarJugadores();
            JugarRondas();
            MostrarResultados();
        }

        private void InicializarJugadores()
        {
            Console.WriteLine("¿Cuántos jugadores (excluyendo la máquina) van a jugar?");
            int numJugadores = int.Parse(Console.ReadLine());

            jugadores = new List<Jugador>();

            for (int i = 0; i < numJugadores; i++)
            {
                Console.WriteLine($"Ingrese el nombre del jugador {i + 1}:");
                string nombre = Console.ReadLine();
                jugadores.Add(new Jugador(nombre));
            }

            jugadores.Add(new Maquina());
        }

        private void JugarRondas()
        {
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

                    if (jugador is Maquina maquina && maquina.Puntaje <= 16)
                    {
                        Console.WriteLine($"{maquina.Nombre} decide continuar.");
                    }
                    else if (jugador is Maquina maquina1 && maquina1.Puntaje > 16)
                    {
                        jugador.Desactivar();
                    }
                    else
                    {
                        jugador.Plantarse();
                    }
                }

                hayJugadoresActivos = jugadores.Any(j => j.EstaActivo);
            }
        }

        private void MostrarResultados()
        {
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

        private Jugador DeterminarGanador(List<Jugador> jugadores)
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
}
