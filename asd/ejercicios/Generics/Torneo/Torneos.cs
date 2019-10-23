using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torneo
{
    public class Torneos <T> where T : Equipo
    {
        private string nombre;
        private List<T> equipos;

        public List<T> Equipos
        {
            get
            {
                return this.equipos;
            }
            set
            {
                this.equipos = value;
            }
        }
        public static bool operator ==(Torneos<T> tor, T equip)
        {

        }


        public static bool operator +(Torneos<T> tor , T equip)
        {
            foreach (var eq in )
            {

            }
        }
    }
}
