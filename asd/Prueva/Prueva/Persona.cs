using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueva
{
    public class Persona
    {
        public string nombre;
        public string apellido;
        public int dni;
        public string provincia;
        public string genero;
        public bool vive;

        public Persona(string nombre, string apellido,int dni ,string provincia,string genero,bool vive)
        {
            this.nombre= nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.provincia = provincia;
            this.genero = genero;
            this.vive = vive;
        }

        public string MostrarDatos()
        {
            return this.nombre + " " + this.apellido + " " + this.dni;
        }
    }
}
