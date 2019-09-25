using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Local:Llamada
    {
        protected float costo;

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        public Local(Llamada unaLlamada, float costo):base(unaLlamada.NroDestino, unaLlamada.NroDestino, unaLlamada.Duracion)
        {
            this.costo = costo;
        }


        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Costo: " + this.costo);
            return sb.ToString();
        }

        private float CalcularCosto()
        {
            float total;
            total = base.Duracion *CostoLlamada;
            return total;
            
        }


    }
}
