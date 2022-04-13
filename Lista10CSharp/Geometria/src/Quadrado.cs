using System;
using System.Collections.Generic;

namespace Geometria.src
{
    public class Quadrado : FormasGeometricas
    {
        public Quadrado(string _nome, double _base, double _altura) : base(_nome, _base, _altura){} 
        public override double CalcularArea()
        {
            double area = Base * Altura;
            return area;
        }
    }
}