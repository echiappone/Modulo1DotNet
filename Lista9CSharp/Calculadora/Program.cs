using System;
using Calculadora.src;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora");

            Calc objeto = new Calc();

            Console.WriteLine($"Soma: {objeto.Somar(1, 2)}");
            Console.WriteLine($"Subtração: {objeto.Subtrair(1, 2)}");
            Console.WriteLine($"Multiplicação: {objeto.Multiplicar(1, 2)}");
            Console.WriteLine($"Divisão: {objeto.Dividir(1, 2)}");
        }
    }
}
