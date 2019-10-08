using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hurtado.Walter._2019
{
    class Satelite : Astro
    {

        Satelite(int duracionOrbitra, int duraRotacion, string nombre) : base(duracionOrbitra, duraRotacion, nombre)
        {

        }

        public override string Orbitar()
        {
            throw new NotImplementedException();
        }

        public string Nombre
        {
            get
            {
                return Nombre;
            }
        }



    }
}
