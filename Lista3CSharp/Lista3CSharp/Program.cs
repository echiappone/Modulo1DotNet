using System;

namespace Lista3CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: !");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite sua altura: ");
            float altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu peso: ");
            float peso = float.Parse(Console.ReadLine());

            float imc = peso / (altura * altura);

            if(imc < 1)
            {
                imc = imc * 10000;
            }
            if(imc < 18.5)
            {
                Console.WriteLine(nome + ", Seu IMC é: " + imc + " - Você esta abaixo do peso") ;
            }
            else if(imc <25)
            {
                Console.WriteLine(nome + ", Seu IMC é: " + imc + " - Você esta com o peso normal");
            }
            else if(imc <30)
            {
                Console.WriteLine(nome + ", Seu IMC é: " + imc + " - Você esta com sobrepeso");
            }
            else if(imc >= 30)
            {
                Console.WriteLine(nome + ", Seu IMC é: " + imc + " - Você esta Obeso");
            }
                
        }
    }
}
