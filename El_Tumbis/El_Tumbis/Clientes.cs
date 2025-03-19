using El_Tumbis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Tumbis
{
    public class Clientes : Persona
    {
        public int ComprasRealizadas { get; private set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        public Clientes(string nombre, string correo, string telefono)
            : base(nombre)
        {
            this.Correo = correo;
            this.Telefono = telefono;
            this.ComprasRealizadas = 0;
        }
        public void RegistrarCompra()
        {
            ComprasRealizadas++;
        }
        
    }
}
