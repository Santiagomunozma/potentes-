using Clase_Vehiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Vehiculos
{
    public class Carro : Vehiculos
    {
        public string color { get; set; }
        public Carro(string marca, int modelo, string tipo, string color) : base(marca, modelo, tipo)
        {
        this.color = color;
        }

        public override void Frenar()
        {
            Console.WriteLine($"El vehiculo  ha frenado en seco");
        }

        public void tanquear()
        {
            Console.WriteLine($"El vehiculo de marca {marca} ha sido tanqueado");
        }

        public override string ToString()
        {
            return $"Marca: {marca}, Modelo: {modelo}, Tipo: {tipo}, Color: {color}";
        }
    }
}
