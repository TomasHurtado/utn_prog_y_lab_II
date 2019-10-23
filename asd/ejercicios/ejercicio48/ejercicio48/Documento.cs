using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio48
{
    class Documento
    {
        private int numero;


        public int Numero
        {
            set
            {
                Numero = numero;
            }
            get
            {
                return Numero;
            }

        }
        
        public Documento()
        {

        }

        public Documento(int numero)
        {
            this.numero = numero;
        }



    }
}
