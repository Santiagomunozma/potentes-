using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace El_Tumbis
{
    class Program
    {

        static void Main(string[] args)
        {
              List<Empleado> ListaEmpleados = new List<Empleado>();
              List<Producto> productos = new List<Producto>();

            ListaEmpleados.Add(new Empleado("Maria", "Cajera", 1000000));
            ListaEmpleados.Add(new Gerente("Pedro", "Gerente general", 9000000, 800000));
            ListaEmpleados.Add(new Empleado("Juan", "Vendedor", 1200000));


            productos.Add(new Producto("Papas Limon",1800,20,"Margarita"));
            productos.Add(new Producto("Condones",15600,50,"Today"));
            productos.Add(new Producto("Chocolatina",3800,87,"Kinder"));

            Clientes cliente = new Clientes("Juan","Juan.perez84@hotmail.com", "3225489785");

            cliente.RegistrarCompra();
            
            Gerente gerente = new Gerente("Pedro", "Gerente administrativo", 5000000, 1500000);

            Empleado empleado = new Empleado("Maria", "Cajera", 1000000);

            Console.WriteLine($"La diferencia salarial entre el gerente y la cajera es de {gerente.CalcularSalarioTotal()-empleado.CalcularSalarioTotal()}");
            
            foreach (Empleado e in ListaEmpleados)
            {
                Console.WriteLine($"El salario de {e.Nombre} es {e.CalcularSalarioTotal()}");
            }
        }
    }
}
