using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10
{
    public abstract class Persona
    {
        public List<Persona> personas;
        public int Cuil { set; get; }
        public string Nombre { set; get; }

       

        public Persona(string nombre, int cuil)
        {
            this.Nombre = nombre;
            this.Cuil = cuil;
        }

        public abstract Persona Mostar();
        

        






    }
}
