using Punto6;

CalculadoraPasos usuario1 = new CalculadoraPasos("Vic", 10000);

usuario1.RegistrarPasos(3000);
usuario1.RegistrarPasos(2500);
usuario1.RegistrarPasos(5000);

Console.WriteLine(usuario1.ObjetivoCumplido());