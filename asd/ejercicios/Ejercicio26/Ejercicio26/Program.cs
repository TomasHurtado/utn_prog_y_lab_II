using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] vector;
            vector = new int[20];
            
            for (int i=0;i< vector.Length;i++)
            {
                vector[i] = rnd.Next(-9999,9999);
            }

            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i]+"\n");
            }

            //prop y 2 veces tab  public int MyProperty { get; set; }


            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i]>0)
                {
                    Console.Write(vector[i] + "positivos: "+vector[i]);
                }
                else
                {
                    Console.Write(vector[i] + "negativos: " + vector[i]);
                }
            }

            Console.ReadKey();


        }
    }
}
