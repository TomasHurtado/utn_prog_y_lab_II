using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecrcicio13
{
  public class Conversor
  {
    public static string bin;
    public static double num;

    public string DecimalBinario(double num)
    {
      string bin;
      bin = Convert.ToString(Convert.ToByte(num), 2);


      return bin;
    }

   public double BinarioDecimal(string bin)
    {
      double num;
      num = Convert.ToInt64(bin,2);

      return num;
    }
  }
}
