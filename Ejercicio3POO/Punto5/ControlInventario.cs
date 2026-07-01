using System;

namespace Punto5
{
    class Producto
    {
        private int _codigo;
        private string _nombre;
        private double _precio;

        public int Codigo
        {
            get { return _codigo; }
            set
            {
                if (value > 0)
                {
                    _codigo = value;
                }
            }
        }
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _nombre = value;
                }
            }
        }
        public double Precio
        {
            get { return _precio; }
            set
            {
                if (value > 0)
                {
                    _precio = value;
                }
            }
        }
        public Producto(int c, string n, double p)
        {
            Codigo = c;
            Nombre = n;
            Precio = p;
        }
        
        public void AplicarDescuento(double porcentaje)
        {
            Precio = Precio - (Precio * porcentaje / 100);
            Console.WriteLine($"Precio con descuento: ${Precio}");
        }
    }
}