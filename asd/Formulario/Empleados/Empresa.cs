using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
    class Empresa
    {
        private string razonSocial;
        private string direccion;
        private float ganancia;
        private List<Empleados> nomina;
        private Empresa()
        {
            
        }
        Empresa(string razon, string direccion, float ganancia)
        {
            this.razonSocial = razon;
            this.direccion = direccion;
            this.ganancia = ganancia;
        }


        public static Empresa  operator +(Empresa empr,Empleados empl1)
        {
            foreach (Empleados item in empr.nomina)
            {
                if (item == empl1)
                {
                    return empr;
                }
            }
                empr.nomina add(empl1);
                return empr;

            
            
        }











    }
}
