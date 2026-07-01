using Punto2;

Reloj_Digital r1 = new Reloj_Digital(14, 35, 50);
Reloj_Digital r2 = new Reloj_Digital(23, 59, 59);
Reloj_Digital r3 = new Reloj_Digital(25, 10, 20);
Reloj_Digital r4 = new Reloj_Digital(12, 59, 59);

Console.WriteLine(r1.MostrarHora());
Console.WriteLine(r2.MostrarHora());
Console.WriteLine(r3.MostrarHora());
Console.WriteLine(r4.MostrarHora());