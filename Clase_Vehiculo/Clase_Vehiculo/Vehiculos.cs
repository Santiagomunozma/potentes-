using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Clase_Vehiculos
{
    public class Vehiculos
    {
        public string marca { get; set; }
        public int modelo { get; set; }
        public string tipo { get; set; }
        private string clase { get; set; }

        public Vehiculos(string marca, int modelo, string tipo)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.tipo = tipo;
            
        }


        public void Arrancar()
        {
            Console.WriteLine($"El vehículo {clase} ha arrancado");
        }

        public virtual void Frenar()
        {
            Console.WriteLine($"El vehiculo {clase} ha frenado");
        }

        public void tanquear()
        {
            Console.WriteLine($"El vehiculo {clase} de marca {marca} ha sido tanqueado");
        }

        public virtual string ToString()
        {
            return $"Marca: {marca}, Modelo: {modelo}, Tipo: {tipo}";
        }
    }
}
