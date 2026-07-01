using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace Punto7
{
    class Rectangulo
    {
        private double _alto;
        private double _ancho;

        public double Alto
        {
            get { return _alto; }
            set { if (value > 0)
                {
                    _alto = value;
                }
            }
        }
        public double Ancho
        {
            get { return _ancho; }
            set { if (value > 0)
                {
                    _ancho = value;
                }
            }
        }

        public Rectangulo(double b, double a)
        {
            if (b > 0 && a > 0)
            {
                Ancho = b;
                Alto = a;
            }
            else
            {
                throw new Exception("No se permiten valores negativos o cero.");
            }
        }

        public double Area()
        {
            return Ancho * Alto;
        }

        public double Perimetro()
        {
            return (Ancho * 2) + (Alto * 2);
        }
    }
}