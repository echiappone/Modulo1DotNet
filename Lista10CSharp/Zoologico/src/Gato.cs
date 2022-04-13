using System;

namespace Zoologico.src
{
    public class Gato : Animal
    {
        // Construtor sem parametro
        public Gato() {}

        // Construtor com parametro
        public Gato(string nome, string cor, string classificacao) : base (nome, cor, classificacao) {}

        public override void Comunicar(string comunicacao)
        {
            Console.WriteLine ($"{Nome} está falando: {comunicacao}");
        }
    }
}