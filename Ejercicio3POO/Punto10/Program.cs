using Punto10;

Estudiante e1 = new Estudiante("Juan", new double[] { 8, 7, 9 });
Estudiante e2 = new Estudiante("Ana", new double[] { 4, 5, 6 });

Console.WriteLine($"Promedio: {e1.CalcularPromedio()}");
e1.EstadoFinal();

Console.WriteLine($"Promedio: {e2.CalcularPromedio()}");
e2.EstadoFinal();