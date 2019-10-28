using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    interface IMensaje
    {
        void Mostrar();
    }
    class Interfaz : IMensaje
    {
        string usuario;
        string texto;
        DateTime hora;

        void IMensaje.Mostrar()
        {

        }

        public string Usuario
        {
            set
            {
                this.usuario = Usuario;
            }

            get
            {
                return Usuario;
            }
        }

        public string Texto
        {
            set
            {
                this.texto = Texto;
            }

            get
            {
                return Texto;
            }
        }

        public DateTime Hora
        {
            set
            {
                this.hora = Hora;
            }

            get
            {
                return Hora;
            }
        }
    }
}
