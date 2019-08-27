using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio2mejorado
{
  class Program
  {

    // sealed  la sellada no hereda
    //abstract obliga a los q la heredan a usar las clases
    // 
    static void Main(string[] args)
    {
      /*   vehiculo vehiculo1 = new vehiculo();
         vehiculo.puertas = 4;
      int n;
      string linea;
      Console.Write("ingrese numero");
      linea = Console.ReadLine();
      n = int.Parse(linea);

      elevadoala2 cuad = new elevadoala2();
      cuad.Valor1 = n;

      elevadoala3 cubi = new elevadoala3();
      cubi.Valor1 = n;

      Console.Write("el cuadrado es " + cuad.Resultado + "y el cubo es" + cubi.Resultado);
      Console.ReadKey();*/

      cuadrado cuad = new cuadrado();
      int n;
      string linea;
      Console.Write("ingrese numero");
      linea = Console.ReadLine();
      n = int.Parse(linea);

      cuad.elevadoalcuad(n);

      Console.Write("cuadrado " + cuad.elevadoalcuad(n) + " cubo " + cuad.elevadoalcubo(n));
      Console.ReadKey();

    }
  }
}
