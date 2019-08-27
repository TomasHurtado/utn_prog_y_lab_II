using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecrcicio13
{
  class Program
  {
    static void Main(string[] args)
    {
      string hola;
      double num;
      Conversor conversor = new Conversor();

      Console.Write("ingrese binario");
      hola = Console.ReadLine();
      num = conversor.BinarioDecimal(hola);



      Console.Write("el numero es: " + num);
      Console.ReadKey();
    }
  }
}
