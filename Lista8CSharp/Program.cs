using Lista8CSharp.scr;
using System;

namespace Lista8CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("caracteristicas do seu dog");
            Dog luana = new Dog("Luana", "liso", "marrom", 12);
            Dog teddy = new Dog("Teddy", "cacheado", "preta", 8);
            Dog nick = new Dog("Nick", "enrolado", "listrada", 20);
            Dog cristal = new Dog("Cristal", "encaracolado", "branca", 5);

            Console.WriteLine($"o nome do cachorrinho é: {luana.nome}, o tipo do seu pelo é: {luana.pelo}, sua cor: {luana.cor}, e seu tamanho é: {luana.tamanho}cm");
            Console.WriteLine($"o nome do cachorrinho é: {teddy.nome}, o tipo do seu pelo é: {teddy.pelo}, sua cor: {teddy.cor}, e seu tamanho é: {teddy.tamanho}cm");
            Console.WriteLine($"o nome do cachorrinho é: {nick.nome}, o tipo do seu pelo é: {nick.pelo}, sua cor: {nick.cor}, e seu tamanho é: {nick.tamanho}cm");
            Console.WriteLine($"o nome do cachorrinho é: {cristal.nome}, o tipo do seu pelo é: {cristal.pelo}, sua cor: {cristal.cor}, e seu tamanho é: {cristal.tamanho}cm");

            Console.WriteLine($"'Ei {luana.nome}, vem comer'");
            luana.dormir();
            Console.WriteLine($"'Isso não é hora de dormir {luana.nome}, levanta'");
            nick.brincar();
            string retorno = cristal.late();
            nick.brincar();
            nick.brincar();
            Console.WriteLine($"'só depois que comer'");
            teddy.cocozinho();
            Console.WriteLine(retorno);
            Console.WriteLine($"'você é um cachorro ou um pato?'");
        }
    }
}