using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hurtado.Walter._2019
{
    public abstract class Astro
    {
        private int duracionOrbita;
        private int duracionRotacion;
        private string nombre;

        protected Astro(int duracionOrbita, int duracionRotacion, string nombre)
        {
            this.duracionOrbita = duracionOrbita;
            this.duracionRotacion = duracionRotacion;
            this.nombre = nombre;
        }

        protected string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre: ", nombre);
            sb.AppendFormat("Orbita: ",duracionOrbita);
            sb.AppendFormat("Rotacion: ",duracionRotacion);

            return sb.ToString();
        }

        public abstract string Orbitar()
        {         
            
        }

        public virtual string Rotar()
        {
            return "Rotando. Tiempo estimado {0}" + duracionRotacion;
        }
    }
}
