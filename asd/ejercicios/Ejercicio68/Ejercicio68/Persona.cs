using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio68
{
    class Persona
    {
        private string nombre;
        private string apellido;


        public string Nombre
        {
            set
            {
                Nombre = nombre;
            }

            get
            {
                return Nombre;
            }
        }

        public string Apellido
        {
            set
            {
                Apellido = apellido;
            }

            get
            {
                return Apellido;
            }
        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public string Mostrar()
        {
                

            return "Nombre: " + Nombre + "Apellido: " + Apellido;
        }
    }
}
