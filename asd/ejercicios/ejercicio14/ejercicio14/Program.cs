using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio14
{
  class Program
  {
    static void Main(string[] args)
    {
      CalculodelArea calcular = new CalculodelArea();
    
    int num;
    int nume;
    string linea;
    double resultado;

      Console.Write("ingrese area del cuadrado");
      linea = Console.ReadLine();
      if (int.TryParse(linea, out num))
      {
        resultado = calcular.CalcuclarCuadrado(num);
        Console.Write("el area es: " + resultado);
      } else
      {

        Console.Write("error");
      }


      Console.Write("\ningrese base del triangulo");
      linea = Console.ReadLine();
      if (int.TryParse(linea, out num))
      {
        Console.Write("ingrese altura del triangulo");
        linea = Console.ReadLine();
        if (int.TryParse(linea, out nume))
        {
          resultado = calcular.CalcularTriangulo(num, nume);
          Console.Write("el area es: " + resultado);
        }
        else
        {
          Console.Write("error");
        }
      } else
      {
        Console.Write("error");
      }

      Console.Write("\ningrese area del circulo");
      linea = Console.ReadLine();
      if (int.TryParse(linea, out num))
      {
        resultado = calcular.CalcularCirculo(num);
        Console.Write("el area es: " + resultado);
      } else
      {
        Console.Write("error");
      }

    
      Console.ReadKey();
    }

  }
}
