using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio14
{
  class CalculodelArea
  {
    

    public double CalcuclarCuadrado(double area)
    {
      double resultado;

      resultado = area * area;
      
      
      return resultado;
    }

    public double CalcularTriangulo(double bace , double altura)
    {
      double resultado;

      resultado = bace * altura;
      return resultado;
    }

    public double CalcularCirculo(double area)
    {
      double resultado;

      resultado = (area * area) * 3.14;

      return resultado;
    }


  }
}
