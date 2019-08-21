using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio N1";
      int[] numeros;
      numeros = new int[5];
      int mayor=0;
      int menor=0;
      float prom;
      string linea;
      for (int i = 0; i < 5; i++)
      {
        Console.Write("ingrese numero");
        linea = Console.ReadLine();
        if (int.TryParse(linea, out numeros[i]))
        {
        }
      }
      /* Console.Write("ingrese numero");
       linea = Console.ReadLine();
       num2 = int.Parse(linea);

       Console.Write("ingrese numero");
       linea = Console.ReadLine();
       num3 = int.Parse(linea);

       Console.Write("ingrese numero");
       linea = Console.ReadLine();
       num4 = int.Parse(linea);

       Console.Write("ingrese numero");
       linea = Console.ReadLine();
       num5 = int.Parse(linea);
       */
      prom = (numeros[0]+ numeros[1]+ numeros[2]+ numeros[3]+numeros[4]) / 5;

      int j=1;
      for (int i = 0; i < 4; i++)
      {
        if (numeros[i] > numeros[j])
        {
          mayor = numeros[i];
        }
        else
        {
          mayor = numeros[j];
        }
        j++;
      }
      j = 1;
      for (int i = 0; i < 4; i++)
      {
        if (numeros[i] < numeros[j])
        {
          menor = numeros[i];
        }
        else
        {
          menor = numeros[j];
        }
      }







      Console.Write("El promedio es " + prom);
      Console.Write("el mayor es " + mayor);
      Console.Write("el menor es " + menor);

      Console.ReadLine();
    }
  }
}
