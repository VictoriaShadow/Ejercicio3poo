using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace Punto10
{
    class Estudiante
    {
        private string _nombre;
        private double[] _notas = new double[3];

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

        public double[] Notas
        {
            get { return _notas; }
            set
            {
                if (value.Length == 3)
                {
                    _notas = value;
                }
            }
        }

        public Estudiante(string n, double[] notas)
        {
            Nombre = n;
            Notas = notas;
        }

        public double CalcularPromedio()
        {
            return (Notas[0] + Notas[1] + Notas[2]) / 3;
        }

        public void EstadoFinal()
        {
            if (CalcularPromedio() >= 6)
            {
                Console.WriteLine("Aprobado");
            }
            else
            {
                Console.WriteLine("Reprobado");
            }
        }
    }
}