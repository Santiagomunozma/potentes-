using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Clase_Vehiculos
{
    internal class Vehiculos
    {
        public string marca { get; set; }
        public int modelo { get; set; }
        public string tipo { get; set; }
        public string clase { get; set; }

        public Vehiculos(string marca, int modelo, string tipo, string clase)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.tipo = tipo;
            this.clase = clase;
        }


        public void Arrancar()
        {
            Console.WriteLine($"El vehículo {clase} ha arrancado");
        }

        public void Frenar()
        {
            Console.WriteLine($"El vehiculo {clase} ha frenado");
        }

        public void tanquear()
        {
            Console.WriteLine($"El vehiculo {clase} de marca {marca} ha sido tanqueado");
        }
        public override string ToString()
        {
            return $"Marca: {marca}, Año: {modelo}, Tipo: {tipo}, Clase: {clase}";
        }
    }
}
