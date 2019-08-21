using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ejercicio2
{
  class Program
  {
    static void Main(string[] args)
    {
      int num;
      string linea;
      Console.Write("ingrese numero");
      linea = Console.ReadLine();
      if (int.TryParse(linea, out num))
      {
       
      }
      if (num == 0)
      {
        Console.Write("error");
      }
      else
      {
        Console.Write(" el cuadrado es:" + Math.Pow(num, 2) + "y el cubo es" + Math.Pow(num, 3));
      }
      Console.ReadLine();

    }
  }
}
