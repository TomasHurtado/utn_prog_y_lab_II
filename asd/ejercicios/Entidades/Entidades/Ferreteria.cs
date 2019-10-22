using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ferreteria:Producto
    {
        private float peso;

        public Ferreteria (int id_prodcu, string descripcion, float peso):base(id_prodcu,descripcion)
        {
            this.peso = peso;
        }
    }
}
