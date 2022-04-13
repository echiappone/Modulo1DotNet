using System;
using Geometria.src;

namespace Geometria.src
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Formas Geométricas");

            Console.WriteLine();  
            
            Quadrado quadrado1 = new Quadrado("Quadrado", 10, 10);
            Console.WriteLine($"A base do {quadrado1.Nome} é {quadrado1.Base}, a altura é {quadrado1.Altura} e a área é {quadrado1.CalcularArea()}");

            Console.WriteLine();

            Triangulo triangulo1 = new Triangulo("Triangulo", 10, 15);
            Console.WriteLine($"A base do {triangulo1.Nome} é {triangulo1.Base}, a altura é {triangulo1.Altura} e a área é {triangulo1.CalcularArea()}");

            Console.WriteLine();
            
            Retangulo retangulo1 = new Retangulo("Retangulo", 10, 15);
            Console.WriteLine($"A base do {retangulo1.Nome} é {retangulo1.Base}, a altura é {retangulo1.Altura} e a área é {retangulo1.CalcularArea()}");
        }
    }
}