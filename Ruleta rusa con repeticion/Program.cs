using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruleta_rusa_con_repeticion
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int num;
			bool continuar = true;
			while (continuar)
			{
				Console.WriteLine("Ingrese un numero del 1 al 6");
				Console.WriteLine("Si el numero ingresado es igual al numero aleatorio pierdes");
				Console.WriteLine("si por el contrario es un numero diferente. !Felicidades, ganaste!");
				Console.WriteLine("Por favor ingresa tu numero. Buena suerte");
				if (!int.TryParse(Console.ReadLine(), out num) || num < 1 || num > 6)
				{
					Console.WriteLine("Error: Debes ingresar un número válido entre 1 y 6.");
					continue;
				}
				var aleatorio = new Random();
				int numeroa = aleatorio.Next(1, 6);
				Console.WriteLine(numeroa);
				if (numeroa == num)
				{
					Console.WriteLine("Lo lamento el numero es el mismo");
					Console.WriteLine("El juego ha terminado");
					break;
				}
				else
				{
					Console.WriteLine("Excelente tu numero es diferente");
				}
					
				Console.ReadKey();
			}

	
        }
    }
}
