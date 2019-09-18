using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
    class Cliente
    {
        private string nombre;
        private int numero;
        public string Nombre
        {
            set
            {
                this.nombre = value;
            }
            get
            {
                return nombre;
            }
        }

        public int Numero
        {
            set
            {
                this.numero = value;
            }
            get
            {
                return numero;
            }
        }


        Cliente(int numero)
        {
            this.numero = numero;
        }

        Cliente(int numero, string nombre)
        {
            this.nombre = nombre;
            this.numero = numero;
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            if(c1!= null && c2 != null)
            {
                if(c1.numero== c2.numero)
                {
                    return true;
                }else
                {
                    return false;
                }
            }else
            {
                return false;
            }

             
        }
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }








    }
}

