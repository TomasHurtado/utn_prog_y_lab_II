using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio31
{
    class PuestoDeAtencion
    {
        private static int numeroActual=0;
        private PuestoDeAtencion puesto;

        public int NumeroActual
        {
            set
            {
                numeroActual = +1;
            }
            get
            {
                return numeroActual;
            }
        }

        public bool Atender(Cliente cli)
        {
            Thread.Sleep(2000);
            return true;
        }


        public static bool operator +(Negocio n, Cliente c)
        {
            return true;
        }








    }
}
