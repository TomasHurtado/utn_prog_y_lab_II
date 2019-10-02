using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private string nombre;
        private int dni;
        private int edad;

        public string Apellido { get;}
        public string Nombre { get; }
        public int Dni { get; }
        public int Edad { get; }

        public Persona(string apellido, string nombre ,int edad, int dni)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
        }

        public virtual bool ValidarAptitud()
        {
            if (Edad < 40 && ValidarEstadoFisico() == true)
            {
                return true;
            }
            else
            {
                return false;

            }

        }

        private bool ValidarEstadoFisico()
        {
            throw new NotImplementedException();
        }

        public abstract string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this.nombre);
            sb.AppendLine("Apellido: " + this.apellido);
            sb.AppendLine("Dni: " + this.dni);
            sb.AppendLine("Edad" + this.edad);



            return sb.ToString();


        }


    }
}
