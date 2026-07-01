using System;

namespace Punto1
{
    class Termometro
    {
        private float celsius;

        public float Celsius
        {
            get { return celsius; }

            set
            {
                if (value >= -273.15f)
                {
                    celsius = value;
                }
                else
                {
                    Console.WriteLine("Error, temperatura inferior a 0 absoluto");
                }
            }
        }

        public Termometro(float c)
        {
            Celsius = c;
        }

        public float Fahrenheit()
        {
            return (Celsius * 1.8f) + 32;
        }

        public float Kelvin()
        {
            return Celsius + 273.15f;
        }
    }
}