using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2mejorado
{
  public class cuadrado //puede ser public o internal o static
  {
    /*protected int valor1;
    protected int resultado;

    public int Valor1
    {
      set
      {
        valor1 = value;
      }
      get
      {
        return valor1;
      }
    }
    public int Resultado
    {
      protected set
      {
        resultado = value;
      }
      get
      {
        return resultado;
      }
    }

  }

  public class elevadoala2 : cuadrado
  {
    public void Operar()
    {
      Resultado = Valor1*Valor1;
    }
  }

  public class elevadoala3 : cuadrado
  {
    public void Operar()
    {
      Resultado = Valor1 * Valor1 * Valor1;
    }
    */

   public int elevadoalcuad(int numero)
    {
   
      numero =numero*numero;

      return numero;
    }
    public int elevadoalcubo(int numeros)
    {

      numeros = numeros * numeros * numeros;

      return numeros;
    }



  }
  
}
