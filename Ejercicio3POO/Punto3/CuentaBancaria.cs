using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace Punto3
{
    public class Cuenta
    {

        private string titular;
        private double saldo;


        public Cuenta(string t, double s)
        {
            titular = t;
            saldo = s;
        }


        public void Depositar(double cantidad)
        {
            saldo += cantidad;
        }


        public void Retirar(double cantidad)
        {
            if (cantidad <= saldo)
            {
                saldo -= cantidad;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }


        public void MostrarSaldo()
        {
            Console.WriteLine($"Saldo actual de {titular}: ${saldo}");
        }
    }
}