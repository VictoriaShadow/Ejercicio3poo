using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace Punto9
{
    class Cafetera
    {
        private int _capacidadMaxima;
        private int _cantidadActual;

        public int CapacidadMaxima
        {
            get { return _capacidadMaxima; }
            set
            {
                if (value > 0)
                {
                    _capacidadMaxima = value;
                }
            }
        }
        public int CantidadActual
        {
            get { return _cantidadActual; }
            set
            {
                if (value >= 0 && value <= CapacidadMaxima)
                {
                    _cantidadActual = value;
                }
            }
        }

        public Cafetera(int c, int a)
        {
            CapacidadMaxima = c;
            CantidadActual = a;
        }

        public void LlenarCafetera()
        {
            CantidadActual = CapacidadMaxima;
            Console.WriteLine("Cafetera llena");
        }
        public void ServirTaza(int cantidad)
        {
            if (cantidad <= CantidadActual)
            {
                CantidadActual -= cantidad;
                Console.WriteLine($"Se sirvieron {cantidad} ml");
            }
            else
            {
                Console.WriteLine("No hay suficiente café");
            }
        }
        public void VaciarCafetera()
        {
            CantidadActual = 0;
            Console.WriteLine("Cafetera vacía");
        }
    }
}