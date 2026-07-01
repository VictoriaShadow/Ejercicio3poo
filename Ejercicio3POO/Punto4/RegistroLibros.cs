using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace Punto4
{
        class Libro
        {
            private string _titulo;
            private string _autor;
            private int _isbn;
            private int _numeroPaginas;

            public string Titulo
            {
                get { return _titulo;}
                set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        _titulo=value;
                    }
                }
            }
            public string Autor
            {
                get { return _autor;}
                set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        _autor=value;
                    }
                }
            }
            public int Isbn
            {
                get{ return _isbn;}
                set
                {
                    if (value > 978)
                    {
                        _isbn=value;
                    }
                }
            }
            public int NumeroPaginas
            {
                get{ return _numeroPaginas;}
                set
                {
                    if (value > 3)
                    {
                        _numeroPaginas=value;
                    }
                }
            }
            public Libro (string t, string a, int i, int n)
            {
                Titulo = t;
                Autor = a;
                Isbn = i;
                NumeroPaginas = n;
            }

            public void Largo ()
            {
                if (NumeroPaginas > 300)
                {
                    Console.WriteLine("El libro es largo");
                } else
                {
                   Console.WriteLine("El libro no es largo");
                }
            }
        }
}