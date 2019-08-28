using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
  class Calculadora
  {

    public static int  Calcular(int num,int num2 , string signo)
    {
      int resultado=0;
      switch(signo)
      {
        case "+":
          resultado = num + num2;
          break;
        case "-":
          resultado = num - num2;
          break;
        case "*":
          resultado = num * num2;
          break;
        case "/":
          if(Validar(num2)==1)
          {
            resultado = num / num2;
          }else
          {
            Console.Write("no se puede dividir por 0\n");
          }
          break;

      }
      return resultado;
    }


    private static int Validar(int num2)
    {
      int hola=1;
     if (num2 == 0)
      {

        hola = 0;
      }
      return hola;
    }
  }
}


