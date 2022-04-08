using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista8CSharp.scr
{
    internal class Dog
    {
        public string nome { get; set; }
        public string pelo { get; set; }
        public string cor { get; set; }
        public int tamanho { get; set; }
        
        public Dog (string _nome, string _pelo, string _cor, int _tamanho)
        {
            nome = _nome;
            pelo = _pelo;
            cor = _cor;
            tamanho = _tamanho;
        }

        public void dormir ()
        {
            Console.WriteLine("zzz...");
        }
        public void cocozinho ()
        {
            Console.WriteLine("estou fazendo cocozinho");
        }
        public void brincar ()
        {
            Console.WriteLine("vamos brincar de cabo de guerra?");
        }
        public string late ()
        {
            return "AU AU AU";
        }
    }
}






