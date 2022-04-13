using System;
using System.Collections.Generic;

namespace Calculadora.src
{
    internal interface IOperacoes
    {
        double Somar(double a, double b);
        double Subtrair(double a, double b);
        double Multiplicar(double a, double b);
        double Dividir(double a, double b);
    }
}