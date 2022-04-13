using System; //acessar o console
using System.Collections.Generic; //acessar a classe collection
using Zoologico.src; //acessar a pasta src


namespace Zoologico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zoológico");

            List<Animal> animais = new List<Animal>
            (
                new Animal[]                {
                    new Gato("Gato Catel", "Cinza", "Felino"),
                    new Cachorro("Cachorro Rodrigo", "Preto", "Canidio"),
                    new Cachorro("Cachorro Bueno", "Branco", "Canidio"),
                    new Gato("Gato Cavalcanti", "Marrom", "Felino"),
                    new Macaco("Macaco Oliveira", "Marrom", "Primata")
                }
            );

            foreach (Animal animal in animais)
            {
                if (animal.Classificacao == "Canidio")
                {
                    Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}");
                    animal.Comunicar("Au Au!");
                } 
                else if (animal.Classificacao == "Felino")
                {
                    Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}");
                    animal.Comunicar("Miau!");

                }
                else if (animal.Classificacao == "Primata")
                {
                    Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}");
                    animal.Comunicar("huhu HAHA!");
                }
            }
        }
    }
}
