using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio48
{
    class Recibo:Documento
    {

        public Recibo()
        {
            Numero = 0;
        }

        public Recibo(int numero):base(numero)
        {

        }

    }
}
