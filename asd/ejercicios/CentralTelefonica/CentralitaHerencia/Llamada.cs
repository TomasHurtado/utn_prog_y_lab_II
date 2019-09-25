using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public Llamada(string nroDestino1, string nroDestino2, float duracion)
        {
            this.duracion = duracion;
        }

        public float Duracion
        {
            get
            {
                return this.Duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.NroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.NroOrigen;
            }
        }


        public string Motrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Duracion: " + this.duracion);
            sb.AppendLine("Nro Destino: " + this.nroDestino);
            sb.AppendLine("Nro Origen: " + this.nroOrigen);
            return sb.ToString();
        }

        public int OrdenarPorDuracion(Llamada uno, Llamada dos)
        {
            int numero = 0;
            if (uno.duracion > dos.duracion)
            {
                numero = -1;
            }
            if (uno.duracion < dos.duracion)
            {
                numero = 1;
            }
            return numero;
        }
    }
}
