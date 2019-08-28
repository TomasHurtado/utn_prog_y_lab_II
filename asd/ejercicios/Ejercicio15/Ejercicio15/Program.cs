using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
  class Program
  {
    static void Main(string[] args)
    {
     

      string signo;
      string linea;
      int resultado;


      Console.Write("ingrese primer numero");
      linea = Console.ReadLine();
      if (int.TryParse(linea, out int num))
      {

      }

      Console.Write("ingrese segundo numero");
      linea = Console.ReadLine();
      if (int.TryParse(linea, out int num2))
      {

      }

      Console.Write("ingrese operador");
      signo = Console.ReadLine();

      resultado=Calculadora.Calcular(num, num2, signo);


      Console.Write("el resultado es: " + resultado);
      Console.ReadKey();
    }
  }
}


/*







 */
