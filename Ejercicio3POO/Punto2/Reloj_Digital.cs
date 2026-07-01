using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace Punto2
{
    class Reloj_Digital
    {
        private int _hora;
        private int _minutos;
        private int _segundos;

        public int Hora
        {
            get { return _hora; }
            set
            {
                if (value >= 0 && value < 24)
                    _hora = value;
            }
        }

        public int Minutos
        {
            get { return _minutos; }
            set
            {
                if (value >= 0 && value < 60)
                    _minutos = value;
                else
                {
                    _minutos = 0;
                    Hora += 1;
                }
            }
        }

        public int Segundos
        {
            get { return _segundos; }
            set
            {
                if (value >= 0 && value < 60)
                    _segundos = value;
                else
                {
                    _segundos = 0;
                    Minutos += 1;
                }
            }
        }
        public Reloj_Digital(int hora, int minutos, int segundos)
        {
            if (hora >= 0 && hora < 24 &&
                minutos >= 0 && minutos < 60 &&
                segundos >= 0 && segundos < 60)
            {
                Hora = hora;
                Minutos = minutos;
                Segundos = segundos;
            }
            else
            {
                Hora = hora % 24;
                Minutos = minutos % 60;
                Segundos = segundos % 60;
            }
        }

        public string MostrarHora()
        {
            return $"{Hora:D2}:{Minutos:D2}:{Segundos:D2}";
        }
    }
}