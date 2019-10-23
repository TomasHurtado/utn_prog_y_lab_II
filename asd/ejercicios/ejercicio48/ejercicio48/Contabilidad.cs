using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio48
{
    class Contabilidad<T,U> where T : Documento where U :Documento
    {
        static List<T> egresos = new List<T>();
        static List<U> ingresos = new List<U>();


        public static bool operator +(Contabilidad<T,U> contabilidad, T egreso)
        {
            if (!(contabilidad is null))
            {
               
                    if (egreso is null)
                    {
                    egresos.Add(egreso);
                    }
            }

            return false;

        }

        public static bool operator +(Contabilidad<T, U> contabilidad, U ingreso)
        {
            if (!(contabilidad is null))
            {

                if (ingreso is null)
                {
                    ingresos.Add(ingreso);
                }
            }

            return false;

        }
    }
}
