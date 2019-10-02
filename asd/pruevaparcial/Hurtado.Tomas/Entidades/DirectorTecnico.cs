using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico:Persona
    {
        private int añosExperiencia;
        
        public int AñosExperiencia { set; get; }

        DirectorTecnico(string apellido, string nombre, int edad, int dni,int añosExperiencia):base(apellido,nombre,edad,dni)
        {

            this.añosExperiencia = añosExperiencia;

        }

        public override string Mostrar()
        {
            throw new NotImplementedException();
        }

    }
}
