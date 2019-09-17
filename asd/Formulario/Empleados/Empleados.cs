using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
    class Empleados
    {
        private string nombre;
        private string apellido;
        private string legajo;
        private int salario;
        private EpuestoJerarquico puesto;


        Empleados(string nombre,string apellido,string legajo,int salario, EpuestoJerarquico puesto)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            this.puesto = puesto;
        }

        public enum EpuestoJerarquico { Administracion, Gerencia, Sistemas, Accionista};

        public static bool operator ==(Empleados empl1, Empleados empl2)
        {
            if(empl1 != null && empl2!=null )
            {
                return empl1.legajo == empl2.legajo;
            }else
            {
                return false;
            }
        }

        public static bool operator !=(Empleados empl1, Empleados empl2)
        {
            return !(empl1.legajo == empl2.legajo);
        }
        

        public string Mostrar(Empleados empl)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Empleados: {0}",empl.nombre,empl.apellido,empl.legajo,empl.puesto,empl.salario);
            return sb.ToString();
        }
    


    }
}
