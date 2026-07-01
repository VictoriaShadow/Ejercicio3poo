using Punto3;

Cuenta c1 = new Cuenta("Juan", 1000);
Cuenta c2 = new Cuenta("Ana", 2000);

double cantidad = 500;
double cantidad2 = 700;

c1.Depositar(cantidad);
c1.MostrarSaldo();
c1.Retirar(cantidad2);
c1.MostrarSaldo();

c2.Depositar(cantidad);
c2.MostrarSaldo();
c2.Retirar(cantidad2);
c2.MostrarSaldo();