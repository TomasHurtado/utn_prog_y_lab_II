using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10
{
    public class Vendedor: Empleado
    {
        private int objetivo;

        public Vendedor(string nombre, int cuil, float sueldo, int obj):base(nombre,cuil,sueldo)
        {
            this.objetivo = obj;
        }


    }
}
