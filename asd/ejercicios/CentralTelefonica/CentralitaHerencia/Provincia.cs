using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Provincia:Llamada
    {
        protected Franja franjaHoraria;
        public enum Franja
        {
            Franja_1, Franja_2, Franja_3
        }
        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }
        public Provincia(Franja mFranja, Llamada unaLlamada)
           : base(unaLlamada.NroDestino, unaLlamada.NroDestino, unaLlamada.Duracion)
        {
            this.franjaHoraria = mFranja;
        }
        public Provincia(string origen, Franja mFranja, float duracion, string destino)
            : base(origen, destino, duracion)
        {
            this.franjaHoraria = mFranja;
        }


        public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Duracion: ");
            sb.AppendLine(base.Duracion.ToString());

            sb.Append("Origen: ");
            sb.AppendLine(base.nroOrigen);

            sb.Append("Destino: ");
            sb.AppendLine(base.nroDestino);

            sb.Append("Franja Horaria: ");
            sb.AppendLine(this.franjaHoraria.ToString());

            sb.Append("Costo: ");
            sb.AppendLine(this.CostoLlamada.ToString());

            Console.WriteLine(sb);
        }

        private float CalcularCosto()
        {
            if (this.franjaHoraria == Franja.Franja_1)
                return base.duracion * 0.99f;

            if (this.franjaHoraria == Franja.Franja_2)
                return base.duracion * 1.25f;

            else
                return base.duracion * 0.66f;
        }
    }
}
