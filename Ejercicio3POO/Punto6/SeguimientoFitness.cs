using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace Punto6
{
    class CalculadoraPasos
    {
        private string _nombreUsuario;
        private int _metaDiaria;
        private int _totalPasos;

        public string NombreUsuario
        {
            get { return _nombreUsuario; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _nombreUsuario = value;
                }
            }
        }
        public int MetaDiaria
        {
            get { return _metaDiaria; }
            set
            {
                if (value > 0)
                {
                    _metaDiaria = value;
                }
            }
        }
        public CalculadoraPasos(string n, int m)
        {
            NombreUsuario = n;
            MetaDiaria = m;
            _totalPasos = 0;
        }

        public void RegistrarPasos(int pasos)
        {
            _totalPasos += pasos;
            Console.WriteLine($"Pasos acumulados: {_totalPasos}");
        }

        public bool ObjetivoCumplido()
        {
            return _totalPasos >= MetaDiaria;
        }
    }
}