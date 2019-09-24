using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10
{
    public class Empleado:Persona
    {

        public float Sueldo { get; set; }
        public Empleado(string nombre,int cuil, float sueldo):base( nombre, cuil)
        {
            this.Sueldo = sueldo;
        }

        public override Persona Mostar()
        {
            throw new NotImplementedException();
        }
    }
}
