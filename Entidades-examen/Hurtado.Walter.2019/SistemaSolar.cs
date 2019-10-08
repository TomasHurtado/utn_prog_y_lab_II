using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hurtado.Walter._2019
{
    class SistemaSolar
    {
        private List<Astro> planetas;

        public SistemaSolar()
        {

        }

        public List<Astro> Planetas
        {
            get
            {   
                return planetas;
            }
        }

        public string MostrarInformacionAstros()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Satelites");
            sb.AppendFormat("Nombre");


            return sb.ToString();
        }


    }
}
