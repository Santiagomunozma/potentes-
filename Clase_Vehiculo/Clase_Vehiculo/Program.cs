using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Vehiculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de vehiculos que va a ingresar");
            int numvehiculos = int.Parse(Console.ReadLine());

            List<Vehiculos> v = new List<Vehiculos>();

            for (int i = 0; i < numvehiculos; i++)
            {
                Console.WriteLine("Ingrese la marca del vehiculo");
                string marca = Console.ReadLine();

                Console.WriteLine("Ingrese el anio del vehiculo");
                int anio = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el tipo de vehiculo");
                string tipo = Console.ReadLine();

                Console.WriteLine("Ingrese la clase de vehiculo (carro, moto,e.t.c)");
                string clase = Console.ReadLine();

                v.Add(new Vehiculos(marca, anio, tipo, clase));
            }
            foreach (var vehiculos in v)
            {
                vehiculos.Arrancar();
                vehiculos.Frenar();
                vehiculos.tanquear();
            }

            Console.WriteLine("Resumen de vehículos ingresados:");
            foreach (var vehiculo in v)
            {
                Console.WriteLine(vehiculo);
            }


            Console.ReadKey();
        }
    }
}
