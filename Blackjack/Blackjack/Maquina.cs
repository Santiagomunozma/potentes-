using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Maquina : Jugador
    {
    
            public Maquina() : base("Máquina")
        {
            Puntaje = 0;
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


        public void LanzarDados(Random random)
        {
            int dado1 = GenerarNumero(random); // 1
            int dado2 = GenerarNumero(random); // 1
            Puntaje += dado1 + dado2;

            Console.WriteLine($"{Nombre} lanzó {dado1} y {dado2}. Puntaje actual: {Puntaje}");
        }

        public void Desactivar()
        {
            EstaActivo = false;
        }
    }

}
