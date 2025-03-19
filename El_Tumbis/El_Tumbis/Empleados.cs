using El_Tumbis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Tumbis
{
    public class Empleado : Persona
    {
        public string Cargo { get; set; }
        public decimal Salario { get; set; }

        public Empleado(string nombre, string cargo, decimal salario)
            : base(nombre)
        {
            this.Cargo = cargo;
            this.Salario = salario;
        }

        public virtual decimal CalcularSalarioTotal()
        {
            return Salario;
        }

        public override string ToString()
        {
            return base.ToString() + $", Cargo: {Cargo}, Salario: {Salario}";
        }
    }
}