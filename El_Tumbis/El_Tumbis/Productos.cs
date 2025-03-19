using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace El_Tumbis
{
    public class Producto
    {
        private string Nombre { get; set; }
        private double Precio { get; set; }
        private int Stock { get; set; }
        private string Marca { get; set; }


        public Producto(string nombre, double precio, int stock, string marca)
        {
            if (precio < 0)
            {
                throw new ArgumentException("El precio del producto no puede ser negativo.");
            }

            if (stock < 0)
            {
                throw new ArgumentException("El stock del producto no puede ser negativo.");
            }
            this.Nombre = nombre;
            this.Precio = precio;
            this.Stock = stock;
            this.Marca = marca;

        }

        public void SetPrecio(double precio)

        {
            if (precio < 0)
            {
                throw new ArgumentException("El precio del producto no puede ser negativo.");
            }
            this.Precio = precio;
        }
        public void SetStock(int stock)

        {
            if (stock < 0)
            {
                throw new ArgumentException("El stock del producto no puede ser negativo.");
            }
            this.Stock = stock;
        }
    }
}
