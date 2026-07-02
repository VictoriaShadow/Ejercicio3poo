using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace Punto8
{
    class Usuario
    {
        private string _nombreDeUsuario;
        private string _password;
        private string _email;

        public string NombreDeUsuario
        {
            get { return _nombreDeUsuario; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _nombreDeUsuario = value;
                }
            }
        }
        public string Contraseña
        {
            get { return _password; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _password = value;
                }
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _email = value;
                }
            }
        }

        public Usuario(string n, string p, string e)
        {
            NombreDeUsuario = n;
            Contraseña = p;
            Email = e;
        }
        public void cambiarPassword(string antigua, string nueva)
        {
            if (antigua == _password)
            {
                Contraseña = nueva;
                Console.WriteLine("Contraseña cambiada");
            } else
            {
                Console.WriteLine("Contraseña incorrecta");
            }
        }
    }
}