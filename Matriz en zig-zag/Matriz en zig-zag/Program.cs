using System;
using System.Collections.Generic;

class Program
{
    // n = 2
    static List<(int, int)> ZigzagIndices(int n)
    {
        List<(int, int)> indices = new List<(int, int)>();

        for (int s = 2 * n; s >= 2; s--)
        {
            int inicio = Math.Max(1, s - n);

            int fin = Math.Min(n, s - 1);


            if (s % 2 == 0)
            {
                for (int i = fin; i >= inicio; i--)
                {
                    int j = s - i;
                    indices.Add((i, j));
                }
            }
            else
            {
                // Si s es impar: recorremos en orden ascendente (de inicio a fin)
                for (int i = inicio; i <= fin; i++)
                {
                    int j = s - i;
                    indices.Add((i, j));
                }
            }
        }
        return indices;
    }

    static void Main(string[] args)
    {
        Console.Write("Ingrese el tamaño de la matriz: ");
        int n = int.Parse(Console.ReadLine());

        if (n > 0)
        {
            List<(int, int)> recorrido = ZigzagIndices(n);

            Console.WriteLine("\nRecorrido en zig-zag (desde [n,n] hasta [1,1]):");
            foreach (var pos in recorrido)
            {
                Console.WriteLine($"[{pos.Item1}, {pos.Item2}]");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida. Ingrese un número entero positivo.");
        }
    }
}