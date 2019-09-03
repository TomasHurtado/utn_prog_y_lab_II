using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicioenclase
{
  class Program
  {
    static void Main(string[] args)
    {
      Empleado empl = new Empleado();

      empl.Cargar("Pepe","Trueno",20000);
      empl.CalcularNeto(true);
      empl.Mostrar();
      empl.Aumento(25.5);

      Empleado emp = new Empleado();
      emp.Cargar("Pipo","Tuno",40000);
      emp.CalcularNeto(false);
      emp.Mostrar();
      emp.Aumento(50);
      
      Console.ReadKey();



      // condicion?verdadero:falso
    }
  }
}
