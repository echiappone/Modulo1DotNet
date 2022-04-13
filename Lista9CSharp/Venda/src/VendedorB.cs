using System;
using Calculadora.src;

namespace Venda.src
{
    public class VendedorB : Bonus
    {
        public string Nome { get; set;}
        public double Venda { get; set;}
        public double Bonus { get; set;}
        public double TotalReceber { get; set;}
        public string Cargo { get; set;}
        private Calc _calculadora;

        public VendedorB(string nome, double venda, double salario, string cargo)
        {
            _calculadora = new Calc();

            Nome = nome;
            Venda = venda;
            Bonus = CalculaBonus(venda);
            TotalReceber = _calculadora.Somar(salario, Bonus);
            Cargo = cargo;
        }

        public override double CalculaBonus(double venda)
        {
            return venda * 0.01;
        }
        public override string ToString()
        {
            return $"Nome: {Nome}\nVenda: {Venda}\nBonus: {Bonus}\nTotal a Receber: {TotalReceber}\nCargo: {Cargo}";
        }
    }
}