using System;

namespace Zoologico.src
{
    public class Cachorro : Animal
    {
        // Construtor sem parametro
        public Cachorro() {}

        // Construtor com parametro
        public Cachorro(string nome, string cor, string classificacao) : base (nome, cor, classificacao) {}

        public override void Comunicar(string comunicacao)
        {
            Console.WriteLine ($"{Nome} está falando: {comunicacao}");
        }
    }
}