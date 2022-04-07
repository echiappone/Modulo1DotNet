using System;

namespace Lista6CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero da tabuada que deseja aprender: ");
            int tabuada = Int32.Parse(Console.ReadLine());

            for (int i=0; i<=10; ++i)
            {
                int resultado = tabuada * i; 
                Console.WriteLine($" {tabuada} x {i} = {resultado}\n");
            }
            Console.WriteLine($"Essa foi a tabuada do {tabuada}");
        }
    }
}
