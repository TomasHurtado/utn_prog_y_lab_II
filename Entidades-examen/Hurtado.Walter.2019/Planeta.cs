using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hurtado.Walter._2019
{
    class Planeta : Astro
    {

        private int cantidadSatelites;


        private Tipos tipo;
        public List<Astro> Satelites
        {
            get
            {
                return Satelites;
            }
        }

        public Planeta(int duracionOrbita, int duracionRotacion, string nombre, int cantidadSatelites, Tipos tipo) : base(duracionOrbita, duracionRotacion, nombre)
        {
            this.cantidadSatelites = cantidadSatelites;
            this.tipo = tipo;
        }
        public Planeta(int duracionOrbita, int duracionRotacion, string nombre) : base(duracionOrbita, duracionRotacion, nombre)
        {

        }

        public override string Orbitar()
        {
            throw new NotImplementedException();
        }


       




    }
}
