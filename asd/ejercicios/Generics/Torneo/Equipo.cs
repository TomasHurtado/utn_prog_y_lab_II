using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torneo
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;


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

        public Equipo(string nombre, DateTime fechaCreacion)
        {
            this.Nombre = nombre;
            this.fechaCreacion = fechaCreacion;
            
        }


        public string Ficha()
        {

            return "";
        }
    }
}
