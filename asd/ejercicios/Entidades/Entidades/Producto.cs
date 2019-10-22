using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        private int id_prodcu;
        private string descripcion;


        public Producto(int id_prodcu, string descripcion)
        {
            this.id_prodcu = id_prodcu;
            this.descripcion = descripcion;
        }
    }
}
