using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
  class Program
  {
    static void Main(string[] args)
    {
      int num;
      string linea;
      int nume = 1;
      int div;
      int flag = 0;
      int resto;
      int cont = 0;
      Console.Write("ingrese numero");
      linea = Console.ReadLine();
      if (int.TryParse(linea, out num))
      {
      }
      while (cont > num)
      {
        div = 2;
        flag = 0;
        while ((div < nume) && (flag == 0))
        {
          resto = nume % div;

          if (resto == 0)
          {
            flag = 1;
          }
          else
          {
            div = div + 1;
          }
        }

        if (flag == 0)
        {
          Console.Write(num + " ");
          cont = cont + 1;
        }

        num = num + 1;

      }

      Console.ReadKey();
    }


  }

  
}

